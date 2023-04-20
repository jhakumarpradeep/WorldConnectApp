﻿using OneWorldConnect.BusinessLogic;
using System;
using System.IO;
using System.Windows.Forms;

namespace OneWordConnectApp
{
    public partial class PresentationList : UserControl
    {
        
        public PresentationList()
        {
            InitializeComponent();
        }
        public string PresentationName { get; set; }
        public string PresenterName { get; set; }
        public string LinkId { get; set; }
        public int RoomId { get; set; }
        public int PresenterId { get; set; }
        public Label ProgressBarVisible { get; set; }

        private void PresentationList_Load(object sender, EventArgs e)
        {
            lnkPresentationName.Text = PresentationName;
            lblPresenterName.Text = PresenterName;
            lnkPresentationName.Name = LinkId;


        }
        private string GetServiceRootPath()
        {
            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
            string configFilePath = System.IO.Path.Combine(strWorkPath, "ApplicationSetting.xml");
            System.Xml.Linq.XElement xElement = System.Xml.Linq.XElement.Load(configFilePath);
            var dbConnectionFilePath = xElement.Element("DbConnectionFilePath");
            return dbConnectionFilePath.Value;
        }
        private void lnkPresentationName_Click(object sender, EventArgs e)
        {
            try
            {
                ProgressBarVisible.Visible = true;
                var documentBusinesssService = DependencyInjector.Retrieve<DocumentBusinesssService>();
                var uploads=documentBusinesssService.GetUploadDocumentsInfo(Convert.ToInt32(LinkId), PresenterId, RoomId);
                string rootPath = GetServiceRootPath();
                foreach (var upload in uploads)
                {
                    if (upload.deleted == 0)
                    {  
                        //lnkPresentationName.Enabled = false;
                        Microsoft.Office.Interop.PowerPoint.Application pptApp = new Microsoft.Office.Interop.PowerPoint.Application();
                        Microsoft.Office.Core.MsoTriState ofalse = Microsoft.Office.Core.MsoTriState.msoFalse;
                        Microsoft.Office.Core.MsoTriState otrue = Microsoft.Office.Core.MsoTriState.msoTrue;
                        pptApp.DisplayAlerts = Microsoft.Office.Interop.PowerPoint.PpAlertLevel.ppAlertsNone;
                        pptApp.Visible = otrue;
                        pptApp.Activate();
                        Microsoft.Office.Interop.PowerPoint.Presentations ps = pptApp.Presentations;
                        string actualFilePath = rootPath + @"\doc_upload\" + upload.presenter_id + @"\" + System.IO.Path.GetFileName(upload.file_path);
                        Logger.LogInfo("Opening file from Path : " + actualFilePath);
                        if (File.Exists(actualFilePath))
                        {
                            Microsoft.Office.Interop.PowerPoint.Presentation p = ps.Open(actualFilePath, otrue, ofalse, otrue);
                            
                            lnkPresentationName.Enabled = true;
                            ProgressBarVisible.Visible = false; ;
                        }
                        
                    }
                   
                }
            }
            catch(Exception ex)
            {
                lnkPresentationName.Enabled = true;
                ProgressBarVisible.Visible = false; ;
                Logger.LogInfo("Error during open ppt file : " + ex.Message);
            }
        }

        private void lnkPresentationName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            string str = e.Link.Name;
        }
    }
}
