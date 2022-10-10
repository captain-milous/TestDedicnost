using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDedicnost
{
    internal class NakladniAuto : Auto
    {
        protected double hmotnostNakladu;

        public NakladniAuto(double objemNadrze, double palivo, double hmotnostNakladu) : base(objemNadrze, palivo)
        {
            HmotnostNakladu = hmotnostNakladu;
        }

        public double HmotnostNakladu
        {
            get { return hmotnostNakladu; }
            set 
            { 
                if(value < 0)
                {
                    throw new ArgumentException("Náklad nesmí být zaporné číslo");
                }
                else
                {
                    hmotnostNakladu = value;
                }
            }
        }

        public override string ToString()
        {
            return "Nákladní auto, které má objem nádrže " + this.objemNadrze + " a v nádrži je "+this.palivo+" paliva, veze náklad o hmotnosti "+this.hmotnostNakladu+".";
        }
    }
}
