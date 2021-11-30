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
    public partial class FormModifyFeature : Form
    {
        AppUser currentUser;
        int selectedProjectId;
        int selectedFeatureId;
        FakePreferenceRepository fakePreferenceRepository;
        FakeFeatureRepository fakeFeatureRepository;
        public FormModifyFeature(AppUser _currentUser, int _selectedFeatureId)
        {
            InitializeComponent();
            currentUser = _currentUser;
            selectedFeatureId = _selectedFeatureId;
        }

        private void FormModifyFeature_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            fakeFeatureRepository = new FakeFeatureRepository();
            fakePreferenceRepository = new FakePreferenceRepository();
            selectedProjectId = Int32.Parse(fakePreferenceRepository.GetPreference(currentUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID));
            this.titleTextBox.Text = this.fakeFeatureRepository.GetFeatureById(selectedProjectId, selectedFeatureId).Title;
        }

        private void modifyFeatureButton_Click(object sender, EventArgs e)
        {
            //Feature mod = new Feature();
            var featureToModify = this.fakeFeatureRepository.GetFeatureById(selectedProjectId, selectedFeatureId);
            featureToModify.Title = this.titleTextBox.Text;
            var result = this.fakeFeatureRepository.Modify(featureToModify);
            if (result == fakeFeatureRepository.NO_ERROR)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(result, "ERROR!");
            }
        }

    }
}
