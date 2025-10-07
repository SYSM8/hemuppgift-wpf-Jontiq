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
using System.Windows.Shapes;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
        }

        private void RowColumnApply_Click(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(ColumnInput.Text, out int column)&&(int.TryParse(RowInput.Text, out int row)))
            {
                if (column >= 0 && column <= 3 && row >= 0 && row <= 3)
                {
                    Grid.SetColumn(GreenBox, column);
                    Grid.SetRow(GreenBox, row);
                    BoxText.Text = $"Row {row}, Column {column}";
                }
                else
                {
                    MessageBox.Show("Please only enter numbers between 0-3.");
                }
            }
            else
            {
                MessageBox.Show("Please enter numerical values");
            }
        }
    }
}
