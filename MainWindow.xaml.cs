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

namespace EdnaLynn_Notes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          
        }

        private void btnShowSomething_Click(object sender, RoutedEventArgs e)
        {

            // How to work with a rich text box
            // Event Driven
            Patient will = new Patient(
                "Will",
                "Cram",
                "123 asdklj Way",
                "123549024",
                "He / Him",
                "Male");

            Patient ednalynn = new Patient("Edna Lynn", "Laxa");
            // FIrst name
            // Last name
            // Mailing Address
            // Social
            // Pronoun
            // Gender
            ednalynn.FirstName = "Jonathan";
  

            runDisplay.Text = $"Patient Name: {ednalynn.FirstName} ";

        }
    }
}
