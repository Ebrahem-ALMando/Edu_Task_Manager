using Edu_Task_Manager.Classes.Connection;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Edu_Task_Manager
{
    class Cls_LoginDB
    {
        Cls_AccessLayer_DB connection = new Cls_AccessLayer_DB();
        //==> Process Login Forms

        // ==> Init 
        private static Cls_LoginDB _instance;

        public static Cls_LoginDB Instance => _instance ?? (_instance = new Cls_LoginDB());

        //    <=============== Method ======================>


        //==> 1 Login To User
        public DataTable loginUser(string username)
        {
            DataTable dataUsers = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@username", SqlDbType.NVarChar);
                param[0].Value = username;
                dataUsers = connection.Read_Data("loginUser", param);
                connection.cloes();
                return dataUsers;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataUsers;
            }
            finally
            {
                connection.cloes(); 
            }
        }
     
    }
}
