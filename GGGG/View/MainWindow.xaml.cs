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
using GGGG.ViewModel;
namespace GGGG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Button> Buttons;
        ViewModel.ViewModel vm;
        public MainWindow()
        {
            InitializeComponent();
            Buttons = new List<Button>() { btn1, btn2, btn3, btn4,btn5,btn6,btn7,btn8,btn9 };
            vm = new ViewModel.ViewModel(Buttons);
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            if (((Button)sender).Content == "")
            {
                vm.Draw((Button)sender);
            }
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            vm.Restart();
        }
    }
}
