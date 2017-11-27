using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesos
{
    public class Calculo
    {

        public double promedio(string nota1, string nota2, string nota3) {
            double media;
            double nt1, nt2, nt3;
            nt1 = Validacion(nota1);
            nt2 = Validacion(nota2);
            nt3 = Validacion(nota3);
            if (nt1 >= 0 && nt1 <= 20 && nt2 >= 0 && nt2 <= 20 && nt3 >= 0 && nt3 <= 20)
            {
                media = (nt1 + nt2 + nt3) / 3;
                return media;
            }
            return -1;
        }

        public string estadoMateria(string promedioMateria) {
            double promedio;
            promedio = Validacion(promedioMateria);
            if (promedio > 14)
                return "A";
            else if (promedio > 12 && promedio < 14)
                return "S";
            else
                return "P";
        }

        public string estadoSemestre(string estadoMateria1, string estadoMateria2) {
            if (estadoMateria1 == "A" || estadoMateria1 == "a" && estadoMateria2 == "A" || estadoMateria2 == "a")
                return "Aprobado";
            else if (estadoMateria2 == "P" || estadoMateria1 == "p" && estadoMateria2 == "P" || estadoMateria1 == "p")
                return "Reprobado";
            else
                return "ERROR";
        }


        public double Validacion(string sueldoA)
        {
            double num;
            try
            {
                num = Double.Parse(sueldoA);
                return num;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

    }
}
