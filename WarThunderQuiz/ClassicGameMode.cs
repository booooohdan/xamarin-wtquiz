using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using WarThunderQuiz.GameData;
using static Android.Views.View;
using Android.Gms.Ads;
using Android.Gms.Ads.Reward;
using System.Threading;
using Android.Preferences;
using Android.Util;


namespace WarThunderQuiz
{
    [Activity(Theme = "@style/AppTheme.NoActionBar", ScreenOrientation = ScreenOrientation.Portrait)]
    public partial class ClassicGameMode : AppCompatActivity, IOnClickListener, IRewardedVideoAdListener
    {
        Context context;
        public InterstitialAd mInterstitialAd;
        protected AdView mAdView;
        public Button DisplayVideoButton { get; set; } //rewardvideo
        protected Button mLoadInterstitialButton;
        ImageView _CGMQuestionImage, _imageHeart1, _imageHeart2, _imageHeart3;
        Button _CGMAnswerA, _CGMAnswerB, _CGMAnswerC, _CGMAnswerD, _BackToMenuButtonNo, _BackToMenuButtonYes;
        Vehicle correctVehicles;
        AlphaAnimation buttonClick = new AlphaAnimation(1F, 0.9F);
        TextView _HintsPoints, _CurrentQuestion, _CountQuestion, _CorrectAnswer, _LoggedInGooglePlay;
        LinearLayout _linearHeart;
        Random random;
        ImageButton _RewardButtonYes;
        LayoutInflater layoutInflater, layoutInflaterVideo;
        View mview, mviewVideo;
        Android.App.AlertDialog.Builder alertDialogBuilder, alertDialogBuilderVideo;
        Android.App.AlertDialog alertDialogAndroid, alertDialogAndroidVideo;
        ProgressBar ProgressBarVideoAd;
        CancellationTokenSource source;

        public IRewardedVideoAd RewardedVideoAd { get; set; } //rewardvideo
        int hintsPoints, currentQuestion, correctAnswer, incorrectAnswer, lifeCount, ChoosedGameModeIndex, ChoosedTotalScore, ChoosedLevelScoreEarned;
        string ChoosedGameModeLabel;
        List<Vehicle> vehicles;
        List<Level> levels = new List<Level>();
        IEnumerable<Vehicle> linqCharacter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ClassicGameMode);
            context = ApplicationContext;

            _CGMQuestionImage = FindViewById<ImageView>(Resource.Id.imageQuestion);
            _CGMAnswerA = FindViewById<Button>(Resource.Id.buttonAnswerA);
            _CGMAnswerB = FindViewById<Button>(Resource.Id.buttonAnswerB);
            _CGMAnswerC = FindViewById<Button>(Resource.Id.buttonAnswerC);
            _CGMAnswerD = FindViewById<Button>(Resource.Id.buttonAnswerD);
            _HintsPoints = FindViewById<TextView>(Resource.Id.textHintpoints);
            _CurrentQuestion = FindViewById<TextView>(Resource.Id.textCurrentQuetion);
            _CountQuestion = FindViewById<TextView>(Resource.Id.textTotalQuesion);
            _CorrectAnswer = FindViewById<TextView>(Resource.Id.textCorrectAnswer);
            _linearHeart = FindViewById<LinearLayout>(Resource.Id.linearHeart);
            _LoggedInGooglePlay = FindViewById<TextView>(Resource.Id.textLogged);
            _linearHeart = FindViewById<LinearLayout>(Resource.Id.linearHeart);
            _imageHeart1 = FindViewById<ImageView>(Resource.Id.imageHeart1);
            _imageHeart2 = FindViewById<ImageView>(Resource.Id.imageHeart2);
            _imageHeart3 = FindViewById<ImageView>(Resource.Id.imageHeart3);

            _CGMAnswerA.SetOnClickListener(this);
            _CGMAnswerB.SetOnClickListener(this);
            _CGMAnswerC.SetOnClickListener(this);
            _CGMAnswerD.SetOnClickListener(this);

