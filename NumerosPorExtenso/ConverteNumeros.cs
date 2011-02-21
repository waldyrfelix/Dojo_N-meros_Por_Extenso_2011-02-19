using System;
using System.Collections.Generic;

namespace Números_Por_Extenso
{
    public class ConverteNumeros
    {
        public static string[] numerosAteDezenove;
        public static Dictionary<int, string> dezenas;

        static ConverteNumeros()
        {
            dezenas = new Dictionary<int, string>
                      {
                          {20, "Vinte"},
                          {30, "Trinta"},
                          {40, "Quarenta"},
                          {50, "Cinquenta"},
                          {60, "Sessenta"},
                          {70, "Setenta"},
                          {80, "Oitenta"},
                          {90, "Noventa"},
                          {100, "Cem"}
                      };

            numerosAteDezenove = new[]
                                 {
                                     "Zero",
                                     "Um",
                                     "Dois",
                                     "Três",
                                     "Quatro",
                                     "Cinco",
                                     "Seis",
                                     "Sete",
                                     "Oito",
                                     "Nove",
                                     "Dez",
                                     "Onze",
                                     "Doze",
                                     "Treze",
                                     "Quatorze",
                                     "Quinze",
                                     "Dezesseis",
                                     "Dezessete",
                                     "Dezoito",
                                     "Dezenove"
                                 };
        }

        private static string converteNumerosMaioresQueDezenoveParaExtenso(int numero)
        {
            string extenso = String.Empty;
            int unidade = (numero%10);
            int dezena = numero - unidade;

            if (unidade > 0)
            {
                extenso =
                    string.Format("{0} e {1}", dezenas[dezena],
                                  converteNumeroParaExtenso(unidade));
            }
            else
            {
                extenso = dezenas[dezena];
            }
            return extenso;
        }

        public static string converteNumeroParaExtenso(int numero)
        {
            if (numero < 0 || numero > 100)
            {
                throw new InvalidOperationException();
            }

            string extenso = String.Empty;

            if (numero < 20)
            {
                extenso = numerosAteDezenove[numero];
            }
            else
            {
                extenso = converteNumerosMaioresQueDezenoveParaExtenso(numero);
            }
            return extenso;
        }
    }
}