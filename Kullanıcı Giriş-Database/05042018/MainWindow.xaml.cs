using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _05042018
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
      
        public string nickname;
        public string password;
        public string email;
        int hak = 3;
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Window1 a = new Window1();
            this.Hide();
            a.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == nickname && passwordBox1.Password.ToString() == password)
            {
             
                
                Form1 g = new Form1();
                g.Show();

            }
            if (hak != 0)
            {
                if (textBox1.Text != nickname || passwordBox1.Password.ToString() != password)
                {
                    label3.Content = "Your password is incorrect = " + hak.ToString();
                    hak--;
                }
            }          
                else if(hak==0)
                {
                    label3.Content = "Your Entry Blocked";
                    button3.Visibility = Visibility.Visible;
                }
            }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Window2 w = new Window2();
            w.Show();
            this.Hide();
        }

        }
    }
