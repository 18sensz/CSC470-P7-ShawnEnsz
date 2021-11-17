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
            var issue = fakeIssueRepository.GetIssueById(issueToEdit);
            this.idTextbox.Text = issueToEdit.ToString();
            this.titleTextbox.Text = issue.Title;
            this.discoveryDateDateTimePicker.Value = issue.DiscoveryDate;
            this.discovererTextbox.Text = issue.Discoverer;
            this.componentTextbox.Text = issue.Component;
            this.statusDropdown.DataSource = fakeIssueStatusRepository.GetAll();
            this.descriptionTextbox.Text = issue.InitialDescription;
        }
    }
}
