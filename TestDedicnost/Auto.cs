using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDedicnost
{
    internal class Auto
    {
        protected double objemNadrze;
        protected double palivo;

        public Auto(double objemNadrze, double palivo)
        {
            ObjemNadrze = objemNadrze;
            Palivo = palivo;
        }

        public double ObjemNadrze { 
            get 
            { 
                return objemNadrze; 
            } 
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Objem nadrže nesmí být záporné");
                }
                else
                {
                    objemNadrze = value;
                }
            }
        }
        public double Palivo
        {
            get
            {
                return palivo;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Palivo nesmí být záporné");
                }
                else if(value > objemNadrze)
                {
                    throw new ArgumentException("Palivo nesmí být více než je objem nadrže");
                } 
                else
                {
                    palivo = value;
                }
                
            }
        }

        public override string ToString()
        {
            return "Auto které má objem nádrže " + this.objemNadrze + " a v nádrži je "+this.palivo+" paliva." ;
        }

        public void NalijPalivo(double pal)
        {
            if(pal <= 0)
            {
                throw new ArgumentException("Nalité palivo nesmí být záporné");
            }
            else if(pal+this.palivo > objemNadrze)
            {
                throw new ArgumentException("Nalité palivo nesmí být více než je objem nadrže");
            } 
            else
            {
                Palivo = pal;
            }

        }
    }
}
