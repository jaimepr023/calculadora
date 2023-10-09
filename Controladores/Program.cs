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
                opcionSelect = menuInterfaz.menuBucle();
                Console.WriteLine(opcionSelect);
                switch()
                {
                    case 0:
                        Console.WriteLine("[INFOS]-Se cerrara la aplicación");
                        cerrarMenu = true;
                        break;
                    case 1:
                        int n1;
                        int n2;
                        Console.WriteLine("Indique el primer operando:");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Indique el segundo operando:");
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado de la operación es:");
                        int resultado =n1+n2;
                        break;
                    case 2:
                        int n1;
                        int n2;
                        Console.WriteLine("Indique el primer operando:");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Indique el segundo operando:");
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado de la operación es:");
                        int resultado = n1 - n2;
                        break;
                    case 3:
                        int n1;
                        int n2;
                        Console.WriteLine("Indique el primer operando:");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Indique el segundo operando:");
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado de la operación es:");
                        int resultado = n1 * n2;
                        break;
                    case 4:
                        int n1;
                        int n2;
                        Console.WriteLine("Indique el primer operando:");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Indique el segundo operando:");
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado de la operación es:");
                        float resultado = n1/n2;
                        break;
                    default:
                        Console.WriteLine("[INFOS]-La opcion seleccionada no existe")
                        break;
                }
            }
        }
    }
}
