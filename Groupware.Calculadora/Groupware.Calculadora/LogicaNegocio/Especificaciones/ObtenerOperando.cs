﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Groupware.Calculadora.LogicaNegocio.Especificaciones
{
    public class ObtenerOperador
    {

        public Enumerados.Operadores ObtenerElOperador(string elOperador)
        {

          var elValidador=new  Validaciones.Operadores();
            return elValidador.ObtenerOperador(elOperador);


        }

    }
}