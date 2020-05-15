using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Graphics;
using Android.OS;
using Android.Preferences;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using WarThunderQuiz.GameData;

namespace WarThunderQuiz
{
    [Activity(Theme = "@style/AppTheme.NoActionBar", ScreenOrientation = ScreenOrientation.Portrait)]
    class ChooseVehicle: AppCompatActivity
    {
        Context context;
        RecyclerView recyclerView;
        RecyclerViewAdapter recyclerAdapter;
        RecyclerView.LayoutManager recyclerLayoutManager;
        #region AlertDialog
        Button _ButtonOk;
        LayoutInflater layoutInflater;
        View mview;
        Android.App.AlertDialog.Builder alertDialogBuilder;
        Android.App.AlertDialog alertDialogAndroid;
        TextView _TWBLabelTextView;
        TextView _TWBAlertTextView;
        #endregion

        List<Level> levels = new List<Level>();
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ChooseVehicleMenu);
            context = Application.Context;

            levels = LevelCollection.GetLevels();

            recyclerView = FindViewById<RecyclerView>(Resource.Id.LevelsRecyclerView);
            recyclerView.HasFixedSize = true;
            recyclerLayoutManager = new LinearLayoutManager(this);
            recyclerView.SetLayoutManager(recyclerLayoutManager);
            recyclerAdapter = new RecyclerViewAdapter(levels);
            recyclerView.SetAdapter(recyclerAdapter);
            recyclerAdapter.ItemClick += OnItemClick;
 

