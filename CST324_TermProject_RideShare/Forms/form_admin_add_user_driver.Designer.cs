namespace CST324_TermProject_RideShare.Forms
{
    partial class form_admin_add_user_driver
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
            this.btn_Finish = new System.Windows.Forms.Button();
            this.lb_VehicleType = new System.Windows.Forms.Label();
            this.lb_LicensePlate = new System.Windows.Forms.Label();
            this.lb_FirstName = new System.Windows.Forms.Label();
            this.tb_VehicleType = new System.Windows.Forms.TextBox();
            this.tb_LicensePlate = new System.Windows.Forms.TextBox();
            this.tb_FirstName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Finish
            // 
            this.btn_Finish.Location = new System.Drawing.Point(12, 89);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Size = new System.Drawing.Size(246, 20);
            this.btn_Finish.TabIndex = 20;
            this.btn_Finish.Text = "Finish";
            this.btn_Finish.UseVisualStyleBackColor = true;
            this.btn_Finish.Click += new System.EventHandler(this.btn_Finish_Click);
            // 
            // lb_VehicleType
            // 
            this.lb_VehicleType.AutoSize = true;
            this.lb_VehicleType.Location = new System.Drawing.Point(14, 66);
            this.lb_VehicleType.Name = "lb_VehicleType";
            this.lb_VehicleType.Size = new System.Drawing.Size(66, 13);
            this.lb_VehicleType.TabIndex = 17;
            this.lb_VehicleType.Text = "VehicleType";
            // 
            // lb_LicensePlate
            // 
            this.lb_LicensePlate.AutoSize = true;
            this.lb_LicensePlate.Location = new System.Drawing.Point(14, 40);
            this.lb_LicensePlate.Name = "lb_LicensePlate";
            this.lb_LicensePlate.Size = new System.Drawing.Size(68, 13);
            this.lb_LicensePlate.TabIndex = 16;
            this.lb_LicensePlate.Text = "LicensePlate";
            // 
            // lb_FirstName
            // 
            this.lb_FirstName.AutoSize = true;
            this.lb_FirstName.Location = new System.Drawing.Point(14, 14);
            this.lb_FirstName.Name = "lb_FirstName";
            this.lb_FirstName.Size = new System.Drawing.Size(52, 13);
            this.lb_FirstName.TabIndex = 15;
            this.lb_FirstName.Text = "Firstname";
            // 
            // tb_VehicleType
            // 
            this.tb_VehicleType.Location = new System.Drawing.Point(91, 63);
            this.tb_VehicleType.Name = "tb_VehicleType";
            this.tb_VehicleType.Size = new System.Drawing.Size(165, 20);
            this.tb_VehicleType.TabIndex = 13;
            // 
            // tb_LicensePlate
            // 
            this.tb_LicensePlate.Location = new System.Drawing.Point(91, 37);
            this.tb_LicensePlate.Name = "tb_LicensePlate";
            this.tb_LicensePlate.Size = new System.Drawing.Size(165, 20);
            this.tb_LicensePlate.TabIndex = 12;
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.Location = new System.Drawing.Point(91, 11);
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(165, 20);
            this.tb_FirstName.TabIndex = 11;
            // 
            // form_admin_add_user_driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 121);
            this.Controls.Add(this.btn_Finish);
            this.Controls.Add(this.lb_VehicleType);
            this.Controls.Add(this.lb_LicensePlate);
            this.Controls.Add(this.lb_FirstName);
            this.Controls.Add(this.tb_VehicleType);
            this.Controls.Add(this.tb_LicensePlate);
            this.Controls.Add(this.tb_FirstName);
            this.Name = "form_admin_add_user_driver";
            this.Text = "form_admin_add_user_driver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Finish;
        private System.Windows.Forms.Label lb_VehicleType;
        private System.Windows.Forms.Label lb_LicensePlate;
        private System.Windows.Forms.Label lb_FirstName;
        private System.Windows.Forms.TextBox tb_VehicleType;
        private System.Windows.Forms.TextBox tb_LicensePlate;
        private System.Windows.Forms.TextBox tb_FirstName;
    }
}