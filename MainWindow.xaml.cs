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
using Login_System;
//Set an executabl application[WPF(Windows Presentation Foundation) as setup application
namespace WPF__XAML_Form
{
    //Kira - WPD(uses C# to and event handlers or mathed)

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TxtName.Focus(); //Set the cursor to be active in that particular textbox
        }

        private void Click_Login(object sender, RoutedEventArgs e)
        {
            //Instatiating the class created in the Class Library(.Net Framework)
            //An object is used to store the properties/attributtes declared in the class
            var attributes = new Login(); //Attributtes is a created bject.

            attributes.Name = TxtName.Text;
            attributes.Location = TxtLocation.Text;
            attributes.School = this.TxtSchool.Text;
            attributes.CellNo = this.TxtCellPhone.Text;

            try
            {
                attributes.Email = this.TxtEmail.Text;
            }
            catch( Exception ex)
            {
                if(MessageBox.Show(ex.Message.ToUpper(),"PAN-AFRICA",MessageBoxButton.OKCancel ,
                    MessageBoxImage.Warning)== MessageBoxResult.OK)
                {
                   
                    this.Close();
                }
            }
            MessageBox.Show(attributes.ToString(), "PAN-AFRICA", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
