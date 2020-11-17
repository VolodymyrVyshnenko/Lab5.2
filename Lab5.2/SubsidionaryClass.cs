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
    class SubsidionaryClass : BaseClass
    {
        private double h;
        private double R1;


        public SubsidionaryClass() { }
        public SubsidionaryClass(double R, double h, double R1)
            : base(R)
        {
            this.h = h;
            this.R1 = R1;
        }

        public override void VandS(TextBox V, TextBox S)
        {
            double OneThird = 0.333333333333333;
            double s = Math.PI * Math.Pow(R, 2);
            double s1 = Math.PI * Math.Pow(R, 2);
            S.Text = "Площадь малой основы конуса = " + Convert.ToString(Math.PI * Math.Pow(R1, 2));
            V.Text = "Обьем усечённого конуса = " + Convert.ToString(h * OneThird * Math.PI * (Math.Pow(R1, 2) + Math.Pow(R, 2) + (R * R1)));
        }
    }
}
