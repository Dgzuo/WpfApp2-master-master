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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int n = 15;
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            int time = int.Parse(Number.Text);
            switch(time)
            {
            case 48:
                    {

                        int minute = int.Parse(Minute.Text);   
                        time*=;
                        resault.Text = "Одесса" + " " + time.ToString() + "Грив";
                    }
                    break;

                case 44:
                    {

                        int minute = int.Parse(Minute.Text);
                        time *= 18;
                        resault.Text = "Киев" + "" + time.ToString() + "Грив";
                    }
                    break;

                case 46:
                    {

                        int minte = int.Parse(Minute.Text);
                        time *= 13;
                        resault.Text = "Харьков" + "" + time.ToString() + "Грив";
                    }
                    break;

                case 45:
                    {

                        int minte = int.Parse(Minute.Text);
                        time *= 11;
                        resault.Text = "Харьков" + "" + time.ToString() + "Грив";
                    }
                    break;

            }
            
        }
    }
}
