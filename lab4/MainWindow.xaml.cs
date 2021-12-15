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

namespace lab4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Posilca> posilcas;

        public MainWindow()
        {
            InitializeComponent();
            posilcas = new List<Posilca>();
            posilcas.Add(new Posilca("Петр", "Иван", "Улан-Удэ", 20000, 20));
            data.ItemsSource = posilcas;
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            posilcas.Add(new Posilca(inputFioOt.Text, inputFioPo.Text, inputAddress.Text, Convert.ToInt32(inputIndex.Text), Convert.ToInt32(inputWeight.Text)));
            inputFioOt.Text = "";
            inputFioPo.Text = "";
            inputIndex.Text = "";
            inputAddress.Text = "";
            inputWeight.Text = "";
            data.ItemsSource = posilcas;
            data.Items.Refresh();
        }

        private void Delet(object sender, RoutedEventArgs e)
        {
            Posilca posilca = data.SelectedItem as Posilca;
            posilcas.Remove(posilca);
            data.Items.Refresh();
        }

        private void Sum(object sender, RoutedEventArgs e)
        {
            if (data.SelectedItems.Count > 2)
            {
                MessageBox.Show("Вы выбрали больше 2х посылок");
            }
            else
            {
                Posilca posilca1 = data.SelectedItems[0] as Posilca;
                Posilca posilca2 = data.SelectedItems[1] as Posilca;
                posilcas.Add(posilca1 + posilca2);
                data.ItemsSource = posilcas;
                data.Items.Refresh();
            }
        }

        private void Compare(object sender, RoutedEventArgs e)
        {
            if (data.SelectedItems.Count > 2)
            {
                MessageBox.Show("Вы выбрали больше 2х посылок");

            }
            else
            {
                Posilca posilca1 = data.SelectedItems[0] as Posilca;
                Posilca posilca2 = data.SelectedItems[1] as Posilca;

                if (posilca1 > posilca2)
                {
                    MessageBox.Show($"посылка с адрресом {posilca1.Address} тяжелее", "Важная информация", MessageBoxButton.OK,  MessageBoxImage.Information);
                }
                else
                {
                    if (posilca1 < posilca2)
                    {
                        MessageBox.Show($"посылка с адрресом {posilca2.Address} тяжелее", "Важная информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show($"посылки равны по весу", "Важная информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }

            }
        }
    }
}
