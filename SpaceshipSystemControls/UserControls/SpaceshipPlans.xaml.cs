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

namespace SpaceshipSystemControls.UserControls
{
    /// <summary>
    /// Interaction logic for SpaceshipPlans.xaml
    /// </summary>
    public partial class SpaceshipPlans : UserControl
    {
        public SystemControl controls;

        public SpaceshipPlans()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);
            window.KeyDown += spaceshipPlansControls;
        }

        private void spaceshipPlansControls(object sender, KeyEventArgs e)
        {
            var window = Window.GetWindow(this);
            if (e.Key == Key.Escape)
            {
                (Application.Current.MainWindow.FindName("gameContent") as ContentControl).Content = controls;
                window.KeyDown -= spaceshipPlansControls;
            }
        }
    }
}
