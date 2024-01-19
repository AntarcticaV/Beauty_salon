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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Beauty_salon.Page;

namespace Beauty_salon
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new AdminPanel(MainFrame);
        }

        private void FrameOnLoadCompleted(object sender, NavigationEventArgs e)
        {
            try
            {
                AdminPanel mf = (AdminPanel)e.Content;
                mf.Load();

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);

            }

        }
    }
}
