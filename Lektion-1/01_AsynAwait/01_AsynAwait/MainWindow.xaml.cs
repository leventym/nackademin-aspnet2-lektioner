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

namespace _01_AsynAwait
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

        private void btnBlockingCode_Click(object sender, RoutedEventArgs e)
        {
            tblockStatus.Text = "";
            Task.FromResult(() => RunCode());
            tblockStatus.Text = "done";
        }

        private async void nonBlockingCode_Click(object sender, RoutedEventArgs e)
        {
            tblockStatus.Text = "";
            await RunCode();
            tblockStatus.Text = "done";
        }

        private async Task<string> RunCode()
        {
            
            await Task.Delay(5000);
            return "Code completed";
        }
    }
}
