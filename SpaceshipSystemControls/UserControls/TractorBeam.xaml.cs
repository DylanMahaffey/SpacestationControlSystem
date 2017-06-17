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
    /// Interaction logic for TractorBeam.xaml
    /// </summary>
    public partial class TractorBeam : UserControl
    {
        public SystemControl controls;

        public TractorBeam()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);
            window.KeyDown += tractorBeamControls;
        }

        private void tractorBeamControls(object sender, KeyEventArgs e)
        {
            var window = Window.GetWindow(this);
            if (e.Key == Key.Escape)
            {
                (Application.Current.MainWindow.FindName("gameContent") as ContentControl).Content = controls;
                window.KeyDown -= tractorBeamControls;
            }

        }
    }
}
