using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Gms.Common;
using Android.Gms.Common.Apis;
using Android.Graphics;
using Android.OS;
using Android.Preferences;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using GooglePlay.Services.Helpers;
using WarThunderQuiz.GameData;
using static Android.Views.View;
using System.Text;
using Android.Gms.Games;
using Android.Gms.Games.Achievement;
using Android.Gms.Games.LeaderBoard;
using Java.Interop;
using Android.Accounts;
using Android.Gms.Auth.Api.SignIn;
using Android.Util;
using Android.Gms.Ads;
using Android.Gms.Ads.Reward;
using Google.Ads.Mediation.Admob;

namespace WarThunderQuiz
{
    [Activity(Theme = "@style/AppTheme.NoActionBar", ScreenOrientation = ScreenOrientation.Portrait)]

    public class ShowResult : AppCompatActivity, GoogleApiClient.IConnectionCallbacks, GoogleApiClient.IOnConnectionFailedListener, IRewardedVideoAdListener
    {
        #region Оголошення змінних реклами
        Context context;
        protected AdView mAdView;
        public Button SRDoublePointsButton { get; set; } //rewardvideo
        public IRewardedVideoAd SRRewardedVideoAd { get; set; } //rewardvideo
        Button SRDoublePointsButtonClick;
        #endregion

        Button _SRNextLevelButton, _SRMainMenuButton;
        TextView _SRLevelNumberTextView, _SRCompletedTextView, _SRBattleNameTextView, _SRScoreEarnedTextView, _SRTotalScoreTextView;
        GameHelper helper;
        int SRLevelNumber, SRTotalScore, points, GlobalPoints;
        string SRBattleName;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ShowResult);
            context = ApplicationContext;

            #region Admob відео нагорода ініціалізація
            SRRewardedVideoAd = MobileAds.GetRewardedVideoAdInstance(this);
            SRRewardedVideoAd.RewardedVideoAdListener = this;
            LoadRewardedVideoAd();
            #endregion

            #region Отримання даних з попереднього актівіті

            SRLevelNumber = Intent.GetIntExtra("SRLevelNumber", 1);
            SRTotalScore = Intent.GetIntExtra("SRTotalScore", 0);
            SRBattleName = Intent.GetStringExtra("SRBattleName");
            points = Intent.GetIntExtra("SRPoints", 0);

            #endregion

            #region SharedPreferences

            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(context);
            ISharedPreferencesEditor editor = prefs.Edit();

            GlobalPoints = prefs.GetInt("SavedTotalPoints", 0);
            GlobalPoints = GlobalPoints + points;
            editor.PutInt("SavedTotalPoints", GlobalPoints);

            editor.Apply();
            #endregion

            #region Прив'язка TextView

            _SRLevelNumberTextView = FindViewById<TextView>(Resource.Id.SRLevelNumberTextView);
            _SRCompletedTextView = FindViewById<TextView>(Resource.Id.SRCompletedTextView);
            _SRBattleNameTextView = FindViewById<TextView>(Resource.Id.SRBattleNameTextView);
            _SRScoreEarnedTextView = FindViewById<TextView>(Resource.Id.SRScoreEarnedTextView);
            _SRTotalScoreTextView = FindViewById<TextView>(Resource.Id.SRTotalScoreTextView);

            _SRMainMenuButton = FindViewById<Button>(Resource.Id.SRMainMenuButton);
            _SRNextLevelButton = FindViewById<Button>(Resource.Id.SRNextLevelButton);
            SRDoublePointsButtonClick= FindViewById<Button>(Resource.Id.SRDoublePointsButton);

            _SRLevelNumberTextView.SetText(SRLevelNumber.ToString(), TextView.BufferType.Normal);
            _SRTotalScoreTextView.SetText(SRTotalScore.ToString(), TextView.BufferType.Normal);
            _SRBattleNameTextView.SetText(SRBattleName, TextView.BufferType.Normal);
            SetLabelDependingPoints();
            #endregion

            #region Оголошення подій
            _SRNextLevelButton.Click += _SRNextLevelButton_Click;
            _SRMainMenuButton.Click += _SRMainMenuButton_Click;
            SRDoublePointsButtonClick.Click += SRDoublePointsButton_Click;
            #endregion



