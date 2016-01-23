using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groupware.Calculadora.LogicaNegocio.Acciones
{
    public class Sumar
    {

        public double Calcular(double operandoUno, double OperandoDos)
        {
            double resultado = operandoUno + OperandoDos;

            return resultado;
        }

    }
}
