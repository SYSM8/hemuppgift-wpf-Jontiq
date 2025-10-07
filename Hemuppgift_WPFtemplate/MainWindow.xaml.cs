using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Media;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //HEJ - HEJ?
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GridButton_Click(object sender, RoutedEventArgs e)
        {
            GridWindow newGridWindow = new GridWindow();
            newGridWindow.Show();
        }

        private void StackPanelButton_Click(object sender, RoutedEventArgs e)
        {
            StackPanelWindow newStackPanelWindow = new StackPanelWindow();
            newStackPanelWindow.Show();
        }

        private void WrapPanelButton_Click(object sender, RoutedEventArgs e)
        {
            WrapPanelWindow newWrapPanelWindow = new WrapPanelWindow();
            newWrapPanelWindow.Show();
        }

        private void DockPanelButton_Click(object sender, RoutedEventArgs e)
        {
            DockPanelWindow newDockPanelWindow = new DockPanelWindow();
            newDockPanelWindow.Show();
        }
    }
}