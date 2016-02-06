using Groupware.Calculadora.LogicaNegocio.Enumerados;

namespace Groupware.Calculadora.LogicaNegocio.Especificaciones
{
    public class RealizaOperacionBinaria
    {
        private Operadores miOperador;
        private double operandoDos;
        private double operandoUno;
    

        public double RealizaLaOperacionBinaria(Operadores miOperador, double operandoUno, double operandoDos)
        {
            double resultado= 0.0;

            switch (miOperador)
            {
                

                case Enumerados.Operadores.Suma:
                    var laSuma = new LogicaNegocio.Especificaciones.Suma();
                    resultado = laSuma.Calculo(operandoUno, operandoDos);
                    break;
            }

            return (resultado);
        }
    }
}