            void OnItemClick(object sender, int position)
            {
                if (levels[position].LevelUnlocked)
                {
                    var intent = new Intent(this, typeof(ClassicGameMode));
                    intent.PutExtra("ChoosedGameMode", levels[position].Number);
                    intent.PutExtra("ChoosedTotalScore", levels[position].LevelTotalScore);
                    intent.PutExtra("ChoosedGameModeLabel", levels[position].LevelName);
                    intent.PutExtra("ChoosedLevelScoreEarned", levels[position].LevelScoreEarned);


                    StartActivity(intent);
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
                    _TWBLabelTextView.SetText("Battle is locked", TextView.BufferType.Normal);
                    _TWBAlertTextView.SetText("You need to finish previous batle", TextView.BufferType.Normal);
                    _ButtonOk.SetText("Ok", TextView.BufferType.Normal);
                    alertDialogAndroid.Show();
                    _ButtonOk.Click += _ButtonOk_Click; ;
                }
            }
        }

        private void _ButtonOk_Click(object sender, EventArgs e)
        {
            alertDialogAndroid.Dismiss();
        }
    }

    

    public class RecyclerViewHolder : RecyclerView.ViewHolder
    {
        public TextView LevelNameTextView { get; private set; }
        public TextView LevelNumberTextView { get; private set; }
        public TextView LevelScoreTextView { get; private set; }
        public TextView LevelScoreDividerTextView { get; private set; }
        public TextView LevelTotalScoreTextView { get; private set; }

        public RelativeLayout LevelNameLinear { get; set; }

        public ImageView MapImageView { get; private set; }
        public ImageView LeftFlagImageView1 { get; private set; }
        public ImageView LeftFlagImageView2 { get; private set; }
        public ImageView LeftFlagImageView3 { get; private set; }
        public ImageView RightFlagImageView1 { get; private set; }
        public ImageView RightFlagImageView2 { get; private set; }
        public ImageView RightFlagImageView3 { get; private set; }
        public ImageView VehicleTypeImageView1 { get; private set; }
        public ImageView VehicleTypeImageView2 { get; private set; }


        // Get references to the views defined in the CardView layout.
        public RecyclerViewHolder(View itemView, Action<int> listener)
            : base(itemView)
        {
            // Locate and cache view references:
            LevelNameTextView = itemView.FindViewById<TextView>(Resource.Id.levelNameTextView);
            LevelNumberTextView = itemView.FindViewById<TextView>(Resource.Id.levelNumberTextView);
            LevelScoreTextView = itemView.FindViewById<TextView>(Resource.Id.levelScoreTextView);
            LevelScoreDividerTextView = itemView.FindViewById<TextView>(Resource.Id.levelScoreDividerTextView);
            LevelTotalScoreTextView = itemView.FindViewById<TextView>(Resource.Id.levelTotalScoreTextView);

            LevelNameLinear = itemView.FindViewById<RelativeLayout>(Resource.Id.levelNameLinear); 

            MapImageView = itemView.FindViewById<ImageView>(Resource.Id.mapImageView);
            LeftFlagImageView1 = itemView.FindViewById<ImageView>(Resource.Id.leftFlagImageView1);
            LeftFlagImageView2 = itemView.FindViewById<ImageView>(Resource.Id.leftFlagImageView2);
            LeftFlagImageView3 = itemView.FindViewById<ImageView>(Resource.Id.leftFlagImageView3);
            RightFlagImageView1 = itemView.FindViewById<ImageView>(Resource.Id.rightFlagImageView1);
            RightFlagImageView2 = itemView.FindViewById<ImageView>(Resource.Id.rightFlagImageView2);
            RightFlagImageView3 = itemView.FindViewById<ImageView>(Resource.Id.rightFlagImageView3);
            VehicleTypeImageView1 = itemView.FindViewById<ImageView>(Resource.Id.vehicleTypeImageView1);
            VehicleTypeImageView2 = itemView.FindViewById<ImageView>(Resource.Id.vehicleTypeImageView2);

            // Detect user clicks on the item view and report which item
            // was clicked (by layout position) to the listener:
            itemView.Click += (sender, e) => listener(base.LayoutPosition);
        }
    }








    class RecyclerViewAdapter : RecyclerView.Adapter
    {
        public event EventHandler<int> ItemClick;
        private Context context;
        private List<Level> levels = new List<Level>();
        public RecyclerViewAdapter(List<Level> levels)
        {
            this.levels = levels;
        }
        // Return the number of photos available in the photo album:
        public override int ItemCount
        {
            get { return levels.Count; }
        }

        // Fill in the contents of the photo card (invoked by the layout manager):
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            RecyclerViewHolder vh = holder as RecyclerViewHolder;
            context = Application.Context;
            // Set the ImageView and TextView in this ViewHolder's CardView 
            // from this position in the photo album:
            vh.LevelNameTextView.Text = levels[position].LevelName;
            vh.LevelNumberTextView.Text = levels[position].Number.ToString();
            vh.LevelScoreTextView.Text = levels[position].LevelScoreEarned.ToString();
            vh.LevelTotalScoreTextView.Text = levels[position].LevelTotalScore.ToString();

            vh.MapImageView.SetImageResource(levels[position].Map);
            vh.LeftFlagImageView1.SetImageResource(levels[position].LeftFlag1);
            vh.LeftFlagImageView2.SetImageResource(levels[position].LeftFlag2);
            vh.LeftFlagImageView3.SetImageResource(levels[position].LeftFlag3);
            vh.RightFlagImageView1.SetImageResource(levels[position].RightFlag1);
            vh.RightFlagImageView2.SetImageResource(levels[position].RightFlag2);
            vh.RightFlagImageView3.SetImageResource(levels[position].RightFlag3);
            vh.VehicleTypeImageView1.SetImageResource(levels[position].VehicleType1);
            vh.VehicleTypeImageView2.SetImageResource(levels[position].VehicleType2);

            ColorMatrix matrix = new ColorMatrix();
            matrix.SetSaturation(0);
            ColorMatrixColorFilter filter = new ColorMatrixColorFilter(matrix);

            #region BWImage
            if (levels[position].LevelUnlocked)
            {
               //
            }
            else
            {
                vh.MapImageView.SetColorFilter(filter);
                vh.LeftFlagImageView1.SetColorFilter(filter);
                vh.LeftFlagImageView2.SetColorFilter(filter);
                vh.LeftFlagImageView3.SetColorFilter(filter);
                vh.RightFlagImageView1.SetColorFilter(filter);
                vh.RightFlagImageView2.SetColorFilter(filter);
                vh.RightFlagImageView3.SetColorFilter(filter);
                vh.VehicleTypeImageView1.SetColorFilter(filter);
                vh.VehicleTypeImageView2.SetColorFilter(filter);
                vh.LevelNameLinear.SetBackgroundResource(Resource.Drawable._MMTopLevelGray);
                vh.LevelScoreTextView.SetTextColor(Color.Gray);
                vh.LevelTotalScoreTextView.SetTextColor(Color.Gray);
                vh.LevelScoreDividerTextView.SetTextColor(Color.Gray);
            }

            #endregion

        }


        // Create a new photo CardView (invoked by the layout manager): 
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout._levelCardView, parent, false);

            RecyclerViewHolder vh = new RecyclerViewHolder(itemView, OnClick);
            return vh;
        }

        // Raise an event when the item-click takes place:
        void OnClick(int position)
        {
            if (ItemClick != null)
                ItemClick(this, position);
        }
    }


}