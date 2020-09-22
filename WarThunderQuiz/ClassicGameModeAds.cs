using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
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
    public partial class ClassicGameMode
    {
        private void AdMobInitialization()
        {
            mInterstitialAd = new InterstitialAd(this);
            mInterstitialAd.AdUnitId = "ca-app-pub-8211072909515345/1856723600";
            mInterstitialAd.AdListener = new AdListener(this);

            RewardedVideoAd = MobileAds.GetRewardedVideoAdInstance(this);
            RewardedVideoAd.RewardedVideoAdListener = this;
            LoadRewardedVideoAd();
        }

        public void RequestNewInterstitial()
        {
            var adRequest = new AdRequest.Builder().Build();
            mInterstitialAd.LoadAd(adRequest);
        }

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

        private void _RewardButtonYes_Click(object sender, EventArgs e)
        {
            source.Cancel();
            alertDialogAndroidVideo.Dismiss();
            ShowRewardedVideo();
        }

        private void TimerElapsed()
        {
            alertDialogAndroidVideo.Dismiss();
            FinishGameAndShowAds();
        }

        private void FinishGameAndShowAds()
        {

            if (mInterstitialAd.IsLoaded)
            {
                mInterstitialAd.Show();
            }
            else
            {
                BeginSecondActivity();
            }

        }
      
        public void BeginSecondActivity()
        {
            LevelDataForUnlocked();
            Intent intent = new Intent(this, typeof(ShowResult));
            SetndDataToShowRelustActivity(intent);
            StartActivity(intent);
            Finish();
        }

        #region VideoRewardRealization
        public void LoadRewardedVideoAd()
        {
            RewardedVideoAd.LoadAd("ca-app-pub-8211072909515345/2330386383",
             new AdRequest.Builder().Build());
            //RewardedVideoAd.LoadAd("ca-app-pub-3940256099942544/5224354917",
            //new AdRequest.Builder().AddTestDevice("FE5692B3DAD1B4CE3BE3BDA2FF4B6103").Build());
        }

        public void OnRewarded(IRewardItem reward)
        {
            incorrectAnswer = incorrectAnswer - 1;
            ShowQuestion();
            UpdateHeart();
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
            Log.Info("VideoAD: ", "DONE----------------EE");
        }

        public void OnRewardedVideoAdOpened()
        {
        }

        public void OnRewardedVideoStarted()
        {
        }

        public void OnRewardedVideoCompleted()
        {
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
                FinishGameAndShowAds();
            }
        }

        #endregion


    }
}