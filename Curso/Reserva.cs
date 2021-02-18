using System;
using System.Collections.Generic;
using System.Text;

namespace Curso
{
    class Reserva
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public int Room { get; set; }

        public override string ToString()
        {
            return "Room "
                + Room
                + ", "
                + Nome
                + " , "
                + Email;
        }
    }
}
