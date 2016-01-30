using Groupware.Calculadora.LogicaNegocio.Enumerados;

namespace Groupware.Calculadora.LogicaNegocio.Especificaciones
{
    internal class RealizaOperacionBinaria
    {
        private Operadores miOperador;
        private double operandoDos;
        private double operandoUno;

        public RealizaOperacionBinaria(Operadores miOperador, double operandoUno, double operandoDos)
        {
          switch (miOperador)
            {

                case Enumerados.Operadores.Suma:
                    var laSuma = LogicaNegocio.Especificaciones.Suma();
                    resultado = laSuma.Calculo(operandoUno, operandoDos);
                    break;
            }

            return (resultado);
        }
    }
}