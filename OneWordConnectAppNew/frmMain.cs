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
    public partial class frmMain : Form
    {
        IPresenterBusinessLogic _presenterBusinessLogic;
        IUserSettingBusinessService _userSettingBusinessService;
        UserSetting _setting;
        Presenter _presenter;
        IList<Presenter> _presenters;
        IList<Session> _sessions;
        string _conferenceName;
        public frmMain(IPresenterBusinessLogic presenterBusinessLogic,UserSetting setting, IList<Presenter> presenters,string conferenceName)
        {
            InitializeComponent();
            _presenterBusinessLogic = presenterBusinessLogic;
            _userSettingBusinessService = DependencyInjector.Retrieve<IUserSettingBusinessService>();
            _setting = setting;
            _presenters = presenters;
            _conferenceName = conferenceName;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                _sessions= _presenterBusinessLogic.GetSessions(_presenters.ToList(), _conferenceName);
                this.BindDateSelection();
                this.BindSessionList();
                this.BindRoomDropdownList();
                string appPath = _setting.UserLogoImagePath;
                lblLogeedInUser.Text = _presenters.Select(a=>a.conference_name).FirstOrDefault();
                pbxMainCompnyLogo.Image = Image.FromFile(appPath);
                string backgroundImagePath =  _setting.UserBackGroundShowImagePath;
                Logger.LogInfo("Main Form Load : "+backgroundImagePath);
                this.BackgroundImage = Image.FromFile(backgroundImagePath);
                this.panel1.Width = this.Width;
            }
            catch(Exception ex)
            {

            }
        }
        private void BindDateSelection()
        {
            cmbDateSelection.DataSource = _sessions.Select(a=>a.session_date).Distinct().ToList();
        }
        private void BindTimeSelection()
        {
            if (!cmbSessionSelection.SelectedValue.ToString().Equals("OneWorldConnect.DomainModel.Session"))
                cmbTimeSelection.DataSource = _sessions.ToList().Where(a => a.SessionId == (int)cmbSessionSelection.SelectedValue).Select(a => a.SessionStartTime).ToList();
        }
        private void BindRoomDropdownList()
        {
            if (!cmbSessionSelection.SelectedValue.ToString().Equals("OneWorldConnect.DomainModel.Session"))
            {
                var rooms = _presenterBusinessLogic.GetRoomList((int)cmbSessionSelection.SelectedValue, _conferenceName).ToList();
                cmbRoomSelection.DataSource = rooms.Distinct().ToList();
                cmbRoomSelection.DisplayMember = "RoomName";
                cmbRoomSelection.ValueMember = "RoomId";
            }
        }

        private void btnUserSetting_Click(object sender, EventArgs e)
        {
            var _myForm = (frmUserSetting)Application.OpenForms["frmUserSetting"];
            if (_myForm == null)
            {
                _myForm = new frmUserSetting(_userSettingBusinessService);
                _myForm.MdiParent = this;
                _myForm.StartPosition = FormStartPosition.CenterScreen;
            }
            var frmuserSession = (frmSession)Application.OpenForms["frmSession"];
            if(frmuserSession!=null)
            {
                frmuserSession.Hide();
            }
            // finally show the form
            _myForm.Show();
            _myForm.BringToFront();
            
        }

        private void btnSessionStart_Click(object sender, EventArgs e)
        {
            var _myForm = (frmSession)Application.OpenForms["frmSession"];
            var session = _sessions.ToList().First(a => a.SessionId == (int)cmbSessionSelection.SelectedValue);
            if (_myForm == null)
            {
               var presentations= _presenterBusinessLogic.GetPresentation(0, (int)cmbRoomSelection.SelectedValue, session.SessionId,session.SessionStartTime,session.SessionEndTime, _conferenceName);
                _myForm = new frmSession(presentations,_presenters.ToList(), _conferenceName);
                _myForm.MdiParent = this;
                _myForm.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                _myForm.Close();
                var presentations = _presenterBusinessLogic.GetPresentation(0, (int)cmbRoomSelection.SelectedValue, session.SessionId, session.SessionStartTime, session.SessionEndTime, _conferenceName);
                _myForm = new frmSession(presentations, _presenters.ToList(),_conferenceName);
                _myForm.MdiParent = this;
                _myForm.StartPosition = FormStartPosition.CenterScreen;
            }
            var frmUserSetting = (frmUserSetting)Application.OpenForms["frmUserSetting"];
            if (frmUserSetting != null)
            {
                frmUserSetting.Hide();
            }
            // finally show the form
            _myForm.Show();
            _myForm.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Environment.Exit(1);
            Application.Restart();
            
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            StopService();
            System.Environment.Exit(1);
            Application.Restart();
            
        }

        private void cmbRoomSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            //BindSessionList();
        }
        private void BindSessionList()
        {
            cmbSessionSelection.DataSource = _sessions.ToList().Where(a=>a.session_date==DateTime.Parse(cmbDateSelection.SelectedValue.ToString())).ToList();
            cmbSessionSelection.DisplayMember = "SessionFullName";
            cmbSessionSelection.ValueMember = "SessionId";
         
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
                    //MessageBox.Show("Data synch up process has stopped successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Data synch up process currently can not stopped. Please try to stop after some time", "", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
            }
        }

        private void cmbTimeSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////cmbSessionSelection.DataSource = null;
            ////BindRoomDropdownList();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.panel1.Hide();
        }

        private void btnShowPanel_Click(object sender, EventArgs e)
        {
            this.panel1.Show();
        }

        private void cmbSessionSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindRoomDropdownList();
        }

        private void BindDateAndTimeSelection()
        {
           
        }

        private void cmbDateSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BindSessionList();
        }
    }
}
