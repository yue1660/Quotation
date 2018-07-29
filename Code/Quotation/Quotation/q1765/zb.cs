using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Quotation.Models;
using DevExpress.XtraTreeList.Nodes;

namespace Quotation.q1765
{
    public partial class zb : DevExpress.XtraEditors.XtraUserControl
    {
        public GlobalProject GlobalProject
        {
            get;
            private set;
        }
        public List<q1765_zb> DataSouce
        {
            get;
            private set;
        }

        public zb(GlobalProject gp)
        {
            InitializeComponent();
            GlobalProject = gp;
        }

        private void zb_Load(object sender, EventArgs e)
        {
            this.InitData();
        }


        public void InitData()
        {
            if (GlobalProject == null)
                return;

            DataSouce = GlobalProject.DbContext.q1765_zb.ToList();
            treeList1.DataSource = DataSouce;
            treeList1.ExpandAll();
        }

        private void treeList1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var p = treeList1.PointToClient(MousePosition);
            var hit = treeList1.CalcHitInfo(p);
            var aaa = hit.Node;

        }



        private void 添加同级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var node = treeList1.FocusedNode;
            if (node != null)
            {
                var parentNode = node.ParentNode ?? node;
                q1765_zb parentItem = treeList1.GetDataRecordByNode(parentNode) as q1765_zb;

                if (parentItem != null)
                {
                    var newItem = GlobalProject.DbContext.q1765_zb.Add(new q1765_zb()
                    {
                        ProjectID = GlobalProject.Project.ID,
                        PID = parentItem.ID
                    });
                    DataSouce.Add(newItem);

                    //treeList1.AppendNode(newItem, parentNode);
                    this.UpdateSeq();
                    parentNode.Expanded = true;
                }
            }
        }

        private void 添加子级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var node = treeList1.FocusedNode;
            if (node != null)
            {
                var parentNode = node;
                q1765_zb parentItem = treeList1.GetDataRecordByNode(parentNode) as q1765_zb;

                q1765_zb newItem = new q1765_zb()
                {
                    ProjectID = GlobalProject.Project.ID,
                    PID = parentItem.ID
                };

                treeList1.AppendNode(newItem, parentNode);
                GlobalProject.DbContext.q1765_zb.Add(newItem);
                this.UpdateSeq();
                parentNode.Expanded = true;
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var list = treeList1.Selection;
            var list = treeList1.GetSelectedCells();

            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    var node = list[i].Node;
                    q1765_zb item = treeList1.GetDataRecordByNode(node) as q1765_zb;

                    var listDelete = GlobalProject.DbContext.q1765_zb.Where(q => q.Xh.IndexOf(item.Xh) == 0);
                    GlobalProject.DbContext.q1765_zb.RemoveRange(listDelete);
                }
                treeList1.DeleteSelectedNodes();
                this.UpdateSeq();
            }
            //var node = treeList1.FocusedNode;
            //if (node != null)
            //{
            //    q1765_zb item = treeList1.GetDataRecordByNode(node) as q1765_zb;
            //    if (item != null)
            //    {
            //        treeList1.DeleteNode(node);
            //        GlobalProject.DbContext.q1765_zb.Remove(item);
            //        this.UpdateSeq();
            //    }
            //}
        }

        private void UpdateSeq()
        {
            this.UpdateSeq(treeList1.Nodes[0].Nodes, "");
            treeList1.Refresh();
        }
        private void UpdateSeq(TreeListNodes nodes, string xh)
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                var seq = xh + (i + 1);
                var node = nodes[i];
                q1765_zb item = treeList1.GetDataRecordByNode(node) as q1765_zb;
                if (item.Xh != seq)
                    item.Xh = seq;

                // 子级
                this.UpdateSeq(node.Nodes, seq + ".");
            }
        }


    }
}
