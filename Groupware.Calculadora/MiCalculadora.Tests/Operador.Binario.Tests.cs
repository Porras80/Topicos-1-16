using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiCalculadora.Tests
{
    [TestClass]
    public class TestsSuma
    {
        const string miOperador = "+";
        double miOperandoUno = 2;
        double miOperandoDos = 2;
        double miResultadoEsperado = 4;
        double miResultadoReal;


     Groupware.Calculadora.MiCalculadora invocador=new Groupware.Calculadora.MiCalculadora();

        [TestMethod]
        public void SumarDosMasDos()
        {
            //Prepare Resultado
           
            miOperandoUno = 2;
            miOperandoDos =2;
            miResultadoEsperado = 4;
          

            // realice la invocacion al metodo


            miResultadoReal = invocador.OperadorBinario(miOperador, miOperandoUno, miOperandoDos);

            // realice la verificacion de si el calculo es correcto

            Assert.AreEqual(miResultadoEsperado, miResultadoReal);



        }
    }
}
