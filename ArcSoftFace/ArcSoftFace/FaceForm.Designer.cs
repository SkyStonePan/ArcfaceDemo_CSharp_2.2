namespace ArcSoftFace
{
    partial class FaceForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaceForm));
            this.picImageCompare = new System.Windows.Forms.PictureBox();
            this.lblImageList = new System.Windows.Forms.Label();
            this.chooseMultiImgBtn = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.TextBox();
            this.chooseImgBtn = new System.Windows.Forms.Button();
            this.imageLists = new System.Windows.Forms.ImageList(this.components);
            this.imageList = new System.Windows.Forms.ListView();
            this.matchBtn = new System.Windows.Forms.Button();
            this.btnClearFaceList = new System.Windows.Forms.Button();
            this.lblCompareImage = new System.Windows.Forms.Label();
            this.lblCompareInfo = new System.Windows.Forms.Label();
            this.rgbVideoSource = new AForge.Controls.VideoSourcePlayer();
            this.btnStartVideo = new System.Windows.Forms.Button();
            this.txtThreshold = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.irVideoSource = new AForge.Controls.VideoSourcePlayer();
            ((System.ComponentModel.ISupportInitialize)(this.picImageCompare)).BeginInit();
            this.SuspendLayout();
            // 
            // picImageCompare
            // 
            this.picImageCompare.BackColor = System.Drawing.Color.White;
            this.picImageCompare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImageCompare.Location = new System.Drawing.Point(603, 37);
            this.picImageCompare.Name = "picImageCompare";
            this.picImageCompare.Size = new System.Drawing.Size(494, 362);
            this.picImageCompare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picImageCompare.TabIndex = 1;
            this.picImageCompare.TabStop = false;
            // 
            // lblImageList
            // 
            this.lblImageList.AutoSize = true;
            this.lblImageList.Location = new System.Drawing.Point(12, 11);
            this.lblImageList.Name = "lblImageList";
            this.lblImageList.Size = new System.Drawing.Size(47, 12);
            this.lblImageList.TabIndex = 7;
            this.lblImageList.Text = "人脸库:";
            // 
            // chooseMultiImgBtn
            // 
            this.chooseMultiImgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseMultiImgBtn.Location = new System.Drawing.Point(14, 431);
            this.chooseMultiImgBtn.Name = "chooseMultiImgBtn";
            this.chooseMultiImgBtn.Size = new System.Drawing.Size(133, 26);
            this.chooseMultiImgBtn.TabIndex = 32;
            this.chooseMultiImgBtn.Text = "注册人脸";
            this.chooseMultiImgBtn.UseVisualStyleBackColor = true;
            this.chooseMultiImgBtn.Click += new System.EventHandler(this.ChooseMultiImg);
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.Color.White;
            this.logBox.Location = new System.Drawing.Point(14, 477);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(1083, 139);
            this.logBox.TabIndex = 31;
            // 
            // chooseImgBtn
            // 
            this.chooseImgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseImgBtn.Location = new System.Drawing.Point(603, 431);
            this.chooseImgBtn.Name = "chooseImgBtn";
            this.chooseImgBtn.Size = new System.Drawing.Size(109, 26);
            this.chooseImgBtn.TabIndex = 30;
            this.chooseImgBtn.Text = "选择识别图";
            this.chooseImgBtn.UseVisualStyleBackColor = true;
            this.chooseImgBtn.Click += new System.EventHandler(this.ChooseImg);
            // 
            // imageLists
            // 
            this.imageLists.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageLists.ImageStream")));
            this.imageLists.TransparentColor = System.Drawing.Color.Transparent;
            this.imageLists.Images.SetKeyName(0, "alai_152784032385984494.jpg");
            // 
            // imageList
            // 
            this.imageList.LargeImageList = this.imageLists;
            this.imageList.Location = new System.Drawing.Point(14, 37);
            this.imageList.Name = "imageList";
            this.imageList.Size = new System.Drawing.Size(527, 362);
            this.imageList.TabIndex = 33;
            this.imageList.UseCompatibleStateImageBehavior = false;
            // 
            // matchBtn
            // 
            this.matchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.matchBtn.Location = new System.Drawing.Point(748, 431);
            this.matchBtn.Name = "matchBtn";
            this.matchBtn.Size = new System.Drawing.Size(104, 26);
            this.matchBtn.TabIndex = 34;
            this.matchBtn.Text = "开始匹配";
            this.matchBtn.UseVisualStyleBackColor = true;
            this.matchBtn.Click += new System.EventHandler(this.matchBtn_Click);
            // 
            // btnClearFaceList
            // 
            this.btnClearFaceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFaceList.Location = new System.Drawing.Point(416, 431);
            this.btnClearFaceList.Name = "btnClearFaceList";
            this.btnClearFaceList.Size = new System.Drawing.Size(125, 26);
            this.btnClearFaceList.TabIndex = 35;
            this.btnClearFaceList.Text = "清空人脸库";
            this.btnClearFaceList.UseVisualStyleBackColor = true;
            this.btnClearFaceList.Click += new System.EventHandler(this.btnClearFaceList_Click);
            // 
            // lblCompareImage
            // 
            this.lblCompareImage.AutoSize = true;
            this.lblCompareImage.Location = new System.Drawing.Point(601, 11);
            this.lblCompareImage.Name = "lblCompareImage";
            this.lblCompareImage.Size = new System.Drawing.Size(59, 12);
            this.lblCompareImage.TabIndex = 36;
            this.lblCompareImage.Text = "比对人脸:";
            // 
            // lblCompareInfo
            // 
            this.lblCompareInfo.AutoSize = true;
            this.lblCompareInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCompareInfo.Location = new System.Drawing.Point(667, 11);
            this.lblCompareInfo.Name = "lblCompareInfo";
            this.lblCompareInfo.Size = new System.Drawing.Size(0, 16);
            this.lblCompareInfo.TabIndex = 37;
            // 
            // rgbVideoSource
            // 
            this.rgbVideoSource.Location = new System.Drawing.Point(603, 37);
            this.rgbVideoSource.Name = "rgbVideoSource";
            this.rgbVideoSource.Size = new System.Drawing.Size(494, 362);
            this.rgbVideoSource.TabIndex = 38;
            this.rgbVideoSource.Text = "videoSource";
            this.rgbVideoSource.VideoSource = null;
            this.rgbVideoSource.PlayingFinished += new AForge.Video.PlayingFinishedEventHandler(this.videoSource_PlayingFinished);
            this.rgbVideoSource.Paint += new System.Windows.Forms.PaintEventHandler(this.videoSource_Paint);
            // 
            // btnStartVideo
            // 
            this.btnStartVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartVideo.Location = new System.Drawing.Point(883, 431);
            this.btnStartVideo.Name = "btnStartVideo";
            this.btnStartVideo.Size = new System.Drawing.Size(107, 26);
            this.btnStartVideo.TabIndex = 39;
            this.btnStartVideo.Text = "启用摄像头";
            this.btnStartVideo.UseVisualStyleBackColor = true;
            this.btnStartVideo.Click += new System.EventHandler(this.btnStartVideo_Click);
            // 
            // txtThreshold
            // 
            this.txtThreshold.BackColor = System.Drawing.SystemColors.Window;
            this.txtThreshold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThreshold.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtThreshold.Location = new System.Drawing.Point(1037, 431);
            this.txtThreshold.Name = "txtThreshold";
            this.txtThreshold.Size = new System.Drawing.Size(60, 25);
            this.txtThreshold.TabIndex = 40;
            this.txtThreshold.Text = "0.8";
            this.txtThreshold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThreshold_KeyPress);
            this.txtThreshold.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtThreshold_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(996, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 41;
            this.label1.Text = "阈值：";
            // 
            // irVideoSource
            // 
            this.irVideoSource.BackColor = System.Drawing.SystemColors.Control;
            this.irVideoSource.Location = new System.Drawing.Point(957, 37);
            this.irVideoSource.Name = "irVideoSource";
            this.irVideoSource.Size = new System.Drawing.Size(140, 107);
            this.irVideoSource.TabIndex = 38;
            this.irVideoSource.Text = "videoSource";
            this.irVideoSource.VideoSource = null;
            this.irVideoSource.Visible = false;
            this.irVideoSource.PlayingFinished += new AForge.Video.PlayingFinishedEventHandler(this.videoSource_PlayingFinished);
            this.irVideoSource.Paint += new System.Windows.Forms.PaintEventHandler(this.irVideoSource_Paint);
            // 
            // FaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 633);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtThreshold);
            this.Controls.Add(this.btnStartVideo);
            this.Controls.Add(this.irVideoSource);
            this.Controls.Add(this.rgbVideoSource);
            this.Controls.Add(this.lblCompareInfo);
            this.Controls.Add(this.lblCompareImage);
            this.Controls.Add(this.btnClearFaceList);
            this.Controls.Add(this.matchBtn);
            this.Controls.Add(this.imageList);
            this.Controls.Add(this.chooseMultiImgBtn);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.chooseImgBtn);
            this.Controls.Add(this.lblImageList);
            this.Controls.Add(this.picImageCompare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArcSoftFace C# demo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.picImageCompare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImageCompare;
        private System.Windows.Forms.Label lblImageList;
        private System.Windows.Forms.Button chooseMultiImgBtn;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Button chooseImgBtn;
        private System.Windows.Forms.ImageList imageLists;
        private System.Windows.Forms.ListView imageList;
        private System.Windows.Forms.Button matchBtn;
        private System.Windows.Forms.Button btnClearFaceList;
        private System.Windows.Forms.Label lblCompareImage;
        private System.Windows.Forms.Label lblCompareInfo;
        private AForge.Controls.VideoSourcePlayer rgbVideoSource;
        private System.Windows.Forms.Button btnStartVideo;
        private System.Windows.Forms.TextBox txtThreshold;
        private System.Windows.Forms.Label label1;
        private AForge.Controls.VideoSourcePlayer irVideoSource;
    }
}

