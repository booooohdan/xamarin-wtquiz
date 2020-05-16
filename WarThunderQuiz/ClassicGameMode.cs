using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using WarThunderQuiz.GameData;
using static Android.Views.View;
using Android.Gms.Ads;
using Android.Gms.Ads.Reward;
using Google.Ads.Mediation.Admob;
using IO.Github.Krtkush.Lineartimer;
using System.Timers;
using System.Threading;
using Android.Preferences;
using Android.Util;

namespace WarThunderQuiz
{
    [Activity(Theme = "@style/AppTheme.NoActionBar", ScreenOrientation = ScreenOrientation.Portrait)]

    public class ClassicGameMode : AppCompatActivity, IOnClickListener, IRewardedVideoAdListener
    {
        #region Оголошення змінних реклами
        Context context;
        protected AdView mAdView;
        public InterstitialAd mInterstitialAd;
        protected Button mLoadInterstitialButton;
        public Button DisplayVideoButton { get; set; } //rewardvideo
        public IRewardedVideoAd RewardedVideoAd { get; set; } //rewardvideo
        #endregion

        #region Оголошення змінних класу
        ImageView _CGMQuestionImage, _imageHeart1, _imageHeart2, _imageHeart3;
        Button _CGMAnswerA, _CGMAnswerB, _CGMAnswerC, _CGMAnswerD, _BackToMenuButtonNo, _BackToMenuButtonYes;
        List<Vehicle> vehicles;
        List<Level> levels = new List<Level>();
        Vehicle correctVehicles;
        AlphaAnimation buttonClick = new AlphaAnimation(1F, 0.9F);
        TextView _HintsPoints, _CurrentQuestion, _CountQuestion, _CorrectAnswer, _LoggedInGooglePlay;
        LinearLayout _linearHeart;
        int hintsPoints, currentQuestion, correctAnswer, incorrectAnswer, lifeCount;
        int ChoosedGameModeIndex, ChoosedTotalScore, ChoosedLevelScoreEarned;
        string ChoosedGameModeLabel;
        Random random;

        #endregion

        #region Оголошення змінних для AlertDialog
        ImageButton _RewardButtonYes;
        LayoutInflater layoutInflater;
        View mview;
        Android.App.AlertDialog.Builder alertDialogBuilder;
        Android.App.AlertDialog alertDialogAndroid;
        LayoutInflater layoutInflaterVideo;
        View mviewVideo;
        Android.App.AlertDialog.Builder alertDialogBuilderVideo;
        Android.App.AlertDialog alertDialogAndroidVideo;
        ProgressBar ProgressBarVideoAd;
        IEnumerable<Vehicle> linqCharacter;
        CancellationTokenSource source;
        #endregion


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ClassicGameMode);
            context = ApplicationContext;
            levels = LevelCollection.GetLevels();

            #region Прив'язка картинок життів через FindView

            _linearHeart = FindViewById<LinearLayout>(Resource.Id.linearHeart);
            _imageHeart1 = FindViewById<ImageView>(Resource.Id.imageHeart1);
            _imageHeart2 = FindViewById<ImageView>(Resource.Id.imageHeart2);
            _imageHeart3 = FindViewById<ImageView>(Resource.Id.imageHeart3);
            #endregion

            #region AdMob міжсторінкова ініціалізація
            mInterstitialAd = new InterstitialAd(this);
            mInterstitialAd.AdUnitId = "ca-app-pub-8211072909515345/1856723600";
            mInterstitialAd.AdListener = new AdListener(this);
            #endregion

            #region Admob відео нагорода ініціалізація
            RewardedVideoAd = MobileAds.GetRewardedVideoAdInstance(this);
            RewardedVideoAd.RewardedVideoAdListener = this;
            LoadRewardedVideoAd();
            #endregion

            #region Отримання даних про режим та встановлення значень

            ChoosedGameModeIndex = Intent.GetIntExtra("ChoosedGameMode", 1); //номер рівня
            ChoosedTotalScore = Intent.GetIntExtra("ChoosedTotalScore", 0); //кількість питань
            ChoosedGameModeLabel = Intent.GetStringExtra("ChoosedGameModeLabel"); //назва битви
            ChoosedLevelScoreEarned = Intent.GetIntExtra("ChoosedLevelScoreEarned", 0); //кількість очок для перезапису
            #endregion

            #region Прив'язка елементів інтерфейсу FindView і ClickListener

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

