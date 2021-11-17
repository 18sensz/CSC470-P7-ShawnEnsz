using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5
{
    public partial class FormRecordIssue : Form
    {
        private int selectedProjectId;
        private AppUser currentUser;
        FakePreferenceRepository fakePreferenceRepository = new FakePreferenceRepository();
        FakeIssueRepository fakeIssueRepository = new FakeIssueRepository();
        FakeIssueStatusRepository fakeIssueStatusRepository = new FakeIssueStatusRepository();

        public FormRecordIssue(AppUser user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void FormRecordIssue_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            selectedProjectId = Int32.Parse(fakePreferenceRepository.GetPreference(currentUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID));

            //Set id textbox
            var nextId = fakeIssueRepository.GetTotalNumberOfIssues(selectedProjectId);
            this.idTextbox.Text = (++nextId).ToString();

            var statuses = fakeIssueStatusRepository.GetAll();
            foreach(IssueStatus status in statuses)
            {
                this.statusDropdown.Items.Add(status.Value);
            }
        }

        private void createIssueButton_Click(object sender, EventArgs e)
        {
            Issue issueToCreate = new Issue()
            {
                Id = Int32.Parse(this.idTextbox.Text),
                Title = this.titleTextbox.Text,
                DiscoveryDate = this.discoveryDateDateTimePicker.Value,
                Discoverer = this.discovererTextbox.Text,
                Component = this.componentTextbox.Text,
                IssueStatusId = fakeIssueStatusRepository.GetIdByStatus(this.statusDropdown.SelectedItem.ToString()),
                InitialDescription = this.descriptionTextbox.Text,
                ProjectId = selectedProjectId,
            };

            var result = fakeIssueRepository.Add(issueToCreate);
            if(result == fakeIssueRepository.NO_ERROR)
            {
                //Message box
                MessageBox.Show("Successfully Recorded issue!", "Success!");
            }
            else
            {
                //failed message box
                MessageBox.Show(result, "ERROR!");

            }
        }
    }
}
