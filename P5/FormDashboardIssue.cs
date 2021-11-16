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
    public partial class FormDashboardIssue : Form
    {
        int selectedProjectId;
        AppUser currentUser;
        public FormDashboardIssue(AppUser user)
        {
            InitializeComponent();
            //selectedProjectId = id;
            currentUser = user;
        }

        private void FormDashboardIssue_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            FakePreferenceRepository fakePreferenceRepository = new FakePreferenceRepository();
            FakeIssueRepository fakeIssueRepository = new FakeIssueRepository();
            selectedProjectId = Int32.Parse(fakePreferenceRepository.GetPreference(currentUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID));
            this.numOfIssuesDisplayLabel.Text = fakeIssueRepository.GetTotalNumberOfIssues(selectedProjectId).ToString();
            this.issueByMonthListBox.DataSource = fakeIssueRepository.GetIssuesByMonth(selectedProjectId);
            this.issueByDiscovererListBox.DataSource = fakeIssueRepository.GetIssuesByDiscoverer(selectedProjectId);
        }
    }
}
