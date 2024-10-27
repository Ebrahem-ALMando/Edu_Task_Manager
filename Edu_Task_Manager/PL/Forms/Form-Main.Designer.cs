namespace Edu_Task_Manager
{
    partial class Form_Main
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
            this.Pan_BTNS = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PIBPanel = new System.Windows.Forms.PictureBox();
            this.BTN_Home = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Users = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Group = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Tasks = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Message = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Logout = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PAN_Time = new Guna.UI2.WinForms.Guna2Panel();
            this.LBL_Date = new System.Windows.Forms.Label();
            this.LBL_TimeNow = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BTN_Setting = new Guna.UI2.WinForms.Guna2Button();
            this.Pan_BTNS.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIBPanel)).BeginInit();
            this.panel2.SuspendLayout();
            this.PAN_Time.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pan_BTNS
            // 
            this.Pan_BTNS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.Pan_BTNS.Controls.Add(this.panel1);
            this.Pan_BTNS.Controls.Add(this.BTN_Home);
            this.Pan_BTNS.Controls.Add(this.BTN_Users);
            this.Pan_BTNS.Controls.Add(this.BTN_Group);
            this.Pan_BTNS.Controls.Add(this.BTN_Tasks);
            this.Pan_BTNS.Controls.Add(this.BTN_Message);
            this.Pan_BTNS.Controls.Add(this.guna2Button1);
            this.Pan_BTNS.Controls.Add(this.BTN_Setting);
            this.Pan_BTNS.Controls.Add(this.BTN_Logout);
            this.Pan_BTNS.Controls.Add(this.panel2);
            this.Pan_BTNS.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pan_BTNS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Pan_BTNS.Location = new System.Drawing.Point(1340, 0);
            this.Pan_BTNS.Name = "Pan_BTNS";
            this.Pan_BTNS.Size = new System.Drawing.Size(267, 890);
            this.Pan_BTNS.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PIBPanel);
            this.panel1.Location = new System.Drawing.Point(-15, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 91);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "إدارة المهام\r\nالتعــلــيمــية";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PIBPanel
            // 
            this.PIBPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PIBPanel.Image = global::Edu_Task_Manager.Properties.Resources.Back_Arrow_60px;
            this.PIBPanel.Location = new System.Drawing.Point(213, 12);
            this.PIBPanel.Name = "PIBPanel";
            this.PIBPanel.Size = new System.Drawing.Size(60, 46);
            this.PIBPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIBPanel.TabIndex = 0;
            this.PIBPanel.TabStop = false;
            this.PIBPanel.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BTN_Home
            // 
            this.BTN_Home.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Home.BorderColor = System.Drawing.Color.White;
            this.BTN_Home.BorderRadius = 20;
            this.BTN_Home.BorderThickness = 2;
            this.BTN_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Home.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Home.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Home.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Home.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Home.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.BTN_Home.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Home.ForeColor = System.Drawing.Color.White;
            this.BTN_Home.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(159)))), ((int)(((byte)(118)))));
            this.BTN_Home.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(159)))), ((int)(((byte)(118)))));
            this.BTN_Home.HoverState.FillColor = System.Drawing.Color.White;
            this.BTN_Home.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.BTN_Home.HoverState.Image = global::Edu_Task_Manager.Properties.Resources.icons8_home_60px;
            this.BTN_Home.Image = global::Edu_Task_Manager.Properties.Resources.icons8_home_40px_1;
            this.BTN_Home.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTN_Home.ImageSize = new System.Drawing.Size(45, 45);
            this.BTN_Home.Location = new System.Drawing.Point(5, 127);
            this.BTN_Home.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_Home.Name = "BTN_Home";
            this.BTN_Home.ShadowDecoration.BorderRadius = 20;
            this.BTN_Home.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Home.ShadowDecoration.Depth = 100;
            this.BTN_Home.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Home.Size = new System.Drawing.Size(259, 53);
            this.BTN_Home.TabIndex = 2;
            this.BTN_Home.Tag = "الرئيسية";
            this.BTN_Home.Text = "الرئيسية";
            this.BTN_Home.Click += new System.EventHandler(this.BTN_Home_Click);
            // 
            // BTN_Users
            // 
            this.BTN_Users.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Users.BorderColor = System.Drawing.Color.White;
            this.BTN_Users.BorderRadius = 20;
            this.BTN_Users.BorderThickness = 2;
            this.BTN_Users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Users.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Users.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Users.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Users.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Users.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.BTN_Users.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Users.ForeColor = System.Drawing.Color.White;
            this.BTN_Users.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(159)))), ((int)(((byte)(118)))));
            this.BTN_Users.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(159)))), ((int)(((byte)(118)))));
            this.BTN_Users.HoverState.FillColor = System.Drawing.Color.White;
            this.BTN_Users.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.BTN_Users.HoverState.Image = global::Edu_Task_Manager.Properties.Resources.icons8_users_60px;
            this.BTN_Users.Image = global::Edu_Task_Manager.Properties.Resources.icons8_users_50px_2;
            this.BTN_Users.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTN_Users.ImageSize = new System.Drawing.Size(40, 40);
            this.BTN_Users.Location = new System.Drawing.Point(5, 193);
            this.BTN_Users.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.BTN_Users.Name = "BTN_Users";
            this.BTN_Users.ShadowDecoration.BorderRadius = 20;
            this.BTN_Users.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Users.ShadowDecoration.Depth = 100;
            this.BTN_Users.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Users.Size = new System.Drawing.Size(259, 53);
            this.BTN_Users.TabIndex = 3;
            this.BTN_Users.Tag = "المستخدمين";
            this.BTN_Users.Text = "المستخدمين";
            this.BTN_Users.Click += new System.EventHandler(this.BTN_Users_Click);
            // 
            // BTN_Group
            // 
            this.BTN_Group.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Group.BorderColor = System.Drawing.Color.White;
            this.BTN_Group.BorderRadius = 20;
            this.BTN_Group.BorderThickness = 2;
            this.BTN_Group.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Group.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Group.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Group.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Group.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Group.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.BTN_Group.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Group.ForeColor = System.Drawing.Color.White;
            this.BTN_Group.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(159)))), ((int)(((byte)(118)))));
            this.BTN_Group.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(159)))), ((int)(((byte)(118)))));
            this.BTN_Group.HoverState.FillColor = System.Drawing.Color.White;
            this.BTN_Group.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.BTN_Group.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTN_Group.ImageSize = new System.Drawing.Size(40, 40);
            this.BTN_Group.Location = new System.Drawing.Point(5, 259);
            this.BTN_Group.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.BTN_Group.Name = "BTN_Group";
            this.BTN_Group.ShadowDecoration.BorderRadius = 20;
            this.BTN_Group.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Group.ShadowDecoration.Depth = 100;
            this.BTN_Group.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Group.Size = new System.Drawing.Size(259, 53);
            this.BTN_Group.TabIndex = 11;
            this.BTN_Group.Tag = "المجموعات";
            this.BTN_Group.Text = "المجموعات";
            // 
            // BTN_Tasks
            // 
            this.BTN_Tasks.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Tasks.BorderColor = System.Drawing.Color.White;
            this.BTN_Tasks.BorderRadius = 20;
            this.BTN_Tasks.BorderThickness = 2;
            this.BTN_Tasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Tasks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Tasks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Tasks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Tasks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Tasks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.BTN_Tasks.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Tasks.ForeColor = System.Drawing.Color.White;
            this.BTN_Tasks.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(159)))), ((int)(((byte)(118)))));
            this.BTN_Tasks.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(159)))), ((int)(((byte)(118)))));
            this.BTN_Tasks.HoverState.FillColor = System.Drawing.Color.White;
            this.BTN_Tasks.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.BTN_Tasks.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTN_Tasks.ImageSize = new System.Drawing.Size(40, 40);
            this.BTN_Tasks.Location = new System.Drawing.Point(5, 325);
            this.BTN_Tasks.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.BTN_Tasks.Name = "BTN_Tasks";
            this.BTN_Tasks.ShadowDecoration.BorderRadius = 20;
            this.BTN_Tasks.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Tasks.ShadowDecoration.Depth = 100;
            this.BTN_Tasks.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Tasks.Size = new System.Drawing.Size(259, 53);
            this.BTN_Tasks.TabIndex = 12;
            this.BTN_Tasks.Tag = "المــــهـام";
            this.BTN_Tasks.Text = "المــــهـام";
            // 
            // BTN_Message
            // 
            this.BTN_Message.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Message.BorderColor = System.Drawing.Color.White;
            this.BTN_Message.BorderRadius = 20;
            this.BTN_Message.BorderThickness = 2;
            this.BTN_Message.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Message.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Message.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Message.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Message.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Message.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.BTN_Message.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Message.ForeColor = System.Drawing.Color.White;
            this.BTN_Message.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(159)))), ((int)(((byte)(118)))));
            this.BTN_Message.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(159)))), ((int)(((byte)(118)))));
            this.BTN_Message.HoverState.FillColor = System.Drawing.Color.White;
            this.BTN_Message.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.BTN_Message.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTN_Message.ImageSize = new System.Drawing.Size(40, 40);
            this.BTN_Message.Location = new System.Drawing.Point(5, 391);
            this.BTN_Message.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.BTN_Message.Name = "BTN_Message";
            this.BTN_Message.ShadowDecoration.BorderRadius = 20;
            this.BTN_Message.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Message.ShadowDecoration.Depth = 100;
            this.BTN_Message.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Message.Size = new System.Drawing.Size(259, 53);
            this.BTN_Message.TabIndex = 13;
            this.BTN_Message.Tag = "الرســــائـل";
            this.BTN_Message.Text = "الرســــائـل";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.guna2Button1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(159)))), ((int)(((byte)(118)))));
            this.guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(159)))), ((int)(((byte)(118)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(5, 457);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.BorderRadius = 20;
            this.guna2Button1.ShadowDecoration.Color = System.Drawing.Color.White;
            this.guna2Button1.ShadowDecoration.Depth = 100;
            this.guna2Button1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.guna2Button1.Size = new System.Drawing.Size(259, 53);
            this.guna2Button1.TabIndex = 14;
            this.guna2Button1.Tag = "الاشعارات";
            this.guna2Button1.Text = "الاشعـارات";
            // 
            // BTN_Logout
            // 
            this.BTN_Logout.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Logout.BorderColor = System.Drawing.Color.White;
            this.BTN_Logout.BorderRadius = 20;
            this.BTN_Logout.BorderThickness = 2;
            this.BTN_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_Logout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.BTN_Logout.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Logout.ForeColor = System.Drawing.Color.White;
            this.BTN_Logout.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(159)))), ((int)(((byte)(118)))));
            this.BTN_Logout.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(159)))), ((int)(((byte)(118)))));
            this.BTN_Logout.HoverState.FillColor = System.Drawing.Color.White;
            this.BTN_Logout.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.BTN_Logout.HoverState.Image = global::Edu_Task_Manager.Properties.Resources.icons8_logout_60px;
            this.BTN_Logout.Image = global::Edu_Task_Manager.Properties.Resources.icons8_logout_40px_1;
            this.BTN_Logout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTN_Logout.ImageSize = new System.Drawing.Size(40, 40);
            this.BTN_Logout.Location = new System.Drawing.Point(5, 589);
            this.BTN_Logout.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.BTN_Logout.Name = "BTN_Logout";
            this.BTN_Logout.ShadowDecoration.BorderRadius = 20;
            this.BTN_Logout.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Logout.ShadowDecoration.Depth = 100;
            this.BTN_Logout.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Logout.Size = new System.Drawing.Size(259, 53);
            this.BTN_Logout.TabIndex = 9;
            this.BTN_Logout.Tag = "تسجيل الخروج";
            this.BTN_Logout.Text = "تسجيل الخروج";
            this.BTN_Logout.Click += new System.EventHandler(this.BTN_Logout_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.PAN_Time);
            this.panel2.Location = new System.Drawing.Point(-8, 648);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 331);
            this.panel2.TabIndex = 10;
            // 
            // PAN_Time
            // 
            this.PAN_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PAN_Time.BorderRadius = 10;
            this.PAN_Time.BorderThickness = 2;
            this.PAN_Time.Controls.Add(this.LBL_Date);
            this.PAN_Time.Controls.Add(this.LBL_TimeNow);
            this.PAN_Time.FillColor = System.Drawing.Color.White;
            this.PAN_Time.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.PAN_Time.Location = new System.Drawing.Point(13, 133);
            this.PAN_Time.Margin = new System.Windows.Forms.Padding(32, 100, 3, 3);
            this.PAN_Time.Name = "PAN_Time";
            this.PAN_Time.Size = new System.Drawing.Size(256, 115);
            this.PAN_Time.TabIndex = 11;
            // 
            // LBL_Date
            // 
            this.LBL_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBL_Date.AutoSize = true;
            this.LBL_Date.BackColor = System.Drawing.Color.White;
            this.LBL_Date.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.LBL_Date.Location = new System.Drawing.Point(65, 19);
            this.LBL_Date.Name = "LBL_Date";
            this.LBL_Date.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LBL_Date.Size = new System.Drawing.Size(84, 27);
            this.LBL_Date.TabIndex = 1;
            this.LBL_Date.Text = "label2";
            // 
            // LBL_TimeNow
            // 
            this.LBL_TimeNow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBL_TimeNow.AutoSize = true;
            this.LBL_TimeNow.BackColor = System.Drawing.Color.White;
            this.LBL_TimeNow.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TimeNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.LBL_TimeNow.Location = new System.Drawing.Point(68, 67);
            this.LBL_TimeNow.Name = "LBL_TimeNow";
            this.LBL_TimeNow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LBL_TimeNow.Size = new System.Drawing.Size(84, 27);
            this.LBL_TimeNow.TabIndex = 0;
            this.LBL_TimeNow.Text = "label2";
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1340, 890);
            this.panelContainer.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BTN_Setting
            // 
            this.BTN_Setting.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Setting.BorderColor = System.Drawing.Color.White;
            this.BTN_Setting.BorderRadius = 20;
            this.BTN_Setting.BorderThickness = 2;
            this.BTN_Setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Setting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Setting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Setting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Setting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Setting.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.BTN_Setting.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Setting.ForeColor = System.Drawing.Color.White;
            this.BTN_Setting.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(159)))), ((int)(((byte)(118)))));
            this.BTN_Setting.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(159)))), ((int)(((byte)(118)))));
            this.BTN_Setting.HoverState.FillColor = System.Drawing.Color.White;
            this.BTN_Setting.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(110)))), ((int)(((byte)(49)))));
            this.BTN_Setting.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTN_Setting.ImageSize = new System.Drawing.Size(40, 40);
            this.BTN_Setting.Location = new System.Drawing.Point(5, 523);
            this.BTN_Setting.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.BTN_Setting.Name = "BTN_Setting";
            this.BTN_Setting.ShadowDecoration.BorderRadius = 20;
            this.BTN_Setting.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Setting.ShadowDecoration.Depth = 100;
            this.BTN_Setting.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Setting.Size = new System.Drawing.Size(259, 53);
            this.BTN_Setting.TabIndex = 15;
            this.BTN_Setting.Tag = "الاعدادات";
            this.BTN_Setting.Text = "الاعدادات";
            // 
            // Form_Main
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 890);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.Pan_BTNS);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.IconOptions.Image = global::Edu_Task_Manager.Properties.Resources.icons8_home_60px;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MinimumSize = new System.Drawing.Size(1609, 930);
            this.Name = "Form_Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الرئيسية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_FormClosed);
            this.Pan_BTNS.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIBPanel)).EndInit();
            this.panel2.ResumeLayout(false);
            this.PAN_Time.ResumeLayout(false);
            this.PAN_Time.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PIBPanel;
        private System.Windows.Forms.FlowLayoutPanel Pan_BTNS;
        private Guna.UI2.WinForms.Guna2Button BTN_Home;
        private Guna.UI2.WinForms.Guna2Button BTN_Users;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button BTN_Logout;
        public System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Panel PAN_Time;
        private System.Windows.Forms.Label LBL_TimeNow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LBL_Date;
        private Guna.UI2.WinForms.Guna2Button BTN_Group;
        private Guna.UI2.WinForms.Guna2Button BTN_Tasks;
        private Guna.UI2.WinForms.Guna2Button BTN_Message;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button BTN_Setting;
    }
}