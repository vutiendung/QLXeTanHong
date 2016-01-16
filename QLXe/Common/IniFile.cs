using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace QLXe
{
    class IniFile
    {
        private string fileName = "";
        private string SectionName = "ConfigApp";

        [DllImport("kernel32.dll")]
        private static extern int WritePrivateProfileString(
                                                              string ApplicationName,
                                                              string KeyName,
                                                              string StrValue,
                                                              string FileName
                                                            );
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(
                                                            string ApplicationName,
                                                            string KeyName,
                                                            string DefaultValue,
                                                            StringBuilder ReturnString,
                                                            int nSize,
                                                            string FileName
                                                        );

        public IniFile(String fileName)
        {
            this.fileName = fileName;
            if (!System.IO.File.Exists(fileName))
            {
                var file = System.IO.File.Create(fileName);
                file.Close();
            }
        }

        public void WriteValues(string KeyName, string Values)
        {
            WritePrivateProfileString(SectionName, KeyName, Values, fileName);
        }

        public string ReadValue(string KeyName)
        {
            StringBuilder result = new System.Text.StringBuilder(255);
            GetPrivateProfileString(SectionName, KeyName, "", result, 255, fileName);
            return result.ToString().Trim();
        }

        public string getConnection()
        {
            string ConnectionString = "";

            string serverName = ReadValue("ServerName");
            string instanceName = ReadValue("InstanceName");
            string databaseName = ReadValue("DatabaseName");
            string aurthentication = ReadValue("Aurthentication");
            string userName = ReadValue("UserName");
            string password = ReadValue("Password");

            if (aurthentication.Equals("true"))
            {

            }

            return ConnectionString;
        }
    }
}
