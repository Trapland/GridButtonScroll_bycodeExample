using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            Grid grid = new Grid();
            ScrollViewer sb = new ScrollViewer();
            sb.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
            sb.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
            sb.Content = grid;
            this.Content = sb;
            for (int i = 0; i < 100; i++)
            {
                ColumnDefinition cd = new ColumnDefinition();
                cd.MinWidth = 100;
                RowDefinition rd = new RowDefinition();
                rd.MinHeight = 100;
                grid.ColumnDefinitions.Add(cd);
                grid.RowDefinitions.Add(rd);
                for (int j = 0; j < 100; j++)
                {
                    Button MyControl = new Button();
                    Grid.SetColumn(MyControl, i);
                    Grid.SetColumnSpan(MyControl, 1);
                    Grid.SetRow(MyControl, j);
                    Grid.SetRowSpan(MyControl, 1);
                    grid.Children.Add(MyControl);
                }
            }
        }
    }
}
