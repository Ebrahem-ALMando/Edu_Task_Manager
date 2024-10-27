using System;

namespace Edu_Task_Manager.Forms.FormsAction
{
    public partial class Form_UserState : DevExpress.XtraEditors.XtraForm
    {
        private bool resultActive = false;

        public Form_UserState()
        {
            InitializeComponent();
        }
        public void configFormState(string nameUser)
        {
            LBL_NameUser.Text = nameUser;
        }
        public bool getResult()
        {
            return resultActive;
        }
        public void setInitResult(bool result)
        {
            this.resultActive = result;
            COMP_UserState.SelectedIndex = result ? 0 : 1;
        }
        public void setResult(bool result)
        {
            this.resultActive = result;
        }
        private void BTN_Close_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        private void BTN_SaveClose_Click(object sender, EventArgs e)
        {
            var resCompo = COMP_UserState.Text == "نشط";
            setResult(resCompo);
            this.Close();
        }
    }
}