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

namespace GoingDynamic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Random _random = new Random();

        public MainWindow()
        {
            InitializeComponent();

            GenerateRows(35, 8);
        }

        public void GenerateRows(int totalItemsCount, int numberOfColumns)
        {
            int numberOfRows = totalItemsCount % numberOfColumns == 0 ? totalItemsCount / numberOfColumns : totalItemsCount / numberOfColumns + 1;

            int cellCount = 0;

            for (int i = 0; i < numberOfRows; i++)
            {
                root.RowDefinitions.Add(new RowDefinition()
                {
                    Height = new GridLength(1, GridUnitType.Star)
                });

                Grid grid = new Grid();

                for (int j = 0; j < numberOfColumns; j++)
                {
                    grid.ColumnDefinitions.Add(new ColumnDefinition()
                    {
                        Width = new GridLength(1, GridUnitType.Star)
                    });

                    grid.ShowGridLines = true;

                    if (cellCount < totalItemsCount)
                    {
                        Button button = new Button();
                        button.Margin = new Thickness(10);

                        grid.Children.Add(button);

                        Grid.SetRow(button, i);
                        Grid.SetColumn(button, j);
                    }

                    cellCount++;
                }

                root.Children.Add(grid);
                Grid.SetRow(grid, i);
            }
        }
    }
}
