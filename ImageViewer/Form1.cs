﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    
    public partial class Form1 : Form
    {
        int ImgCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.picImg.Image = this.imgList.Images[ImgCount];
            this.lblNum.Text = (this.ImgCount + 1)+"/"+this.imgList.Images.Count;

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            this.ImgCount++;
            if(this.ImgCount>=this.imgList.Images.Count)
            {
                this.ImgCount = 0;
            }
            this.picImg.Image = this.imgList.Images[ImgCount];
            this.lblNum.Text = (this.ImgCount + 1) + "/" + this.imgList.Images.Count;
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            this.ImgCount++;
            if (this.ImgCount <0)
            {
                this.ImgCount = this.imgList.Images.Count-1;
            }
            this.picImg.Image = this.imgList.Images[ImgCount];
            this.lblNum.Text = (this.ImgCount + 1) + "/" + this.imgList.Images.Count;

        }
    }
}
