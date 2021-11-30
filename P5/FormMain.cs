using System;
using System.Windows.Forms;

namespace P5
{
    public partial class FormMain : Form
    {
        private AppUser _CurrentAppUser = new AppUser();
        private FakeIssueRepository _fakeIssueRepository = new FakeIssueRepository();

        public FormMain()
        {
            InitializeComponent();
        }

        private void preferencesCreateProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormCreateProject form = new FormCreateProject();
            form.ShowDialog();
        }

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            this.CenterToScreen();
            // Force the user to login successfully or abort the application
            DialogResult isOK = DialogResult.OK;
            while (!_CurrentAppUser.IsAuthenticated && isOK == DialogResult.OK)
            {
                FormLogin login = new FormLogin();
                isOK = login.ShowDialog();
                _CurrentAppUser = login._CurrentAppUser;
                login.Dispose();
            }
            if (isOK != DialogResult.OK)
            {
                Close();
                return;
            }
            this.Text = "Main - No Project Selected";
            while (selectAProject() == "")
            {
                DialogResult result = MessageBox.Show("A project must be selected.", "Attention", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    Close();
                    return;
                }
            }
        }

        private void preferencesSelectProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            selectAProject();
        }

        private string selectAProject()
        {
            string selectedProject = "";
            FormSelectProject form = new FormSelectProject();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
                preferenceRepository.SetPreference(_CurrentAppUser.UserName,
                                                   FakePreferenceRepository.PREFERENCE_PROJECT_NAME,
                                                   form._SelectedProjectName);
                int selectedProjectId = form._SelectedProjectId;
                preferenceRepository.SetPreference(_CurrentAppUser.UserName,
                                                   FakePreferenceRepository.PREFERENCE_PROJECT_ID,
                                                   selectedProjectId.ToString());
                this.Text = "Main - " + form._SelectedProjectName;
                selectedProject = form._SelectedProjectName;
            }
            form.Dispose();
            return selectedProject;
        }

        private void preferencesModifyProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormModifyProject form = new FormModifyProject(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void preferencesRemoveProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormRemoveProject form = new FormRemoveProject(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesDashboardToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormDashboardIssue form = new FormDashboardIssue(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesRecordToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormRecordIssue form = new FormRecordIssue(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesModifyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormSelectIssue form = new FormSelectIssue(_CurrentAppUser);
            form.ShowDialog();
            var selectedIssue = form.selectedIssueId;
            form.Dispose();

            if (form.DialogResult == DialogResult.OK)
            {
                FormModifyIssue modifyForm = new FormModifyIssue(selectedIssue);
                modifyForm.ShowDialog();
                modifyForm.Dispose();
                selectedIssue = -1;
            }
        }

        private void issuesRemoveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormSelectIssue form = new FormSelectIssue(_CurrentAppUser);
            form.ShowDialog();
            var selectedIssue = form.selectedIssueId;
            if(form.DialogResult == DialogResult.OK)
            {
                DialogResult mbResult = MessageBox.Show($"Are you sure you want to remove: {_fakeIssueRepository.GetIssueById(selectedIssue).Title}","Confirmation", MessageBoxButtons.YesNo);
                if(mbResult == DialogResult.Yes)
                {
                    //Remove
                    _fakeIssueRepository.Remove(_fakeIssueRepository.GetIssueById(selectedIssue));
                }
                else
                {
                    MessageBox.Show("Remove canceled!", "Attention");
                }
            }

            form.Dispose();
            selectedIssue = -1;
        }

        //Feature Create
        private void createToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormCreateFeature form = new FormCreateFeature(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        //Feature Modify
        private void modifyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormSelectFeature form = new FormSelectFeature(_CurrentAppUser);
            form.ShowDialog();
            var selectedFeatureId = form.selectedFeatureId;

            if(form.DialogResult == DialogResult.OK)
            {
                FormModifyFeature form2 = new FormModifyFeature(_CurrentAppUser, selectedFeatureId);
                form2.ShowDialog();
                form2.Dispose();
            }
            form.Dispose();

        }

        //Remove Feature
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FakeRequirementRepository fakeRequirementRepository = new FakeRequirementRepository();
            FakeFeatureRepository fakeFeatureRepository = new FakeFeatureRepository();
            FormSelectFeature form = new FormSelectFeature(_CurrentAppUser);
            FakePreferenceRepository fakePreferenceRepository = new FakePreferenceRepository();
            var selectedProjectId = Int32.Parse(fakePreferenceRepository.GetPreference(_CurrentAppUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID));
            form.ShowDialog();
            var selectedFeatureId = form.selectedFeatureId;

            if (form.DialogResult == DialogResult.OK)
            {
                var result = MessageBox.Show($"Are you sure you want to remove: {fakeFeatureRepository.GetFeatureById(selectedProjectId, selectedFeatureId).Title}?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (fakeRequirementRepository.CountByFeatureId(selectedFeatureId) > 0)
                    {
                        var secondResult = MessageBox.Show($"There are one or more requirements associated with this feature. These requirements will be destroyed if you remove this feature. Are you sure you want to remove: {fakeFeatureRepository.GetFeatureById(selectedProjectId, selectedFeatureId).Title}", "Confirmation", MessageBoxButtons.YesNo);
                        if (secondResult == DialogResult.Yes)
                        {
                            fakeRequirementRepository.RemoveByFeatureId(selectedFeatureId);
                            fakeFeatureRepository.Remove(fakeFeatureRepository.GetFeatureById(selectedProjectId, selectedFeatureId));
                        }
                        else
                        {
                            MessageBox.Show("Remove canceled!", "Attention");
                        }
                    }
                    else
                    {
                        fakeRequirementRepository.RemoveByFeatureId(selectedFeatureId);
                        fakeFeatureRepository.Remove(fakeFeatureRepository.GetFeatureById(selectedProjectId, selectedFeatureId));
                    }
                }
                else
                {
                    MessageBox.Show("Remove canceled!", "Attention");
                }
            }
            form.Dispose();
        }

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCreateRequirement form = new FormCreateRequirement(_CurrentAppUser);
            form.ShowDialog();

            form.Dispose();

        }

        private void modifyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSelectRequirement form = new FormSelectRequirement(_CurrentAppUser);
            form.ShowDialog();
            var selectedRequirement = form.selectedRequirementId;

            if(form.DialogResult == DialogResult.OK)
            {
                FormModifyRequirement form2 = new FormModifyRequirement(_CurrentAppUser, selectedRequirement);
                form2.ShowDialog();
                form2.Dispose();
            }

            form.Dispose();
        }
    }
}
