using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groupware.Calculadora.LogicaNegocio.Especificaciones
{
   public class Suma
    {

        public double Calculo(double operandoUno, double OperandoDos)
        {

            double resultado;
            //invoque a la acción correspondiente
            Acciones.Sumar operacion = new Acciones.Sumar();
            resultado = operacion.Calcular(operandoUno, OperandoDos);
            return (resultado);
        }
    }
}
