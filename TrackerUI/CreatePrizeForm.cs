﻿using System;
using System.Windows.Forms;
using TrackerLib;
using TrackerLib.DataAccess;
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
                PrizeModel prize = new PrizeModel
                {
                    PlaceName = lbl_PlaceName.Text,
                    PlaceNumber = int.Parse(lbl_PlaceNumber.Text),
                    PrizeAmount = decimal.Parse(lbl_PlaceNumber.Text),
                    PrizePercentage = double.Parse(lbl_PlaceNumber.Text),
                };

                DataConfig config = new DataConfig(AgentType.Sql);
                config.Agent.CreatePrize(prize);
                //TODO case when data passed to db and a blank option to create second prize
            }
            else
            {
                MessageBox.Show("Information you provided is invalid, please try again", "Warning");
            }
        }

        private bool ValidateForm()
        {
            bool validPlaceNumber = int.TryParse(
                lbl_PlaceNumber.Text, out int placeNumber);
            
            bool validPrizeAmount = decimal.TryParse(
                lbl_PrizeAmount.Text, out decimal prizeAmount);

            bool validPrizePercentage = double.TryParse(
                lbl_PrizePercentage.Text, out double prizePercentage);

            string placeName = lbl_PlaceName.Text;

            if (validPlaceNumber && validPrizeAmount && validPrizePercentage)
            {
                if (placeNumber > 0 && placeName.Length > 0
                    && prizeAmount > 0 && prizePercentage > 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
