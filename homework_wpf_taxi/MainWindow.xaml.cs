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

namespace homework_wpf_taxi
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button1.IsEnabled = false;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == "") return;
            if (TextBox2.Text == "") return;
            if (TextBox3.Text == "") return;
            if (RadioButton1.IsChecked == false && RadioButton2.IsChecked == false && RadioButton3.IsChecked == false) return;
            if (Label1.Content.ToString() == "0") return;
            MessageBox.Show($"призвіще та імя замвника: {TextBox1.Text} { TextBox3.Text }\nадреса прибуття: { TextBox2.Text}\nкількість пасажирів: {Label1.Content}\nціна: {Type_cars()} грн ");
            Button2_Click(sender, e);
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)CheckBox.IsChecked )
            {
                Button1.IsEnabled = true;
            }
            else
            {
                Button1.IsEnabled = false;
            }
        }
        static int number = 0;
        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
           
            if (int.Parse(Label1.Content.ToString()) < 8)
            {
                number++;
                Label1.Content = number;
            }
            else
            {
                number = 0;
                Label1.Content = number;
            }
           
        }

        private object Type_cars()
        {
            if ((bool)RadioButton1.IsChecked)
                return RadioButton1.Tag;
            if ((bool)RadioButton2.IsChecked)
                return RadioButton2.Tag;
            if ((bool)RadioButton3.IsChecked)
                return RadioButton3.Tag;
            else
                return 0;
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            Label1.Content = 0;
            number = 0;
            RadioButton1.IsChecked = false;
            RadioButton2.IsChecked = false;
            RadioButton3.IsChecked = false;
            CheckBox.IsChecked = false;
        }
    }
}
