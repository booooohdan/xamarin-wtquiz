using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Gms.Common;
using Android.Gms.Common.Apis;
using Android.OS;
using Android.Preferences;
using Android.Views;
using Android.Widget;
using GooglePlay.Services.Helpers;
using Android.Util;
using Android.Gms.Ads;
using Android.Gms.Ads.Reward;
using System.Collections.Generic;
using AndroidX.AppCompat.App;

namespace WarThunderQuiz
{
    [Activity(Theme = "@style/AppTheme.NoActionBar", ScreenOrientation = ScreenOrientation.Portrait)]
    public class ShowResult : AppCompatActivity, GoogleApiClient.IConnectionCallbacks, GoogleApiClient.IOnConnectionFailedListener, IRewardedVideoAdListener
    {
        Context context;
        protected AdView mAdView;
        public IRewardedVideoAd SRRewardedVideoAd { get; set; }
        Button SRDoublePointsButtonClick, _SRNextLevelButton, _SRMainMenuButton;
        TextView _SRLevelNumberTextView, _SRCompletedTextView, _SRBattleNameTextView, _SRScoreEarnedTextView, _SRTotalScoreTextView;
        GameHelper helper;
        int SRLevelNumber, SRTotalScore, points, GlobalPoints;
        string SRBattleName;
        Android.App.AlertDialog alertDialogAndroid;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ShowResult);
            context = ApplicationContext;

            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(context);
            ISharedPreferencesEditor editor = prefs.Edit();

            _SRLevelNumberTextView = FindViewById<TextView>(Resource.Id.SRLevelNumberTextView);
            _SRCompletedTextView = FindViewById<TextView>(Resource.Id.SRCompletedTextView);
            _SRBattleNameTextView = FindViewById<TextView>(Resource.Id.SRBattleNameTextView);
            _SRScoreEarnedTextView = FindViewById<TextView>(Resource.Id.SRScoreEarnedTextView);
            _SRTotalScoreTextView = FindViewById<TextView>(Resource.Id.SRTotalScoreTextView);
            _SRMainMenuButton = FindViewById<Button>(Resource.Id.SRMainMenuButton);
            _SRNextLevelButton = FindViewById<Button>(Resource.Id.SRNextLevelButton);
            SRDoublePointsButtonClick = FindViewById<Button>(Resource.Id.SRDoublePointsButton);

            RewardVideoAdInitial();
            GetDataFropPrevActivityViaSharedPreferences();
            SetGamePointsToPreferedShares(prefs, editor);
            SetLabelDependingPoints();
            InitializeServices();
            RateApp();

            _SRBattleNameTextView.SetText(SRBattleName, TextView.BufferType.Normal);
            _SRLevelNumberTextView.SetText(SRLevelNumber.ToString(), TextView.BufferType.Normal);
            _SRTotalScoreTextView.SetText(SRTotalScore.ToString(), TextView.BufferType.Normal);

