using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Quotation.Models;

namespace Quotation
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //Form CurrentForm
        //{
        //    get
        //    {
        //        if (this.ActiveMdiChild == null) return null;
        //        if (xtraTabbedMdiManager1.ActiveFloatForm != null)
        //            return xtraTabbedMdiManager1.ActiveFloatForm as frmPad;
        //        return this.ActiveMdiChild;
        //    }
        //}

        public frmMain()
        {
            Common.ConsoleLog("Main - Init");
            InitializeComponent();
            Common.ConsoleLog("Main - Init.End");
        }

        private void bblNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = new Form();
            frm.MdiParent = this;
            frm.Text = DateTime.Now.ToString("mm:ss");
            frm.Show();
        }

        private void bbiOpen_ItemClick(object sender, ItemClickEventArgs e)
        {
            Common.ConsoleLog("Open");
            string filename = @"D:\Project1.db";
            var gp = new GlobalProject(filename);
            foreach (var form in this.MdiChildren)
            {
                if (form is frmProject)
                {
                    var f = (frmProject)form;
                    if (f.GlobalProject.DbContext == gp.DbContext)
                    {
                        f.Activate();
                        return;
                    }
                }
            }


            frmProject frm = new frmProject(gp);
            frm.MdiParent = this;
            frm.Text = gp.Project.XMMC;
            frm.Show();
            Common.ConsoleLog("Open.Show");
        }

        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (var form in this.MdiChildren)
            {
                if (form is frmProject)
                {
                    var f = (frmProject)form;

                    f.GlobalProject.DbContext.SaveChanges();
                }
            }
        }

    }
}