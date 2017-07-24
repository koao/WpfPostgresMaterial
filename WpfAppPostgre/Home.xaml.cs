using System;
using MaterialDesignThemes.Wpf;
using System.Windows;
using System.Windows.Controls;


namespace WpfAppPostgre
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private async void MesseageButton_Click(object sender, RoutedEventArgs e)
        {
            var sampleMessageDialog = new SampleMessageDialog
            {
                Message = {Text = "メッセージテスト\nあいうえお"}
            };

            await DialogHost.Show(sampleMessageDialog, "RootDialog");  
        }
    }
}
