﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    //static já nasce existindo - já esta alocado em memória na construção do programa - pronta para ser usada - compartilha dados entre todo mundo
    public static class Calculo 
    {
        public static double Somar(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        public static double Subtrair(double numero1, double numero2)
        {
            return numero1 - numero2;
        }

        public static double Multiplicar(double numero1, double numero2)
        {
            return numero1 * numero2;
        }

        public static double Dividir(double numero1, double numero2)
        {
            return numero1 / numero2;
        }
    }
}
