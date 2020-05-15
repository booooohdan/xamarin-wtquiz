using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Gms.Auth.Api;
using Android.Gms.Auth.Api.SignIn;
using Android.Gms.Common;
using Android.Gms.Common.Apis;
using Android.OS;
using Android.Preferences;
using Android.Runtime;
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
        Button signOutButton, _BackToMenuButtonNo, _BackToMenuButtonYes;
        GameHelper helper;
        LayoutInflater layoutInflater;
        View mview;
        Android.App.AlertDialog.Builder alertDialogBuilder;
        Android.App.AlertDialog alertDialogAndroid;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Settings);
            context = ApplicationContext;

            #region Прив'язкаView
            signInButton = FindViewById<SignInButton>(Resource.Id.signInButton);
            signOutButton = FindViewById<Button>(Resource.Id.signOutButton);

            #endregion

            #region Оголошення подій
            signInButton.Click += SignInButton_Click;
            signOutButton.Click += SignOutButton_Click;

            #endregion

            InitializeServices();
        }

        #region GoogleGames
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
