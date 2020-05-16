using System;
using Android;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Gms.Common;
using Android.Gms.Common.Apis;
using Android.OS;
using Android.Preferences;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using GooglePlay.Services.Helpers;

namespace WarThunderQuiz
{
    [Activity(Theme = "@style/AppTheme.NoActionBar", ScreenOrientation = ScreenOrientation.Portrait)]
    class Settings : AppCompatActivity, GoogleApiClient.IConnectionCallbacks, GoogleApiClient.IOnConnectionFailedListener
    {
        Context context;
        SignInButton signInButton;
        Button signOutButton, ButtonReddit, ButtonEmail;
        RatingBar RatingBar;
        GameHelper helper;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Settings);
            context = ApplicationContext;

            #region View Linking
            signInButton = FindViewById<SignInButton>(Resource.Id.signInButton);
            signOutButton = FindViewById<Button>(Resource.Id.signOutButton);
            ButtonReddit = FindViewById<Button>(Resource.Id.buttonReddit);
            ButtonEmail = FindViewById<Button>(Resource.Id.buttonEMail);
            RatingBar = FindViewById<RatingBar>(Resource.Id.ratingBar);

            #endregion

            #region Events listener
            signInButton.Click += SignInButton_Click;
            signOutButton.Click += SignOutButton_Click;
            ButtonReddit.Click += ButtonReddit_Click;
            ButtonEmail.Click += ButtonEmail_Click;
            RatingBar.RatingBarChange += RatingBar_RatingBarChange;

            #endregion

            InitializeServices();
        }

        private void ButtonReddit_Click(object sender, EventArgs e)
        {
            var uri = Android.Net.Uri.Parse("https://www.reddit.com/r/wave_app/");
            var intent = new Intent(Intent.ActionView, uri);
            StartActivity(intent);
        }

        private void ButtonEmail_Click(object sender, EventArgs e)
        {
            var EditTo = "waveappfeedback@gmail.com";
            var EditSubject = "WT Quiz Feedback";
            var EditMessage = "";

            Intent email = new Intent(Intent.ActionSend);
            email.PutExtra(Intent.ExtraEmail, new string[] { EditTo.ToString() });
            email.PutExtra(Intent.ExtraSubject, new string[] { EditSubject.ToString() });
            email.PutExtra(Intent.ExtraText, new string[] { EditMessage.ToString() });
            email.SetType("message/rfc822");
            StartActivity(Intent.CreateChooser(email, "Choose your email client:"));
        }

        private void RatingBar_RatingBarChange(object sender, RatingBar.RatingBarChangeEventArgs e)
        {
            StartActivity(new Intent(Intent.ActionView, Android.Net.Uri.Parse("https://play.google.com/store/apps/details?id=com.wave.wtquiz")));
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (CheckSelfPermission(Manifest.Permission.GetAccounts) == Permission.Granted)
            {
                if (helper != null && helper.SignedOut)
                {
                    helper.SignIn();
                    signInButton.Visibility = ViewStates.Gone;
                    signOutButton.Visibility = ViewStates.Visible;
                }
            }
            else
            {
                RequestPermissions(new String[] { Manifest.Permission.GetAccounts }, 1);
            }
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            if (helper != null && !helper.SignedOut)
            {
                helper.SignOut();
                signInButton.Visibility = ViewStates.Visible;
                signOutButton.Visibility = ViewStates.Gone;
            }
        }
        
        #region GoogleGames

        private void InitializeServices()
        {
            // Setup Google Play Services Helper
            helper = new GameHelper(this);
            // Set Gravity and View for Popups
            helper.GravityForPopups = (GravityFlags.Bottom | GravityFlags.Center);
            helper.ViewForPopups = FindViewById<View>(Resource.Id.SMLinearLayout);
            // Hook up events
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(context);
            ISharedPreferencesEditor editor = prefs.Edit();

            helper.OnSignedIn += (object sender, EventArgs e) =>
            {
                signInButton.Visibility = ViewStates.Gone;
                signOutButton.Visibility = ViewStates.Visible;
                editor.PutBoolean("LoggedInGooglePlay", true);
                editor.Apply();

            };
            helper.OnSignInFailed += (object sender, EventArgs e) =>
            {
                signInButton.Visibility = ViewStates.Visible;
                signOutButton.Visibility = ViewStates.Gone;
                editor.PutBoolean("LoggedInGooglePlay", false);
                editor.Apply();
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
