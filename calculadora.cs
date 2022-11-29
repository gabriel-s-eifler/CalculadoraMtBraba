using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMtBraba
{
    internal class calculadora
    {
        private double variavel1;
        private string Operacao;
        private double variavel2;


        public double GetVariavel1()
        {
            return variavel1;
        }

        public void SetVariavel1(double value)
        {
            variavel1 = value;
        }

        

        public double GetVariavel2()
        {
            return variavel2;
        }

        public void SetVariavel2(double value)
        {
            variavel2 = value;
        }

        

        public string GetOperacao()
        {
            return Operacao;
        }

        public void SetOperacao(string value)
        {
            Operacao = value;
        }
        public double executarOperacao()
        {
            double result = 0;
            if (Operacao.Equals("+"))
            {
                result = variavel1 + variavel2;
            }
            if (Operacao.Equals("-"))
            {
                result = variavel1 - variavel2;
            }
            if (Operacao.Equals("*"))
            {
                result = variavel1 * variavel2;
            }
            if (Operacao.Equals("/"))
            {
                result = (variavel1 / variavel2);
            }
            return result;
        }  
    }
}