            _CGMAnswerA.SetOnClickListener(this);
            _CGMAnswerB.SetOnClickListener(this);
            _CGMAnswerC.SetOnClickListener(this);
            _CGMAnswerD.SetOnClickListener(this);

            #endregion

            #region Ініціалізація і установка текстових значень (очки, підказки, питання) в верхній панелі

            hintsPoints = 0; //load
            currentQuestion = 1;
            correctAnswer = 0;
            incorrectAnswer = 0;
            _CountQuestion.SetText(ChoosedTotalScore.ToString(), TextView.BufferType.Normal);
            _HintsPoints.SetText(hintsPoints.ToString(), TextView.BufferType.Normal);
            _CurrentQuestion.SetText(currentQuestion.ToString(), TextView.BufferType.Normal);
            _CorrectAnswer.SetText(correctAnswer.ToString(), TextView.BufferType.Normal);
            #endregion

            ChooseLevel();
            ShowQuestion();
            UpdateHeart();
            ShowGoogleLoginLabel();
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

        private void ChooseLevel()
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(context);
            ISharedPreferencesEditor editor = prefs.Edit();
            lifeCount = 100;

            switch (ChoosedGameModeIndex)
            {
                case 1:
                    _linearHeart.Visibility = ViewStates.Invisible;
                    LoadListPlanesAndTanks();
                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked2", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel1", correctAnswer); }
                    editor.Apply();
                    break;

                case 2:
                    _linearHeart.Visibility = ViewStates.Invisible;
                    LoadListPlanesAndTanks();
                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked3", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel2", correctAnswer); }
                    editor.Apply();
                    break;

                case 3:
                    _linearHeart.Visibility = ViewStates.Invisible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked4", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel3", correctAnswer); }
                    editor.Apply();
                    break;

                case 4:
                    _linearHeart.Visibility = ViewStates.Invisible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked5", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel4", correctAnswer); }
                    editor.Apply();
                    break;

                case 5:
                    _linearHeart.Visibility = ViewStates.Invisible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked6", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel5", correctAnswer); }
                    editor.Apply();
                    break;

                case 6:
                    _linearHeart.Visibility = ViewStates.Invisible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked7", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel6", correctAnswer); }
                    editor.Apply();
                    break;

                case 7:
                    _linearHeart.Visibility = ViewStates.Invisible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked8", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel7", correctAnswer); }
                    editor.Apply();
                    break;

                case 8:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndShips();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked9", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel8", correctAnswer); }
                    editor.Apply();
                    break;

                case 9:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndShips();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked10", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel9", correctAnswer); }
                    editor.Apply();
                    break;

                case 10:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked11", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel10", correctAnswer); }
                    editor.Apply();
                    break;

                case 11:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked12", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel11", correctAnswer); }
                    editor.Apply();
                    break;

                case 12:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked13", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel12", correctAnswer); }
                    editor.Apply();
                    break;

                case 13:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndShips();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked14", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel13", correctAnswer); }
                    editor.Apply();
                    break;

                case 14:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked15", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel14", correctAnswer); }
                    editor.Apply();
                    break;

                case 15:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked16", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel15", correctAnswer); }
                    editor.Apply();
                    break;

                case 16:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked17", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel16", correctAnswer); }
                    editor.Apply();
                    break;

                case 17:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked18", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel17", correctAnswer); }
                    editor.Apply();
                    break;

                case 18:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndShips();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked19", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel18", correctAnswer); }
                    editor.Apply();
                    break;

                case 19:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndShips();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked20", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel19", correctAnswer); }
                    editor.Apply();
                    break;

                case 20:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked21", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel20", correctAnswer); }
                    editor.Apply();
                    break;

                case 21:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked22", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel21", correctAnswer); }
                    editor.Apply();
                    break;

                case 22:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked23", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel22", correctAnswer); }
                    editor.Apply();
                    break;

                case 23:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked24", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel23", correctAnswer); }
                    editor.Apply();
                    break;

                case 24:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked25", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel24", correctAnswer); }
                    editor.Apply();
                    break;

                case 25:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked26", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel25", correctAnswer); }
                    editor.Apply();
                    break;

                case 26:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked27", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel26", correctAnswer); }
                    editor.Apply();
                    break;

                case 27:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndShips();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked28", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel27", correctAnswer); }
                    editor.Apply();
                    break;

                case 28:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked29", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel28", correctAnswer); }
                    editor.Apply();
                    break;

                case 29:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndShips();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked30", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel29", correctAnswer); }
                    editor.Apply();
                    break;

                case 30:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndShips();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked31", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel30", correctAnswer); }
                    editor.Apply();
                    break;

                case 31:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible; 
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked32", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel31", correctAnswer); }
                    editor.Apply();
                    break;

                case 32:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndShips();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked33", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel32", correctAnswer); }
                    editor.Apply();
                    break;


                case 33:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndShips();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked34", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel33", correctAnswer); }
                    editor.Apply();
                    break;

                case 34:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked35", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel34", correctAnswer); }
                    editor.Apply();
                    break;

                case 35:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndShips();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked36", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel35", correctAnswer); }
                    editor.Apply();
                    break;

                case 36:
                    lifeCount = 1;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked37", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel36", correctAnswer); }
                    editor.Apply();
                    break;

                case 37:
                    lifeCount = 1;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked38", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel37", correctAnswer); }
                    editor.Apply();
                    break;

                case 38:
                    lifeCount = 1;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked39", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel38", correctAnswer); }
                    editor.Apply();
                    break;

                case 39:
                    lifeCount = 1;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked40", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel39", correctAnswer); }
                    editor.Apply();
                    break;

                case 40:
                    lifeCount = 1;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked41", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel40", correctAnswer); }
                    editor.Apply();
                    break;




                case 100:
                    lifeCount = 1;
                    _linearHeart.Visibility = ViewStates.Visible;
                    var planes = PlaneCollection.GetPlanes();
                    var tanks = TankCollection.GetTanks();
                    var ships = ShipCollection.GetShips();
                    planes.AddRange(tanks);
                    planes.AddRange(ships);
                    vehicles = planes;
                    break;


                case 101:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();
                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked102", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel101", correctAnswer); }
                    editor.Apply();
                    break;

                case 102:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();
                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked103", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel102", correctAnswer); }
                    editor.Apply();
                    break;

                case 103:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndShips();
                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked104", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel103", correctAnswer); }
                    editor.Apply();
                    break;

                case 104:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked105", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel104", correctAnswer); }
                    editor.Apply();
                    break;

                case 105:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked106", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel105", correctAnswer); }
                    editor.Apply();
                    break;

                case 106:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked107", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel106", correctAnswer); }
                    editor.Apply();
                    break;

                case 107:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked108", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel107", correctAnswer); }
                    editor.Apply();
                    break;

                case 108:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked109", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel108", correctAnswer); }
                    editor.Apply();
                    break;

                case 109:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked110", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel109", correctAnswer); }
                    editor.Apply();
                    break;

                case 110:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();
                     
                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked111", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel110", correctAnswer); }
                    editor.Apply();
                    break;

                case 111:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked112", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel111", correctAnswer); }
                    editor.Apply();
                    break;


                case 112:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked113", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel112", correctAnswer); }
                    editor.Apply();
                    break;

                case 113:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked114", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel113", correctAnswer); }
                    editor.Apply();
                    break;

                case 114:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked115", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel114", correctAnswer); }
                    editor.Apply();
                    break;

            }

        }

        #region Реалізація міжсторінкової реклами

        public void RequestNewInterstitial()
        {
            var adRequest = new AdRequest.Builder().Build();
            //  var adRequest = new AdRequest.Builder().AddTestDevice("D0BE22F1A4BE27C7470F95A699568FE2").Build();
            mInterstitialAd.LoadAd(adRequest);
        }

        public void BeginSecondActivity()
        {
            ChooseLevel();
            Intent intent = new Intent(this, typeof(ShowResult));
            intent.PutExtra("SRLevelNumber", ChoosedGameModeIndex);
            intent.PutExtra("SRTotalScore", ChoosedTotalScore);
            intent.PutExtra("SRBattleName", ChoosedGameModeLabel);
            intent.PutExtra("SRPoints", correctAnswer);
            StartActivity(intent);
            Finish();
        }

        #endregion

        #region Відео нагорода, реалізація
        public void LoadRewardedVideoAd()
        {
            RewardedVideoAd.LoadAd("ca-app-pub-8211072909515345/2330386383",
             new AdRequest.Builder().Build());
            //RewardedVideoAd.LoadAd("ca-app-pub-3940256099942544/5224354917",
            //new AdRequest.Builder().AddTestDevice("FE5692B3DAD1B4CE3BE3BDA2FF4B6103").Build());
        }

        public void OnRewarded(IRewardItem reward)
        {
            //  Toast.MakeText(this, string.Format("OnRewarded ! currency: {0} amount: {1}", reward.GetType(), reward.Amount), ToastLength.Short).Show();
            incorrectAnswer = incorrectAnswer - 1;
            ShowQuestion();
            UpdateHeart();

        }

        public void OnRewardedVideoAdLeftApplication()
        {
            // Toast.MakeText(this, "OnRewardedVideoAdLeftApplication", ToastLength.Short).Show();
        }

        public void OnRewardedVideoAdClosed()
        {
            //  Toast.MakeText(this, "OnRewardedVideoAdClosed", ToastLength.Short).Show();
            LoadRewardedVideoAd();
        }

        public void OnRewardedVideoAdFailedToLoad(int errorCode)
        {
            //   Toast.MakeText(this, "OnRewardedVideoAdFailedToLoad Code error : " + errorCode, ToastLength.Short).Show();
        }

        public void OnRewardedVideoAdLoaded()
        {
            Log.Info("VideoAD: ", "DONE----------------EE");
            //Toast.MakeText(this, "OnRewardedVideoAdLoaded", ToastLength.Short).Show();
        }

        public void OnRewardedVideoAdOpened()
        {
            //  Toast.MakeText(this, "OnRewardedVideoAdOpened", ToastLength.Short).Show();
        }

        public void OnRewardedVideoStarted()
        {
            //   Toast.MakeText(this, "OnRewardedVideoStarted", ToastLength.Short).Show();
        }

        public void OnRewardedVideoCompleted()
        {
            //   Toast.MakeText(this, "OnRewardedVideoCompleted", ToastLength.Short).Show();
        }

        public void ShowRewardedVideo()
        {
            if (RewardedVideoAd.IsLoaded)
            {
                RewardedVideoAd.Show();
            }
            else
            {
                Toast.MakeText(this, "Ad not loaded. Check your internet connection", ToastLength.Long).Show();
                FinishGame();
            }
        }

        #endregion

        #region Перевизначення OnPause, OnResume, OnDestroy, OnBackPressed

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

        #endregion

        #region AlertDialog OnBackPressed
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

        #endregion

        #region AlertDialog OnRewardVideo
        public async void AlertDialogVideoReward()
        {
            source = new CancellationTokenSource();

            layoutInflaterVideo = LayoutInflater.From(this);
            mviewVideo = layoutInflaterVideo.Inflate(Resource.Layout._alertDialogRewardVideo, null);
            alertDialogBuilderVideo = new Android.App.AlertDialog.Builder(this);
            alertDialogBuilderVideo.SetView(mviewVideo);
            alertDialogAndroidVideo = alertDialogBuilderVideo.Create();
            alertDialogAndroidVideo.Show();
            alertDialogAndroidVideo.SetCanceledOnTouchOutside(false);
            alertDialogAndroidVideo.SetCancelable(false);
            alertDialogAndroidVideo.Window.SetBackgroundDrawableResource(Resource.Color.mtrl_btn_transparent_bg_color);
            _RewardButtonYes = mviewVideo.FindViewById<ImageButton>(Resource.Id.RewardButtonYes);
            _RewardButtonYes.Click += _RewardButtonYes_Click;

            ProgressBarVideoAd = mviewVideo.FindViewById<ProgressBar>(Resource.Id.progressBarVideoAd);
            ProgressBarVideoAd.Max = 100;
            DoProgressBar();





            try
            {
                //ProgressBarVideoAd.IncrementProgressBy(10);
                await Task.Delay(5200, source.Token);
                TimerElapsed();
            }
            catch (TaskCanceledException)
            {
                return;
            }
        }


        private async void DoProgressBar()
        {
            for (int i = 0; i < 100; i++)
            {
                await Task.Delay(50);
                ProgressBarVideoAd.IncrementProgressBy(1);
                ProgressBarVideoAd.Progress = 100 - i;
            }
        }

        private void TimerElapsed()
        {
            alertDialogAndroidVideo.Dismiss();
            FinishGame();
        }

        private void _RewardButtonYes_Click(object sender, EventArgs e)
        {
            source.Cancel();
            alertDialogAndroidVideo.Dismiss();
            ShowRewardedVideo();
        }


        #endregion

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
            Button btnClicked = (Button)v; //Кнопка нажата 
            _CGMAnswerA.Enabled = false; //Вимк всі кнопки 
            _CGMAnswerB.Enabled = false;
            _CGMAnswerC.Enabled = false;
            _CGMAnswerD.Enabled = false;
            if (btnClicked.Text == correctVehicles.Name) //Якщо відповідь правильна
            {
                currentQuestion++;
                correctAnswer++;
                hintsPoints = hintsPoints + 10;

                #region Мигання правильної відповіді
                btnClicked.SetBackgroundResource(Resource.Drawable._GreenButton);
                await Task.Delay(500);
                btnClicked.SetBackgroundResource(Resource.Drawable._ShapeButton);
                await Task.Delay(500);
                #endregion

                #region Запис значень в верхню панель
                _HintsPoints.SetText(hintsPoints.ToString(), TextView.BufferType.Normal);
                _CurrentQuestion.SetText(currentQuestion.ToString(), TextView.BufferType.Normal);
                _CorrectAnswer.SetText(correctAnswer.ToString(), TextView.BufferType.Normal);
                #endregion

            }
            else //Якщо відповідь неправильна
            {
                currentQuestion++;
                incorrectAnswer++;

                #region Мигання неправильної відповіді

                if (_CGMAnswerA.Text == correctVehicles.Name)
                {
                    btnClicked.SetBackgroundResource(Resource.Drawable._RedButton);
                    _CGMAnswerA.SetBackgroundResource(Resource.Drawable._GreenButton);
                    await Task.Delay(500);
                    btnClicked.SetBackgroundResource(Resource.Drawable._ShapeButton);
                    _CGMAnswerA.SetBackgroundResource(Resource.Drawable._ShapeButton);
                    await Task.Delay(500);
                    btnClicked.SetBackgroundResource(Resource.Drawable._RedButton);
                    _CGMAnswerA.SetBackgroundResource(Resource.Drawable._GreenButton);
                    await Task.Delay(500);
                    btnClicked.SetBackgroundResource(Resource.Drawable._ShapeButton);
                    _CGMAnswerA.SetBackgroundResource(Resource.Drawable._ShapeButton);
                    await Task.Delay(500);
                }
                else
                     if (_CGMAnswerB.Text == correctVehicles.Name)
                {
                    btnClicked.SetBackgroundResource(Resource.Drawable._RedButton);
                    _CGMAnswerB.SetBackgroundResource(Resource.Drawable._GreenButton);
                    await Task.Delay(500);
                    btnClicked.SetBackgroundResource(Resource.Drawable._ShapeButton);
                    _CGMAnswerB.SetBackgroundResource(Resource.Drawable._ShapeButton);
                    await Task.Delay(500);
                    btnClicked.SetBackgroundResource(Resource.Drawable._RedButton);
                    _CGMAnswerB.SetBackgroundResource(Resource.Drawable._GreenButton);
                    await Task.Delay(500);
                    btnClicked.SetBackgroundResource(Resource.Drawable._ShapeButton);
                    _CGMAnswerB.SetBackgroundResource(Resource.Drawable._ShapeButton);
                    await Task.Delay(500);
                }
                else
                     if (_CGMAnswerC.Text == correctVehicles.Name)
                {
                    btnClicked.SetBackgroundResource(Resource.Drawable._RedButton);
                    _CGMAnswerC.SetBackgroundResource(Resource.Drawable._GreenButton);
                    await Task.Delay(500);
                    btnClicked.SetBackgroundResource(Resource.Drawable._ShapeButton);
                    _CGMAnswerC.SetBackgroundResource(Resource.Drawable._ShapeButton);
                    await Task.Delay(500);
                    btnClicked.SetBackgroundResource(Resource.Drawable._RedButton);
                    _CGMAnswerC.SetBackgroundResource(Resource.Drawable._GreenButton);
                    await Task.Delay(500);
                    btnClicked.SetBackgroundResource(Resource.Drawable._ShapeButton);
                    _CGMAnswerC.SetBackgroundResource(Resource.Drawable._ShapeButton);
                    await Task.Delay(500);
                }
                else
                      if (_CGMAnswerD.Text == correctVehicles.Name)
                {
                    btnClicked.SetBackgroundResource(Resource.Drawable._RedButton);
                    _CGMAnswerD.SetBackgroundResource(Resource.Drawable._GreenButton);
                    await Task.Delay(500);
                    btnClicked.SetBackgroundResource(Resource.Drawable._ShapeButton);
                    _CGMAnswerD.SetBackgroundResource(Resource.Drawable._ShapeButton);
                    await Task.Delay(500);
                    btnClicked.SetBackgroundResource(Resource.Drawable._RedButton);
                    _CGMAnswerD.SetBackgroundResource(Resource.Drawable._GreenButton);
                    await Task.Delay(500);
                    btnClicked.SetBackgroundResource(Resource.Drawable._ShapeButton);
                    _CGMAnswerD.SetBackgroundResource(Resource.Drawable._ShapeButton);
                    await Task.Delay(500);
                }
                #endregion

                #region Запис значень в верхню панель
                _CurrentQuestion.SetText(currentQuestion.ToString(), TextView.BufferType.Normal);
                #endregion

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
            #region Кінець гри

            if (currentQuestion > ChoosedTotalScore)
            {
                var qc = currentQuestion - 1;
                _CurrentQuestion.SetText(qc.ToString(), TextView.BufferType.Normal);
                EnableButton();
                FinishGame();
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

            #region Генератора рандомних унікальних значень для тексту кнопок

            //        selectedVehicleCharacter = correctVehicles.Character; //змінна типу техніки
            //        selectedVehicleNation = correctVehicles.Nation; //змінна нації техніки

            #region Рівні
            switch (ChoosedGameModeIndex)
            {
                case 1:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "Japan" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 2:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "Germany" || s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "Italy" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "Germany" || s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 3:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "Germany" || s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "Italy" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "Germany" || s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 4:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "Germany" || s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "Italy" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "Germany" || s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 5:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "Japan" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 6:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "Japan" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 7:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "Japan" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 8:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" || 
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" || 
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Italy" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 1 && s.Nation == "USA" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 1 && s.Nation == "GB" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 1 && s.Nation == "France" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 1 && s.Nation == "Germany" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 1 && s.Nation == "Italy" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 9:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 1 && s.Nation == "GB" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 1 && s.Nation == "France" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 1 && s.Nation == "Germany" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "Germany"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 10:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 11:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Italy"||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 12:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Italy" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 13:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 1 && s.Nation == "USSR" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 1 && s.Nation == "GB" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 1 && s.Nation == "USA" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 1 && s.Nation == "Germany" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "Germany"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 14:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Italy" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 15:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 16:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Japan" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 17:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Italy" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 18:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Japan" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 19:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Japan" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 20:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Italy" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 21:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Italy" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 22:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Italy" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 23:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 24:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Italy" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 25:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Italy" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 26:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 27:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Japan" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 28:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 29:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Japan" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 30:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Japan" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 31:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 32:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Japan" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 33:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Japan" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 34:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Japan" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 35:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Japan" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 36:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USSR"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 37:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USSR"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 38:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USSR"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 39:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USSR"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 40:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USSR"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;



                case 100:
                    break;

                case 101:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 102:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Tank"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 103:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Ship"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 104:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane"&& s.Nation == "USA" ||
                                               s.Character == "Tank" && s.Nation == "USA"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 105:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.Nation == "Germany"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 106:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.Nation == "USSR"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 107:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.Nation == "GB" ||
                                               s.Character == "Tank" && s.Nation == "GB"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 108:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.Nation == "Japan" ||
                                               s.Character == "Tank" && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 109:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.Nation == "Italy" ||
                                               s.Character == "Tank" && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 110:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.Nation == "France" ||
                                               s.Character == "Tank" && s.Nation == "France"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 111:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.Nation == "Sweden" ||
                                               s.Character == "Tank" && s.Nation == "Sweden"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;


                case 112:
                    linqCharacter = from s in vehicles
                                    where s.PeriodOfTime == 1
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;



                case 113:
                    linqCharacter = from s in vehicles
                                    where s.PeriodOfTime == 2
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;



                case 114:
                    linqCharacter = from s in vehicles
                                    where s.PeriodOfTime == 3
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;
            }




            #endregion

            random = new Random();
            correctVehicles = vehicles.ElementAt(random.Next(vehicles.Count));  //отримання правильного значення

            List<string> shufleTemporaryCollection = new List<string>();
            do
            {
                int index = random.Next(0, vehicles.Count); //отримання випадкового індексу
                if (vehicles[index].Character == correctVehicles.Character)
                {
                    if (shufleTemporaryCollection.Contains(vehicles[index].Name))
                    {

                    }
                    else
                    {
                        shufleTemporaryCollection.Add(vehicles[index].Name);  //додання в тимчасову колекцію
                    }
                }
            }
            while (shufleTemporaryCollection.Count < 5);

            //for (int i = 0; i < 4; i++) //додання 4 випадкових індексів з selectedVehicleList в колекцію 
            //{
            //    int index = random.Next(0, vehicles.Count); //отримання випадкового індексу

            //    shufleTemporaryCollection.Add(vehicles[index].Name);  //додання в тимчасову колекцію
            //    //vehicles.RemoveAt(index); //видалення з загальної колекції
            //}

            var btn1 = shufleTemporaryCollection.ElementAt(0);
            var btn2 = shufleTemporaryCollection.ElementAt(1);
            var btn3 = shufleTemporaryCollection.ElementAt(2);
            var btn4 = shufleTemporaryCollection.ElementAt(3);

            #endregion

            #region Присвоєння рандомних значень елементам
            _CGMQuestionImage.SetImageResource(correctVehicles.Image);
            _CGMAnswerA.SetText(shufleTemporaryCollection.ElementAt(0), TextView.BufferType.Normal);
            _CGMAnswerB.SetText(shufleTemporaryCollection.ElementAt(1), TextView.BufferType.Normal);
            _CGMAnswerC.SetText(shufleTemporaryCollection.ElementAt(2), TextView.BufferType.Normal);
            _CGMAnswerD.SetText(shufleTemporaryCollection.ElementAt(3), TextView.BufferType.Normal);
            #endregion

            #region Перевірка на наявність відповіді в рандомній кнопці. Якщо є то ігнорування, якщо ні то присвоєння відповіді


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
            //        selectedVehicleList.Clear();
            shufleTemporaryCollection.Clear();
        }

        private void FinishGame()
        {
            #region Показ міжсторінкової реклами при фініші

            if (mInterstitialAd.IsLoaded)
            {
                mInterstitialAd.Show();
            }
            else
            {
                BeginSecondActivity();
            }
            #endregion

        }

        private void UpdateHeart()
        {
            if (ChoosedGameModeIndex == 100)
            {
                if (incorrectAnswer == 0)
                {
                    _imageHeart1.SetImageResource(Resource.Drawable._Heart);
                    _imageHeart2.SetImageResource(Resource.Drawable._HeartEmpty);
                    _imageHeart3.SetImageResource(Resource.Drawable._HeartEmpty);
                }
                else
                {
                    _imageHeart1.SetImageResource(Resource.Drawable._HeartEmpty);
                    _imageHeart2.SetImageResource(Resource.Drawable._HeartEmpty);
                    _imageHeart3.SetImageResource(Resource.Drawable._HeartEmpty);
                }
                return;
            }

            if (incorrectAnswer == 2)
            {
                _imageHeart1.SetImageResource(Resource.Drawable._Heart);
                _imageHeart2.SetImageResource(Resource.Drawable._HeartEmpty);
                _imageHeart3.SetImageResource(Resource.Drawable._HeartEmpty);
            }
            else
            if (incorrectAnswer == 1)
            {
                _imageHeart1.SetImageResource(Resource.Drawable._Heart);
                _imageHeart2.SetImageResource(Resource.Drawable._Heart);
                _imageHeart3.SetImageResource(Resource.Drawable._HeartEmpty);
            }
            else
            if (incorrectAnswer == 0)
            {
                _imageHeart1.SetImageResource(Resource.Drawable._Heart);
                _imageHeart2.SetImageResource(Resource.Drawable._Heart);
                _imageHeart3.SetImageResource(Resource.Drawable._Heart);
            }
            else
            {
                _imageHeart1.SetImageResource(Resource.Drawable._HeartEmpty);
                _imageHeart2.SetImageResource(Resource.Drawable._HeartEmpty);
                _imageHeart3.SetImageResource(Resource.Drawable._HeartEmpty);
            }
        }

    }

    #region Міжсторінкова реклама, закриття і виклик методу наступної актівіті
    class AdListener : Android.Gms.Ads.AdListener
    {
        ClassicGameMode that;

        public AdListener(ClassicGameMode t)
        {
            that = t;
        }

        public override void OnAdClosed()
        {
            that.RequestNewInterstitial();
            that.BeginSecondActivity();
        }
    }

    #endregion

}