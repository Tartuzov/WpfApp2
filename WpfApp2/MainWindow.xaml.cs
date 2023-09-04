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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DockPanel dock = new DockPanel();
            var button1 = new Button { Content = "Button 1" };
            var button2 = new Button { Content = "Button 2" };
            var button3 = new Button { Content = "Button 3" };
            var button4 = new Button { Content = "Button 4" };
            var button5 = new Button { Content = "Button 5" };
            dock.Children.Add(button1);
            dock.Children.Add(button2);
            dock.Children.Add(button3);
            dock.Children.Add(button4);
            dock.Children.Add(button5);
            DockPanel.SetDock(button1, Dock.Top);
            DockPanel.SetDock(button2, Dock.Bottom);
            DockPanel.SetDock(button3, Dock.Left);
            DockPanel.SetDock(button4, Dock.Top);
            grid1.Children.Add(dock);

        }
    }
}
