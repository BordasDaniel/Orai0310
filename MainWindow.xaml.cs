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

namespace Orai0310
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


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tbxSzam.Text, out int db))
            {
                if (db >= 1 && db <= 10)
                {
                    for (int i = 0; i < db; i++)
                    {
                        Button newButton = new()
                        {
                            Content = $"{i + 1}.",
                            Height = 30,
                            Width = 50,
                            Margin = new Thickness(5, i * 30, 5, 5),
                            HorizontalAlignment = HorizontalAlignment.Left,
                            VerticalAlignment = VerticalAlignment.Top,
                        };
                        newButton.Click += NewBtnClick;
                        gridGombok.Children.Add(newButton);
                    }
                }
                else
                {
                    MessageBox.Show("Határon kívüli szám");
                }

            }
            else
            {
                MessageBox.Show("Nem megfelelő számformátum");
            }

        }

        private void NewBtnClick(object sender, RoutedEventArgs e)
        {

            MessageBox.Show($"Click történt a {(sender as Button).Content} gombon");
        }

        private void tbxSzambevitel_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!int.TryParse((sender as TextBox).Text, out int eredmeny))
            {
                MessageBox.Show("Nem megfelelő számformátum");
                (sender as TextBox).Text = "0";
            }
          
        }
    }
}