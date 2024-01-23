using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Beauty_salon.Entity;

namespace Beauty_salon.Windows
{
    /// <summary>
    /// Логика взаимодействия для ClientOfService.xaml
    /// </summary>
    public partial class ClientOfService : System.Windows.Window
    {
        private string pathStoregeImage =
            $"C:\\Users\\{Environment.UserName}\\OneDrive\\Документы\\Beauty_salon\\Image\\";
        public ClientOfService(Client client)
        {
            InitializeComponent();
            Load(client);
        }

        public void Load(Client client)
        {
            var listToDataGrid = new List<DataGridService>();
            foreach (var item in client.ClientService)
            {
                var temp = new DataGridService();
                var MainImagePath = item.Service.MainImagePath.Substring(1);
                temp.Image = pathStoregeImage + MainImagePath;
                temp.Name = item.Service.Title;
                temp.Price = "Цена: " + ((int)item.Service.Cost).ToString();
                temp.Time = (item.Service.DurationInSeconds / 60).ToString()+ " мин";
                temp.Dm = "Скидка: " + item.Service.Discount.ToString() + '%';
                listToDataGrid.Add(temp);
            }
            DataGridClient.ItemsSource = listToDataGrid;
        }
    }

    public class DataGridService
    {
        public string Name { get; set; }
        public string Time { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }
        public string Dm { get; set; }
    }
}
