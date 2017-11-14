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

namespace ResorcesDemo
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

        private void CommandNew_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_PreviewExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            var menuItem = e.Source as MenuItem;
            if (menuItem == null)
            {
                MessageBox.Show("Команда отработала");
                return;
            }

            MessageBox.Show($"Вы кликнули по пункту \"{menuItem.Header.ToString()}\"!");
        }

        private void CommandBinding_PreviewExecuted_1(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
