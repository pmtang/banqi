using Banqi.MVVM.Model;
using Banqi.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Banqi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Border highlight;

        public MainWindow()
        {
            InitializeComponent();

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 8; col++)
                {

                    Button button = new Button();
                    button.Name = "Btn" + row + col;

                    button.PreviewMouseRightButtonDown += OnBtnDoubleClick;
                    button.PreviewMouseLeftButtonDown += OnBtnClick;

                    button.Background = new SolidColorBrush(Colors.Black);

                    Grid.SetRow(button, row);
                    Grid.SetColumn(button, col);
                    grid.Children.Add(button);
                }
            }

            highlight = new Border();
            highlight.BorderBrush= new SolidColorBrush(Colors.Green);
            highlight.BorderThickness = new Thickness(5);

            Binding highlightRow = new Binding();
            highlightRow.Path = new PropertyPath("Setting.FirstPiece.Item1");
            highlightRow.Mode = BindingMode.OneWay;

            Binding highlightCol = new Binding();
            highlightCol.Path = new PropertyPath("Setting.FirstPiece.Item2");
            highlightCol.Mode = BindingMode.OneWay;

            highlight.SetBinding(Grid.RowProperty, highlightRow);
            highlight.SetBinding(Grid.ColumnProperty, highlightCol);

            
        }

        private void OnBtnDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                int row = Grid.GetRow((UIElement)sender);
                int col = Grid.GetColumn((UIElement)sender);

                if (mainViewModel.FlipPieceRequest(row, col))
                {
                    Button button = (Button)sender;
                    Binding binding = new Binding();
                    binding.Path = new PropertyPath($"Board[{row}][{col}].Name");
                    binding.Mode = BindingMode.OneWay;
                    button.SetBinding(ContentProperty, binding);

                    button.Background = new SolidColorBrush(Colors.White);
                }
            }
        }

        private void OnBtnClick(object sender, MouseButtonEventArgs e)
        {

            if (e.ClickCount == 1)
            {
                int row = Grid.GetRow((UIElement)sender);
                int col = Grid.GetColumn((UIElement)sender);

                MoveState moveState = mainViewModel.MovePieceRequest(row, col);

                switch (moveState)
                {
                    case MoveState.None:
                        break;
                    case MoveState.Selected:
                        grid.Children.Add(highlight);
                        break;
                    case MoveState.Invalid:
                        grid.Children.Remove(highlight);
                        break;
                    case MoveState.Moved:
                        Move(sender, row, col);
                        break;
                    case MoveState.Capture:
                        Move(sender, row, col);
                        break;
                    default:
                        break;
                }
            }
        }

        private void Move(Object sender, int row, int col)
        {
            grid.Children.Remove(highlight);
            Button button = (Button)sender;
            BindingOperations.ClearBinding(button, ContentProperty);

            Binding binding = new Binding();
            binding.Path = new PropertyPath($"Board[{row}][{col}].Name");
            binding.Mode = BindingMode.OneWay;
            button.SetBinding(ContentProperty, binding);
        }
    }
}
