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
            this.lb_VehicleType = new System.Windows.Forms.Label();
            this.lb_LicensePlate = new System.Windows.Forms.Label();
            this.lb_FirstName = new System.Windows.Forms.Label();
            this.tb_VehicleType = new System.Windows.Forms.TextBox();
            this.tb_LicensePlate = new System.Windows.Forms.TextBox();
            this.tb_FirstName = new System.Windows.Forms.TextBox();
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
            this.tb_DriverID.Location = new System.Drawing.Point(330, 12);
            this.tb_DriverID.Name = "tb_DriverID";
            this.tb_DriverID.Size = new System.Drawing.Size(165, 20);
            this.tb_DriverID.TabIndex = 2;
            this.tb_DriverID.TextChanged += new System.EventHandler(this.tb_DriverID_TextChanged);
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
            this.lb_driverID.Location = new System.Drawing.Point(253, 15);
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
            // lb_VehicleType
            // 
            this.lb_VehicleType.AutoSize = true;
            this.lb_VehicleType.Location = new System.Drawing.Point(253, 95);
            this.lb_VehicleType.Name = "lb_VehicleType";
            this.lb_VehicleType.Size = new System.Drawing.Size(66, 13);
            this.lb_VehicleType.TabIndex = 23;
            this.lb_VehicleType.Text = "VehicleType";
            // 
            // lb_LicensePlate
            // 
            this.lb_LicensePlate.AutoSize = true;
            this.lb_LicensePlate.Location = new System.Drawing.Point(253, 69);
            this.lb_LicensePlate.Name = "lb_LicensePlate";
            this.lb_LicensePlate.Size = new System.Drawing.Size(68, 13);
            this.lb_LicensePlate.TabIndex = 22;
            this.lb_LicensePlate.Text = "LicensePlate";
            // 
            // lb_FirstName
            // 
            this.lb_FirstName.AutoSize = true;
            this.lb_FirstName.Location = new System.Drawing.Point(253, 43);
            this.lb_FirstName.Name = "lb_FirstName";
            this.lb_FirstName.Size = new System.Drawing.Size(52, 13);
            this.lb_FirstName.TabIndex = 21;
            this.lb_FirstName.Text = "Firstname";
            // 
            // tb_VehicleType
            // 
            this.tb_VehicleType.Location = new System.Drawing.Point(330, 92);
            this.tb_VehicleType.Name = "tb_VehicleType";
            this.tb_VehicleType.Size = new System.Drawing.Size(165, 20);
            this.tb_VehicleType.TabIndex = 20;
            // 
            // tb_LicensePlate
            // 
            this.tb_LicensePlate.Location = new System.Drawing.Point(330, 66);
            this.tb_LicensePlate.Name = "tb_LicensePlate";
            this.tb_LicensePlate.Size = new System.Drawing.Size(165, 20);
            this.tb_LicensePlate.TabIndex = 19;
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.Location = new System.Drawing.Point(330, 40);
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(165, 20);
            this.tb_FirstName.TabIndex = 18;
            // 
            // form_admin_add_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 187);
            this.Controls.Add(this.lb_VehicleType);
            this.Controls.Add(this.lb_LicensePlate);
            this.Controls.Add(this.lb_FirstName);
            this.Controls.Add(this.tb_VehicleType);
            this.Controls.Add(this.tb_LicensePlate);
            this.Controls.Add(this.tb_FirstName);
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
        private System.Windows.Forms.Label lb_VehicleType;
        private System.Windows.Forms.Label lb_LicensePlate;
        private System.Windows.Forms.Label lb_FirstName;
        private System.Windows.Forms.TextBox tb_VehicleType;
        private System.Windows.Forms.TextBox tb_LicensePlate;
        private System.Windows.Forms.TextBox tb_FirstName;
    }
}