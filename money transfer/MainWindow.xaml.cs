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
            CBRubl.Visibility = Visibility.Visible;
            CBForeignCurrency.Visibility = Visibility.Collapsed;
            CBRubl.IsEnabled = true;

        }

        private void RBForeignCurrency_Checked(object sender, RoutedEventArgs e)  // выбран перевод из инстранной валюты в рубли
        {
            CBRubl.Visibility = Visibility.Collapsed;
            CBForeignCurrency.Visibility = Visibility.Visible;
            CBForeignCurrency.IsEnabled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)  // событие для кнопки рассчета площади
        {
            try
            {
                if (RBRubl.IsChecked == true)
                {
                    switch (CBRubl.SelectedIndex)
                    {
                        case 0:
                            double transferToDollar = (Convert.ToDouble(TBRuble.Text)+(Convert.ToDouble(TBKopek.Text)/100)) * 0.017;
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
                if (RBForeignCurrency.IsChecked == true)
                {
                    switch (CBForeignCurrency.SelectedIndex)
                    {
                        case 0:
                            double dollartransferToRuble = Convert.ToDouble(TBSumm.Text)/0.017;
                            TBTransferSummRuble.Text = dollartransferToRuble + "";
                            TBTransferSummKopek.Text = dollartransferToRuble * 100 + "";
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
    }
}
