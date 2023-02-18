using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MerlinSujeyDuarteArgueta18022023.Entidades;

namespace MerlinSujeyDuarteArgueta18022023.Negocio
{
    public class ClsPalabras
    {
        public int Contador(Palabras palabras){
            return palabras.palabras.Length;
        }
    }
}