using System;
using System.Collections.Generic;
using System.Text;

namespace Curso
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double CalcularArea()
        {
            return Largura * Altura;
        }

        public double CalcularPerimetro()
        {
            return (Largura + Altura) * 2;
        }

        public double CalcularDiagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }
    }
}
