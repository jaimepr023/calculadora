using calculadora.Servicios;

namespace calculadora
{
    /// <summary>
    /// Clase principal donde esta nuestro metodo main
    /// @autor jpr-091023
    /// </summary>
    class program
    {
        /// <summary>
        /// Metodo principal de nuestro programs
        /// @autor jpr-091023
        /// </summary>
        /// <param name="args"></param>
        public static void main(String[] args)
        {
            MenuInterfaz menuInterfaz = new MenuImplementacion();
            menuInterfaz.mensajeBienvenida();
            bool cerrarMenu=false;
            int opcionSelect;

            while(!cerrarMenu)
            {
                switch()
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
