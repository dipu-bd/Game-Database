namespace Game_Database
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listNameContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.importListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameListContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.CustomSplitContainer();
            this.listNameViewer = new BrightIdeasSoftware.ObjectListView();
            this.listNameViewerCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.itemCountCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listAddButton = new System.Windows.Forms.Button();
            this.listNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.CustomSplitContainer();
            this.gameListViewer = new BrightIdeasSoftware.FastObjectListView();
            this.NameCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TypeCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.RatingCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.gameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addGameButton = new System.Windows.Forms.Button();
            this.removeSelectedButton = new System.Windows.Forms.Button();
            this.gameNoteBox = new YARTE.UI.HtmlEditor();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.noteLabel = new System.Windows.Forms.Label();
            this.listNameContext.SuspendLayout();
            this.gameListContext.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listNameViewer)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameListViewer)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listNameContext
            // 
            this.listNameContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator3,
            this.refreshToolStripMenuItem1,
            this.toolStripSeparator4,
            this.importListToolStripMenuItem,
            this.exportListToolStripMenuItem,
            this.exportAllToolStripMenuItem});
            this.listNameContext.Name = "listNameContext";
            this.listNameContext.Size = new System.Drawing.Size(132, 148);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(128, 6);
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.refreshToolStripMenuItem1.Text = "Refresh";
            this.refreshToolStripMenuItem1.Click += new System.EventHandler(this.refreshToolStripMenuItem1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(128, 6);
            // 
            // importListToolStripMenuItem
            // 
            this.importListToolStripMenuItem.Name = "importListToolStripMenuItem";
            this.importListToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.importListToolStripMenuItem.Text = "Import List";
            this.importListToolStripMenuItem.Click += new System.EventHandler(this.importListToolStripMenuItem_Click);
            // 
            // exportListToolStripMenuItem
            // 
            this.exportListToolStripMenuItem.Name = "exportListToolStripMenuItem";
            this.exportListToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exportListToolStripMenuItem.Text = "Export List";
            this.exportListToolStripMenuItem.Click += new System.EventHandler(this.exportListToolStripMenuItem_Click);
            // 
            // exportAllToolStripMenuItem
            // 
            this.exportAllToolStripMenuItem.Name = "exportAllToolStripMenuItem";
            this.exportAllToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exportAllToolStripMenuItem.Text = "Export All";
            this.exportAllToolStripMenuItem.Click += new System.EventHandler(this.exportAllToolStripMenuItem_Click);
            // 
            // gameListContext
            // 
            this.gameListContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.toolStripSeparator2,
            this.refreshToolStripMenuItem,
            this.saveListToolStripMenuItem,
            this.toolStripSeparator1,
            this.printListToolStripMenuItem});
            this.gameListContext.Name = "gameListContext";
            this.gameListContext.Size = new System.Drawing.Size(121, 126);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addGameButton_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(117, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // saveListToolStripMenuItem
            // 
            this.saveListToolStripMenuItem.Name = "saveListToolStripMenuItem";
            this.saveListToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.saveListToolStripMenuItem.Text = "Save List";
            this.saveListToolStripMenuItem.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(117, 6);
            // 
            // printListToolStripMenuItem
            // 
            this.printListToolStripMenuItem.Name = "printListToolStripMenuItem";
            this.printListToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.printListToolStripMenuItem.Text = "Print List";
            this.printListToolStripMenuItem.Click += new System.EventHandler(this.printListToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listNameViewer);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(734, 362);
            this.splitContainer1.SplitterDistance = 130;
            this.splitContainer1.TabIndex = 1;
            // 
            // listNameViewer
            // 
            this.listNameViewer.AllColumns.Add(this.listNameViewerCol);
            this.listNameViewer.AllColumns.Add(this.itemCountCol);
            this.listNameViewer.AllowColumnReorder = true;
            this.listNameViewer.AlternateRowBackColor = System.Drawing.Color.Azure;
            this.listNameViewer.BackColor = System.Drawing.Color.LightCyan;
            this.listNameViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listNameViewer.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.listNameViewer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listNameViewerCol,
            this.itemCountCol});
            this.listNameViewer.ContextMenuStrip = this.listNameContext;
            this.listNameViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.listNameViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listNameViewer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listNameViewer.ForeColor = System.Drawing.Color.Black;
            this.listNameViewer.FullRowSelect = true;
            this.listNameViewer.Location = new System.Drawing.Point(0, 35);
            this.listNameViewer.Name = "listNameViewer";
            this.listNameViewer.ShowGroups = false;
            this.listNameViewer.Size = new System.Drawing.Size(130, 239);
            this.listNameViewer.TabIndex = 3;
            this.listNameViewer.UseAlternatingBackColors = true;
            this.listNameViewer.UseCellFormatEvents = true;
            this.listNameViewer.UseCompatibleStateImageBehavior = false;
            this.listNameViewer.UseCustomSelectionColors = true;
            this.listNameViewer.UseHotItem = true;
            this.listNameViewer.UseTranslucentHotItem = true;
            this.listNameViewer.UseTranslucentSelection = true;
            this.listNameViewer.View = System.Windows.Forms.View.Details;
            this.listNameViewer.CellEditFinishing += new BrightIdeasSoftware.CellEditEventHandler(this.listNameViewer_CellEditFinishing);
            this.listNameViewer.CellEditStarting += new BrightIdeasSoftware.CellEditEventHandler(this.listNameViewer_CellEditStarting);
            this.listNameViewer.CellEditValidating += new BrightIdeasSoftware.CellEditEventHandler(this.listNameViewer_CellEditValidating);
            this.listNameViewer.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.ListViewer_FormatCell);
            this.listNameViewer.SelectedIndexChanged += new System.EventHandler(this.listNameViewer_SelectedIndexChanged);
            // 
            // listNameViewerCol
            // 
            this.listNameViewerCol.AspectName = "name";
            this.listNameViewerCol.FillsFreeSpace = true;
            this.listNameViewerCol.Text = "List Name";
            // 
            // itemCountCol
            // 
            this.itemCountCol.AspectName = "itemCount";
            this.itemCountCol.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.itemCountCol.Text = "Items";
            this.itemCountCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.itemCountCol.Width = 45;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 35);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lists";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listAddButton);
            this.groupBox2.Controls.Add(this.listNameBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 88);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add List";
            // 
            // listAddButton
            // 
            this.listAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listAddButton.Location = new System.Drawing.Point(43, 62);
            this.listAddButton.Name = "listAddButton";
            this.listAddButton.Size = new System.Drawing.Size(80, 23);
            this.listAddButton.TabIndex = 2;
            this.listAddButton.Text = "Add";
            this.listAddButton.UseVisualStyleBackColor = true;
            this.listAddButton.Click += new System.EventHandler(this.listAddButton_Click);
            // 
            // listNameBox
            // 
            this.listNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listNameBox.BackColor = System.Drawing.Color.MintCream;
            this.listNameBox.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listNameBox.ForeColor = System.Drawing.Color.Black;
            this.listNameBox.Location = new System.Drawing.Point(6, 34);
            this.listNameBox.Name = "listNameBox";
            this.listNameBox.Size = new System.Drawing.Size(118, 24);
            this.listNameBox.TabIndex = 1;
            this.listNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listNameBox_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "List Name :";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gameListViewer);
            this.splitContainer2.Panel1.Controls.Add(this.panel3);
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gameNoteBox);
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer2.Panel2.Controls.Add(this.panel2);
            this.splitContainer2.Size = new System.Drawing.Size(600, 362);
            this.splitContainer2.SplitterDistance = 250;
            this.splitContainer2.TabIndex = 0;
            // 
            // gameListViewer
            // 
            this.gameListViewer.AllColumns.Add(this.NameCol);
            this.gameListViewer.AllColumns.Add(this.TypeCol);
            this.gameListViewer.AllColumns.Add(this.RatingCol);
            this.gameListViewer.AllowColumnReorder = true;
            this.gameListViewer.AllowDrop = true;
            this.gameListViewer.AlternateRowBackColor = System.Drawing.Color.LightCyan;
            this.gameListViewer.BackColor = System.Drawing.Color.Azure;
            this.gameListViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gameListViewer.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.gameListViewer.CellEditTabChangesRows = true;
            this.gameListViewer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameCol,
            this.TypeCol,
            this.RatingCol});
            this.gameListViewer.ContextMenuStrip = this.gameListContext;
            this.gameListViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.gameListViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameListViewer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameListViewer.ForeColor = System.Drawing.Color.Black;
            this.gameListViewer.FullRowSelect = true;
            this.gameListViewer.Location = new System.Drawing.Point(0, 35);
            this.gameListViewer.Name = "gameListViewer";
            this.gameListViewer.SelectAllOnControlA = false;
            this.gameListViewer.ShowGroups = false;
            this.gameListViewer.ShowItemCountOnGroups = true;
            this.gameListViewer.ShowItemToolTips = true;
            this.gameListViewer.Size = new System.Drawing.Size(250, 291);
            this.gameListViewer.TabIndex = 0;
            this.gameListViewer.UseAlternatingBackColors = true;
            this.gameListViewer.UseCellFormatEvents = true;
            this.gameListViewer.UseCompatibleStateImageBehavior = false;
            this.gameListViewer.UseCustomSelectionColors = true;
            this.gameListViewer.UseHotItem = true;
            this.gameListViewer.UseTranslucentHotItem = true;
            this.gameListViewer.UseTranslucentSelection = true;
            this.gameListViewer.View = System.Windows.Forms.View.Details;
            this.gameListViewer.VirtualMode = true;
            this.gameListViewer.CellEditFinishing += new BrightIdeasSoftware.CellEditEventHandler(this.gameListViewer_CellEditFinishing);
            this.gameListViewer.CellEditStarting += new BrightIdeasSoftware.CellEditEventHandler(this.gameListViewer_CellEditStarting);
            this.gameListViewer.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.ListViewer_FormatCell);
            this.gameListViewer.SelectedIndexChanged += new System.EventHandler(this.gameListViewer_SelectedIndexChanged);
            // 
            // NameCol
            // 
            this.NameCol.AspectName = "Name";
            this.NameCol.Text = "Name";
            this.NameCol.Width = 160;
            // 
            // TypeCol
            // 
            this.TypeCol.AspectName = "Type";
            this.TypeCol.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TypeCol.Text = "Game Type";
            this.TypeCol.Width = 150;
            // 
            // RatingCol
            // 
            this.RatingCol.AspectName = "Rating";
            this.RatingCol.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RatingCol.Text = "Rating";
            this.RatingCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RatingCol.Width = 100;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PowderBlue;
            this.panel3.Controls.Add(this.gameLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 35);
            this.panel3.TabIndex = 2;
            // 
            // gameLabel
            // 
            this.gameLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gameLabel.Location = new System.Drawing.Point(0, 0);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(250, 35);
            this.gameLabel.TabIndex = 1;
            this.gameLabel.Tag = "Games";
            this.gameLabel.Text = "Games";
            this.gameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.addGameButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.removeSelectedButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 326);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 36);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // addGameButton
            // 
            this.addGameButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addGameButton.Image = global::Game_Database.Properties.Resources.add;
            this.addGameButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addGameButton.Location = new System.Drawing.Point(3, 3);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(119, 30);
            this.addGameButton.TabIndex = 4;
            this.addGameButton.Text = "Add Game";
            this.addGameButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addGameButton.UseVisualStyleBackColor = true;
            this.addGameButton.Click += new System.EventHandler(this.addGameButton_Click);
            // 
            // removeSelectedButton
            // 
            this.removeSelectedButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeSelectedButton.Location = new System.Drawing.Point(128, 3);
            this.removeSelectedButton.Name = "removeSelectedButton";
            this.removeSelectedButton.Size = new System.Drawing.Size(119, 30);
            this.removeSelectedButton.TabIndex = 3;
            this.removeSelectedButton.Text = "Remove Selected";
            this.removeSelectedButton.UseVisualStyleBackColor = true;
            this.removeSelectedButton.Click += new System.EventHandler(this.removeSelectedButton_Click);
            // 
            // gameNoteBox
            // 
            this.gameNoteBox.BackColor = System.Drawing.Color.Azure;
            this.gameNoteBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameNoteBox.Html = resources.GetString("gameNoteBox.Html");
            this.gameNoteBox.Location = new System.Drawing.Point(0, 35);
            this.gameNoteBox.Name = "gameNoteBox";
            this.gameNoteBox.ReadOnly = true;
            this.gameNoteBox.ShowToolbar = true;
            this.gameNoteBox.Size = new System.Drawing.Size(346, 291);
            this.gameNoteBox.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.Controls.Add(this.saveButton, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 326);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(346, 36);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.Image = global::Game_Database.Properties.Resources.save;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.Location = new System.Drawing.Point(199, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(144, 30);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.noteLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 35);
            this.panel2.TabIndex = 1;
            // 
            // noteLabel
            // 
            this.noteLabel.BackColor = System.Drawing.Color.Transparent;
            this.noteLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noteLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.noteLabel.Location = new System.Drawing.Point(0, 0);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(346, 35);
            this.noteLabel.TabIndex = 1;
            this.noteLabel.Tag = "Note";
            this.noteLabel.Text = "Note";
            this.noteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(734, 362);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Database";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.listNameContext.ResumeLayout(false);
            this.gameListContext.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listNameViewer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameListViewer)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CustomSplitContainer splitContainer1;
        private System.Windows.Forms.CustomSplitContainer splitContainer2;
        private BrightIdeasSoftware.FastObjectListView gameListViewer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.Label noteLabel;
        private BrightIdeasSoftware.OLVColumn NameCol;
        private BrightIdeasSoftware.OLVColumn RatingCol;
        private BrightIdeasSoftware.OLVColumn TypeCol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button listAddButton;
        private System.Windows.Forms.TextBox listNameBox;
        private System.Windows.Forms.Label label4;
        private BrightIdeasSoftware.ObjectListView listNameViewer;
        private BrightIdeasSoftware.OLVColumn listNameViewerCol;
        private BrightIdeasSoftware.OLVColumn itemCountCol;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addGameButton;
        private System.Windows.Forms.Button removeSelectedButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button saveButton;
        private YARTE.UI.HtmlEditor gameNoteBox;
        private System.Windows.Forms.ContextMenuStrip gameListContext;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printListToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip listNameContext;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exportListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
    }
}

