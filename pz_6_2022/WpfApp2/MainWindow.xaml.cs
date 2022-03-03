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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Boolean[] oper = { false, false, false, false };
        int a;
        int b;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + "1";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + "2";
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + "+";
        }



        private void minus_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + "-";
        }

        private void multi_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + "*";
        }

        private void divis_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + "/";
        }
        private void equal_Click(object sender, RoutedEventArgs e)
        {
            char[] ch = Result.Text.ToCharArray();
            string ad = "";
            string bd = "";
            for (int i = 0; i < ch.Length/2; i++)
            {
                ad += ch[i];
            }
            for (int i = (ch.Length/2)+1; i < ch.Length; i++)
            {
                bd += ch[i];
            }
            decimal a = Convert.ToDecimal(ad);
            decimal b = Convert.ToDecimal(bd);
            if (ch.Contains('+')) Result.Text = (a+b).ToString();
            if (ch.Contains('-')) Result.Text = (a - b).ToString();
            if (ch.Contains('*')) Result.Text = (a * b).ToString();
            if (ch.Contains('/')) Result.Text = (a / b).ToString();


        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + "3";
        }

        private void fo_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + "4";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + "5";
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + "6";
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + "7";
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + "8";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + "9";
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + "0";
        }
    }
}
