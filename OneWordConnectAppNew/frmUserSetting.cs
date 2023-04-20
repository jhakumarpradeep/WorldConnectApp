using OneWorldConnect.BusinessLogic;
using OneWorldConnect.DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneWordConnectApp
{
    public partial class frmUserSetting : Form
    {
        IUserSettingBusinessService _userSettingBusinessService;
        public frmUserSetting(IUserSettingBusinessService userSettingBusinessService)
        {
            InitializeComponent();
            _userSettingBusinessService = userSettingBusinessService;
        }

        private void frmUserSetting_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bnBrowseLogo_Click(object sender, EventArgs e)
        {
            SelectImageFileDialog.ShowDialog();
            txtLogoSelection.Text = SelectImageFileDialog.SafeFileName;
            SaveSelectedImage(SelectImageFileDialog);
        }

        private void SaveSelectedImage(OpenFileDialog openFileDialog)
        {
            try
            {
                string iName = openFileDialog.SafeFileName;
                string filepath = openFileDialog.FileName;
                string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Images\";
                Logger.LogInfo("User Setting Form Save Selected Image : " + appPath);
                if (!Directory.Exists(appPath))
                {
                    Directory.CreateDirectory(appPath);
                }
                if (File.Exists(appPath + iName))
                {
                    File.Delete(appPath + iName);
                }
                File.Copy(filepath, appPath + iName);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrowseShow_Click(object sender, EventArgs e)
        {
            selectedBackGroundImage.ShowDialog();
            txtBackgroundShow.Text = selectedBackGroundImage.SafeFileName;
            SaveSelectedImage(selectedBackGroundImage);
        }

        private void btnBrowseLogin_Click(object sender, EventArgs e)
        {
            selectedLoginImage.ShowDialog();
            txtLoginImageSelection.Text = selectedLoginImage.SafeFileName;
            SaveSelectedImage(selectedLoginImage);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           
            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
            string strSettingsXmlFilePath = System.IO.Path.Combine(strWorkPath, "ApplicationSetting.xml");
            UserSetting setting = new UserSetting()
            {
                UserLogoImagePath = txtLogoSelection.Text,
                UserBackgroundLoginImagePath = txtLoginImageSelection.Text,
                UserBackGroundShowImagePath = txtBackgroundShow.Text
            };
            int result= _userSettingBusinessService.SaveUerSetting(strSettingsXmlFilePath, setting);
            if(result > 0)
            {
                MessageBox.Show("setting has been applied successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain mdiForm = (frmMain)this.MdiParent;
                if (!string.IsNullOrEmpty(setting.UserLogoImagePath))
                {
                    string compnyLogoPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Images\" + setting.UserLogoImagePath;
                    ((PictureBox)mdiForm.Controls["pbxMainCompnyLogo"]).Image = Image.FromFile(compnyLogoPath);
                }
                if (!string.IsNullOrEmpty(setting.UserBackGroundShowImagePath))
                {
                    string backgroundImagePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Images\" + setting.UserBackGroundShowImagePath;
                    mdiForm.BackgroundImage = Image.FromFile(backgroundImagePath);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("setting has not been updated due to some techncal issue", "", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
