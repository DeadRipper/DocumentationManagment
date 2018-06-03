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
using WPF.MDI;

namespace Desktop
{
    /// <summary>
    /// Логика взаимодействия для StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        string _original_title;

        void Container_MdiChildTitleChanged(object sender, RoutedEventArgs e)
        {
            if (Container.ActiveMdiChild != null && Container.ActiveMdiChild.WindowState == WindowState.Maximized)
                Title = _original_title + " - [" + Container.ActiveMdiChild.Title + "]";
            else
                Title = _original_title;
        }

        private void StudWindow_Click(object sender, RoutedEventArgs e)
        {
            Container.Children.Add(new MdiChild
            {
                Title = "Студенты",
                Content = new Students(),
                Width = 714,
                Height = 734,
                Position = new Point(300, 80)
            });
        }

        private void PrepWindow_Click(object sender, RoutedEventArgs e)
        {
            Container.Children.Add(new MdiChild
            {
                Title = "Преподаватели",
                Content = new UsersWindow(),
                Width = 714,
                Height = 734,
                Position = new Point(300, 80)
            });
        
        }
    }
}
