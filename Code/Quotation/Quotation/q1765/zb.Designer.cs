namespace Quotation.q1765
{
    partial class zb
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zb));
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListBand3 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListBand1 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.colLock = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.imgCollLock = new DevExpress.Utils.ImageCollection(this.components);
            this.colFlag = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imgCollFlag = new DevExpress.Utils.ImageCollection(this.components);
            this.treeListBand2 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.colSeq = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListBand4 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.ItemImageComboBoxLock = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.添加同级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加子级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCollLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCollFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemImageComboBoxLock)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Bands.AddRange(new DevExpress.XtraTreeList.Columns.TreeListBand[] {
            this.treeListBand3,
            this.treeListBand1,
            this.treeListBand2,
            this.treeListBand4});
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colLock,
            this.colFlag,
            this.colSeq,
            this.colName,
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3});
            this.treeList1.ColumnsImageList = this.imgCollLock;
            this.treeList1.CustomizationFormBounds = new System.Drawing.Rectangle(1111, 620, 216, 208);
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 25);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            "0",
            null,
            "1",
            "项目",
            null,
            null,
            null}, -1);
            this.treeList1.AppendNode(new object[] {
            "1",
            null,
            "1.1",
            "阶段1",
            null,
            null,
            null}, 0);
            this.treeList1.AppendNode(new object[] {
            "0",
            2,
            "1.1.1",
            "课题1.1",
            null,
            null,
            null}, 1);
            this.treeList1.AppendNode(new object[] {
            "1",
            null,
            "1.2",
            "课题1.2",
            null,
            null,
            null}, 0);
            this.treeList1.EndUnboundLoad();
            this.treeList1.OptionsSelection.MultiSelect = true;
            this.treeList1.OptionsSelection.MultiSelectMode = DevExpress.XtraTreeList.TreeListMultiSelectMode.CellSelect;
            this.treeList1.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.RowFullFocus;
            this.treeList1.ParentFieldName = "PID";
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1,
            this.repositoryItemImageComboBox1,
            this.repositoryItemPictureEdit1,
            this.ItemImageComboBoxLock});
            this.treeList1.RootValue = null;
            this.treeList1.Size = new System.Drawing.Size(721, 381);
            this.treeList1.TabIndex = 0;
            this.treeList1.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.Solid;
            // 
            // treeListBand3
            // 
            this.treeListBand3.Caption = "基本信息";
            this.treeListBand3.Columns.Add(this.colName);
            this.treeListBand3.MinWidth = 70;
            this.treeListBand3.Name = "treeListBand3";
            // 
            // colName
            // 
            this.colName.Caption = "标题";
            this.colName.FieldName = "Mc";
            this.colName.MinWidth = 70;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowSort = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 112;
            // 
            // treeListBand1
            // 
            this.treeListBand1.Caption = "状态";
            this.treeListBand1.Columns.Add(this.colLock);
            this.treeListBand1.Columns.Add(this.colFlag);
            this.treeListBand1.MinWidth = 70;
            this.treeListBand1.Name = "treeListBand1";
            // 
            // colLock
            // 
            this.colLock.Caption = "锁定";
            this.colLock.ColumnEdit = this.repositoryItemImageEdit1;
            this.colLock.FieldName = "Sfsd";
            this.colLock.MinWidth = 30;
            this.colLock.Name = "colLock";
            this.colLock.OptionsColumn.AllowSize = false;
            this.colLock.OptionsColumn.AllowSort = false;
            this.colLock.Visible = true;
            this.colLock.VisibleIndex = 1;
            this.colLock.Width = 30;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.HtmlImages = this.imgCollLock;
            this.repositoryItemImageEdit1.Images = this.imgCollLock;
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            this.repositoryItemImageEdit1.NullValuePromptShowForEmptyValue = true;
            // 
            // imgCollLock
            // 
            this.imgCollLock.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgCollLock.ImageStream")));
            this.imgCollLock.Images.SetKeyName(0, "透明32.png");
            this.imgCollLock.Images.SetKeyName(1, "lock.png");
            // 
            // colFlag
            // 
            this.colFlag.Caption = "标记";
            this.colFlag.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colFlag.FieldName = "Ztbj";
            this.colFlag.MinWidth = 30;
            this.colFlag.Name = "colFlag";
            this.colFlag.OptionsColumn.AllowSize = false;
            this.colFlag.OptionsColumn.AllowSort = false;
            this.colFlag.Visible = true;
            this.colFlag.VisibleIndex = 2;
            this.colFlag.Width = 30;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 1, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 2, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 3, 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 4, 3)});
            this.repositoryItemImageComboBox1.LargeImages = this.imgCollFlag;
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // imgCollFlag
            // 
            this.imgCollFlag.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgCollFlag.ImageStream")));
            this.imgCollFlag.Images.SetKeyName(0, "flag1.png");
            this.imgCollFlag.Images.SetKeyName(1, "flag2.png");
            this.imgCollFlag.Images.SetKeyName(2, "flag3.png");
            this.imgCollFlag.Images.SetKeyName(3, "flag4.png");
            // 
            // treeListBand2
            // 
            this.treeListBand2.Caption = "序号";
            this.treeListBand2.Columns.Add(this.colSeq);
            this.treeListBand2.Name = "treeListBand2";
            // 
            // colSeq
            // 
            this.colSeq.Caption = "序号";
            this.colSeq.FieldName = "Xh";
            this.colSeq.Name = "colSeq";
            this.colSeq.OptionsColumn.AllowSort = false;
            this.colSeq.OptionsColumn.ReadOnly = true;
            this.colSeq.Visible = true;
            this.colSeq.VisibleIndex = 3;
            // 
            // treeListBand4
            // 
            this.treeListBand4.Caption = "treeListBand4";
            this.treeListBand4.Columns.Add(this.treeListColumn1);
            this.treeListBand4.Columns.Add(this.treeListColumn2);
            this.treeListBand4.Columns.Add(this.treeListColumn3);
            this.treeListBand4.Name = "treeListBand4";
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "treeListColumn1";
            this.treeListColumn1.FieldName = "treeListColumn1";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowSort = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 4;
            this.treeListColumn1.Width = 112;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "treeListColumn2";
            this.treeListColumn2.FieldName = "treeListColumn2";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.OptionsColumn.AllowSort = false;
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 5;
            this.treeListColumn2.Width = 112;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "treeListColumn3";
            this.treeListColumn3.FieldName = "treeListColumn3";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.OptionsColumn.AllowSort = false;
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 6;
            this.treeListColumn3.Width = 113;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // ItemImageComboBoxLock
            // 
            this.ItemImageComboBoxLock.AutoHeight = false;
            this.ItemImageComboBoxLock.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemImageComboBoxLock.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 1, 1)});
            this.ItemImageComboBoxLock.LargeImages = this.imgCollLock;
            this.ItemImageComboBoxLock.Name = "ItemImageComboBoxLock";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加同级ToolStripMenuItem,
            this.添加子级ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(721, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 添加同级ToolStripMenuItem
            // 
            this.添加同级ToolStripMenuItem.Name = "添加同级ToolStripMenuItem";
            this.添加同级ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.添加同级ToolStripMenuItem.Text = "添加同级";
            this.添加同级ToolStripMenuItem.Click += new System.EventHandler(this.添加同级ToolStripMenuItem_Click);
            // 
            // 添加子级ToolStripMenuItem
            // 
            this.添加子级ToolStripMenuItem.Name = "添加子级ToolStripMenuItem";
            this.添加子级ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.添加子级ToolStripMenuItem.Text = "添加子级";
            this.添加子级ToolStripMenuItem.Click += new System.EventHandler(this.添加子级ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.删除ToolStripMenuItem.Text = "删除选中";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // zb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "zb";
            this.Size = new System.Drawing.Size(721, 406);
            this.Load += new System.EventHandler(this.zb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCollLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCollFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemImageComboBoxLock)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLock;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFlag;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSeq;
        private DevExpress.Utils.ImageCollection imgCollLock;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand3;
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand1;
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand2;
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand4;
        private DevExpress.Utils.ImageCollection imgCollFlag;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox ItemImageComboBoxLock;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加同级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加子级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;

    }
}
