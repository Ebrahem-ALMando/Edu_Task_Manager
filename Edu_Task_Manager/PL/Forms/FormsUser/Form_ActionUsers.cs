using Bunifu.UI.WinForms;
using DevExpress.XtraEditors.Filtering.Templates;
using Edu_Task_Manager.Classes;
using Edu_Task_Manager.Classes.Connection.UsersProcess;
using Edu_Task_Manager.Classes.Login;
using Edu_Task_Manager.Properties;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Edu_Task_Manager.Forms.FormsUser
{
    public partial class Form_ActionUsers : DevExpress.XtraEditors.XtraForm
    {
        #region Var
        private string lastUserName;
        private int id;
        Form formMain;
        Form formBackground;

        private bool isClose;
        Cls_UsersDB currentUser =Cls_UsersDB.Instance;
        #endregion
        public Form_ActionUsers()
        {
            InitializeComponent();
        }

        #region Function

        private void showSuccessAddMessageData(Form form)
        {
            MessageShow.Show(form, Resources.SuccessAddData, BunifuSnackbar.MessageTypes.Success, 3000, "", BunifuSnackbar.Positions.TopRight);
        }
        private void showSuccessUpdateMessageData(Form form)
        {
            MessageShow.Show(form, Resources.SuccessUpdateData, BunifuSnackbar.MessageTypes.Information, 3000, "", BunifuSnackbar.Positions.TopRight);

        }
        /*        private void loadConfigToAddData()
                {
                    this.Text = "إضافة مستخدم";
                    loadValueDTPBirthDate();
                }*/

    
        public void loadForms(Form formMain, Form formBackground)
        {
            this.formMain = formMain;
            this.formBackground = formBackground;
        }
        public void loadConfigToAddData()
        {
            this.Text = "إضافة مستخدم";
            loadValueDTPBirthDate();
            loadRoleUser();
        }
        public void loadDataAndConfigToUpdateData(int id,string name,DateTime birthDate, string phone,
            string address, string username, string role)
        {
            loadRoleUser();
            
            this.Text = "تعديل مستخدم";
            this.id = id;
            
            TX_Name_User.Text = name;
            DTP_BirthDate.Value = birthDate;
            TX_Phone_User.Text = phone;
            TX_Address_User.Text = address;
            TX_UserName.Text = username;
            TX_UserName.ReadOnly = username=="admin";
            TX_UserName.BackColor = Color.White;
            COMP_Role_User.Enabled= username != "admin";
            lastUserName = username;
            TX_Password.Text="********";
            COMP_Role_User.Text = role;
            checkUserName(TX_UserName.Text);
        }
        private void loadRoleUser()
        {
            try
            {
                DataTable dataRole = new DataTable();
                dataRole.Columns.Add(new DataColumn("Name", typeof(string)));
                dataRole.Columns.Add(new DataColumn("Value", typeof(string)));
                if (currentUser.role == "Admin")
                {
                    dataRole.Rows.Add(new object[] { "مسؤول", "Admin" });
                    dataRole.Rows.Add(new object[] { "مدرس", "Teacher" });
                }
                dataRole.Rows.Add(new object[] { "طالب", "Student" });
                COMP_Role_User.DataSource = dataRole;
                COMP_Role_User.DisplayMember = "Name";
                COMP_Role_User.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void loadValueDTPBirthDate()
        {
            var cuurentData=DateTime.Now.Year;
            var maxValue = cuurentData - 18;
            var minValue = cuurentData - 65;
            DTP_BirthDate.MaxDate =new DateTime(maxValue,12,31);
            DTP_BirthDate.MinDate = new DateTime(minValue, 1, 1); ;
        }

        private void clearField()
        {
            TX_Name_User.Clear();
            TX_Phone_User.Clear();
            TX_Address_User.Clear();
            TX_UserName.Clear();
            TX_Password.Clear();
            COMP_Role_User.SelectedIndex = 0;
            lastUserName = "";
        }
        private bool checkUserName(string userN)
        {
            if (lastUserName == TX_UserName.Text && TX_UserName.Text != "" && TX_UserName.Text.Length >= 5)
            {
                pictureBox_CheckUserName.Visible = true;
                pictureBox_CheckUserName.Image = Properties.Resources.icons8_Checkmark_32px_1;
                label7.Visible = false;
                return true;
            }
            else
            {
                if (TX_UserName.Text != "" && TX_UserName.Text.Length >= 5)
                {
                    if (currentUser.getDataCheckUserName(userN).Rows.Count == 0)
                    {
                        pictureBox_CheckUserName.Visible = true;
                        pictureBox_CheckUserName.Image = Properties.Resources.icons8_Checkmark_32px_1;
                        label7.Visible = false;
                        return true;
                    }
                    else
                    {
                        pictureBox_CheckUserName.Visible = true;
                        pictureBox_CheckUserName.Image = Properties.Resources.icons8_cancel_32px_2;
                        label7.Visible = true;
                        return false;
                    }
                }
                else
                {
                    pictureBox_CheckUserName.Visible = false;
                    label7.Visible = false;
                    return false;

                }
            }

        }
        private bool checkPassword()
        {

            if (TX_Password.Text != "" && TX_Password.Text.Length >= 8)
            {

                pictureBoxCheckPassword.Visible = true;
                pictureBoxCheckPassword.Image = Properties.Resources.icons8_Checkmark_32px_1;
                label10.Visible = false;
                return true;

            }
            else if (TX_Password.Text != "")
            {
                pictureBoxCheckPassword.Visible = true;
                pictureBoxCheckPassword.Image = Properties.Resources.icons8_cancel_32px_2;
                label10.Visible = true;
                return false;
            }
            else
            {
                pictureBoxCheckPassword.Visible = false;
                label10.Visible = false;
                return false;

            }
        }
        private bool isNotValidDataUser()
        {
            var isValid = TX_Name_User.Text == "" || TX_Address_User.Text == "" || TX_Phone_User.Text == ""
                   || !checkPassword() || !checkUserName(TX_UserName.Text) || COMP_Role_User.Text == "";
            return isValid;
        }
        private void addData()
        {
            try
            {
                if (isNotValidDataUser())
                {
                    ClsMessageCollections.showEmptyMessageData();
                }
                else
                {
                    if (ClsMessageCollections.showQuitionAddMessageData() == DialogResult.OK)
                    {

                        var (hashedPassword, salt) = Cls_PasswordManager.HashPassword(TX_Password.Text);
                        var combinedPassword = $"{hashedPassword}-{salt}";
                        currentUser.insertUser(currentUser.idUser, TX_UserName.Text, combinedPassword, COMP_Role_User.SelectedValue.ToString(),
                            TX_Name_User.Text, TX_Phone_User.Text, DTP_BirthDate.Value, TX_Address_User.Text);

                        clearField();
                        if (isClose)
                        {
                            showSuccessAddMessageData(formMain);
                            this.Close();
                        }
                        else
                        {
                            showSuccessAddMessageData(formBackground);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Code:LI:135-FA_User ", "خطأ");
            }
        }
        private void updateData()
        {
            try
            {
             

                if (isNotValidDataUser())
                {
                    ClsMessageCollections.showEmptyMessageData();
                }
                else
                {
                    if (ClsMessageCollections.showQuitionUpdateMessageData() == DialogResult.OK)
                    {
                        var combinedPassword = "********";
                        if (TX_Password.Text!= "********")
                        {
                            var (hashedPassword, salt) = Cls_PasswordManager.HashPassword(TX_Password.Text);
                            combinedPassword = $"{hashedPassword}-{salt}";
                        }
                        currentUser.updateUsers(id, TX_UserName.Text, combinedPassword, COMP_Role_User.SelectedValue.ToString(),
                           TX_Name_User.Text, TX_Phone_User.Text, DTP_BirthDate.Value, TX_Address_User.Text); ;
                        lastUserName = TX_UserName.Text;
                        if (isClose)
                        {
                            showSuccessUpdateMessageData(formMain);
                            this.Close();
                        }
                        else
                        {
                            showSuccessUpdateMessageData(formBackground);
                        }
                    
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Code:LI:185-FA_User ", "خطأ");
            }
        }
        private void saveData()
        {
            if (id != 0)
            {
                updateData();
            }
            else
            {
                addData();
            }
        }
        private void chickEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                BTN_AddClose.PerformClick();
            }
        }
        #endregion
        #region Event
        private void TX_UserName_TextChanged_1(object sender, EventArgs e)
        {
            checkUserName(TX_UserName.Text);
        }
        private void TX_Password_TextChanged(object sender, EventArgs e)
        {
            checkPassword();
        }
        private void BTN_Add_Click(object sender, EventArgs e)
        {
            isClose = false;
            saveData();
        }
        private void BTN_AddClose_Click(object sender, EventArgs e)
        {
            isClose = true;
            saveData();
        }
        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TX_Phone_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsMessageCollections.checkInputTextBoxNumber(sender, e);
        }
        private void TX_Name_User_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);
        }
        private void TX_Phone_User_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);
        }
        private void TX_Address_User_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);
        }
        private void TX_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);
        }
        private void TX_Password_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);
        }
        private void DTP_BirthDate_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);
        }
        #endregion


    }
}