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

namespace Lab5._2
{

    public partial class MainWindow : Window
    {
        BaseClass Conus;
        SubsidionaryClass CutedConus;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Conus = new BaseClass(Convert.ToDouble(HBox.Text), Convert.ToDouble(RadiusBox.Text));
                CutedConus = new SubsidionaryClass(Convert.ToDouble(RadiusBox.Text), Convert.ToDouble(hBox.Text), Convert.ToDouble(Radius1Box.Text));
                Conus.VandS(V, S);
                CutedConus.VandS(v, s);
            }
            catch
            {
                RadiusBox.Text = "Enter R";
                HBox.Text = "Enter H";
                hBox.Text = "Enter h";
                Radius1Box.Text = "Enter R1";
            }
        }
    }
}
