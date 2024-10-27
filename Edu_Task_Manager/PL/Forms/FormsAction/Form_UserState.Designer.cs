namespace Edu_Task_Manager.Forms.FormsAction
{
    partial class Form_UserState
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_NameUser = new System.Windows.Forms.Label();
            this.BTN_Close = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_SaveClose = new Guna.UI2.WinForms.Guna2Button();
            this._animateWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.COMP_UserState = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(380, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "تنبيه هـــام";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Edu_Task_Manager.Properties.Resources.icons8_box_important_50px;
            this.pictureBox1.Location = new System.Drawing.Point(495, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(351, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "اسم المستخدم ";
            // 
            // LBL_NameUser
            // 
            this.LBL_NameUser.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NameUser.ForeColor = System.Drawing.Color.Red;
            this.LBL_NameUser.Location = new System.Drawing.Point(82, 87);
            this.LBL_NameUser.Name = "LBL_NameUser";
            this.LBL_NameUser.Size = new System.Drawing.Size(263, 37);
            this.LBL_NameUser.TabIndex = 6;
            this.LBL_NameUser.Text = "\" ابراهيم المندو \"";
            // 
            // BTN_Close
            // 
            this.BTN_Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Close.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Close.BorderColor = System.Drawing.Color.White;
            this.BTN_Close.BorderRadius = 8;
            this.BTN_Close.BorderThickness = 2;
            this.BTN_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Close.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_Close.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Close.ForeColor = System.Drawing.Color.Red;
            this.BTN_Close.HoverState.BorderColor = System.Drawing.Color.Red;
            this.BTN_Close.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.BTN_Close.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_Close.HoverState.ForeColor = System.Drawing.Color.Red;
            this.BTN_Close.Image = global::Edu_Task_Manager.Properties.Resources.icons8_cancel_32px_2;
            this.BTN_Close.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Close.ImageSize = new System.Drawing.Size(40, 40);
            this.BTN_Close.Location = new System.Drawing.Point(86, 245);
            this.BTN_Close.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.ShadowDecoration.BorderRadius = 20;
            this.BTN_Close.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Close.ShadowDecoration.Depth = 100;
            this.BTN_Close.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Close.Size = new System.Drawing.Size(190, 52);
            this.BTN_Close.TabIndex = 10;
            this.BTN_Close.Tag = "";
            this.BTN_Close.Text = "اغلاق";
            this.BTN_Close.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // BTN_SaveClose
            // 
            this.BTN_SaveClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_SaveClose.BackColor = System.Drawing.Color.Transparent;
            this.BTN_SaveClose.BorderColor = System.Drawing.Color.White;
            this.BTN_SaveClose.BorderRadius = 8;
            this.BTN_SaveClose.BorderThickness = 2;
            this.BTN_SaveClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SaveClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_SaveClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_SaveClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_SaveClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_SaveClose.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_SaveClose.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.BTN_SaveClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(145)))), ((int)(((byte)(115)))));
            this.BTN_SaveClose.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(145)))), ((int)(((byte)(115)))));
            this.BTN_SaveClose.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(145)))), ((int)(((byte)(115)))));
            this.BTN_SaveClose.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_SaveClose.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(154)))), ((int)(((byte)(60)))));
            this.BTN_SaveClose.Image = global::Edu_Task_Manager.Properties.Resources.icons8_Delete_Trash_60px_1;
            this.BTN_SaveClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_SaveClose.ImageSize = new System.Drawing.Size(40, 40);
            this.BTN_SaveClose.Location = new System.Drawing.Point(308, 245);
            this.BTN_SaveClose.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_SaveClose.Name = "BTN_SaveClose";
            this.BTN_SaveClose.ShadowDecoration.BorderRadius = 20;
            this.BTN_SaveClose.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_SaveClose.ShadowDecoration.Depth = 100;
            this.BTN_SaveClose.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_SaveClose.Size = new System.Drawing.Size(190, 52);
            this.BTN_SaveClose.TabIndex = 13;
            this.BTN_SaveClose.Tag = "";
            this.BTN_SaveClose.Text = "حفظ";
            this.BTN_SaveClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTN_SaveClose.Click += new System.EventHandler(this.BTN_SaveClose_Click);
            // 
            // _animateWindow
            // 
            this._animateWindow.TargetForm = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(82, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(419, 37);
            this.label3.TabIndex = 14;
            this.label3.Text = "تـعد يــــــــل حـــــــــــالـــــة نشــــــــاط الحــســاب";
            // 
            // COMP_UserState
            // 
            this.COMP_UserState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMP_UserState.Font = new System.Drawing.Font("Cairo", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMP_UserState.FormattingEnabled = true;
            this.COMP_UserState.Items.AddRange(new object[] {
            "نشط",
            "غير نشط"});
            this.COMP_UserState.Location = new System.Drawing.Point(82, 175);
            this.COMP_UserState.Name = "COMP_UserState";
            this.COMP_UserState.Size = new System.Drawing.Size(412, 50);
            this.COMP_UserState.TabIndex = 15;
            // 
            // Form_UserState
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 342);
            this.Controls.Add(this.COMP_UserState);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_SaveClose);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.LBL_NameUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.Name = "Form_UserState";
            this.Opacity = 0.9D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDeleteFollowUp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_NameUser;
        private Guna.UI2.WinForms.Guna2Button BTN_Close;
        private Guna.UI2.WinForms.Guna2Button BTN_SaveClose;
        private Guna.UI2.WinForms.Guna2AnimateWindow _animateWindow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox COMP_UserState;
    }
}