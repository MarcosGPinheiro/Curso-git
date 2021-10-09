using System;


namespace Secao4_Exerc_01_01
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

        public override string ToString()
        {
            return $"Area = {Area():F2} " + $"Perímetro = {Perimetro():F2} " +  $"Diagonal = {Diagonal():F2}";
        }

    }
}
