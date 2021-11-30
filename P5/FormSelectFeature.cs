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
    public partial class FormSelectFeature : Form
    {
        AppUser currentUser;
        int selectedProjectId;
        FakePreferenceRepository fakePreferenceRepository;
        FakeFeatureRepository fakeFeatureRepository;
        public int selectedFeatureId;
        public FormSelectFeature(AppUser _currentUser)
        {
            InitializeComponent();
            currentUser = _currentUser;
        }

        private void FormSelectFeature_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            fakeFeatureRepository = new FakeFeatureRepository();
            fakePreferenceRepository = new FakePreferenceRepository();
            selectedProjectId = Int32.Parse(fakePreferenceRepository.GetPreference(currentUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID));
            var features = this.fakeFeatureRepository.GetAll(selectedProjectId);
            this.dataGridView1.DataSource = features;
        }

        private void selectFeatureButton_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                var row = this.dataGridView1.SelectedRows[0];
                selectedFeatureId = (int)row.Cells["Id"].Value;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("A Feature must be selected.", "Attention");
            }
        }
    }
}