            levels = LevelCollection.GetLevels();
            AdMobInitialization();
            GetDataFromPrevActiviity();
            SetTopPanelData();
            LevelDataForUnlocked();
            ShowQuestion();
            UpdateHeart();
            ShowGoogleLoginLabel();
        }

        private void SetTopPanelData()
        {
            hintsPoints = 0; //load
            currentQuestion = 1;
            correctAnswer = 0;
            incorrectAnswer = 0;
            _CountQuestion.SetText(ChoosedTotalScore.ToString(), TextView.BufferType.Normal);
            _HintsPoints.SetText(hintsPoints.ToString(), TextView.BufferType.Normal);
            _CurrentQuestion.SetText(currentQuestion.ToString(), TextView.BufferType.Normal);
            _CorrectAnswer.SetText(correctAnswer.ToString(), TextView.BufferType.Normal);
        }

        private void GetDataFromPrevActiviity()
        {
            ChoosedGameModeIndex = Intent.GetIntExtra("ChoosedGameMode", 1); //номер рівня
            ChoosedTotalScore = Intent.GetIntExtra("ChoosedTotalScore", 0); //кількість питань
            ChoosedGameModeLabel = Intent.GetStringExtra("ChoosedGameModeLabel"); //назва битви
            ChoosedLevelScoreEarned = Intent.GetIntExtra("ChoosedLevelScoreEarned", 0); //кількість очок для перезапису
        }

        private void LoadListPlanesAndTanks()
        {
            var planes = PlaneCollection.GetPlanes();
            var tanks = TankCollection.GetTanks();
            planes.AddRange(tanks);
            vehicles = planes;
        }

        private void LoadListPlanesAndShips()
        {
            var planes = PlaneCollection.GetPlanes();
            var ships = ShipCollection.GetShips();
            planes.AddRange(ships);
            vehicles = planes;
        }

        private void _BackToMenuButtonNo_Click(object sender, EventArgs e)
        {
            alertDialogAndroid.Dismiss();
        }

        private void _BackToMenuButtonYes_Click(object sender, EventArgs e)
        {
            alertDialogAndroid.Dismiss();
            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
            Finish();
        }

        private void ShowGoogleLoginLabel()
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(context);
            ISharedPreferencesEditor editor = prefs.Edit();

            var loggedInGooglePlay = prefs.GetBoolean("LoggedInGooglePlay", false);
            if (loggedInGooglePlay == true)
            {
                _LoggedInGooglePlay.Visibility = ViewStates.Gone;
            }
            else
            {
                _LoggedInGooglePlay.Visibility = ViewStates.Visible;
            }
        }

        public async void OnClick(View v)
        {
            v.StartAnimation(buttonClick);
            Button btnClicked = (Button)v;
            _CGMAnswerA.Enabled = false;
            _CGMAnswerB.Enabled = false;
            _CGMAnswerC.Enabled = false;
            _CGMAnswerD.Enabled = false;

            if (btnClicked.Text == correctVehicles.Name) //Correct answer
            {
                currentQuestion++;
                correctAnswer++;
                hintsPoints = hintsPoints + 10;

                btnClicked.SetBackgroundResource(Resource.Drawable._GreenButton);
                await Task.Delay(500);
                btnClicked.SetBackgroundResource(Resource.Drawable._ShapeButton);
                await Task.Delay(500);

                _HintsPoints.SetText(hintsPoints.ToString(), TextView.BufferType.Normal);
                _CurrentQuestion.SetText(currentQuestion.ToString(), TextView.BufferType.Normal);
                _CorrectAnswer.SetText(correctAnswer.ToString(), TextView.BufferType.Normal);
            }
            else //Incorrect answer
            {
                currentQuestion++;
                incorrectAnswer++;
                              
                if (_CGMAnswerA.Text == correctVehicles.Name)
                {
                    await BlinkingAsync(_CGMAnswerA);                
                } 
                if (_CGMAnswerB.Text == correctVehicles.Name)
                {
                    await BlinkingAsync(_CGMAnswerB);
                }
                if (_CGMAnswerC.Text == correctVehicles.Name)
                {
                    await BlinkingAsync(_CGMAnswerC);
                }
                if (_CGMAnswerD.Text == correctVehicles.Name)
                {
                    await BlinkingAsync(_CGMAnswerD);
                }

                async Task BlinkingAsync(Button buttonRigtAnswer)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        btnClicked.SetBackgroundResource(Resource.Drawable._RedButton);
                        buttonRigtAnswer.SetBackgroundResource(Resource.Drawable._GreenButton);
                        await Task.Delay(500);
                        btnClicked.SetBackgroundResource(Resource.Drawable._ShapeButton);
                        buttonRigtAnswer.SetBackgroundResource(Resource.Drawable._ShapeButton);
                        await Task.Delay(500);
                    }
                }

                _CurrentQuestion.SetText(currentQuestion.ToString(), TextView.BufferType.Normal);
            }

            ShowQuestion();
            UpdateHeart();
        }

        private void EnableButton()
        {
            _CGMAnswerA.Enabled = true;
            _CGMAnswerB.Enabled = true;
            _CGMAnswerC.Enabled = true;
            _CGMAnswerD.Enabled = true;
        }

        public void ShowQuestion()
        {
            #region Check If end of the game

            if (currentQuestion > ChoosedTotalScore)
            {
                var qc = currentQuestion - 1;
                _CurrentQuestion.SetText(qc.ToString(), TextView.BufferType.Normal);
                EnableButton();
                FinishGameAndShowAds();
            }
            else if (incorrectAnswer >= lifeCount)
            {
                EnableButton();
                AlertDialogVideoReward();
            }
            else
            {
                EnableButton();
            }
            #endregion

            #region Randomizer for answer. Heart of game

            LevelFilteredViaLinq();

            random = new Random();
            correctVehicles = vehicles.ElementAt(random.Next(vehicles.Count));  //get right answer

            List<string> shufleTemporaryCollection = new List<string>();
            do
            {
                int index = random.Next(0, vehicles.Count); //get random index
                if (vehicles[index].Character == correctVehicles.Character)
                {
                    if (shufleTemporaryCollection.Contains(vehicles[index].Name))
                    {

                    }
                    else
                    {
                        shufleTemporaryCollection.Add(vehicles[index].Name);  //add to temporary collection
                    }
                }
            }
            while (shufleTemporaryCollection.Count < 5);

            var btn1 = shufleTemporaryCollection.ElementAt(0);
            var btn2 = shufleTemporaryCollection.ElementAt(1);
            var btn3 = shufleTemporaryCollection.ElementAt(2);
            var btn4 = shufleTemporaryCollection.ElementAt(3);

            #endregion

            #region Signing random value
            _CGMQuestionImage.SetImageResource(correctVehicles.Image);
            _CGMAnswerA.SetText(shufleTemporaryCollection.ElementAt(0), TextView.BufferType.Normal);
            _CGMAnswerB.SetText(shufleTemporaryCollection.ElementAt(1), TextView.BufferType.Normal);
            _CGMAnswerC.SetText(shufleTemporaryCollection.ElementAt(2), TextView.BufferType.Normal);
            _CGMAnswerD.SetText(shufleTemporaryCollection.ElementAt(3), TextView.BufferType.Normal);
            #endregion

            #region Check the right answer in button

            if (_CGMAnswerA.Text == correctVehicles.Name)
            {

            }
            else if (_CGMAnswerB.Text == correctVehicles.Name)
            {

            }
            else if (_CGMAnswerC.Text == correctVehicles.Name)
            {

            }
            else if (_CGMAnswerD.Text == correctVehicles.Name)
            {

            }
            else
            {
                Random randomButton = new Random();
                Button chosenButton;
                Button[] LeftArr = new Button[4] { _CGMAnswerA, _CGMAnswerB, _CGMAnswerC, _CGMAnswerD };
                chosenButton = LeftArr[randomButton.Next(0, 4)];
                chosenButton.SetText(correctVehicles.Name, TextView.BufferType.Normal);
            }
            #endregion

            vehicles.Remove(correctVehicles);
            shufleTemporaryCollection.Clear();
        }

        private void SetndDataToShowRelustActivity(Intent intent)
        {
            intent.PutExtra("SRLevelNumber", ChoosedGameModeIndex);
            intent.PutExtra("SRTotalScore", ChoosedTotalScore);
            intent.PutExtra("SRBattleName", ChoosedGameModeLabel);
            intent.PutExtra("SRPoints", correctAnswer);
        }

        private void UpdateHeart()
        {
            if (ChoosedGameModeIndex == 100)
            {
                switch (incorrectAnswer)
                {
                    case 0:
                        _imageHeart1.SetImageResource(Resource.Drawable._Heart);
                        _imageHeart2.SetImageResource(Resource.Drawable._HeartEmpty);
                        _imageHeart3.SetImageResource(Resource.Drawable._HeartEmpty);
                        break;
                    default:
                        _imageHeart1.SetImageResource(Resource.Drawable._HeartEmpty);
                        _imageHeart2.SetImageResource(Resource.Drawable._HeartEmpty);
                        _imageHeart3.SetImageResource(Resource.Drawable._HeartEmpty);
                        break;
                }
                return;
            }

            switch (incorrectAnswer)
            {
                case 2:
                    _imageHeart1.SetImageResource(Resource.Drawable._Heart);
                    _imageHeart2.SetImageResource(Resource.Drawable._HeartEmpty);
                    _imageHeart3.SetImageResource(Resource.Drawable._HeartEmpty);
                    break;
                case 1:
                    _imageHeart1.SetImageResource(Resource.Drawable._Heart);
                    _imageHeart2.SetImageResource(Resource.Drawable._Heart);
                    _imageHeart3.SetImageResource(Resource.Drawable._HeartEmpty);
                    break;
                case 0:
                    _imageHeart1.SetImageResource(Resource.Drawable._Heart);
                    _imageHeart2.SetImageResource(Resource.Drawable._Heart);
                    _imageHeart3.SetImageResource(Resource.Drawable._Heart);
                    break;
                default:
                    _imageHeart1.SetImageResource(Resource.Drawable._HeartEmpty);
                    _imageHeart2.SetImageResource(Resource.Drawable._HeartEmpty);
                    _imageHeart3.SetImageResource(Resource.Drawable._HeartEmpty);
                    break;
            }
        }

        protected override void OnPause()
        {
            if (mAdView != null)
            {
                mAdView.Pause();
            }
            RewardedVideoAd.Pause(this);
            base.OnPause();
        }

        protected override void OnResume()
        {
            if (mAdView != null)
            {
                mAdView.Resume();
            }
            if (!mInterstitialAd.IsLoaded)
            {
                RequestNewInterstitial();
            }
            RewardedVideoAd.Resume(this);
            base.OnResume();
        }

        protected override void OnDestroy()
        {
            if (mAdView != null)
            {
                mAdView.Destroy();
            }
            RewardedVideoAd.Destroy(this);
            base.OnDestroy();
        }

        public override void OnBackPressed()
        {
            layoutInflater = LayoutInflater.From(this);
            mview = layoutInflater.Inflate(Resource.Layout._alertDialogBackToMenu, null);
            alertDialogBuilder = new Android.App.AlertDialog.Builder(this);
            alertDialogBuilder.SetView(mview);
            alertDialogAndroid = alertDialogBuilder.Create();
            alertDialogAndroid.Window.SetBackgroundDrawableResource(Resource.Color.mtrl_btn_transparent_bg_color);
            alertDialogAndroid.Show();
            _BackToMenuButtonNo = mview.FindViewById<Button>(Resource.Id.BackToMenuButtonNo);
            _BackToMenuButtonYes = mview.FindViewById<Button>(Resource.Id.BackToMenuButtonYes);
            _BackToMenuButtonNo.Click += _BackToMenuButtonNo_Click;
            _BackToMenuButtonYes.Click += _BackToMenuButtonYes_Click;
        }
    }
}