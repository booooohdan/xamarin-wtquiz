using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using WarThunderQuiz.GameData;
using WarThunderQuiz.RecyclerViews;

namespace WarThunderQuiz
{
    [Activity(Theme = "@style/AppTheme.NoActionBar", ScreenOrientation = ScreenOrientation.Portrait)]
    class ChooseVehicle: AppCompatActivity
    {
        Context context;
        RecyclerView recyclerView;
        RecyclerViewAdapter recyclerAdapter;
        RecyclerView.LayoutManager recyclerLayoutManager;
        List<Level> levels = new List<Level>();

        #region AlertDialog
        Button _ButtonOk;
        LayoutInflater layoutInflater;
        View mview;
        Android.App.AlertDialog.Builder alertDialogBuilder;
        Android.App.AlertDialog alertDialogAndroid;
        TextView _TWBLabelTextView, _TWBAlertTextView;
        #endregion

        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ChooseVehicleMenu);
            context = Application.Context;

            if (Intent.GetIntExtra("IndexOfGameMode", 1) == 1)
            {
                levels = LevelCollection.GetLevels();
            }
            else
            {
                levels = LevelCollection.GetTrainingLevels();
            }

            RecyclerInitializer();
        }


        private void _ButtonOk_Click(object sender, EventArgs e)
        {
            alertDialogAndroid.Dismiss();
        }

        private void OnItemClick(object sender, int position)
        {
            if (levels[position].LevelUnlocked)
            {
                var intent = new Intent(this, typeof(ClassicGameMode));
                SendDataToNextActivityViaSharedPreferences(position, intent);
                StartActivity(intent);
            }
            else
            {
                AlertButtonInitializer();

                alertDialogAndroid.Show();
                _ButtonOk.Click += _ButtonOk_Click; ;
            }
        }

        private void RecyclerInitializer()
        {
            recyclerView = FindViewById<RecyclerView>(Resource.Id.LevelsRecyclerView);
            recyclerView.HasFixedSize = true;
            recyclerLayoutManager = new LinearLayoutManager(this);
            recyclerView.SetLayoutManager(recyclerLayoutManager);
            recyclerAdapter = new RecyclerViewAdapter(levels);
            recyclerView.SetAdapter(recyclerAdapter);
            recyclerAdapter.ItemClick += OnItemClick;
        }

        private void AlertButtonInitializer()
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
            _TWBLabelTextView.SetText("Battle is locked", TextView.BufferType.Normal);
            _TWBAlertTextView.SetText("You need to finish previous batle", TextView.BufferType.Normal);
            _ButtonOk.SetText("Ok", TextView.BufferType.Normal);
        }

        private void SendDataToNextActivityViaSharedPreferences(int position, Intent intent)
        {
            intent.PutExtra("ChoosedGameMode", levels[position].Number);
            intent.PutExtra("ChoosedTotalScore", levels[position].LevelTotalScore);
            intent.PutExtra("ChoosedGameModeLabel", levels[position].LevelName);
            intent.PutExtra("ChoosedLevelScoreEarned", levels[position].LevelScoreEarned);
        }
    }
}