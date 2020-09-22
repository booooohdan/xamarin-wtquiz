using System;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;

namespace WarThunderQuiz.RecyclerViews
{
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


}