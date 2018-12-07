namespace CST324_TermProject_RideShare.Forms
{
    partial class form_admin_add_user
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
            this.tb_Location = new System.Windows.Forms.TextBox();
            this.tb_Admin = new System.Windows.Forms.TextBox();
            this.tb_DriverID = new System.Windows.Forms.TextBox();
            this.tb_RiderID = new System.Windows.Forms.TextBox();
            this.lb_Location = new System.Windows.Forms.Label();
            this.lb_Admin = new System.Windows.Forms.Label();
            this.lb_driverID = new System.Windows.Forms.Label();
            this.lb_RiderID = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_Finish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Location
            // 
            this.tb_Location.Location = new System.Drawing.Point(80, 12);
            this.tb_Location.Name = "tb_Location";
            this.tb_Location.Size = new System.Drawing.Size(165, 20);
            this.tb_Location.TabIndex = 0;
            // 
            // tb_Admin
            // 
            this.tb_Admin.Location = new System.Drawing.Point(80, 38);
            this.tb_Admin.Name = "tb_Admin";
            this.tb_Admin.Size = new System.Drawing.Size(165, 20);
            this.tb_Admin.TabIndex = 1;
            // 
            // tb_DriverID
            // 
            this.tb_DriverID.Location = new System.Drawing.Point(80, 64);
            this.tb_DriverID.Name = "tb_DriverID";
            this.tb_DriverID.Size = new System.Drawing.Size(165, 20);
            this.tb_DriverID.TabIndex = 2;
            // 
            // tb_RiderID
            // 
            this.tb_RiderID.Location = new System.Drawing.Point(80, 90);
            this.tb_RiderID.Name = "tb_RiderID";
            this.tb_RiderID.Size = new System.Drawing.Size(165, 20);
            this.tb_RiderID.TabIndex = 3;
            // 
            // lb_Location
            // 
            this.lb_Location.AutoSize = true;
            this.lb_Location.Location = new System.Drawing.Point(3, 15);
            this.lb_Location.Name = "lb_Location";
            this.lb_Location.Size = new System.Drawing.Size(48, 13);
            this.lb_Location.TabIndex = 5;
            this.lb_Location.Text = "Location";
            // 
            // lb_Admin
            // 
            this.lb_Admin.AutoSize = true;
            this.lb_Admin.Location = new System.Drawing.Point(3, 41);
            this.lb_Admin.Name = "lb_Admin";
            this.lb_Admin.Size = new System.Drawing.Size(36, 13);
            this.lb_Admin.TabIndex = 6;
            this.lb_Admin.Text = "Admin";
            // 
            // lb_driverID
            // 
            this.lb_driverID.AutoSize = true;
            this.lb_driverID.Location = new System.Drawing.Point(3, 67);
            this.lb_driverID.Name = "lb_driverID";
            this.lb_driverID.Size = new System.Drawing.Size(46, 13);
            this.lb_driverID.TabIndex = 7;
            this.lb_driverID.Text = "DriverID";
            // 
            // lb_RiderID
            // 
            this.lb_RiderID.AutoSize = true;
            this.lb_RiderID.Location = new System.Drawing.Point(3, 93);
            this.lb_RiderID.Name = "lb_RiderID";
            this.lb_RiderID.Size = new System.Drawing.Size(43, 13);
            this.lb_RiderID.TabIndex = 8;
            this.lb_RiderID.Text = "RiderID";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(138, 150);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(107, 23);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Add User";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_Finish
            // 
            this.btn_Finish.Location = new System.Drawing.Point(57, 150);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Size = new System.Drawing.Size(75, 23);
            this.btn_Finish.TabIndex = 10;
            this.btn_Finish.Text = "Finish";
            this.btn_Finish.UseVisualStyleBackColor = true;
            // 
            // form_admin_add_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 185);
            this.Controls.Add(this.btn_Finish);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lb_RiderID);
            this.Controls.Add(this.lb_driverID);
            this.Controls.Add(this.lb_Admin);
            this.Controls.Add(this.lb_Location);
            this.Controls.Add(this.tb_RiderID);
            this.Controls.Add(this.tb_DriverID);
            this.Controls.Add(this.tb_Admin);
            this.Controls.Add(this.tb_Location);
            this.Name = "form_admin_add_user";
            this.Text = "form_admin_add_user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Location;
        private System.Windows.Forms.TextBox tb_Admin;
        private System.Windows.Forms.TextBox tb_DriverID;
        private System.Windows.Forms.TextBox tb_RiderID;
        private System.Windows.Forms.Label lb_Location;
        private System.Windows.Forms.Label lb_Admin;
        private System.Windows.Forms.Label lb_driverID;
        private System.Windows.Forms.Label lb_RiderID;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_Finish;
    }
}