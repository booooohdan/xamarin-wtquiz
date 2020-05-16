using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Support.V7.Widget;
using Android.Views;
using WarThunderQuiz.GameData;

namespace WarThunderQuiz.RecyclerViews
{
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