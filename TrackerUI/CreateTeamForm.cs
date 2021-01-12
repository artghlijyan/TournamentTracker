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

            var person = new PersonModel
            {
                FirstName = textB_FirstName.Text,
                LastName = textB_LastName.Text,
                EmailAddress = textB_Email.Text,
                Mobile = textB_Mobile.Text,
            };

            DataConfig config = new DataConfig(AgentType.Sql);
            config.Agent.CreatePerson(person);
            //TODO case when data passed to db and a blank option to create second prize
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
