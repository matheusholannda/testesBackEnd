using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public static class Operacoes // static é para não precisar instanciar para chamar a classe
    {
        public static double CalcularIMC(double peso, double altura) // como ele vai retornar um double, definimos ele como double
        {
            return Math.Round((peso / (altura * altura)), 2);
        }

        public static String ClassificarIMC(double imc) // como ele vai retornar um texto, definimos ele como String
        {
            if (imc < 18.5)
            {
                return "Abaixo do peso";
            }
            else if (imc < 25)
            {
                return "Peso normal";
            }
            else if (imc < 30)
            {
                return "Sobrepeso";
            }
            else if (imc < 35)
            {
                return "Obesidade Grau I";
            }
            else if (imc < 40)
            {
                return "Obesidade Grau II";
            }
            else
            {
                return "Obesidade Grau III";
            }
        }
    }
}
