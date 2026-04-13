using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace RestauraceKasa
{
    public static class DataManager
    {

        private static readonly string DataDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Data");


        static DataManager()
        {
            if (!Directory.Exists(DataDirectory))
            {
                Directory.CreateDirectory(DataDirectory);
            }
        }

        public static void SaveData<T>(List<T> data, string fileName)
        {
            try
            {
                string filePath = Path.Combine(DataDirectory, fileName);
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(data, options);
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Chyba při ukládání dat: " + ex.Message);
            }
        }


        public static List<T> LoadData<T>(string fileName)
        {
            try
            {
                string filePath = Path.Combine(DataDirectory, fileName);

                if (!File.Exists(filePath))
                {
                    return new List<T>();
                }
                string jsonString = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<T>>(jsonString) ?? new List<T>();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Chyba při načítání dat: " + ex.Message);
                return new List<T>();
            }
        }


    }
}
