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
        public frmMain(IPresenterBusinessLogic presenterBusinessLogic,UserSetting setting, IList<Presenter> presenters)
        {
            InitializeComponent();
            _presenterBusinessLogic = presenterBusinessLogic;
            _userSettingBusinessService = DependencyInjector.Retrieve<IUserSettingBusinessService>();
            _setting = setting;
            _presenters = presenters;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                this.BindDateSelection();
                this.BindTimeSelection();
                this.BindRoomDropdownList();
                //this.BindSessionList();
                //this. BindSessionList(int roomId)
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
            var dates = _presenterBusinessLogic.GetDateByPresenters(_presenters.ToList());
            cmbDateSelection.DataSource = dates.Distinct().ToList();
        }
        private void BindTimeSelection()
        {
            var times = _presenterBusinessLogic.GetTimeByPresenters(_presenters.ToList());
            cmbTimeSelection.DataSource = times.Distinct().ToList();
        }
        private void BindRoomDropdownList()
        {
            var rooms = _presenterBusinessLogic.GetRoomList(cmbDateSelection.SelectedValue.ToString(), cmbTimeSelection.SelectedValue.ToString()).ToList();
            cmbRoomSelection.DataSource = rooms.Distinct().ToList();
            cmbRoomSelection.DisplayMember = "RoomName";
            cmbRoomSelection.ValueMember = "RoomId";
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
            if (_myForm == null)
            {
               var presentations= _presenterBusinessLogic.GetPresentation(0, (int)cmbRoomSelection.SelectedValue, (int)cmbSessionSelection.SelectedValue,cmbDateSelection.SelectedValue.ToString(),cmbTimeSelection.SelectedValue.ToString());
                _myForm = new frmSession(presentations,_presenters.ToList());
                _myForm.MdiParent = this;
                _myForm.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                _myForm.Close();
                var presentations = _presenterBusinessLogic.GetPresentation(0, (int)cmbRoomSelection.SelectedValue, (int)cmbSessionSelection.SelectedValue, cmbDateSelection.SelectedValue.ToString(), cmbTimeSelection.SelectedValue.ToString());
                _myForm = new frmSession(presentations, _presenters.ToList());
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
            BindSessionList();
        }
        private void BindSessionList()
        {
            if (cmbRoomSelection.SelectedValue.ToString() != "OneWorldConnect.DomainModel.Room")
            {
                var sessions= _presenterBusinessLogic.GetSessions(Convert.ToInt32(cmbRoomSelection.SelectedValue.ToString()), cmbDateSelection.SelectedValue.ToString(), cmbTimeSelection.SelectedValue.ToString());
                cmbSessionSelection.DataSource = sessions;
                cmbSessionSelection.DisplayMember = "SessionFullName";
                cmbSessionSelection.ValueMember = "SessionId";
            }
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
            cmbSessionSelection.DataSource = null;
            BindRoomDropdownList();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.panel1.Hide();
        }

        private void btnShowPanel_Click(object sender, EventArgs e)
        {
            this.panel1.Show();
        }
    }
}
