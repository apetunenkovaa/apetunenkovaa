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

namespace money_transfer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }
        private void RBRuble_Checked(object sender, RoutedEventArgs e)  // выбран перевод из рубля в иностранную валюту
        {
            Param_Ruble.Visibility = Visibility.Visible;
            CBForeignCurrency.Visibility = Visibility.Collapsed;
            ForeignCurrency.Visibility = Visibility.Collapsed;
            CBRubl.IsEnabled = true;
           
           



        }
        private void Money_Transfer_Checked(object sender, RoutedEventArgs e)  // выбран перевод из рубля в иностранную валюту
        {
           
        }





        private void RBForeignCurrency_Checked(object sender, RoutedEventArgs e)  // выбран перевод из инстранной валюты в рубли
        {
            ForeignCurrency.Visibility = Visibility.Visible;
            Param_Ruble.Visibility = Visibility.Collapsed;
            CBForeignCurrency.Visibility = Visibility.Visible;
            CBForeignCurrency.IsEnabled = true;
        }

        private void Button_Click_1_1(object sender, RoutedEventArgs e)  // событие для перевода денег
        {
            Money_Transfer.Visibility = Visibility.Visible;
            //try
            //{
            //    if (TBRuble.Text TBKopek.Text )
            //}
            //catch
            //{
            //    Console.WriteLine("Проверьте коректность даннных!");
            //}
        }
        private void Button_Click_1_2(object sender, RoutedEventArgs e)  // событие для перевода денег
        {
            try
            {
                if (RBRubl.IsChecked == true)
                {
                    switch (CBRubl.SelectedIndex)
                    {
                        case 0:
                            double transferToDollar = (Convert.ToDouble(TBRuble.Text) + (Convert.ToDouble(TBKopek.Text) / 100)) * 0.017;
                            TBlResult.Text = transferToDollar + "";
                            break;
                        case 1:
                            double transferToEvro = (Convert.ToDouble(TBRuble.Text) + (Convert.ToDouble(TBKopek.Text) / 100)) * 0.018;
                            TBlResult.Text = transferToEvro + "";
                            break;
                        case 2:
                            double transferToPoundSterling = (Convert.ToDouble(TBRuble.Text) + (Convert.ToDouble(TBKopek.Text) / 100)) * 0.016;
                            TBlResult.Text = transferToPoundSterling + "";
                            break;
                        case 3:
                            double transferToArmenianDram = (Convert.ToDouble(TBRuble.Text) + (Convert.ToDouble(TBKopek.Text) / 100)) * 7.10;
                            TBlResult.Text = transferToArmenianDram + "";
                            break;
                        case 4:
                            double transferToJapaneseYen = (Convert.ToDouble(TBRuble.Text) + (Convert.ToDouble(TBKopek.Text) / 100)) * 2.48;
                            TBlResult.Text = transferToJapaneseYen + "";
                            break;
                        case 5:

                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Проверьте корректность введенных данных");
            }
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)  // событие для перевода денег
        {

            try
            {
               
                if (RBForeignCurrency.IsChecked == true)
                {
                    switch (CBForeignCurrency.SelectedIndex)
                    {
                        case 0:
                            double dollartransferToRuble = Convert.ToDouble(TBSumm.Text) / 0.017;
                            string[] s = Convert.ToString(dollartransferToRuble).Split(',');
                            TBTransferSummRuble.Text = s[0] + "";
                            TBTransferSummKopek.Text = s[1].Remove(2,s[1].Length - 2) + "";
                            break;
                        case 1:
                            double transferToEvro = Convert.ToDouble(TBSumm.Text) / 0.018;
                            string[] x = Convert.ToString(transferToEvro).Split(',');
                            TBTransferSummRuble.Text = x[0] + "";
                            TBTransferSummKopek.Text = x[1].Remove(2, x[1].Length - 2) + "";
                            break;
                        case 2:
                            double transferToPoundSterling = Convert.ToDouble(TBSumm.Text) / 0.016;
                            string[] p = Convert.ToString(transferToPoundSterling).Split(',');
                            TBTransferSummRuble.Text = p[0] + "";
                            TBTransferSummKopek.Text = p[1].Remove(2, p[1].Length - 2) + "";
                            break;
                        case 3:
                            double transferToArmenianDram = Convert.ToDouble(TBSumm.Text) / 7.10;
                            string[] a = Convert.ToString(transferToArmenianDram).Split(',');
                            TBTransferSummRuble.Text = a[0] + "";
                            TBTransferSummKopek.Text = a[1].Remove(2, a[1].Length - 2) + "";
                            break;
                        case 4:
                            double transferToJapaneseYen = Convert.ToDouble(TBSumm.Text) / 2.48;
                            string[] y = Convert.ToString(transferToJapaneseYen).Split(',');
                            TBTransferSummRuble.Text = y[0] + "";
                            TBTransferSummKopek.Text = y[1].Remove(2, y[1].Length - 2) + "";
                            break;
                        case 5:

                            break;
                    }
                }
            }
            catch
            {

                MessageBox.Show($"Проверьте корректность введенных данных");
            }
        }
    }
}
