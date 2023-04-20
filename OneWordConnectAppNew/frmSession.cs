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
    public partial class frmSession : Form
    {
        List<Presentation> _presentations;
        List<Presenter> _presenters;
        public frmSession(List<Presentation> presentations, List<Presenter> presenters)
        {
            InitializeComponent();
            _presentations = presentations;
            _presenters = presenters;
        }

        private void frmSession_Load(object sender, EventArgs e)
        {
            this.DisplayPresenationDetails();
        }
        private void DisplayPresenationDetails()
        {
            foreach (var item in _presentations)
            {
                var prseneter = _presenters.FirstOrDefault(a => a.PresenterId == item.presenter_id);
                flowLayoutPanel1.Controls.Add(new PresentationList()
                {
                    LinkId = item.id.ToString(),
                    RoomId = item.room_id,
                    PresenterId = item.presenter_id,
                    PresentationName = item.name,
                    PresenterName = prseneter.FirstName+" "+prseneter.LastName,
                    FontSize = new System.Drawing.Size(18,18),
                    ProgressBarVisible=label1
                });
            }
        }
        private void grvAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
