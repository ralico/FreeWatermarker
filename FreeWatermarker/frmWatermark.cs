﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FreeWatermarker
{
    public partial class frmWatermark : Form
    {
        clsImageWaterMark imgWM;
        clsWaterMarker WaterMark;
        public List<clsImageItem> images;
        int previusSelected;

        public frmWatermark()
        {
            InitializeComponent();

            imgWM = new clsImageWaterMark();
            WaterMark = new clsWaterMarker();
            images = new List<clsImageItem>();

            previusSelected = -1;
            imgWM.HasTransparentColor = true;
            imgWM.TransparentColor = Color.White;
            imgWM.Alignment = ContentAlignment.MiddleCenter;
            checkBox5.Checked = true;
            nudTransparency.Value = 50;

            loadImages(new string[] { "..\\..\\..\\..\\1.jpg", "..\\..\\..\\..\\2.jpg", "..\\..\\..\\..\\3.jpg", "..\\..\\..\\..\\4.jpg" });
            LoadWaterMark("..\\..\\Images\\watermark.bmp");

            this.pbWatermark.AllowDrop = true;
            this.pbWatermark.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbWatermark_DragEnter);
            this.pbWatermark.DragLeave += new System.EventHandler(this.pbWatermark_DragLeave);
            this.pbWatermark.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbWatermark_DragDrop);
        }

        private void loadImages(string[] files)
        {
            if (files != null)
            {
                int index;
                gridImages.Enabled = false;

                foreach (string file in files)
                {
                    try
                    {
                        index = images.Count;
                    
                        images.Add(new clsImageItem(file));

                        gridImages.Rows.Add();
                        gridImages.Rows[index].Height = 100;
                        gridImages.Rows[index].Cells[0].Value = images[index].ResizeToFill(95);
                        gridImages.Rows[index].Cells[1].Value = images[index].Description();
                        gridImages.Enabled = true;                        	
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("There is a problem reading this image: " + file, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                gridImages.Enabled = true;
                gridImages.AutoResizeColumn(1);
            }
        }

        private void btnOpenImages_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdOpen = new OpenFileDialog();
            ofdOpen.Filter = "Imagens|*.bmp;*.jpg;*.png|Imagens Bitmap|*.bmp|Imagens jpg|*.jpg|Imagens png|*.png";
            ofdOpen.Multiselect = true;
            ofdOpen.Title = "Open original images";

            if (ofdOpen.ShowDialog() == DialogResult.OK)
            {
                loadImages(ofdOpen.FileNames);
            }
        }

        private void btnSaveImages_Click(object sender, EventArgs e)
        {
            frmSave f = new frmSave(ref images, WaterMark);
            f.ShowDialog();
            f.Dispose();
        }

        private void selecionarTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
                gridImages.SelectAll();
        }

        private void limparSeleçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridImages.ClearSelection();
        }

        private void pbImage_MouseEnter(object sender, EventArgs e)
        {
            lblStatus.Text = "Double click to preview in full screen";
        }

        private void pbImage_MouseLeave(object sender, EventArgs e)
        {
            lblStatus.Text = "";
        }

        private void pbImage_DoubleClick(object sender, EventArgs e)
        {
            frmPreview f = new frmPreview(pbImage.Image);
            f.ShowDialog(this);
            f.Dispose();
        }

        private void frmWatermark_DragLeave(object sender, EventArgs e)
        {
            pbWatermark.BorderStyle = BorderStyle.FixedSingle;
            gridImages.BorderStyle = BorderStyle.None;
        }

        private void frmWatermark_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            pbWatermark.BorderStyle = BorderStyle.FixedSingle;
            gridImages.BorderStyle = BorderStyle.FixedSingle;
        }

        private void frmWatermark_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            loadImages(files);
        }

        private void pbWatermark_DragLeave(object sender, EventArgs e)
        {
            //this.Cursor = Cursors.Default;
            pbWatermark.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbWatermark_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            //this.Cursor = Cursors.Hand;
            pbWatermark.BorderStyle = BorderStyle.Fixed3D;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            //((string[])e.Data.GetData(DataFormats.FileDrop)).Count()
        }

        private void pbWatermark_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            LoadWaterMark(files[0]);
        }

        private void gridImages_SelectionChanged(object sender, EventArgs e)
        {
            SelectImageFromGrid();
        }

        private void SelectImageFromGrid()
        {
            if (gridImages.SelectedCells.Count > 0)
            {
                SelectImage(gridImages.SelectedCells[0].RowIndex);
            }
            else
            {
                SelectImage(-1);
            }        
        }

        private void SelectImage(int index)
        {
            if (index < 0 || images.Count == 0)
            {
                pbImage.Image = null;
            }
            else
            {
                if (index != previusSelected)
                {
                    if (images[index].WaterMarks.Count <= 0)
                    {
                        images[index].WaterMarks.Add(imgWM.Clone());
                        WaterMark.CreateWaterMark(images[index]);
                    }
                    else if(images[index].WaterMarks[0] != imgWM)
                    {
                        images[index].WaterMarks[0] = imgWM.Clone();
                        WaterMark.CreateWaterMark(images[index]);
                    }
                    pbImage.Image = WaterMark.insertWaterMark(images[index]);
                }
            }
        }

        private void gridImages_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (!deleteImage(e.Row.Index))
            {
                e.Cancel = true;
            }
        }

        private bool deleteImage(int index)
        {
            try
            {
                images.RemoveAt(index);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void gridImages_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                cmsImages.Show(gridImages, e.X, e.Y);
            }
        }

        private void removeSelectedImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in gridImages.SelectedRows)
            {
                deleteImage(r.Index);
                gridImages.Rows.Remove(r);
            }
        }

        private void btnOpenWaterMark_Click(object sender, EventArgs e)
        {
            OpeWaterMark();
        }

        private void pbWatermark_DoubleClick(object sender, EventArgs e)
        {
            OpeWaterMark();
        }

        private void OpeWaterMark()
        {
            OpenFileDialog ofdOpen = new OpenFileDialog();
            ofdOpen.Filter = "Imagens|*.bmp;*.jpg;*.png|Imagens Bitmap|*.bmp|Imagens jpg|*.jpg|Imagens png|*.png";
            ofdOpen.Multiselect = false;
            ofdOpen.Title = "Open Watermark";

            if (ofdOpen.ShowDialog() == DialogResult.OK)
            {
                LoadWaterMark(ofdOpen.FileName);
            }
        }

        private void LoadWaterMark(string FileName)
        {
            try
            {
                imgWM.ImgWaterMark = new Bitmap(FileName);
                pbWatermark.Image = imgWM.ImgWaterMark;
            }
            catch (Exception)
            {
                MessageBox.Show("There is a problem reading the watermark image: " + FileName, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewWaterMark_Click(object sender, EventArgs e)
        {
            frmPreview f = new frmPreview(imgWM.ImgWaterMark);
            f.ShowDialog(this);
            f.Dispose();
        }

        private void SelectWMTransparentColor()
        {           
            ColorDialog cdSelectColor = new System.Windows.Forms.ColorDialog();
            DialogResult res = cdSelectColor.ShowDialog();
            if (res == DialogResult.OK)
            {
                imgWM.HasTransparentColor = true;
                imgWM.TransparentColor = cdSelectColor.Color;
                lblWMTransparentColor.BackColor = cdSelectColor.Color;
                SelectImageFromGrid();
            }
        }

        private void lblWMTransparentColor_MouseDown(object sender, MouseEventArgs e)
        {
            cmsTransparentColor.Show(lblWMTransparentColor, e.X, e.Y);
        }

        private void tsmSelectColor_Click(object sender, EventArgs e)
        {
            SelectWMTransparentColor();
        }

        private void tsmRemoveColor_Click(object sender, EventArgs e)
        {
            imgWM.HasTransparentColor = false;
            lblWMTransparentColor.BackColor = SystemColors.InactiveCaption;
            lblWMTransparentColor.Text = "N";
            SelectImageFromGrid();
        }

        private void checkBoxPosition_Click(object sender, EventArgs e)
        {
            foreach (object obj in panelPosition.Controls)
            {
                if (obj.GetType() == typeof(CheckBox))
                {
                    CheckBox ck = (CheckBox)obj;
                    ck.Checked = ck == (CheckBox)sender;
                    if (ck.Checked)
                    {
                        imgWM.Alignment = (ContentAlignment)(int.Parse(((CheckBox)sender).Tag.ToString()));
                        SelectImageFromGrid();
                    }
                }
            }
        }

        private void nudTransparency_ValueChanged(object sender, EventArgs e)
        {
            imgWM.Transparency = (int)nudTransparency.Value;
            SelectImageFromGrid();
        }

        private void nudOffSetX_ValueChanged(object sender, EventArgs e)
        {
            imgWM.OffSet.Width = (int)nudOffSetX.Value;
            SelectImageFromGrid();
        }

        private void nudOffSetY_ValueChanged(object sender, EventArgs e)
        {
            imgWM.OffSet.Height = (int)nudOffSetY.Value;
            SelectImageFromGrid();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout f = new frmAbout();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < images.Count; x++)
            {
                images[x].WaterMarkerApplied = true;
                if (images[x].WaterMarks.Count == 0)
                {
                    images[x].WaterMarks.Add(imgWM.Clone());
                }
                else
                {
                    images[x].WaterMarks[0] = imgWM.Clone();
                }
            }
            clsBatchWaterMarker WMBatch = new clsBatchWaterMarker(ref images);
            WMBatch.WaterMark();
        }
    }
}
