using System.Windows;
using System.Windows.Input;
using TNovCommon;

namespace TNovParking
{
    /// <summary>
    /// Логика взаимодействия для ParkWPF.xaml
    /// </summary>
    public partial class ParkWPF : Window
    {
        public ParkWPF(ParkViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;

            this.SizeToContent = SizeToContent.Height;
        }

        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
        }

        private void escButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }

        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            HelpLinks.ShowHelp("Парковки");
        }
    }
}
