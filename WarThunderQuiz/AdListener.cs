namespace WarThunderQuiz
{
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
}