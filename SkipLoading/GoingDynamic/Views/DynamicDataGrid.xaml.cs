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

namespace GoingDynamic.Views
{
    /// <summary>
    /// Interaction logic for DynamicDataGrid.xaml
    /// </summary>
    public partial class DynamicDataGrid : UserControl
    {
        public static Random _random = new Random();

        public DynamicDataGrid()
        {
            InitializeComponent();

            GenerateRows(17, 5);
        }

        public void GenerateRows(int totalItemsCount, int numberOfColumns)
        {
            int numberOfRows = totalItemsCount % numberOfColumns == 0 ? totalItemsCount / numberOfColumns : totalItemsCount / numberOfColumns + 1;

            int cellCount = 0;

            for (int i = 0; i < numberOfRows; i++)
            {
                root.RowDefinitions.Add(new RowDefinition());

                for (int j = 0; j < numberOfColumns; j++)
                {
                    if (cellCount >= totalItemsCount) return;

                    root.ColumnDefinitions.Add(new ColumnDefinition());

                    Button button = new Button();
                    button.Content = (char)_random.Next(10, 100);
                    button.Margin = new Thickness(10);

                    root.Children.Add(button);

                    Grid.SetRow(button, i);
                    Grid.SetColumn(button, j);

                    cellCount++;
                }
            }
        }
    }
}
