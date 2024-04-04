using Microsoft.Win32;
using OneWorldConnect.BusinessLogic;
using OneWorldConnect.DomainModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Windows.Forms;

namespace OneWordConnectApp
{
    public partial class FormLogin : Form
    {
        UserSetting _setting;
        List<Conference> _conferences;
        public FormLogin()
        {
            InitializeComponent();
            Initiator.Init();
            _setting = LoadConfigurations();
            _conferences = APIHelper.GetAPIUploadList();
        }

        private static string GetServiceInstallPath(string serviceName)
        {
            RegistryKey regkey;
            regkey = Registry.LocalMachine.OpenSubKey(string.Format(@"SYSTEM\CurrentControlSet\services\{0}", serviceName));

            if (regkey.GetValue("ImagePath") == null)
                return "Not Found";
            else
                return regkey.GetValue("ImagePath").ToString();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsValidateUserInfo())
            {
                var presenterBusinessLogic = DependencyInjector.Retrieve<IPresenterBusinessLogic>();
                var presenters = presenterBusinessLogic.GetPresenters((int)cmbConference.SelectedValue, txtPassword.Text,cmbConference.Text);
                if (presenters != null)
                {
                    frmMain obj = new frmMain(presenterBusinessLogic, _setting, presenters,cmbConference.Text);
                    obj.Show();
                    this.Hide();
                    obj = null;
                }
                else
                {
                    MessageBox.Show("Please enter valid user id or password", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private UserSetting LoadConfigurations()
        {
            UserSetting userSetting = new UserSetting();
            string imagePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Images\";
            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
            string configFilePath = System.IO.Path.Combine(strWorkPath, "ApplicationSetting.xml");
            System.Xml.Linq.XElement xElement = System.Xml.Linq.XElement.Load(configFilePath);
            var CompanyLogoImagePath = xElement.Element("CompanyLogoImagePath");
            var BackGroundShowImagePath = xElement.Element("BackGroundShowImagePath");
            var LoginImagePath = xElement.Element("LoginImagePath");
            userSetting.UserBackGroundShowImagePath = imagePath + BackGroundShowImagePath?.Value;
            userSetting.UserLogoImagePath = imagePath + CompanyLogoImagePath?.Value;
            userSetting.UserBackgroundLoginImagePath = imagePath + LoginImagePath?.Value;

            var dbConnectionFilePath = xElement.Element("DbConnectionFilePath");
            string serviceExecutionPath = GetServiceInstallPath("OneWorldConnectService");
            string actualServiceExecutionPath = Path.GetDirectoryName(serviceExecutionPath.Replace("\"", ""));
            dbConnectionFilePath.Value = actualServiceExecutionPath;
            xElement.Save(configFilePath);
            return userSetting;
        }
        public int UpadteApplicationConfigSetting()
        {
            try
            {
                string serviceExecutionPath = GetServiceInstallPath("OneWorldConnectService");
                string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
                string configFilePath = System.IO.Path.Combine(strWorkPath, "ApplicationSetting.xml");
                System.Xml.Linq.XElement xElement = System.Xml.Linq.XElement.Load(configFilePath);
                var dbConnectionFilePath = xElement.Element("DbConnectionFilePath");
                dbConnectionFilePath.Value = serviceExecutionPath;
                xElement.Save(configFilePath);
            }
            catch (Exception)
            {
                return 0;
            }
            return 1;
        }
        private bool IsValidateUserInfo()
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter correct password");
                return false;
            }
            var findConference = _conferences.Where(a => a.conference_id == (int)cmbConference.SelectedValue && a.conference_password == txtPassword.Text).FirstOrDefault();
            if (findConference == null)
            {
                MessageBox.Show("Please enter correct password");
                return false;
            }
            return true;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            try
            {
                this.BindConferenceList();
                cmbConference.Left = txtuser.Left;
                cmbConference.Top = txtuser.Top;
                if (_setting.UserLogoImagePath != null)
                {
                    pbxLoginCompanyLogo.Image = Image.FromFile(_setting.UserLogoImagePath);
                }
                if (_setting.UserBackgroundLoginImagePath != null)
                {
                    pnlLoginImage.BackgroundImage = Image.FromFile(_setting.UserBackgroundLoginImagePath);
                }
            }
            catch(Exception ex)
            {

            }
        }
        private void BindConferenceList()
        {
            
            cmbConference.DataSource = _conferences;
            cmbConference.DisplayMember = "conference_name";
            cmbConference.ValueMember = "conference_id";
        }
        private void lnkUserSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        //    var _myForm = (frmUserSetting)Application.OpenForms["frmUserSetting"];
        //    if (_myForm == null)
        //    {
        //        _myForm = new frmUserSetting(_userSettingBusinessService);
        //        _myForm.MdiParent = this;
        //        _myForm.StartPosition = FormStartPosition.CenterScreen;
        //    }
        }

        private void btnStartSynchUp_Click(object sender, EventArgs e)
        {
            ServiceController service = new ServiceController("OneWorldConnectService",".");
            //string str = service.DisplayName;
            if ((service.Status.Equals(ServiceControllerStatus.Stopped)) || (service.Status.Equals(ServiceControllerStatus.StopPending)))
            {
                string[] str = new string[1];
                str[0] = cmbConference.Text;
                service.Start(str);
                MessageBox.Show("Data synchUp process has started successfully. Please try to login after 2 minute", "", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            BindConferenceList();
            //cmbConference.Refresh();
            //else service.Stop();
        }

        private void btnStopSynchUp_Click(object sender, EventArgs e)
        {
            StopService();
        }

        private static void StopService()
        {
            ServiceController service = new ServiceController("OneWorldConnectService", ".");
            //string str = service.DisplayName;
            if ((service.Status.Equals(ServiceControllerStatus.Running)) || (service.Status.Equals(ServiceControllerStatus.StartPending)))
            {
                try
                {
                    service.Stop();
                    MessageBox.Show("Data synch up process has stopped successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data synch up process currently can not stopped. Please try to stop after some time", "", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
            }
        }
    }
}
