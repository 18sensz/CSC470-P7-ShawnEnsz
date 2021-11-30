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
    public partial class FormSelectRequirement : Form
    {
        AppUser currentUser;
        int selectedProjectId;
        FakePreferenceRepository fakePreferenceRepository;
        FakeFeatureRepository fakeFeatureRepository;
        FakeRequirementRepository fakeRequirementRepository;
        public int selectedRequirementId;
        public FormSelectRequirement(AppUser _currentUser)
        {
            InitializeComponent();
            currentUser = _currentUser;
            fakeFeatureRepository = new FakeFeatureRepository();
            fakePreferenceRepository = new FakePreferenceRepository();
            fakeRequirementRepository = new FakeRequirementRepository();
            selectedProjectId = Int32.Parse(fakePreferenceRepository.GetPreference(currentUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID));
        }

        private void FormSelectRequirement_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            var listOfFeats = fakeFeatureRepository.GetAll(selectedProjectId);
            foreach (Feature feature in listOfFeats)
            {
                this.comboBox1.Items.Add(feature.Title);
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                var row = this.dataGridView1.SelectedRows[0];
                selectedRequirementId = (int)row.Cells["Id"].Value;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("A Requirement must be selected.", "Attention");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectButton.Enabled = true;
            this.dataGridView1.DataSource = fakeRequirementRepository.GetAll(selectedProjectId, fakeFeatureRepository.GetFeatureByTitle(selectedProjectId, this.comboBox1.SelectedItem.ToString()).Id);
        }
    }
}
