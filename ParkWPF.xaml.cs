using System.Windows;

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
            this.Close(); // закрытие окна
        }

        private void Border_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

        }

        private void escButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close(); // закрытие окна
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            string commandText = @"https://portal.talan.group/knowledge/proektirovanie/parking/";
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = commandText;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }
    }
}
