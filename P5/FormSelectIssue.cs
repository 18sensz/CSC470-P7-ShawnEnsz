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
    public partial class FormSelectIssue : Form
    {
        AppUser currentUser;
        int selectedProjectId;
        public int selectedIssueId = -1;
        FakeIssueRepository fakeIssueRepository;
        FakePreferenceRepository fakePreferenceRepository;
        public FormSelectIssue(AppUser user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void FormSelectIssue_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            fakePreferenceRepository = new FakePreferenceRepository();
            fakeIssueRepository = new FakeIssueRepository();
            selectedProjectId = Int32.Parse(fakePreferenceRepository.GetPreference(currentUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID));

            List<Issue> Issues = new List<Issue>();
            Issues = fakeIssueRepository.GetAll(selectedProjectId);
            
            this.dataGridView1.DataSource = Issues;
        }

        private void selectIssueButton_Click(object sender, EventArgs e)
        {
            if(this.dataGridView1.SelectedRows.Count > 0)
            {
                var row = this.dataGridView1.SelectedRows[0];
                selectedIssueId = (int)row.Cells["Id"].Value;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("A Issue must be selected.", "Attention");
            }
        }
    }
}
