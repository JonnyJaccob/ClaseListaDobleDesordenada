using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionForms
{
    interface ITipo
    {
        int Numero { get; set; }
        double Doble { get; set; }
        string Nombre { get; set; }
        char Caracter { get; set; }
        DateTime Fecha { get; set; }
        bool Logico { get; set; }
        string DireccionPath { get; set; }
    }
}
