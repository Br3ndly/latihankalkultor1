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

namespace latihan
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
        double angka1, angka2;
        string opt;

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            var data = btn.Content.ToString();

            if (textboxhasil.Text.Length == 1 && textboxhasil.Text == "0") // jika length=1 dan textbox adalah 0
            {
                if (data == ".") //jika tombol yg ditekan adalah "."
                {
                    textboxhasil.Text = textboxhasil.Text + data; // tambahkan titik dibelakang 0

                }
                else
                {
                    textboxhasil.Text = data; //gantikan 0 dengan angka baru
                }

            }
            else
            {
                if (data == "." && textboxhasil.Text.Contains(".")) // jika yng datang titik dan textbox belum ada sudah ada titik kembali;
                {
                    return;
                }
                else
                {
                    textboxhasil.Text = textboxhasil.Text + data; // gabungkan data lama dengan data baru
                }
            }

        }

        private void btn_opr(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            opt = btn.Content.ToString();
            angka1 = Convert.ToDouble(textboxhasil.Text);
            textboxhasil.Text = "0";

        }

        private void btn_samadengan(object sender, RoutedEventArgs e)
        {
            angka2 = Convert.ToDouble(textboxhasil.Text);
            switch (opt)
            {
                case "+":
                    textboxhasil.Text = (angka1 + angka2).ToString();
                    break;

                case "-":
                    textboxhasil.Text = (angka1 - angka2).ToString();
                    break;

                case "/":
                    textboxhasil.Text = (angka1 / angka2).ToString();
                    break;

                case "x":
                    textboxhasil.Text = (angka1 * angka2).ToString();
                    break;
                default:
                    break;
            }
        }

        private void btn_del(object sender, RoutedEventArgs e)
        {
            if (textboxhasil.Text.Length == 1) /// jika panjang text ==1 
            {
                textboxhasil.Text = "0"; // ganti jadi 0
            }
            else
                textboxhasil.Text = textboxhasil.Text.Substring(0, textboxhasil.Text.Length - 1); // kurang 1 digit di belakang
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            textboxhasil.Text = "0";
            angka1 = 0;
            angka2 = 0;
            opt = "";
        }
    }
}
