using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Windows;
using PostSystemMVVM.Serialization;

namespace PostSystemMVVM.Model
{
    [DataContract]
    public class DataModel
    {
        [DataMember]
        public IEnumerable<Branch> Branches { get; set; }
        [DataMember]
        public IEnumerable<Client> Clients { get; set; }
        [DataMember]
        public IEnumerable<Worker> Workers { get; set; }
        [DataMember]
        public IEnumerable<Order> Orders { get; set; }

        public DataModel()
        {
            Branches = new List<Branch>() { new Branch() };
            Clients = new List<Client>() { new Client() };
            Workers = new List<Worker>() { new Worker() };
            Orders = new List<Order>() { new Order() };
        }

        public static string DataPath => "C:\\Users\\franc\\OneDrive\\Робочий стіл\\data.json";

        public static DataModel Load()
        {
            if (File.Exists(DataPath))
            {
                try
                {
                    var data = DataSerializer.DeserializeData(DataPath);
                    if (data != null)
                    {
                        return data;
                    }
                    else
                    {
                        MessageBox.Show("Файл порожній або пошкоджений. Створюється нова модель.");
                        return new DataModel();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при завантаженні файлу: {ex.Message}. Створюється нова модель.");
                    return new DataModel();
                }
            }
            else
            {
                MessageBox.Show("Файл не знайдено. Створюється новий файл і нова модель.");
                return new DataModel();
            }
        }

        public void Save()
        {
            try
            {
                DataSerializer.SerializeData(DataPath, this);
                MessageBox.Show("Дані успішно збережені.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні файлу: {ex.Message}");
            }
        }
    }
}
