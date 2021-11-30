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
    public partial class FormCreateFeature : Form
    {
        AppUser currentUser;
        int selectedProjectId;
        FakePreferenceRepository fakePreferenceRepository;
        FakeFeatureRepository fakeFeatureRepository;

        public FormCreateFeature(AppUser _currentUser)
        {
            InitializeComponent();
            currentUser = _currentUser;
        }

        private void FormCreateFeature_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            fakeFeatureRepository = new FakeFeatureRepository();
            fakePreferenceRepository = new FakePreferenceRepository();
            selectedProjectId = Int32.Parse(fakePreferenceRepository.GetPreference(currentUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID));
        }

        private void createFeatureButton_Click(object sender, EventArgs e)
        {
            var featureToAdd = new Feature();
            featureToAdd.ProjectId = selectedProjectId;
            featureToAdd.Title = this.titleTextBox.Text;
            var result = fakeFeatureRepository.Add(featureToAdd);
            if(result == fakeFeatureRepository.NO_ERROR)
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
