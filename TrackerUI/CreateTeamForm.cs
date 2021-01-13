using System.Collections.Generic;
using System.Windows.Forms;
using TrackerLib;
using TrackerLib.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = new List<PersonModel>();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void WireUpLists()
        {
            dd_SelectTeamMember.DataSource = availableTeamMembers;
            dd_SelectTeamMember.DisplayMember = "FullName";
            
            listB_TeamMembers.DataSource = selectedTeamMembers;
            dd_SelectTeamMember.DisplayMember = "FullName";
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
            if (string.IsNullOrWhiteSpace(textB_FirstName.Text)
                || string.IsNullOrWhiteSpace(textB_LastName.Text)
                || string.IsNullOrWhiteSpace(textB_Email.Text)
                || string.IsNullOrWhiteSpace(textB_Mobile.Text))
            {
                return false;
            }

            return true;
        }
    }
}
