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

            this.issueByMonthListBox.Items.Clear();
            this.issueByDiscovererListBox.Items.Clear();
            var tmp = fakeIssueRepository.GetIssuesByMonth(selectedProjectId);
            foreach (string line in tmp)
            {
                this.issueByMonthListBox.Items.Add(line);
            }
            tmp = fakeIssueRepository.GetIssuesByDiscoverer(selectedProjectId);
            foreach (string line in tmp)
            {
                this.issueByDiscovererListBox.Items.Add(line);
            }
        }
    }
}