            _SRNextLevelButton.Click += _SRNextLevelButton_Click;
            _SRMainMenuButton.Click += _SRMainMenuButton_Click;
            SRDoublePointsButtonClick.Click += SRDoublePointsButton_Click;
        }

        private void RateApp()
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(context);
            ISharedPreferencesEditor editor = prefs.Edit();

            var showRateAlert = prefs.GetInt("rateAlert", 1);
            showRateAlert++;
            editor.PutInt("rateAlert", showRateAlert);
            editor.Apply();

            if (showRateAlert == 7 || showRateAlert == 15)
                CallAlert();
        }

        private void CallAlert()
        {
            var layoutInflater = LayoutInflater.From(this);
            var mview = layoutInflater.Inflate(Resource.Layout._alertRateAppDialog, null);
            var alertDialogBuilder = new Android.App.AlertDialog.Builder(this);
            alertDialogBuilder.SetView(mview);
            alertDialogAndroid = alertDialogBuilder.Create();
            alertDialogAndroid.Show();
            alertDialogAndroid.SetCanceledOnTouchOutside(false);
            alertDialogAndroid.SetCancelable(false);
            var rateButtonYes = mview.FindViewById<Button>(Resource.Id.buttonYes);
            var rateButtonNo = mview.FindViewById<Button>(Resource.Id.buttonNo);
            rateButtonNo.Click += (s, e) => alertDialogAndroid.Dismiss();
            rateButtonYes.Click += RateButtonYes_Click;
        }

        private void RateButtonYes_Click(object sender, EventArgs e)
        {
            alertDialogAndroid.Dismiss();
            StartActivity(new Intent(Intent.ActionView, Android.Net.Uri
                .Parse("https://play.google.com/store/apps/details?id=com.wave.wtquiz")));
        }


        private void SetGamePointsToPreferedShares(ISharedPreferences prefs, ISharedPreferencesEditor editor)
        {
            GlobalPoints = prefs.GetInt("SavedTotalPoints", 0);
            GlobalPoints = GlobalPoints + points;
            editor.PutInt("SavedTotalPoints", GlobalPoints);
            editor.Apply();
        }

        private void GetDataFropPrevActivityViaSharedPreferences()
        {
            SRLevelNumber = Intent.GetIntExtra("SRLevelNumber", 1);
            SRTotalScore = Intent.GetIntExtra("SRTotalScore", 0);
            SRBattleName = Intent.GetStringExtra("SRBattleName");
            points = Intent.GetIntExtra("SRPoints", 0);
        }

        private void SetLabelDependingPoints()
        {
            _SRScoreEarnedTextView.SetText(points.ToString(), TextView.BufferType.Normal);

            if (points >= SRTotalScore - 1)
            {
                _SRCompletedTextView.SetText(context.Resources.GetString(Resource.String.completed), TextView.BufferType.Normal);
                _SRNextLevelButton.SetText(context.Resources.GetString(Resource.String.nextLevel), TextView.BufferType.Normal);
            }
            else
            {
                _SRCompletedTextView.SetText(context.Resources.GetString(Resource.String.failed), TextView.BufferType.Normal);
                _SRNextLevelButton.SetText(context.Resources.GetString(Resource.String.retry), TextView.BufferType.Normal);
            }

            var leveIds = new List<int>() { 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113 };
            if (leveIds.Contains(SRLevelNumber))
            {
                _SRNextLevelButton.Visibility = Android.Views.ViewStates.Gone;
            }
        }

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
            SRDoublePointsButtonClick.Visibility = Android.Views.ViewStates.Gone;
        }


        #region RewardedVideoRealization

        private void RewardVideoAdInitial()
        {
            SRRewardedVideoAd = MobileAds.GetRewardedVideoAdInstance(this);
            SRRewardedVideoAd.RewardedVideoAdListener = this;
            LoadRewardedVideoAd();
        }

        public void LoadRewardedVideoAd()
        {
            SRRewardedVideoAd.LoadAd("ca-app-pub-8211072909515345/5206827518",
             new AdRequest.Builder().Build());
            //SRRewardedVideoAd.LoadAd("ca-app-pub-3940256099942544/5224354917",
            //new AdRequest.Builder().AddTestDevice("46CCAB8BBCE5B5FFA79C22BEB98029AC").Build());
        }

        public void OnRewarded(IRewardItem reward)
        {
            points = points * 2;
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(context);
            ISharedPreferencesEditor editor = prefs.Edit();
            SetGamePointsToPreferedShares(prefs, editor);
            SetLabelDependingPoints();
            SetScore();
            GetAchievement();
            SRDoublePointsButtonClick.Visibility = Android.Views.ViewStates.Gone;
        }

        public void OnRewardedVideoAdLeftApplication()
        {
        }

        public void OnRewardedVideoAdClosed()
        {
            LoadRewardedVideoAd();
        }

        public void OnRewardedVideoAdFailedToLoad(int errorCode)
        {
        }

        public void OnRewardedVideoAdLoaded()
        {
            Log.Info("VideoAD: ", "Ads Loaded!!!");
        }

        public void OnRewardedVideoAdOpened()
        {
        }

        public void OnRewardedVideoStarted()
        {
        }

        public void OnRewardedVideoCompleted()
        {
            Toast.MakeText(this, "OnRewardedVideoCompleted", ToastLength.Short).Show();
        }

        public async void ShowRewardedVideo()
        {
            if (SRRewardedVideoAd.IsLoaded)
            {
                SRRewardedVideoAd.Show();
                await System.Threading.Tasks.Task.Delay(5000);
                points = points * 2;
                SetLabelDependingPoints();
                SetScore();
            }
            else
            {
                Toast.MakeText(this, "Ad not loaded. Check your internet connection", ToastLength.Long).Show();
            }
        }

        #endregion

        #region Overriding OnPause, OnResume, OnDestroy, etc

        public override void OnBackPressed()
        {
            base.OnBackPressed();
            SetScore();
            GetAchievement();
            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
            Finish();
        }

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
                var value = points * 10;
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
    }
}