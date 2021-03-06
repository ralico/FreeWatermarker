﻿namespace FreeWatermarker
{
    partial class frmWatermark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWatermark));
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpenImages = new System.Windows.Forms.Button();
            this.btnSaveImages = new System.Windows.Forms.Button();
            this.gridImages = new System.Windows.Forms.DataGridView();
            this.ColumnImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelWMImage = new System.Windows.Forms.Panel();
            this.nudRows = new System.Windows.Forms.NumericUpDown();
            this.panelPosition = new System.Windows.Forms.Panel();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.pbWatermark = new System.Windows.Forms.PictureBox();
            this.nudColumns = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblColumns = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudOffSetX = new System.Windows.Forms.NumericUpDown();
            this.nudTransparency = new System.Windows.Forms.NumericUpDown();
            this.lblWMTransparentColor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnViewWaterMark = new System.Windows.Forms.Button();
            this.nudOffSetY = new System.Windows.Forms.NumericUpDown();
            this.btnColorPicker = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnOpenWaterMark = new System.Windows.Forms.Button();
            this.btnRemoveImageWaterMark = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmsImages = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClearSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.removeSelectedImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTransparentColor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmSelectColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRemoveColor = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelWMImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).BeginInit();
            this.panelPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWatermark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffSetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTransparency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffSetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.cmsImages.SuspendLayout();
            this.cmsTransparentColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBar
            // 
            this.pBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBar.Location = new System.Drawing.Point(400, 433);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(135, 19);
            this.pBar.TabIndex = 0;
            this.pBar.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.gridImages);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel1MinSize = 160;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel2MinSize = 300;
            this.splitContainer1.Size = new System.Drawing.Size(632, 428);
            this.splitContainer1.SplitterDistance = 160;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOpenImages);
            this.panel1.Controls.Add(this.btnSaveImages);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 33);
            this.panel1.TabIndex = 1;
            // 
            // btnOpenImages
            // 
            this.btnOpenImages.BackgroundImage = global::FreeWatermarker.Properties.Resources.Open32x32;
            this.btnOpenImages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenImages.Location = new System.Drawing.Point(1, 1);
            this.btnOpenImages.Name = "btnOpenImages";
            this.btnOpenImages.Size = new System.Drawing.Size(30, 30);
            this.btnOpenImages.TabIndex = 4;
            this.btnOpenImages.UseVisualStyleBackColor = true;
            this.btnOpenImages.Click += new System.EventHandler(this.btnOpenImages_Click);
            // 
            // btnSaveImages
            // 
            this.btnSaveImages.BackgroundImage = global::FreeWatermarker.Properties.Resources.Save32x32;
            this.btnSaveImages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveImages.Location = new System.Drawing.Point(130, 1);
            this.btnSaveImages.Name = "btnSaveImages";
            this.btnSaveImages.Size = new System.Drawing.Size(30, 30);
            this.btnSaveImages.TabIndex = 5;
            this.btnSaveImages.UseVisualStyleBackColor = true;
            this.btnSaveImages.Click += new System.EventHandler(this.btnSaveImages_Click);
            // 
            // gridImages
            // 
            this.gridImages.AllowUserToAddRows = false;
            this.gridImages.AllowUserToResizeColumns = false;
            this.gridImages.AllowUserToResizeRows = false;
            this.gridImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridImages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridImages.ColumnHeadersVisible = false;
            this.gridImages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnImg,
            this.ColumnDesc});
            this.gridImages.Location = new System.Drawing.Point(0, 33);
            this.gridImages.Name = "gridImages";
            this.gridImages.ReadOnly = true;
            this.gridImages.RowHeadersVisible = false;
            this.gridImages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridImages.Size = new System.Drawing.Size(160, 395);
            this.gridImages.TabIndex = 0;
            this.gridImages.SelectionChanged += new System.EventHandler(this.gridImages_SelectionChanged);
            this.gridImages.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.gridImages_UserDeletingRow);
            this.gridImages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridImages_MouseClick);
            // 
            // ColumnImg
            // 
            this.ColumnImg.HeaderText = "Image";
            this.ColumnImg.Name = "ColumnImg";
            this.ColumnImg.ReadOnly = true;
            // 
            // ColumnDesc
            // 
            this.ColumnDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.ColumnDesc.HeaderText = "Description";
            this.ColumnDesc.Name = "ColumnDesc";
            this.ColumnDesc.ReadOnly = true;
            this.ColumnDesc.Width = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.pbImage);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Size = new System.Drawing.Size(468, 428);
            this.splitContainer2.SplitterDistance = 150;
            this.splitContainer2.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(466, 148);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelWMImage);
            this.tabPage1.Controls.Add(this.btnAbout);
            this.tabPage1.Controls.Add(this.btnOpenWaterMark);
            this.tabPage1.Controls.Add(this.btnRemoveImageWaterMark);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(458, 122);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Image";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelWMImage
            // 
            this.panelWMImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelWMImage.Controls.Add(this.nudRows);
            this.panelWMImage.Controls.Add(this.panelPosition);
            this.panelWMImage.Controls.Add(this.lblRows);
            this.panelWMImage.Controls.Add(this.pbWatermark);
            this.panelWMImage.Controls.Add(this.nudColumns);
            this.panelWMImage.Controls.Add(this.label2);
            this.panelWMImage.Controls.Add(this.lblColumns);
            this.panelWMImage.Controls.Add(this.label3);
            this.panelWMImage.Controls.Add(this.nudOffSetX);
            this.panelWMImage.Controls.Add(this.nudTransparency);
            this.panelWMImage.Controls.Add(this.lblWMTransparentColor);
            this.panelWMImage.Controls.Add(this.label4);
            this.panelWMImage.Controls.Add(this.btnViewWaterMark);
            this.panelWMImage.Controls.Add(this.nudOffSetY);
            this.panelWMImage.Controls.Add(this.btnColorPicker);
            this.panelWMImage.Location = new System.Drawing.Point(2, 0);
            this.panelWMImage.Name = "panelWMImage";
            this.panelWMImage.Size = new System.Drawing.Size(426, 126);
            this.panelWMImage.TabIndex = 1;
            // 
            // nudRows
            // 
            this.nudRows.Enabled = false;
            this.nudRows.Location = new System.Drawing.Point(86, 97);
            this.nudRows.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRows.Name = "nudRows";
            this.nudRows.Size = new System.Drawing.Size(42, 20);
            this.nudRows.TabIndex = 26;
            this.nudRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRows.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // panelPosition
            // 
            this.panelPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPosition.Controls.Add(this.checkBox13);
            this.panelPosition.Controls.Add(this.checkBox12);
            this.panelPosition.Controls.Add(this.checkBox11);
            this.panelPosition.Controls.Add(this.checkBox10);
            this.panelPosition.Controls.Add(this.checkBox9);
            this.panelPosition.Controls.Add(this.checkBox8);
            this.panelPosition.Controls.Add(this.checkBox7);
            this.panelPosition.Controls.Add(this.checkBox6);
            this.panelPosition.Controls.Add(this.checkBox5);
            this.panelPosition.Controls.Add(this.checkBox3);
            this.panelPosition.Controls.Add(this.checkBox2);
            this.panelPosition.Controls.Add(this.checkBox1);
            this.panelPosition.Controls.Add(this.checkBox4);
            this.panelPosition.Controls.Add(this.label1);
            this.panelPosition.Location = new System.Drawing.Point(131, 2);
            this.panelPosition.Name = "panelPosition";
            this.panelPosition.Size = new System.Drawing.Size(130, 119);
            this.panelPosition.TabIndex = 13;
            // 
            // checkBox13
            // 
            this.checkBox13.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox13.BackgroundImage = global::FreeWatermarker.Properties.Resources.WMRepeat32x32;
            this.checkBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox13.Location = new System.Drawing.Point(2, 88);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(30, 30);
            this.checkBox13.TabIndex = 29;
            this.checkBox13.Tag = "12";
            this.checkBox13.UseVisualStyleBackColor = true;
            this.checkBox13.Click += new System.EventHandler(this.checkBoxPosition_Click);
            // 
            // checkBox12
            // 
            this.checkBox12.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox12.BackgroundImage = global::FreeWatermarker.Properties.Resources.WMFill32x32;
            this.checkBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox12.Location = new System.Drawing.Point(2, 59);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(30, 30);
            this.checkBox12.TabIndex = 28;
            this.checkBox12.Tag = "11";
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox12.Click += new System.EventHandler(this.checkBoxPosition_Click);
            // 
            // checkBox11
            // 
            this.checkBox11.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox11.BackgroundImage = global::FreeWatermarker.Properties.Resources.WMZoomed32x32;
            this.checkBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox11.Location = new System.Drawing.Point(2, 30);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(30, 30);
            this.checkBox11.TabIndex = 27;
            this.checkBox11.Tag = "10";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.Click += new System.EventHandler(this.checkBoxPosition_Click);
            // 
            // checkBox10
            // 
            this.checkBox10.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox10.BackgroundImage = global::FreeWatermarker.Properties.Resources.WMAjusted32x32;
            this.checkBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox10.Location = new System.Drawing.Point(2, 1);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(30, 30);
            this.checkBox10.TabIndex = 26;
            this.checkBox10.Tag = "9";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.Click += new System.EventHandler(this.checkBoxPosition_Click);
            // 
            // checkBox9
            // 
            this.checkBox9.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox9.Location = new System.Drawing.Point(96, 83);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(30, 30);
            this.checkBox9.TabIndex = 25;
            this.checkBox9.Tag = "8";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.Click += new System.EventHandler(this.checkBoxPosition_Click);
            // 
            // checkBox8
            // 
            this.checkBox8.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox8.Location = new System.Drawing.Point(65, 83);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(30, 30);
            this.checkBox8.TabIndex = 24;
            this.checkBox8.Tag = "7";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.Click += new System.EventHandler(this.checkBoxPosition_Click);
            // 
            // checkBox7
            // 
            this.checkBox7.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox7.Location = new System.Drawing.Point(34, 83);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(30, 30);
            this.checkBox7.TabIndex = 23;
            this.checkBox7.Tag = "6";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.Click += new System.EventHandler(this.checkBoxPosition_Click);
            // 
            // checkBox6
            // 
            this.checkBox6.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox6.Location = new System.Drawing.Point(96, 52);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(30, 30);
            this.checkBox6.TabIndex = 22;
            this.checkBox6.Tag = "5";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.Click += new System.EventHandler(this.checkBoxPosition_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox5.Location = new System.Drawing.Point(65, 52);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(30, 30);
            this.checkBox5.TabIndex = 21;
            this.checkBox5.Tag = "4";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.Click += new System.EventHandler(this.checkBoxPosition_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.Location = new System.Drawing.Point(96, 21);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(30, 30);
            this.checkBox3.TabIndex = 20;
            this.checkBox3.Tag = "2";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Click += new System.EventHandler(this.checkBoxPosition_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.Location = new System.Drawing.Point(65, 21);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(30, 30);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Tag = "1";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.checkBoxPosition_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.Location = new System.Drawing.Point(34, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(30, 30);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Tag = "0";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBoxPosition_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox4.Location = new System.Drawing.Point(34, 52);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(30, 30);
            this.checkBox4.TabIndex = 17;
            this.checkBox4.Tag = "3";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Click += new System.EventHandler(this.checkBoxPosition_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(34, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 11);
            this.label1.TabIndex = 5;
            this.label1.Text = "Position";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Enabled = false;
            this.lblRows.Location = new System.Drawing.Point(51, 101);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(34, 13);
            this.lblRows.TabIndex = 27;
            this.lblRows.Text = "Rows";
            // 
            // pbWatermark
            // 
            this.pbWatermark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbWatermark.Location = new System.Drawing.Point(263, 2);
            this.pbWatermark.Name = "pbWatermark";
            this.pbWatermark.Size = new System.Drawing.Size(160, 90);
            this.pbWatermark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWatermark.TabIndex = 7;
            this.pbWatermark.TabStop = false;
            this.pbWatermark.DoubleClick += new System.EventHandler(this.pbWatermark_DoubleClick);
            // 
            // nudColumns
            // 
            this.nudColumns.Enabled = false;
            this.nudColumns.Location = new System.Drawing.Point(86, 76);
            this.nudColumns.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudColumns.Name = "nudColumns";
            this.nudColumns.Size = new System.Drawing.Size(42, 20);
            this.nudColumns.TabIndex = 24;
            this.nudColumns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudColumns.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "OffSet X %";
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Enabled = false;
            this.lblColumns.Location = new System.Drawing.Point(38, 78);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(47, 13);
            this.lblColumns.TabIndex = 25;
            this.lblColumns.Text = "Columns";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Transparency %";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudOffSetX
            // 
            this.nudOffSetX.Location = new System.Drawing.Point(86, 27);
            this.nudOffSetX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudOffSetX.Name = "nudOffSetX";
            this.nudOffSetX.Size = new System.Drawing.Size(42, 20);
            this.nudOffSetX.TabIndex = 14;
            this.nudOffSetX.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // nudTransparency
            // 
            this.nudTransparency.Location = new System.Drawing.Point(86, 6);
            this.nudTransparency.Name = "nudTransparency";
            this.nudTransparency.Size = new System.Drawing.Size(42, 20);
            this.nudTransparency.TabIndex = 16;
            this.nudTransparency.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudTransparency.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // lblWMTransparentColor
            // 
            this.lblWMTransparentColor.BackColor = System.Drawing.Color.White;
            this.lblWMTransparentColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWMTransparentColor.Location = new System.Drawing.Point(263, 93);
            this.lblWMTransparentColor.Name = "lblWMTransparentColor";
            this.lblWMTransparentColor.Size = new System.Drawing.Size(28, 28);
            this.lblWMTransparentColor.TabIndex = 12;
            this.lblWMTransparentColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWMTransparentColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblWMTransparentColor_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "OffSet Y %";
            // 
            // btnViewWaterMark
            // 
            this.btnViewWaterMark.BackgroundImage = global::FreeWatermarker.Properties.Resources.Preview32x32;
            this.btnViewWaterMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewWaterMark.Location = new System.Drawing.Point(323, 92);
            this.btnViewWaterMark.Name = "btnViewWaterMark";
            this.btnViewWaterMark.Size = new System.Drawing.Size(30, 30);
            this.btnViewWaterMark.TabIndex = 8;
            this.btnViewWaterMark.UseVisualStyleBackColor = true;
            this.btnViewWaterMark.Click += new System.EventHandler(this.btnViewWaterMark_Click);
            // 
            // nudOffSetY
            // 
            this.nudOffSetY.Location = new System.Drawing.Point(86, 48);
            this.nudOffSetY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudOffSetY.Name = "nudOffSetY";
            this.nudOffSetY.Size = new System.Drawing.Size(42, 20);
            this.nudOffSetY.TabIndex = 18;
            this.nudOffSetY.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // btnColorPicker
            // 
            this.btnColorPicker.BackgroundImage = global::FreeWatermarker.Properties.Resources.ColorPicker32x32;
            this.btnColorPicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnColorPicker.Location = new System.Drawing.Point(290, 92);
            this.btnColorPicker.Name = "btnColorPicker";
            this.btnColorPicker.Size = new System.Drawing.Size(30, 30);
            this.btnColorPicker.TabIndex = 11;
            this.btnColorPicker.UseVisualStyleBackColor = true;
            this.btnColorPicker.Visible = false;
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAbout.BackgroundImage = global::FreeWatermarker.Properties.Resources.Info32x32;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbout.Location = new System.Drawing.Point(427, 91);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(30, 30);
            this.btnAbout.TabIndex = 20;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnOpenWaterMark
            // 
            this.btnOpenWaterMark.BackgroundImage = global::FreeWatermarker.Properties.Resources.Open32x32;
            this.btnOpenWaterMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenWaterMark.Location = new System.Drawing.Point(427, 1);
            this.btnOpenWaterMark.Name = "btnOpenWaterMark";
            this.btnOpenWaterMark.Size = new System.Drawing.Size(30, 30);
            this.btnOpenWaterMark.TabIndex = 9;
            this.btnOpenWaterMark.UseVisualStyleBackColor = true;
            this.btnOpenWaterMark.Click += new System.EventHandler(this.btnOpenWaterMark_Click);
            // 
            // btnRemoveImageWaterMark
            // 
            this.btnRemoveImageWaterMark.BackgroundImage = global::FreeWatermarker.Properties.Resources.Cancel32x32;
            this.btnRemoveImageWaterMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveImageWaterMark.Location = new System.Drawing.Point(427, 33);
            this.btnRemoveImageWaterMark.Name = "btnRemoveImageWaterMark";
            this.btnRemoveImageWaterMark.Size = new System.Drawing.Size(30, 30);
            this.btnRemoveImageWaterMark.TabIndex = 23;
            this.btnRemoveImageWaterMark.UseVisualStyleBackColor = true;
            this.btnRemoveImageWaterMark.Click += new System.EventHandler(this.btnRemoveImageWaterMark_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(458, 122);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Text";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pbImage
            // 
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(466, 272);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.DoubleClick += new System.EventHandler(this.pbImage_DoubleClick);
            this.pbImage.MouseEnter += new System.EventHandler(this.pbImage_MouseEnter);
            this.pbImage.MouseLeave += new System.EventHandler(this.pbImage_MouseLeave);
            // 
            // ssStatus
            // 
            this.ssStatus.Location = new System.Drawing.Point(0, 431);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(632, 22);
            this.ssStatus.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(539, 433);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 19);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            // 
            // cmsImages
            // 
            this.cmsImages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSelectAll,
            this.tsmClearSelection,
            this.toolStripSeparator1,
            this.removeSelectedImagesToolStripMenuItem});
            this.cmsImages.Name = "cmsMenu";
            this.cmsImages.Size = new System.Drawing.Size(194, 76);
            // 
            // tsmSelectAll
            // 
            this.tsmSelectAll.Name = "tsmSelectAll";
            this.tsmSelectAll.Size = new System.Drawing.Size(193, 22);
            this.tsmSelectAll.Text = "Select all";
            this.tsmSelectAll.Click += new System.EventHandler(this.selecionarTodasToolStripMenuItem_Click);
            // 
            // tsmClearSelection
            // 
            this.tsmClearSelection.Name = "tsmClearSelection";
            this.tsmClearSelection.Size = new System.Drawing.Size(193, 22);
            this.tsmClearSelection.Text = "Clear selection";
            this.tsmClearSelection.Click += new System.EventHandler(this.limparSeleçãoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // removeSelectedImagesToolStripMenuItem
            // 
            this.removeSelectedImagesToolStripMenuItem.Name = "removeSelectedImagesToolStripMenuItem";
            this.removeSelectedImagesToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.removeSelectedImagesToolStripMenuItem.Text = "Remove selected images";
            this.removeSelectedImagesToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedImagesToolStripMenuItem_Click);
            // 
            // cmsTransparentColor
            // 
            this.cmsTransparentColor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSelectColor,
            this.tsmRemoveColor});
            this.cmsTransparentColor.Name = "cmsMenu";
            this.cmsTransparentColor.Size = new System.Drawing.Size(142, 48);
            // 
            // tsmSelectColor
            // 
            this.tsmSelectColor.Name = "tsmSelectColor";
            this.tsmSelectColor.Size = new System.Drawing.Size(141, 22);
            this.tsmSelectColor.Text = "Select Color";
            this.tsmSelectColor.Click += new System.EventHandler(this.tsmSelectColor_Click);
            // 
            // tsmRemoveColor
            // 
            this.tsmRemoveColor.Name = "tsmRemoveColor";
            this.tsmRemoveColor.Size = new System.Drawing.Size(141, 22);
            this.tsmRemoveColor.Text = "Remove Color";
            this.tsmRemoveColor.Click += new System.EventHandler(this.tsmRemoveColor_Click);
            // 
            // frmWatermark
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 360);
            this.Name = "frmWatermark";
            this.Text = "Free Watermarker";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmWatermark_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmWatermark_DragEnter);
            this.DragLeave += new System.EventHandler(this.frmWatermark_DragLeave);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridImages)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelWMImage.ResumeLayout(false);
            this.panelWMImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).EndInit();
            this.panelPosition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbWatermark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffSetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTransparency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffSetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.cmsImages.ResumeLayout(false);
            this.cmsTransparentColor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnOpenImages;
        private System.Windows.Forms.Button btnSaveImages;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.ContextMenuStrip cmsImages;
        private System.Windows.Forms.ToolStripMenuItem tsmSelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmClearSelection;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.PictureBox pbWatermark;
        private System.Windows.Forms.DataGridView gridImages;
        private System.Windows.Forms.DataGridViewImageColumn ColumnImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDesc;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnOpenWaterMark;
        private System.Windows.Forms.Button btnViewWaterMark;
        private System.Windows.Forms.Label lblWMTransparentColor;
        private System.Windows.Forms.Button btnColorPicker;
        private System.Windows.Forms.ContextMenuStrip cmsTransparentColor;
        private System.Windows.Forms.ToolStripMenuItem tsmSelectColor;
        private System.Windows.Forms.ToolStripMenuItem tsmRemoveColor;
        private System.Windows.Forms.Panel panelPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudOffSetX;
        private System.Windows.Forms.NumericUpDown nudTransparency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown nudOffSetY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemoveImageWaterMark;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.NumericUpDown nudRows;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.NumericUpDown nudColumns;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.Panel panelWMImage;
    }
}

