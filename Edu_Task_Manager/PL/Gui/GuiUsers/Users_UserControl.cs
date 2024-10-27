using Bunifu.UI.WinForms;
using Edu_Task_Manager.Classes;
using Edu_Task_Manager.Classes.Connection.UsersProcess;
using Edu_Task_Manager.Forms;
using Edu_Task_Manager.Forms.FormsAction;
using Edu_Task_Manager.Forms.FormsUser;
using Edu_Task_Manager.Properties;
using OfficeOpenXml;
using System;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu_Task_Manager.Gui.GuiUsers
{
    public partial class Users_UserControl : UserControl
    {
        #region Var
        private int id;
        private string name;
        private DateTime birthDate;
        private string phone;
        private string address;
        private string username;
        private string role;
        private bool isActive;
        private static Users_UserControl userControl;
        Cls_UsersDB currentUser = Cls_UsersDB.Instance;
        private Form formMain;
        #endregion

        public Users_UserControl(Form formMain)
        {
            InitializeComponent();
            userVerification(formMain);

        }
        #region Function
        public static Users_UserControl Instance(Form form)
        {
            //==> Freeing resources and not cloning more than once
            return userControl ?? (new Users_UserControl(form));
        }

        private void showSuccessDeleteMessageData()=>
            MessageShow.Show(formMain, Resources.SuccessDeleteData, BunifuSnackbar.MessageTypes.Error, 3000, "", BunifuSnackbar.Positions.TopRight);
        private void showSuccessExportDataMessageData()=>
            MessageShow.Show(formMain, Resources.SuccessExportData, BunifuSnackbar.MessageTypes.Success, 3000, "", BunifuSnackbar.Positions.TopRight);
        private void showSuccessUpdateMessageData()=>
            MessageShow.Show(formMain, Resources.SuccessUpdateData, BunifuSnackbar.MessageTypes.Information, 3000, "", BunifuSnackbar.Positions.TopRight);

        private void loadInitDataToAdmin()
        {
            getData();
            loadFilterData();
        }
        private void loadFilterData()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add(new DataColumn("Name", typeof(string)));
                dataTable.Columns.Add(new DataColumn("Value", typeof(string)));
                dataTable.Rows.Add(new object[] { "الكل", "all" });
                dataTable.Rows.Add(new object[] { "المسؤولين", "Admin" });
                dataTable.Rows.Add(new object[] { "المدرسين", "Teacher" });
                dataTable.Rows.Add(new object[] { "الطلاب", "Student" });
                COMP_FilterData.DataSource = dataTable;
                COMP_FilterData.DisplayMember = "Name";
                COMP_FilterData.ValueMember = "Value";
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void getData()=>
             dataGridViewUsers.DataSource = currentUser.getDataUsers();
        public void getDataUsersAdmin()=>
            dataGridViewUsers.DataSource = currentUser.getDataUsersAdmin();
        public void getDataUsersTeachers()=>
            dataGridViewUsers.DataSource = currentUser.getDataUsersTeachers();
        public void getDataUsersStudents()=>
            dataGridViewUsers.DataSource = currentUser.getDataUsersStudents();
        public void getDataUsersByTeacher() =>
            dataGridViewUsers.DataSource = currentUser.getDataUsersByTeacher(currentUser.idUser);

        private void userVerification(Form formMain)
        {
            if (currentUser.role == "Teacher")
            {
                getDataUsersByTeacher();
                COMP_FilterData.Visible = false;
                LBL_Filtter.Visible = false;
            }
            else
            {
                loadInitDataToAdmin();
            }
            this.formMain = formMain;
        }
        private void getDataFromDGV()
        {
            if (dataGridViewUsers.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridViewUsers.CurrentRow.Cells[0].Value);
                name = dataGridViewUsers.CurrentRow.Cells[1].Value.ToString();
                birthDate = dataGridViewUsers.CurrentRow.Cells[2].Value!=DBNull.Value?
                    (DateTime)dataGridViewUsers.CurrentRow.Cells[2].Value
                    :new DateTime(2000, 12, 31); ;
                phone = dataGridViewUsers.CurrentRow.Cells[3].Value.ToString();
                address = dataGridViewUsers.CurrentRow.Cells[4].Value.ToString();
                username = dataGridViewUsers.CurrentRow.Cells[5].Value.ToString();
                role = dataGridViewUsers.CurrentRow.Cells[6].Value.ToString();
                isActive = dataGridViewUsers.CurrentRow.Cells[8].Value.ToString()=="نشط";
                BTN_UpdateUserState.Enabled = username != "admin";
                BTN_Delete.Enabled = (Convert.ToBoolean(currentUser.getDataIsCanDeleteUser(id).Rows[0][0].ToString()));

            }
        }
        private void deleteData()
        {
            try
            {
                if (id != 0)
                {
                    if (ClsMessageCollections.showQuitionDeleteMessageData() == DialogResult.OK)
                    {
                        currentUser.deleteUser(id);
                        showSuccessDeleteMessageData();
                        loadData();
                        id = 0;
                    }
                }
                else
                {
                    ClsMessageCollections.showWarningIdSelectMessageData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Code:LI:385-FG_User ", "خطأ");
            }
        }
        private void updateData()
        {
            try
            {
                if (id != 0)
                {
                    using (Form_background form_Background = new Form_background())
                    {
                        form_Background.Show();
                        using (Form_ActionUsers updateUsers = new Form_ActionUsers())
                        {
                            updateUsers.loadForms(formMain, form_Background);
                            updateUsers.loadDataAndConfigToUpdateData(id, name, birthDate, phone, address, username, role);
                            updateUsers.ShowDialog();
                            updateUsers.Dispose();
                            form_Background.Close();
                            form_Background.Dispose();
                            loadData();
                        }
                    }
                }
                else
                {
                    ClsMessageCollections.showWarningIdSelectMessageData();
                }
             

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void loadData()
        {
            if (currentUser.role == "Teacher")
            {
                getDataUsersByTeacher();
            }
            else
            {
                if (COMP_FilterData.SelectedIndex == 0)
                {
                    getData();
                }
                else if (COMP_FilterData.SelectedIndex == 1)
                {
                    getDataUsersAdmin();
                }
                else if (COMP_FilterData.SelectedIndex == 2)
                {
                    getDataUsersTeachers();
                }
                else if (COMP_FilterData.SelectedIndex == 3)
                {
                    getDataUsersStudents();
                }
            }
            TX_Search.Clear();
        }
        private void searchData(string searchText)
        {
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataGridViewUsers.DataSource];
            currencyManager.SuspendBinding();

            foreach (DataGridViewRow row in dataGridViewUsers.Rows)
            {
                bool rowVisible = false;
                bool columnExists = dataGridViewUsers.Columns.Contains("أُضيف بواسطة");

                if (row.Cells["المعرف"].Value != null && row.Cells["المعرف"].Value.ToString().ToLower().Contains(searchText.ToLower()) ||
                    row.Cells["الاسم"].Value != null && row.Cells["الاسم"].Value.ToString().ToLower().Contains(searchText.ToLower()) ||
                    row.Cells["العنوان"].Value != null && row.Cells["العنوان"].Value.ToString().ToLower().Contains(searchText.ToLower()) ||
                    row.Cells["اسم الحساب"].Value != null && row.Cells["اسم الحساب"].Value.ToString().ToLower().Contains(searchText.ToLower()) ||
                    row.Cells["نوع الحساب"].Value != null && row.Cells["نوع الحساب"].Value.ToString().ToLower().Contains(searchText.ToLower()) ||
                    row.Cells["الحالة"].Value != null && row.Cells["الحالة"].Value.ToString().ToLower().Contains(searchText.ToLower()) ||
                    (columnExists && row.Cells["أُضيف بواسطة"].Value != null && row.Cells["أُضيف بواسطة"].Value.ToString().ToLower().Contains(searchText.ToLower()))
                )
                {
                    rowVisible = true;
                }
                row.Visible = rowVisible;
            }

            currencyManager.ResumeBinding();
        }
        private void exportData()
        {
            try
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("المستخدمين");
                    worksheet.Cells.Style.Font.Name = "Cairo";
                    worksheet.View.RightToLeft = true;
                    worksheet.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    for (int col = 1; col <= dataGridViewUsers.Columns.Count; col++)
                    {
                        worksheet.Column(col).Width = 12.5;


                        var cell = worksheet.Cells[1, col];

                        cell.Value = dataGridViewUsers.Columns[col - 1].HeaderText;
                        cell.Style.Font.Bold = true;
                        cell.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#609173"));
                        cell.Style.Font.Color.SetColor(System.Drawing.Color.White);

                    }
                    int excelRowIndex = 2;
                    foreach (DataGridViewRow row in dataGridViewUsers.Rows)
                    {
                        if (row.Visible)
                        {
                            for (int col = 1; col <= dataGridViewUsers.Columns.Count; col++)
                            {
                                var cellValue = row.Cells[col - 1].Value != null ? row.Cells[col - 1].Value.ToString() : "";
                                worksheet.Cells[excelRowIndex, col].Value = cellValue;
                            }
                            excelRowIndex++;
                        }
                    }
                    worksheet.Column(dataGridViewUsers.Columns.Count).Width = 23;

                    int numberOfUsers = dataGridViewUsers.Rows.Count;
                    worksheet.Cells["M3"].Value = "عدد المستخدمين:";
                    worksheet.Cells["M3"].Style.Font.Bold = true;
                    worksheet.Cells["M3"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    worksheet.Cells["M3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#609173"));
                    worksheet.Cells["M3"].Style.Font.Color.SetColor(System.Drawing.Color.White);
                    worksheet.Column(13).Width = 19;
                    worksheet.Column(14).Width = 5;
                    worksheet.Cells["N3"].Style.Font.Bold = true;
                    worksheet.Cells["N3"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    worksheet.Cells["N3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#609173"));
                    worksheet.Cells["N3"].Style.Font.Color.SetColor(System.Drawing.Color.White);
                    worksheet.Cells["N3"].Value = numberOfUsers;
                    var table = worksheet.Tables.Add(new ExcelAddressBase(1, 1, dataGridViewUsers.Rows.Count + 1, dataGridViewUsers.Columns.Count), "جدول_المستخدمين");
                    table.TableStyle = OfficeOpenXml.Table.TableStyles.Light1;


                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "ملفات Excel (*.xlsx)|*.xlsx";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                        excelPackage.SaveAs(excelFile);
                        showSuccessExportDataMessageData();
                        Task.Delay(1500);
                        System.Diagnostics.Process.Start(excelFile.FullName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nTry Agin");
            }
        }
        private void updateUserState(bool isActive)
        {
            try
            {
                currentUser.updateUserState(id, isActive);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            id = 0;
        }
        #endregion
        #region Event
        private void BTN_Add_Click(object sender, EventArgs e)
        {
            try
            {
                using (Form_background form_Background = new Form_background())
                {
                    form_Background.Show();
                    using (Form_ActionUsers addUsers = new Form_ActionUsers())
                    {
                        addUsers.loadForms(formMain, form_Background);
                        addUsers.loadConfigToAddData();
                        addUsers.ShowDialog();
                        addUsers.Dispose();
                        form_Background.Close();
                        form_Background.Dispose();
                        loadData();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            deleteData();
        }
        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataFromDGV();
        }
        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            getDataFromDGV();
        }
        private void dataGridViewUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridViewUsers.CurrentRow != null)
            {
                if (e.KeyData == Keys.Delete)
                {
                    if (BTN_Delete.Enabled)
                    {
                        BTN_Delete.PerformClick();
                    }
                }
            }
        }
        private void BTN_Update_Click(object sender, EventArgs e)
        {
            updateData();
        }
        private void dataGridViewUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updateData();
        }
        private void BTN_Export_Click(object sender, EventArgs e)
        {
          exportData();
        }
        private void COMP_FilterData_SelectedIndexChanged(object sender, EventArgs e)
        {
                loadData();
        }
        private void TX_Search_TextChanged(object sender, EventArgs e)
        {
            if (TX_Search.Text!= "")
            {
               
               searchData(TX_Search.Text);
            }
            else
            {
                loadData();
            }
        }
        private void BTN_UpdateUserState_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != 0)
                {
                    using (Form_background form_Background = new Form_background())
                    {
                        form_Background.Show();
                        using (Form_UserState userState = new Form_UserState())
                        {
                            userState.configFormState(name);
                            userState.setInitResult(isActive);
                            userState.ShowDialog();
                            var newUserState = userState.getResult();
                            userState.Dispose();
                            form_Background.Close();
                            form_Background.Dispose();
                            if (newUserState != isActive)
                            {
                                updateUserState(newUserState);
                                loadData();
                                showSuccessUpdateMessageData();
                            }
                           
                        }
                    }
                }
          

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


    }
}
