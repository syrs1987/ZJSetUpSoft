namespace WFRead
{
    partial class ElecForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElecForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btn_cf = new System.Windows.Forms.Button();
            this.btn_setup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.btn_SetIP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Site = new System.Windows.Forms.TextBox();
            this.btn_Site = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_DNS = new System.Windows.Forms.TextBox();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.tree_file = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(104, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件夹路径";
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.SystemColors.Info;
            this.txtFilePath.Location = new System.Drawing.Point(203, 20);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(362, 21);
            this.txtFilePath.TabIndex = 1;
            // 
            // btn_cf
            // 
            this.btn_cf.BackColor = System.Drawing.Color.Transparent;
            this.btn_cf.Location = new System.Drawing.Point(605, 19);
            this.btn_cf.Name = "btn_cf";
            this.btn_cf.Size = new System.Drawing.Size(84, 21);
            this.btn_cf.TabIndex = 2;
            this.btn_cf.Text = "选择文件";
            this.btn_cf.UseVisualStyleBackColor = false;
            this.btn_cf.Click += new System.EventHandler(this.btn_cf_Click);
            // 
            // btn_setup
            // 
            this.btn_setup.BackColor = System.Drawing.Color.Transparent;
            this.btn_setup.Location = new System.Drawing.Point(736, 20);
            this.btn_setup.Name = "btn_setup";
            this.btn_setup.Size = new System.Drawing.Size(95, 21);
            this.btn_setup.TabIndex = 4;
            this.btn_setup.Text = "安装";
            this.btn_setup.UseVisualStyleBackColor = false;
            this.btn_setup.Click += new System.EventHandler(this.btn_setup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "设置静态IP";
            // 
            // txt_IP
            // 
            this.txt_IP.BackColor = System.Drawing.SystemColors.Info;
            this.txt_IP.Location = new System.Drawing.Point(143, 431);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(172, 21);
            this.txt_IP.TabIndex = 6;
            // 
            // btn_SetIP
            // 
            this.btn_SetIP.BackColor = System.Drawing.Color.Transparent;
            this.btn_SetIP.Location = new System.Drawing.Point(544, 431);
            this.btn_SetIP.Name = "btn_SetIP";
            this.btn_SetIP.Size = new System.Drawing.Size(95, 21);
            this.btn_SetIP.TabIndex = 7;
            this.btn_SetIP.Text = "保存";
            this.btn_SetIP.UseVisualStyleBackColor = false;
            this.btn_SetIP.Click += new System.EventHandler(this.btn_SetIP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "设置信任站点";
            // 
            // txt_Site
            // 
            this.txt_Site.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Site.Location = new System.Drawing.Point(143, 513);
            this.txt_Site.Name = "txt_Site";
            this.txt_Site.Size = new System.Drawing.Size(362, 21);
            this.txt_Site.TabIndex = 9;
            // 
            // btn_Site
            // 
            this.btn_Site.BackColor = System.Drawing.Color.Transparent;
            this.btn_Site.Location = new System.Drawing.Point(647, 512);
            this.btn_Site.Name = "btn_Site";
            this.btn_Site.Size = new System.Drawing.Size(95, 21);
            this.btn_Site.TabIndex = 10;
            this.btn_Site.Text = "保存";
            this.btn_Site.UseVisualStyleBackColor = false;
            this.btn_Site.Click += new System.EventHandler(this.btn_Site_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(522, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "例如:www.csdn.com";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(72, 517);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "站点名称";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(84, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "IP地址";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(332, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "DNS";
            // 
            // txt_DNS
            // 
            this.txt_DNS.BackColor = System.Drawing.SystemColors.Info;
            this.txt_DNS.Location = new System.Drawing.Point(361, 431);
            this.txt_DNS.Name = "txt_DNS";
            this.txt_DNS.Size = new System.Drawing.Size(172, 21);
            this.txt_DNS.TabIndex = 17;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "QQ截图20180909132743.png");
            this.imgList.Images.SetKeyName(1, "Office2010.jpg");
            this.imgList.Images.SetKeyName(2, "北信源.jpg");
            this.imgList.Images.SetKeyName(3, "天擎.png");
            this.imgList.Images.SetKeyName(4, "WPS.jpg");
            this.imgList.Images.SetKeyName(5, "WinRAR.png");
            this.imgList.Images.SetKeyName(6, "Foxmail.jpg");
            this.imgList.Images.SetKeyName(7, "AutoCAD_2.png");
            this.imgList.Images.SetKeyName(8, "Google浏览器.jpg");
            this.imgList.Images.SetKeyName(9, "SAP GUI.jpg");
            // 
            // tree_file
            // 
            this.tree_file.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tree_file.CheckBoxes = true;
            this.tree_file.ImageIndex = 0;
            this.tree_file.ImageList = this.imgList;
            this.tree_file.Location = new System.Drawing.Point(104, 46);
            this.tree_file.Name = "tree_file";
            this.tree_file.SelectedImageIndex = 0;
            this.tree_file.ShowLines = false;
            this.tree_file.Size = new System.Drawing.Size(677, 326);
            this.tree_file.TabIndex = 18;
            this.tree_file.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tree_file_AfterCheck);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 88);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // ElecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 573);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tree_file);
            this.Controls.Add(this.txt_DNS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Site);
            this.Controls.Add(this.txt_Site);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_SetIP);
            this.Controls.Add(this.txt_IP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_setup);
            this.Controls.Add(this.btn_cf);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label1);
            this.Name = "ElecForm";
            this.Text = "批量安装管理软件";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.ElecForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btn_cf;
        private System.Windows.Forms.Button btn_setup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Button btn_SetIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Site;
        private System.Windows.Forms.Button btn_Site;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_DNS;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.TreeView tree_file;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

