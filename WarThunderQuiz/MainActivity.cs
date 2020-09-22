using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Gms.Common.Apis;
using Android.Gms.Common;
using GooglePlay.Services.Helpers;
using Android.Preferences;
using AndroidX.AppCompat.App;

namespace WarThunderQuiz
{
    [Activity(Label = "WT Quiz", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true, Icon = "@drawable/_Icon", ScreenOrientation = ScreenOrientation.Portrait)]
    class MainActivity : AppCompatActivity, GoogleApiClient.IConnectionCallbacks, GoogleApiClient.IOnConnectionFailedListener
    {
        Button _MMClassicModeButton, _MMHardcoreModeButton, _MMEveryDayModeButton;
        ImageButton _MMSettingsButton, _MMPedestalButton, _MMCupButton;
        TextView _MMTotalPointsTextView, _MMNicknameTextView;
        Context context;
        GameHelper helper;
        int STotalPoints;
        string NickName;

        #region AlertDialog
        Button _ButtonOk;
        LayoutInflater layoutInflater;
        View mview;
        Android.App.AlertDialog.Builder alertDialogBuilder;
        Android.App.AlertDialog alertDialogAndroid;
        TextView _TWBLabelTextView;
        TextView _TWBAlertTextView;
        #endregion

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MainMenu);
            context = ApplicationContext;
            InitializeServices();

            #region View Linking
            _MMClassicModeButton = FindViewById<Button>(Resource.Id.MMClassicModeButton);
            _MMHardcoreModeButton = FindViewById<Button>(Resource.Id.MMHardcoreModeButton);
            _MMEveryDayModeButton = FindViewById<Button>(Resource.Id.MMEveryDayModeButton);
            _MMSettingsButton = FindViewById<ImageButton>(Resource.Id.MMSettingsButton);
            _MMPedestalButton = FindViewById<ImageButton>(Resource.Id.MMPedestalButton);
            _MMCupButton = FindViewById<ImageButton>(Resource.Id.MMCupButton);
            _MMTotalPointsTextView = FindViewById<TextView>(Resource.Id.MMTotalPoint);
            _MMNicknameTextView = FindViewById<TextView>(Resource.Id.MMProfineName);

            #endregion

            #region SharedPreference
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(context);
            ISharedPreferencesEditor editor = prefs.Edit();

            STotalPoints = prefs.GetInt("SavedTotalPoints", 0);
            NickName = prefs.GetString("nickname", context.Resources.GetString(Resource.String.notLogged));

            #endregion

            #region Set TextView value from SharedPreference
            _MMNicknameTextView.SetText(NickName, TextView.BufferType.Normal);
            _MMTotalPointsTextView.SetText(STotalPoints.ToString(), TextView.BufferType.Normal);

            #endregion

            #region Events listener
            _MMClassicModeButton.Click += _MMClassicModeButton_Click;
            _MMHardcoreModeButton.Click += _MMHardcoreModeButton_Click;
            _MMEveryDayModeButton.Click += _MMEveryDayModeButton_Click;
            _MMSettingsButton.Click += _MMSettingsButton_Click;
            _MMPedestalButton.Click += _MMPedestalButton_Click;
            _MMCupButton.Click += _MMCupButton_Click;

            #endregion
        }

        private void _MMClassicModeButton_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ChooseVehicle));
            intent.PutExtra("IndexOfGameMode", 1);
            StartActivity(intent);
            Finish();
        }

        private void _MMHardcoreModeButton_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ClassicGameMode));
            intent.PutExtra("ChoosedGameMode", 100);
            intent.PutExtra("ChoosedTotalScore", 100);
            intent.PutExtra("ChoosedGameModeLabel", "Hardcore");
            intent.PutExtra("ChoosedLevelScoreEarned", 0);
            StartActivity(intent);
            Finish();
        }

        private void _MMEveryDayModeButton_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ChooseVehicle));
            intent.PutExtra("IndexOfGameMode", 2);
            StartActivity(intent);
            Finish();
        }

        private void _MMSettingsButton_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Settings));
            StartActivity(intent);
        }

        private void _MMPedestalButton_Click(object sender, EventArgs e)
        {
            if (helper != null && !helper.SignedOut)
            {
                helper.ShowAllLeaderBoardsIntent();
            }
            else
            {
                layoutInflater = LayoutInflater.From(this);
                mview = layoutInflater.Inflate(Resource.Layout._alertDialogTextWithButton, null);
                alertDialogBuilder = new Android.App.AlertDialog.Builder(this);
                alertDialogBuilder.SetView(mview);
                alertDialogAndroid = alertDialogBuilder.Create();
                alertDialogAndroid.Window.SetBackgroundDrawableResource(Resource.Color.mtrl_btn_transparent_bg_color);
                _TWBLabelTextView = mview.FindViewById<TextView>(Resource.Id.TWBLabelTextView);
                _TWBAlertTextView = mview.FindViewById<TextView>(Resource.Id.TWBAlertTextView);
                _ButtonOk = mview.FindViewById<Button>(Resource.Id.TWBButton);
                _TWBLabelTextView.SetText(context.Resources.GetString(Resource.String.notSign), TextView.BufferType.Normal);
                _TWBAlertTextView.SetText(context.Resources.GetString(Resource.String.sign), TextView.BufferType.Normal);
                _ButtonOk.SetText("Ok", TextView.BufferType.Normal);
                alertDialogAndroid.Show();
                _ButtonOk.Click += _ButtonOk_Click;
            }
        }

        private void _MMCupButton_Click(object sender, EventArgs e)
        {
            if (helper != null && !helper.SignedOut)
            {
                helper.ShowAchievements();
            }
            else
            {
                layoutInflater = LayoutInflater.From(this);
                mview = layoutInflater.Inflate(Resource.Layout._alertDialogTextWithButton, null);
                alertDialogBuilder = new Android.App.AlertDialog.Builder(this);
                alertDialogBuilder.SetView(mview);
                alertDialogAndroid = alertDialogBuilder.Create();
                alertDialogAndroid.Window.SetBackgroundDrawableResource(Resource.Color.mtrl_btn_transparent_bg_color);
                _TWBLabelTextView = mview.FindViewById<TextView>(Resource.Id.TWBLabelTextView);
                _TWBAlertTextView = mview.FindViewById<TextView>(Resource.Id.TWBAlertTextView);
                _ButtonOk = mview.FindViewById<Button>(Resource.Id.TWBButton);
                _TWBLabelTextView.SetText(context.Resources.GetString(Resource.String.notSign), TextView.BufferType.Normal);
                _TWBAlertTextView.SetText(context.Resources.GetString(Resource.String.sign), TextView.BufferType.Normal);
                _ButtonOk.SetText("Ok", TextView.BufferType.Normal);
                alertDialogAndroid.Show();
                _ButtonOk.Click += _ButtonOk_Click;
            }
        }

        private void _ButtonOk_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Settings));
            StartActivity(intent);
            alertDialogAndroid.Dismiss();
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
    }
}