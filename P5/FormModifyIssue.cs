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
    public partial class FormModifyIssue : Form
    {
        int issueToEdit;
        Issue issue;
        private AppUser currentUser;
        FakePreferenceRepository fakePreferenceRepository = new FakePreferenceRepository();
        FakeIssueRepository fakeIssueRepository = new FakeIssueRepository();
        FakeIssueStatusRepository fakeIssueStatusRepository = new FakeIssueStatusRepository();
        public FormModifyIssue(int id)
        {
            InitializeComponent();
            issueToEdit = id;
        }

        private void FormModifyIssue_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            var statuses = fakeIssueStatusRepository.GetAll();
            foreach (IssueStatus status in statuses)
            {
                this.statusDropdown.Items.Add(status.Value);
            }

            issue = fakeIssueRepository.GetIssueById(issueToEdit);
            this.idTextbox.Text = issueToEdit.ToString();
            this.titleTextbox.Text = issue.Title;
            this.discoveryDateDateTimePicker.Value = issue.DiscoveryDate;
            this.discovererTextbox.Text = issue.Discoverer;
            this.componentTextbox.Text = issue.Component;
            this.statusDropdown.SelectedItem = fakeIssueStatusRepository.GetValueById(issue.IssueStatusId);
            this.descriptionTextbox.Text = issue.InitialDescription;
        }

        private void createIssueButton_Click(object sender, EventArgs e)
        {
            var tempIssue = new Issue();
            tempIssue.ProjectId = issue.ProjectId;
            tempIssue.Id = Int32.Parse(this.idTextbox.Text);
            tempIssue.Title = this.titleTextbox.Text;
            tempIssue.DiscoveryDate = this.discoveryDateDateTimePicker.Value;
            tempIssue.Discoverer = this.discovererTextbox.Text;
            tempIssue.Component = this.componentTextbox.Text;
            tempIssue.IssueStatusId = fakeIssueStatusRepository.GetIdByStatus(this.statusDropdown.SelectedItem.ToString());
            tempIssue.InitialDescription = this.descriptionTextbox.Text;

            var result = fakeIssueRepository.Modify(tempIssue);
            if (result != fakeIssueRepository.NO_ERROR )
            {
                MessageBox.Show(result, "Error!");
            }
        }
    }
}
