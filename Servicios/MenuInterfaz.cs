using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora.Servicios
{
    /// <summary>
    /// Interfaz donde estara la cabecera de los métodos
    /// @autor jpr-091023
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// cabecera del mensajeBienvenida
        /// </summary>
        public void mensajeBienvenida();


        /// <summary>
        /// Cabecera del menu Bucle que devuelve una variable int
        /// </summary>
        /// <returns></returns>
        public int menuBucle();
    }
}
