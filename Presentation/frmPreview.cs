using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Presentation
{
    public partial class frmPreview : Form
    {
        public frmPreview(ReportClass rpt)
        {
            InitializeComponent();
            this.crptViewer.ReportSource = rpt;
            crptViewer.Show();

        }
    }
}
