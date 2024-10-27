using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Edu_Task_Manager.Classes.Connection.UsersProcess;
using Edu_Task_Manager.Classes.Login;
using Edu_Task_Manager.Classes;
using System.Data;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace Edu_Task_Manager
{
    public partial class Form_Login : DevExpress.XtraEditors.XtraForm
    {

        Guna2MessageDialog message = new Guna2MessageDialog();
        Form_Main main;
        Cls_UsersDB currentUser=Cls_UsersDB.Instance;
        private bool isActve = false;
        public Form_Login()
        {
            InitializeComponent();
            Cls_AppConfig.LoadInitConfig();
            
        }
        #region Function
 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public bool isLoogin(string username, string pass)
        {
            DataTable result =Cls_LoginDB.Instance.loginUser(username);
            if (result.Rows.Count > 0)
            {
                string combinedStoredPassword = result.Rows[0]["password_hash"].ToString();
                isActve = result.Rows[0]["is_active"].ToString()=="True";

                string enteredPassword = pass;

                var parts = combinedStoredPassword.Split('-');
                string storedHashedPassword = parts[0];
                string storedSalt = parts[1];

                bool isPasswordValid = Cls_PasswordManager.VerifyPassword(enteredPassword, storedHashedPassword, storedSalt);

                if (isPasswordValid)
                {
                    if (isActve)
                    {
                        Int32.TryParse(result.Rows[0]["id"].ToString(), out int id);
                        currentUser.idUser = id;
                        currentUser.name = result.Rows[0]["full_name"].ToString();
                        currentUser.username = result.Rows[0]["username"].ToString();
                        currentUser.passwordHash = storedHashedPassword;
                        currentUser.salt = storedSalt;
                        currentUser.combinedStoredPassword = combinedStoredPassword;
                        currentUser.role = result.Rows[0]["role"].ToString();
                        currentUser.updateLastLoginUser(currentUser.idUser);
                        return true;
                    }
                }
            
            }
            return false;
        }
        private async void MoveLabelAsync(Panel label, int targetX, double durationInSeconds)
        {
            int initialX = label.Location.X;
            int distance = targetX - initialX;
            int steps = 100; 
            double stepDuration = durationInSeconds / steps;

            for (int i = 0; i <= steps; i++)
            {
                int newX = (int)(initialX + (distance * (i / (double)steps)));
                label.Location = new Point(newX, label.Location.Y); 
                await Task.Delay(TimeSpan.FromMilliseconds(stepDuration * 1000 / steps)); 
            }
        }
        private void movePanel(object obj)
        {
            var parameters = (Tuple<Panel, int>)obj;
            Panel panel = parameters.Item1;
            int pointX = parameters.Item2;


            for (int i = 1; i <= pointX; i++)
            {
       
                if (panel.InvokeRequired)
                {
                    panel.Invoke(new Action(() =>
                    {
                        panel.Location = new Point(panel.Location.X+i, panel.Location.Y);
                 
                    }));
                }
                else
                {
                    panel.Location = new Point(panel.Location.X + i, panel.Location.Y);
               
                }

                Thread.Sleep(10); 
            }
            
        }


        private void startMove()
        {


            Thread threadPanSecOne = new Thread(new ParameterizedThreadStart(movePanel));
            Thread threadPanSecTow = new Thread(new ParameterizedThreadStart(movePanel));



            var panelsTupleOne = new Tuple<Panel, int>(PAN_SectionOne, 300);
            var panelsTupleTow = new Tuple<Panel, int>(PAN_SectionTow, 700);



            threadPanSecOne.Start(panelsTupleOne);
            threadPanSecTow.Start(panelsTupleTow);


        }

        #endregion
        #region Event
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Wellcome_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private  void BTN_Login_Click(object sender, EventArgs e)
        {
            message.Buttons = MessageDialogButtons.OK;
            message.Style = MessageDialogStyle.Light;
            message.Icon = MessageDialogIcon.Warning;
            if (TX_UserName.Text == "" || TX_Password.Text == "")
            {
                message.Show("يرجى إدخال جميع البيانات\n ", "تنبيه");

            }else if (TX_Password.Text.Length < 8)
            {
                message.Show("كلمة المرور قصيرة جدا\n ", "تنبيه");
            }
            else
            {
                var isLogin = isLoogin(TX_UserName.Text, TX_Password.Text);
                if (isLogin)
                {
                    main = new Form_Main();
                    this.Hide();
                    main.ShowDialog();
                    main.Dispose();
                }
                else
                {
                    message.Icon = MessageDialogIcon.Error;

                    if (!isActve)
                    {
                        message.Show(" . . . الحساب معطل مؤقتاً  \n ", "خطأ");
                    }
                    else
                    {
                        message.Show("المعلومات خاطئة\n ");
                    }
            
                }
            }
        }
        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {
            if (TX_Password.Text != "")
            {
                if (TX_Password.UseSystemPasswordChar == false)
                {
                    TX_Password.UseSystemPasswordChar = true;
                }
                else if (TX_Password.UseSystemPasswordChar == true)
                {
                    TX_Password.UseSystemPasswordChar = false;
                }
            }
           
        }
        private void TX_Password_Enter(object sender, EventArgs e)
        {
            if (TX_Password.Text== "")
            {
                TX_Password.UseSystemPasswordChar = true;
            }
        }
        private void TX_Password_Leave(object sender, EventArgs e)
        {
            if (TX_Password.Text == "")
            {
                TX_Password.UseSystemPasswordChar = false;
                
            }
           
        }
        private void TX_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {

            message.Style = MessageDialogStyle.Light;
            message.Buttons = MessageDialogButtons.OK;
            message.Icon = MessageDialogIcon.Warning;
            if (e.KeyChar >= 'ا' && e.KeyChar <= 'ي')
            {
                e.Handled = true;

                message.Show(" لا يمكن ان يحتوي الاسم  " + "\n" + " محارف باللغة العربية\n   ", " تنبيه");

            }
            else
            {
                e.Handled = false;
            }
         
        }
        private void TX_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            message.Style = MessageDialogStyle.Light;
            message.Buttons = MessageDialogButtons.OK;
            message.Icon = MessageDialogIcon.Warning;
            if (e.KeyChar >= 'ا' && e.KeyChar <= 'ي')
            {
                e.Handled = true;
                message.Show(" لا يمكن ان تحتوي كلمة المرور " + "\n" + " محارف باللغة العربية\n   ", " تنبيه");


            }
            else
            {
                e.Handled = false;
            }
            
        }
        private void TX_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                BTN_Login.PerformClick();
            }
        }
        private void TX_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                BTN_Login.PerformClick();
            }
        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private async void BTN_TowSection_Click(object sender, EventArgs e)
        {
         /*  startMove();*/
           /* MoveLabelAsync(PAN_SectionOne, 200, 5);*/
            /*MoveLabelAsync(label4, 700, 5);*/
        }
        #endregion


    }
}
