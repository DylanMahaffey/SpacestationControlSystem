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
    /// Interaction logic for TrashCompactor.xaml
    /// </summary>
    public partial class TrashCompactor : UserControl
    {
        public SystemControl controls;

        public TrashCompactor()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            
            var window = Window.GetWindow(this);

            window.KeyDown += trashCompactorControls;
            this.Width = window.Width;
            this.Height = window.Height;

            
        }

        private void trashCompactorControls(object sender, KeyEventArgs e)
        {
            var window = Window.GetWindow(this);
            if (e.Key == Key.Escape)
            {
                (Application.Current.MainWindow.FindName("gameContent") as ContentControl).Content = controls;
                window.KeyDown -= trashCompactorControls;
            }
        }
    }
}
