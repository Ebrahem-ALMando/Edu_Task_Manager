using Edu_Task_Manager.Classes.Connection.UsersProcess;
using Edu_Task_Manager.Classes.Login;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Management.Instrumentation;
using System.Windows;

namespace Edu_Task_Manager.Classes
{
    internal class Cls_AppConfig
    {
        public bool AppInitialized { get; set; }
        private static Cls_AppConfig config;
        private static string configFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "EduTaskManager", "config.json");
        private Cls_AppConfig() { }

        private  static void CreateInitUser()
        {
            try
            {
                string plainPasww = "admin123";
                var (hashedPassword, salt)= Cls_PasswordManager.HashPassword(plainPasww);
                Cls_UsersDB.Instance.createInitUser($"{hashedPassword}-{salt}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static bool LoadConfig()
        {
            try
            {

                if (!File.Exists(configFilePath))
                {
           
                    Directory.CreateDirectory(Path.GetDirectoryName(configFilePath));
                    config = new Cls_AppConfig { AppInitialized = false }; 
                    File.WriteAllText(configFilePath, JsonConvert.SerializeObject(config, Formatting.Indented));
                    return false;
                }
   
                config = JsonConvert.DeserializeObject<Cls_AppConfig>(File.ReadAllText(configFilePath));
                return config.AppInitialized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static void LoadInitConfig()
        {
            try
            {
                if (!LoadConfig())
                {
                    CreateInitUser();
                    config.AppInitialized = true; 
                    File.WriteAllText(configFilePath, JsonConvert.SerializeObject(config, Formatting.Indented));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
