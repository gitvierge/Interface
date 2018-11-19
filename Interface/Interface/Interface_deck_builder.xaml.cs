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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Interface
{
    /// <summary>
    /// Fichier du créateur de deck
    /// </summary>
    ///
    public partial class Interface_deck_builder : Window
    {
        public Boolean spec = true;


        /// <summary>
        ///  Permet de déplacer la fenêtre facilement en drag & drop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        public Interface_deck_builder()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Splash w = new Splash();
            w.Show();
            this.Close();


        }

        private void openSpec_Click(object sender, RoutedEventArgs e)
        {

            checkSpec();
        }

        

        public void checkSpec()
        {
            if (spec == true)
            {
                closeMenu();
                spec = false;
            }
            else if (spec == false)
            {
                openMenu();
                spec = true;
            }

        }



        public void closeMenu()
        {
            stackPanel.Visibility = Visibility.Hidden;
        }
        public void openMenu()
        {
            stackPanel.Visibility = Visibility.Visible;

        }

  
    }
}
