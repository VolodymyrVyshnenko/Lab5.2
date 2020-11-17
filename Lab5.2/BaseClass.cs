
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
    class BaseClass
    {
        protected double H;
        protected double R;


        public BaseClass() { }
        public BaseClass(double H, double R)
        {
            this.H = H;
            this.R = R;
        }
        public BaseClass(double R)
        {
            this.R = R;
        }

        public virtual void VandS(TextBox V, TextBox S)
        {
            double OneThird = 0.333333333333333;
            double s = Math.PI * Math.Pow(R, 2);
            S.Text = "Площадь основы конуса = " + Convert.ToString(s);
            V.Text = "Обьем конуса = " + Convert.ToString(H * OneThird * s);
        }
    }
}
