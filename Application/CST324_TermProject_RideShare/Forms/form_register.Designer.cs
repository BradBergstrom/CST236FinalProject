namespace CST324_TermProject_RideShare
{
    partial class form_register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_register));
            this.title_lb = new System.Windows.Forms.Label();
            this.rider_btn = new System.Windows.Forms.Button();
            this.driver_btn = new System.Windows.Forms.Button();
            this.admin_btn = new System.Windows.Forms.Button();
            this.loginQuestion_lb = new System.Windows.Forms.Label();
            this.register_tb = new System.Windows.Forms.TextBox();
            this.enter_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.register_ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.register_ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title_lb
            // 
            this.title_lb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.title_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.title_lb.Location = new System.Drawing.Point(313, 212);
            this.title_lb.Name = "title_lb";
            this.title_lb.Size = new System.Drawing.Size(519, 49);
            this.title_lb.TabIndex = 1;
            this.title_lb.Text = "Oregon Institute of Technology RideShare";
            // 
            // rider_btn
            // 
            this.rider_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rider_btn.Location = new System.Drawing.Point(458, 293);
            this.rider_btn.Name = "rider_btn";
            this.rider_btn.Size = new System.Drawing.Size(174, 34);
            this.rider_btn.TabIndex = 2;
            this.rider_btn.Text = "Rider";
            this.rider_btn.UseVisualStyleBackColor = true;
            // 
            // driver_btn
            // 
            this.driver_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.driver_btn.Location = new System.Drawing.Point(458, 342);
            this.driver_btn.Name = "driver_btn";
            this.driver_btn.Size = new System.Drawing.Size(174, 34);
            this.driver_btn.TabIndex = 3;
            this.driver_btn.Text = "Driver";
            this.driver_btn.UseVisualStyleBackColor = true;
            this.driver_btn.Click += new System.EventHandler(this.driver_btn_Click);
            // 
            // admin_btn
            // 
            this.admin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.admin_btn.Location = new System.Drawing.Point(458, 395);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(174, 34);
            this.admin_btn.TabIndex = 4;
            this.admin_btn.Text = "Admin";
            this.admin_btn.UseVisualStyleBackColor = true;
            this.admin_btn.Click += new System.EventHandler(this.admin_btn_Click);
            // 
            // loginQuestion_lb
            // 
            this.loginQuestion_lb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.loginQuestion_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loginQuestion_lb.Location = new System.Drawing.Point(405, 252);
            this.loginQuestion_lb.Name = "loginQuestion_lb";
            this.loginQuestion_lb.Size = new System.Drawing.Size(276, 38);
            this.loginQuestion_lb.TabIndex = 5;
            this.loginQuestion_lb.Text = "      Enter First Name";
            this.loginQuestion_lb.Visible = false;
            // 
            // register_tb
            // 
            this.register_tb.Location = new System.Drawing.Point(343, 305);
            this.register_tb.Name = "register_tb";
            this.register_tb.Size = new System.Drawing.Size(404, 22);
            this.register_tb.TabIndex = 6;
            this.register_tb.Visible = false;
            this.register_tb.Validating += new System.ComponentModel.CancelEventHandler(this.register_tb_Validating);
            // 
            // enter_btn
            // 
            this.enter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.enter_btn.Location = new System.Drawing.Point(548, 342);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(174, 34);
            this.enter_btn.TabIndex = 7;
            this.enter_btn.Text = "Enter";
            this.enter_btn.UseVisualStyleBackColor = true;
            this.enter_btn.Visible = false;
            this.enter_btn.Click += new System.EventHandler(this.enter_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.back_btn.Location = new System.Drawing.Point(368, 342);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(174, 34);
            this.back_btn.TabIndex = 8;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Visible = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // register_ep
            // 
            this.register_ep.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1077, 209);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // form_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 517);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.register_tb);
            this.Controls.Add(this.loginQuestion_lb);
            this.Controls.Add(this.admin_btn);
            this.Controls.Add(this.driver_btn);
            this.Controls.Add(this.rider_btn);
            this.Controls.Add(this.title_lb);
            this.Name = "form_register";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form_register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.register_ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title_lb;
        private System.Windows.Forms.Button rider_btn;
        private System.Windows.Forms.Button driver_btn;
        private System.Windows.Forms.Button admin_btn;
        private System.Windows.Forms.Label loginQuestion_lb;
        private System.Windows.Forms.TextBox register_tb;
        private System.Windows.Forms.Button enter_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.ErrorProvider register_ep;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

