using System;
using System.Data.SqlClient;
using System.Data;

namespace Edu_Task_Manager.Classes.Connection.UsersProcess
{
    internal class Cls_UsersDB
    {
        #region Var-Pro
        public string username { get; set; }
        public string passwordHash { get; set; }
        public string salt { get; set; }
        public string combinedStoredPassword { get; set; }
        public int idUser { get; set; } = 0;
        public string name { get; set; }
        public string role { get; set; }

        private static Cls_UsersDB _instance;
        public static Cls_UsersDB Instance => _instance ?? (_instance = new Cls_UsersDB());
        Cls_AccessLayer_DB connection = new Cls_AccessLayer_DB();
        #endregion
        //==> Process Users Forms

        // ==> Init 
        private Cls_UsersDB()
        {

        }

        //    <=============== Method ======================>
        #region Function
        //==> 1 getData To Users
        public DataTable getDataUsers()
        {
            DataTable dataUsers = new DataTable();
            try
            {
                connection.open();
                dataUsers = connection.Read_Data("getDataUsers", null);
                connection.cloes();
                return dataUsers;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataUsers;
            }

        }
        //==> 2 get Data To Users Admins
        public DataTable getDataUsersAdmin()
        {
            DataTable dataUsers = new DataTable();
            try
            {
                connection.open();
                dataUsers = connection.Read_Data("getDataUsersAdmin", null);
                connection.cloes();
                return dataUsers;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataUsers;
            }

        }
        //==> 3 getData To Users Teachers
        public DataTable getDataUsersTeachers()
        {
            DataTable dataUsers = new DataTable();
            try
            {
                connection.open();
                dataUsers = connection.Read_Data("getDataUsersTeachers", null);
                connection.cloes();
                return dataUsers;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataUsers;
            }

        }
        //==> 4 get Data To Users Data Students
        public DataTable getDataUsersStudents()
        {
            DataTable dataUsers = new DataTable();
            try
            {
                connection.open();
                dataUsers = connection.Read_Data("getDataUsersStudents", null);
                connection.cloes();
                return dataUsers;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataUsers;
            }

        }
        //==> 5 Insert To Users
        public void insertUser(int createdByUserId,string username,string passwordHash,string role,string fullName
                                ,string phoneNumber ,DateTime birthDate ,string address)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[8];
                param[0] = new SqlParameter("@created_by_user_id", SqlDbType.Int);
                param[0].Value = createdByUserId;

                param[1] = new SqlParameter("@username", SqlDbType.VarChar);
                param[1].Value = username;

                param[2] = new SqlParameter("@password_hash", SqlDbType.VarChar);
                param[2].Value = passwordHash;

                param[3] = new SqlParameter("@role", SqlDbType.VarChar);
                param[3].Value = role;

                param[4] = new SqlParameter("@full_name", SqlDbType.VarChar);
                param[4].Value = fullName;

                param[5] = new SqlParameter("@phone_number", SqlDbType.VarChar);
                param[5].Value = phoneNumber;

                param[6] = new SqlParameter("@birth_date", SqlDbType.Date);
                param[6].Value = birthDate;

                param[7] = new SqlParameter("@address", SqlDbType.VarChar);
                param[7].Value = address;
                connection.process("insertUsers", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 6 update To Users
        public void updateUsers(int id, string username, string passwordHash, string role, string fullName
                                , string phoneNumber, DateTime birthDate, string address)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[8];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;

                param[1] = new SqlParameter("@username", SqlDbType.VarChar);
                param[1].Value = username;

                param[2] = new SqlParameter("@password_hash", SqlDbType.VarChar);
                param[2].Value = passwordHash;

                param[3] = new SqlParameter("@role", SqlDbType.VarChar);
                param[3].Value = role;

                param[4] = new SqlParameter("@full_name", SqlDbType.VarChar);
                param[4].Value = fullName;

                param[5] = new SqlParameter("@phone_number", SqlDbType.VarChar);
                param[5].Value = phoneNumber;

                param[6] = new SqlParameter("@birth_date", SqlDbType.Date);
                param[6].Value = birthDate;

                param[7] = new SqlParameter("@address", SqlDbType.VarChar);
                param[7].Value = address;
                connection.process("updateUsers", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 7 Delete To Users
        public void deleteUser(int id)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                connection.process("deleteUser", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        //==> 8 Get Data Check User Name To Users
        public DataTable getDataCheckUserName(string userN)
        {
            DataTable dataUsers = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@userName", SqlDbType.NVarChar);
                param[0].Value = userN;
                dataUsers = connection.Read_Data("getDataCheckUserName", param);
                connection.cloes();
                return dataUsers;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataUsers;
            }

        }
        //==> 9 Get CheckIsDelete
        public DataTable getDataIsCanDeleteUser(int id)
        {
            DataTable dataUser = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                dataUser = connection.Read_Data("getDataIsCanDeleteUser", param);
                connection.cloes();
                return dataUser;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataUser;
            }
        }
        //==> 10 create Init User 
        public void createInitUser(string passwordHash)
        {
            try
            {
                connection.open();

                SqlParameter[] parameters = new SqlParameter[1];

                parameters[0] = new SqlParameter("@passwordHash", SqlDbType.VarChar);
                parameters[0].Value = passwordHash;

                connection.process("createInitUser", parameters);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 11 update User State
        public void updateUserState(int idUser,bool isActive)
        {
            try
            {
                connection.open();

                SqlParameter[] parameters = new SqlParameter[2];

                parameters[0] = new SqlParameter("@idUser", SqlDbType.Int);
                parameters[0].Value = idUser;

                parameters[1] = new SqlParameter("@isActive", SqlDbType.Bit);
                parameters[1].Value = isActive;

                connection.process("updateUserState", parameters);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 12 getData Users By Teacher
        public DataTable getDataUsersByTeacher(int idTeacher)
        {
            DataTable dataUsers = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@idTeacher", SqlDbType.Int);
                param[0].Value = idTeacher;
                dataUsers = connection.Read_Data("getDataUsersByTeacher", param);
                connection.cloes();
                return dataUsers;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataUsers;
            }

        }
        //==> 13 Update Last Login User
        public void updateLastLoginUser(int idUser)
        {
            try
            {
                connection.open();

                SqlParameter[] parameters = new SqlParameter[1];

                parameters[0] = new SqlParameter("@idUser", SqlDbType.Int);
                parameters[0].Value = idUser;

                connection.process("updateLastLoginUser", parameters);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 14 Check User State
        public DataTable checkUserState(int idUser)
        {
            DataTable dataUsers = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@idUser", SqlDbType.Int);
                param[0].Value = idUser;
                dataUsers = connection.Read_Data("checkUserState", param);
                connection.cloes();
                return dataUsers;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataUsers;
            }

        }
        #endregion
    }

}
