using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSimples
{
    public static class Calculo
    {
       
        public enum TipoOperacao
        {
            Soma,
            Subtracao,
            Multiplicacao,
            Divisao,
        }

        public static double Calcular(double numero1, double numero2, TipoOperacao operacao)
        {
            switch (operacao)
            {
                case TipoOperacao.Soma:
                    return numero1 + numero2;
                case TipoOperacao.Subtracao:
                    return numero1 - numero2;
                case TipoOperacao.Multiplicacao:
                    return numero1 * numero2;
                case TipoOperacao.Divisao:
                    if (numero2 == 0 || numero1 < 0 || numero2 < 0)
                    throw new ArgumentException("Preenchimento incorreto, tente novamente");
                    double resultado = numero1 / numero2;
                        return Math.Round(resultado,2);
                default:
                    return double.NaN;

            }




        }

    }
}
