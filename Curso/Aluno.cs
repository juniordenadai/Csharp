using System;
using System.Collections.Generic;
using System.Text;

namespace Curso
{
    class Aluno
    {
        public string Nome;
        public double NotaPrimeiroTrimestre;
        public double NotaSegundoTrimestre;
        public double NotaTerceiroTrimestre;

        public double Notafinal()
        {
            return NotaPrimeiroTrimestre + NotaSegundoTrimestre + NotaTerceiroTrimestre;

        }
    }
}