            InitializeServices();
            if (SRLevelNumber == 100)
            {
                _SRNextLevelButton.Visibility = Android.Views.ViewStates.Gone;
            }
    //        SRDoublePointsButtonClick.Enabled = false;
            SRDoublePointsButtonClick.SetText("Loading ...", TextView.BufferType.Normal);
            }

        private void SetLabelDependingPoints()
        {
            _SRScoreEarnedTextView.SetText(points.ToString(), TextView.BufferType.Normal);

            if (points >= SRTotalScore - 1)
            {
                _SRCompletedTextView.SetText(" completed", TextView.BufferType.Normal);
                _SRNextLevelButton.SetText("Next Level", TextView.BufferType.Normal);
            }
            else
            {
                _SRCompletedTextView.SetText(" failed", TextView.BufferType.Normal);
                _SRNextLevelButton.SetText("Retry", TextView.BufferType.Normal);
            }
        }

        #region Google Games
        void InitializeServices()
        {
            // Setup Google Play Services Helper
            helper = new GameHelper(this);
            // Set Gravity and View for Popups
            helper.GravityForPopups = (GravityFlags.Bottom | GravityFlags.Center);
            helper.ViewForPopups = FindViewById<View>(Resource.Id.container);
            // Hook up events
            helper.OnSignedIn += (object sender, EventArgs e) =>
            {
                //          signInLayout.Visibility = ViewStates.Gone;
                //       controlsLayout.Visibility = ViewStates.Visible;
            };
            helper.OnSignInFailed += (object sender, EventArgs e) =>
            {
                //             signInLayout.Visibility = ViewStates.Visible;
                //          controlsLayout.Visibility = ViewStates.Gone;
            };

            helper.Initialize();
        }

        protected override void OnStart()
        {
            base.OnStart();
            if (helper != null)
                helper.Start();
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            if (helper != null)
                helper.OnActivityResult(requestCode, resultCode, data);
            base.OnActivityResult(requestCode, resultCode, data);
        }

        protected override void OnStop()
        {
            if (helper != null)
                helper.Stop();
            base.OnStop();
        }

        public void OnConnectionFailed(ConnectionResult result)
        {
            ((GoogleApiClient.IOnConnectionFailedListener)helper).OnConnectionFailed(result);
        }

        public void OnConnected(Bundle connectionHint)
        {
            ((GoogleApiClient.IConnectionCallbacks)helper).OnConnected(connectionHint);
        }

        public void OnConnectionSuspended(int cause)
        {
            ((GoogleApiClient.IConnectionCallbacks)helper).OnConnectionSuspended(cause);
        }
        #endregion

        private void _SRNextLevelButton_Click(object sender, EventArgs e)
        {
            SetScore();
            GetAchievement();
            Intent intent = new Intent(this, typeof(ChooseVehicle));
            StartActivity(intent);
            Finish();
        }

        private void _SRMainMenuButton_Click(object sender, EventArgs e)
        {
            SetScore();
            GetAchievement();
            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
            Finish();
        }

        private void SRDoublePointsButton_Click(object sender, EventArgs e)
        {
            ShowRewardedVideo();
        }

        public override void OnBackPressed()
        {
            base.OnBackPressed();
            SetScore();
            GetAchievement();
            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
            Finish();
        }

        #region Відео нагорода, реалізація
        public void LoadRewardedVideoAd()
        {
            SRRewardedVideoAd.LoadAd("ca-app-pub-8211072909515345/5206827518",
             new AdRequest.Builder().Build());
            //SRRewardedVideoAd.LoadAd("ca-app-pub-3940256099942544/5224354917",
            //new AdRequest.Builder().AddTestDevice("D0BE22F1A4BE27C7470F95A699568FE2").Build());
        }

        public void OnRewarded(IRewardItem reward)
        {
            Toast.MakeText(this, string.Format("OnRewarded ! currency: {0} amount: {1}", reward.GetType(), reward.Amount), ToastLength.Short).Show();
            points = points * 2;

            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(context);
            ISharedPreferencesEditor editor = prefs.Edit();
            GlobalPoints = GlobalPoints + points;
            editor.PutInt("SavedTotalPoints", GlobalPoints);
            editor.Apply();

            SetLabelDependingPoints();

            SetScore();
            GetAchievement();
            SRDoublePointsButtonClick.Visibility = Android.Views.ViewStates.Gone;

        }

        public void OnRewardedVideoAdLeftApplication()
        {
            // Toast.MakeText(this, "OnRewardedVideoAdLeftApplication", ToastLength.Short).Show();
        }

        public void OnRewardedVideoAdClosed()
        {
            //  Toast.MakeText(this, "OnRewardedVideoAdClosed", ToastLength.Short).Show();
        }

        public void OnRewardedVideoAdFailedToLoad(int errorCode)
        {
            //   Toast.MakeText(this, "OnRewardedVideoAdFailedToLoad Code error : " + errorCode, ToastLength.Short).Show();
        }

        public void OnRewardedVideoAdLoaded()
        {
            Log.Info("VideoAD: ", "DONEEE");
            SRDoublePointsButtonClick.Enabled = true;
            SRDoublePointsButtonClick.SetText("Double points", TextView.BufferType.Normal);

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
            if (SRRewardedVideoAd.IsLoaded)
            {
                SRRewardedVideoAd.Show();
            }
            else
            {
                Toast.MakeText(this, "Ad not loaded. Check your internet connection", ToastLength.Long).Show();
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
            SRRewardedVideoAd.Pause(this);
            base.OnPause();
            SetScore();
            GetAchievement();
        }

        protected override void OnResume()
        {
            if (mAdView != null)
            {
                mAdView.Resume();
            }
            SRRewardedVideoAd.Resume(this);
            base.OnResume();
        }

        protected override void OnDestroy()
        {
            if (mAdView != null)
            {
                mAdView.Destroy();
            }
            SRRewardedVideoAd.Destroy(this);
            base.OnDestroy();
        }

        #endregion

        #region Запис в LeaderBoards

        private void SetScore()
        {
            if (helper != null && !helper.SignedOut)
            {
                var code = "CgkI-cHtgZAREAIQCg";
                var value = points;
                helper.SubmitScore(code, value);
            }
        }
        private void GetAchievement()
        {

            if (helper != null && !helper.SignedOut)
            {
                //if(choosedGameModeIndex==3 & points==500)
                //helper.UnlockAchievement("CgkI-cHtgZAREAIQAg");

            }
        }
        #endregion
    }
}