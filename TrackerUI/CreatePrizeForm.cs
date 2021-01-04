using System;
using System.Windows.Forms;
using TrackerLib;
using TrackerLib.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void btn_CreatePrize_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                PrizeModel model = new PrizeModel();

                model.PlaceName = lbl_PlaceName.Text;

                model.PlaceNumber = int.Parse(lbl_PlaceNumber.Text);
                model.PrizeAmount = decimal.Parse(lbl_PlaceNumber.Text);
                model.PrizePercentage = double.Parse(lbl_PlaceNumber.Text);

                GlobalConfig.Connection.CreatePrize(model);

                //TODO case when data passed to db and a blank option to create second prize
            }
            else
            {
                MessageBox.Show("Information you provided is invalid, please try again", "Warning");
            }
        }

        private bool ValidateForm()
        {
            int placeNumber = 0;
            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool validPlaceNumber = int.TryParse(lbl_PlaceNumber.Text, out placeNumber);
            bool validPrizeAmount = decimal.TryParse(lbl_PrizeAmount.Text, out prizeAmount);
            bool validPrizePercentage = double.TryParse(lbl_PrizePercentage.Text, out prizePercentage);

            string placeName = string.Empty;
            placeName = lbl_PlaceName.Text;

            if (validPlaceNumber && validPrizeAmount && validPrizePercentage)
            {
                if (placeNumber > 0 && placeName.Length > 0 && prizeAmount > 0 && prizePercentage > 0)
                {
                    return true;
                } 
            }

            return false;
        }
    }
}
