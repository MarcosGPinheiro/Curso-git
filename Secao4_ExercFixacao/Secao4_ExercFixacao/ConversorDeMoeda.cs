using System;
using System.Collections.Generic;
using System.Text;

namespace Secao4_ExercFixacao
{
    class ConversorDeMoeda
    {
        static double Iof = 6.00;
        public static double ConverteDolar(double cotacao, double valordolar)
        {
            return cotacao * valordolar * (1 + Iof/100) ;
        }
    }
}
