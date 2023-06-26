using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAPP
{
    public class Configuration
    {
        const string API_PATH = "API_PATH";
        private static Configuration instance;
        private Dictionary<string, string> config;
        private string path;
        private Configuration() {
            config = new Dictionary<string, string>();
            var fileName = $"{Assembly.GetEntryAssembly().GetName().Name}.cfg";
            path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            GrantCfgFile(path);
            LoadConfigs();
        }

        private void LoadConfigs()
        {
            string[] rows = File.ReadAllLines(path);

            foreach (string row in rows)
            {
                string[] split = row.Split('=');
                string key = split[0];
                string value = split[1];
                config[key] = value;
            }
        }

        private void GrantCfgFile(string path)
        {
            if (File.Exists(path)) return;
            File.WriteAllText(path, $"{API_PATH}=http://localhost:5106");
        }

        public static Configuration GetInstance()
        {
            if(instance == null)
                instance = new Configuration();
            return instance;
        }

        public string GetValue(string key)
            =>config[key];
        public string GetApiPath()
            => config[API_PATH];

    }
}
