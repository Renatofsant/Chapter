using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_teste_operacoes
{
    public static class operacoes // static eh para nao precisar chamar a classe.
    {
        public static double Somar(double pNum, double sNum) //usar double pois nem sempre os numeros sao inteiros "int".
        {
            return (pNum + sNum);
        }
    }
}

