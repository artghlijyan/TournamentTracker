using System.Windows.Forms;
using TrackerLib;
using TrackerLib.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void btn_CreateMember_Click(object sender, System.EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show("All Fields must be filled");
            }

            var personModel = new PersonModel
            {
                FirstName = lb_FirstName.Text,
                LastName = lb_FirstName.Text,
                EmailAddress = lbl_Email.Text,
                Mobile = lbl_Cellphone.Text,
            };

            DataConfig.Agent.CreatePerson(personModel);
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(lb_FirstName.Text)
                || string.IsNullOrWhiteSpace(lb_FirstName.Text)
                || string.IsNullOrWhiteSpace(lbl_Email.Text)
                || string.IsNullOrWhiteSpace(lbl_Cellphone.Text))
            {
                return false;
            }

            return true;
        }
    }
}
