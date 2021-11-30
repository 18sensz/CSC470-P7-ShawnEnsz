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
    public partial class FormModifyRequirement : Form
    {
        AppUser currentUser;
        int selectedProjectId;
        FakePreferenceRepository fakePreferenceRepository;
        FakeFeatureRepository fakeFeatureRepository;
        FakeRequirementRepository fakeRequirementRepository;
        Requirement selectedRequirement;
        public FormModifyRequirement(AppUser _currentUser, int selectedRequirementId)
        {
            InitializeComponent();
            currentUser = _currentUser;
            fakeFeatureRepository = new FakeFeatureRepository();
            fakePreferenceRepository = new FakePreferenceRepository();
            fakeRequirementRepository = new FakeRequirementRepository();
            selectedProjectId = Int32.Parse(fakePreferenceRepository.GetPreference(currentUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID));
            selectedRequirement = fakeRequirementRepository.GetRequirementById(selectedProjectId , selectedRequirementId);
        }

        private void FormModifyRequirement_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            var listOfFeats = fakeFeatureRepository.GetAll(selectedProjectId);
            foreach (Feature feature in listOfFeats)
            {
                this.comboBox1.Items.Add(feature.Title);
            }
            this.comboBox1.SelectedItem = fakeFeatureRepository.GetFeatureById(selectedProjectId, selectedRequirement.FeatureId).Title;
            this.textBox1.Text = selectedRequirement.Statement;
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            Requirement req = new Requirement();
            req.FeatureId = fakeFeatureRepository.GetFeatureByTitle(selectedProjectId, this.comboBox1.SelectedItem.ToString()).Id;
            req.ProjectId = selectedProjectId;
            req.Statement = this.textBox1.Text;
            req.Id = selectedRequirement.Id;
            var result = fakeRequirementRepository.Modify(req);
            if(result == fakeRequirementRepository.NO_ERROR)
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
