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
using System.Windows.Shapes;

namespace _05042018
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
       
        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            
            
            if (checkBox1.IsChecked == true)
            {
                button1.Visibility = Visibility.Visible;

            }
            if (checkBox1.IsChecked == false)
            {
                button1.Visibility = Visibility.Hidden;
            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow gir = new MainWindow();
            gir.nickname = textBox1.Text;
            gir.email = textBox4.Text;
            gir.password=passwordBox1.Password.ToString();
            if ((textBox1.Text == "") || (passwordBox1.Password== "") || (passwordBox2.Password == "") || (textBox4.Text == ""))
            {
                MessageBox.Show("Please do not leave blank");
                return;
            }
            if (passwordBox1.Password.ToString() != passwordBox2.Password.ToString())
            {
                MessageBox.Show("Passwords do not match");
                return;
            }
          
            progressBar1.Visibility = Visibility.Visible;
            MessageBox.Show("You are successfully redirected");
            gir.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
             if (comboBox1.SelectedIndex == 0)
             {
                textBox4.Text = textBox4.Text + "@hotmail.com";
            }
             if (comboBox1.SelectedIndex == 1)
             {
                 textBox4.Text = textBox4.Text + "@gmail.com";
             }
             if (comboBox1.SelectedIndex == 2)
             {
                 textBox4.Text = textBox4.Text + "@outlook.com";
             }
             if (comboBox1.SelectedIndex == 3)
             {  
                 textBox4.Text = textBox4.Text + "@msn.com";
             }
             if (comboBox1.SelectedIndex == 4)
             {
                 textBox4.Text = textBox4.Text + "@yahoo.com";
             }
        }
        }

       
    }
