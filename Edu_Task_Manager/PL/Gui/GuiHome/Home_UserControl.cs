using System.Windows.Forms;
using Edu_Task_Manager.Classes.Connection.UsersProcess;

namespace Edu_Task_Manager.Gui.GuiHome
{
    public partial class Home_UserControl : UserControl
    {
        private static Home_UserControl homeUserControl;
        public Home_UserControl()
        {
            InitializeComponent();
            loadInitConfig();
        }
        #region Function
        private void loadInitConfig()=>
        LBL_NameUser.Text += Cls_UsersDB.Instance.name ?? "Gust";
        public static Home_UserControl Instance()
        {
            //==> Freeing resources and not cloning more than once
            return homeUserControl ?? (new Home_UserControl());
        }
        #endregion

    }
}
