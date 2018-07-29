using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Quotation.Models;

namespace Quotation
{
    public partial class frmProject : DevExpress.XtraEditors.XtraForm
    {
        public GlobalProject GlobalProject
        {
            get;
            private set;
        }



        public frmProject(GlobalProject gp)
        {
            InitializeComponent();

            GlobalProject = gp;

            this.InitTab();
        }

        private void InitTab()
        {
            tabControl1.TabPages.Clear();
            switch (GlobalProject.Project.Mb)
            {
                case "1765":
                    this.InitTab_1765();
                    break;
            }
        }

        private void InitTab_1765()
        {
            tabControl1.TabPages.Add("价格方案").Controls.Add(new Quotation.q1765.zb(GlobalProject));
            tabControl1.TabPages.Add("设计费");
            tabControl1.TabPages.Add("外协费");
            tabControl1.TabPages.Add("专用费");
            tabControl1.TabPages.Add("试验费");
            tabControl1.TabPages.Add("固资及工资费");
        }


        private void frmProject_Load(object sender, EventArgs e)
        {

        }






    }
}
