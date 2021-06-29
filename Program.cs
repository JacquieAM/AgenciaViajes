using System;

namespace AgenciaViajes
{
    class Program
    {
        static void Main(string[] args)
        {

            //c) Caso de uso “Limpiar planeación”
            //a.El usuario elige la opción limpiar planeación
            //b.La aplicación resetea valores y notifica al usuario

            static void borrarPlaneacion(double mCostoTotal)
            {

                String menuKey;

                Console.WriteLine("5. Limpiar Planeacion");
                menuKey = Console.ReadLine();
                if (menuKey == "5")
                {
                    mCostoTotal = 0;
                    Console.WriteLine("La planeacion ha sido limpiada" + "\n El costo total es de: " + mCostoTotal);

                }

            }
            // Menu

            Console.WriteLine("Menu");
            Console.WriteLine();
            Console.WriteLine("\n Bienvenido a la Agencia de Viajes Espaciales 'Cosmos' ");
            Console.WriteLine();
            Console.WriteLine("Oprima el numero de la opcion que desee  elegir");
            Console.WriteLine("1. Planear un Viaje");
            Console.WriteLine("2. Salir");

            String menuKey = Console.ReadLine();
            //Permite salir del programa
            if(menuKey == "2")
            {
                
                System.Environment.Exit(1);

            }

            if(menuKey == "1")
            {

                //Caso de Uso Planear Viaje
                //a) Caso de uso “Planear viaje”
                //a.El usuario elige la opción añade viaje
                //b.La aplicación muestra los destinos
                //c.El usuario elije un destino
                //d. La aplicación muestra los paquetes
                //e. El usuario elije un paquete

                Console.WriteLine("Eliga un destino");
                Console.WriteLine("Planetas Extremos: ");
                Console.WriteLine("1. Tatooine");
                Console.WriteLine("2. Hoth");
                Console.WriteLine("Planetas Normales: ");
                Console.WriteLine("3. Alderaan");
                Console.WriteLine("4. Yavin IV");
                Console.WriteLine("Oprima el numero de la opcion que desee  elegir");
                menuKey = Console.ReadLine();

                if(menuKey == "1")
                {
                    Console.WriteLine("Ha  elegido el destino Tatooine");
                    //b) Caso de uso “Obtener precio”
                    //a.El usuario elige la opción obtener precio
                    //b.La aplicación pregunta por el número de personas
                    //c. El usuario introduce información
                    //d.La aplicación muestra el precio final
                    Console.WriteLine("Presione Enter para Obtener precio");
                    Console.WriteLine("2. Salir");
                    menuKey = Console.ReadLine();
                    if(menuKey == "2")
                    {
                        System.Environment.Exit(1);
                    }
                    Console.WriteLine("Eliga el paquete que desee");
                    double mCargoExtraTotal = 0;
                    double mCostoTotal;
                    DestinosExtremos Tatooine1 = new DestinosExtremos("Tatooine",23, 304, 10465, "Arido", "2 veces la tierra", "Desertico",
                        2000, 9600, 100, mCargoExtraTotal/*, mCostoTotal*/);
                    Console.WriteLine("1. Oro");
                    Console.WriteLine("2. Plata");
                    Console.WriteLine("3. Bronce");
                    menuKey = Console.ReadLine();

                    if (menuKey == "1")
                    {
                        
                        Console.WriteLine("Usted ha elegido el paquete Oro");
                        Console.WriteLine("Teclee el numero de personas que viajaran");
                        int numPersonas = Convert.ToInt32(Console.ReadLine());
                        PaquetesDeViaje Oro1 = new PaquetesDeViaje("Oro", "Boletos de  viaje, comida y tour en zona turistica",9000);
                        
                        //Console.WriteLine(Tatooine1.calcularCostoTotal(numPersonas) + (Oro1.PrecioExtraXPersona * numPersonas));
                        ////Tatooine1.CostoTotal = (Tatooine1.calcularCostoTotal(numPersonas)) + (Oro1.PrecioExtraXPersona * numPersonas);
                        //Console.WriteLine("costo total Tatooine" + Tatooine1.CostoTotal);
                        mCostoTotal = Tatooine1.calcularCostoTotal(numPersonas) + (Oro1.PrecioExtraXPersona * numPersonas);
                        Console.WriteLine("El costo total antes de agregar el 5% de cargo extra $ " + mCostoTotal);
                        Console.WriteLine("Costo total despues de agregar el 5% de cargo extra $ " + Tatooine1.calcularCargoExtraTotal(mCostoTotal, numPersonas));
                        //c) Caso de uso “Limpiar planeación”
                        //a.El usuario elige la opción limpiar planeación
                        //b.La aplicación resetea valores y notifica al usuario
                        borrarPlaneacion(mCostoTotal);
                    }
                    if (menuKey == "2")
                    {
                        Console.WriteLine("Usted ha elegido el paquete Plata");
                        Console.WriteLine("Teclee el numero de personas que viajaran");
                        int numPersonas = Convert.ToInt32(Console.ReadLine());
                        PaquetesDeViaje Plata1 = new PaquetesDeViaje("Plata", "Boletos de viaje y comida", 5000);
                        mCostoTotal = Tatooine1.calcularCostoTotal(numPersonas) + (Plata1.PrecioExtraXPersona * numPersonas);
                        Console.WriteLine("El costo total antes de agregar el 5% de cargo extra $ " + mCostoTotal);
                        Console.WriteLine("Costo total despues de agregar el 5% de cargo extra $ " + Tatooine1.calcularCargoExtraTotal(mCostoTotal, numPersonas));
                        borrarPlaneacion(mCostoTotal);
                    }
                    if (menuKey == "3")
                    {
                        Console.WriteLine("Usted ha elegido el paquete Bronce");
                        Console.WriteLine("Teclee el numero de personas que viajaran");
                        int numPersonas = Convert.ToInt32(Console.ReadLine());
                        PaquetesDeViaje Bronce1 = new PaquetesDeViaje("Bronce", "Boletos de viaje", 0);
                        mCostoTotal = Tatooine1.calcularCostoTotal(numPersonas) + (Bronce1.PrecioExtraXPersona * numPersonas);
                        Console.WriteLine("El costo total antes de agregar el 5% de cargo extra $ " + mCostoTotal);
                        Console.WriteLine("Costo total despues de agregar el 5% de cargo extra $ " + Tatooine1.calcularCargoExtraTotal(mCostoTotal, numPersonas));
                        borrarPlaneacion(mCostoTotal);
                    }
                }

                if(menuKey == "2")
                {
                    Console.WriteLine("Ha  elegido el destino Hoth");
                    Console.WriteLine("Presione Enter para Obtener precio");
                    Console.WriteLine("2. Salir");
                    menuKey = Console.ReadLine();
                    if (menuKey == "2")
                    {
                        System.Environment.Exit(1);
                    }
                    Console.WriteLine("Eliga el paquete que desee"); 
                    double mCargoExtraTotal = 0;
                    double mCostoTotal = 0;
                    DestinosExtremos Hoth1 = new DestinosExtremos("Hoth", 23, 549, 7200, "Frio", "2 veces la Tierra", "Tundra", 0, 8790, 200, mCargoExtraTotal/*, mCostoTotal*/);
                    Console.WriteLine("1. Oro");
                    Console.WriteLine("2. Plata");
                    Console.WriteLine("3. Bronce");
                    menuKey = Console.ReadLine();
                    if (menuKey == "1")
                    {
                        Console.WriteLine("Usted ha elegido el paquete Oro");
                        Console.WriteLine("Teclee el numero de personas que viajaran");
                        int numPersonas = Convert.ToInt32(Console.ReadLine());

                        PaquetesDeViaje Oro1 = new PaquetesDeViaje("Oro", "Boletos de  viaje, comida y tour en zona turistica", 9000);
                        //para este caso hago uso de calcularCostoTotal y del precio extra para sacar el cargo antes del 5%
                        mCostoTotal = Hoth1.calcularCostoTotal(numPersonas) + (Oro1.PrecioExtraXPersona * numPersonas);
                        Console.WriteLine("El costo total antes de agregar el 5% de cargo extra $ " + mCostoTotal);
                        //aqui se aplica el metodo calcularCargoExtraTotal para mostrar el rpecio despues de agregar el 5%
                        Console.WriteLine("Costo total despues de agregar el 5% de cargo extra $ " + Hoth1.calcularCargoExtraTotal(mCostoTotal, numPersonas));
                        borrarPlaneacion(mCostoTotal);
                    }
                    if (menuKey == "2")
                    {
                        Console.WriteLine("Usted ha elegido el paquete Plata");
                        Console.WriteLine("Teclee el numero de personas que viajaran");
                        int numPersonas = Convert.ToInt32(Console.ReadLine());
                        PaquetesDeViaje Plata1 = new PaquetesDeViaje("Plata", "Boletos de viaje y comida", 5000);
                        mCostoTotal = Hoth1.calcularCostoTotal(numPersonas) + (Plata1.PrecioExtraXPersona * numPersonas);
                        Console.WriteLine("El costo total antes de agregar el 5% de cargo extra $ " + mCostoTotal);
                        Console.WriteLine("Costo total despues de agregar el 5% de cargo extra $ " + Hoth1.calcularCargoExtraTotal(mCostoTotal, numPersonas));
                        borrarPlaneacion(mCostoTotal);
                    }
                    if (menuKey == "3")
                    {
                        Console.WriteLine("Usted ha elegido el paquete Bronce");
                        Console.WriteLine("Teclee el numero de personas que viajaran");
                        int numPersonas = Convert.ToInt32(Console.ReadLine());
                        PaquetesDeViaje Bronce1 = new PaquetesDeViaje("Bronce", "Boletos de viaje", 0);
                        mCostoTotal = Hoth1.calcularCostoTotal(numPersonas) + (Bronce1.PrecioExtraXPersona * numPersonas);
                        Console.WriteLine("El costo total antes de agregar el 5% de cargo extra $ " + mCostoTotal);
                        Console.WriteLine("Costo total despues de agregar el 5% de cargo extra $ " + Hoth1.calcularCargoExtraTotal(mCostoTotal, numPersonas));
                        borrarPlaneacion(mCostoTotal);
                    }

                }

                if(menuKey == "3")
                {
                    Console.WriteLine("Ha  elegido el destino Alderaan");
                    Console.WriteLine("Presione Enter para Obtener precio");
                    Console.WriteLine("2. Salir");
                    menuKey = Console.ReadLine();
                    if (menuKey == "2")
                    {
                        System.Environment.Exit(1);
                    }
                    Console.WriteLine("Eliga el paquete que desee");
                    double mDescuentoTotal = 0;
                    double mCostoTotal = 0;
                    DestinosNormales Alderaan1 = new DestinosNormales("Alderaan", 24, 264, 12500, "Templado", "1 Estandar", "Montanoso", 20000000, 18700,
                        200, mDescuentoTotal/*, mCostoTotal*/);
                    Console.WriteLine("1. Oro");
                    Console.WriteLine("2. Plata");
                    Console.WriteLine("3. Bronce");
                    menuKey = Console.ReadLine();
                    if (menuKey == "1")
                    {
                        Console.WriteLine("Usted ha elegido el paquete Oro");
                        Console.WriteLine("Teclee el numero de personas que viajaran");
                        int numPersonas = Convert.ToInt32(Console.ReadLine());

                        PaquetesDeViaje Oro1 = new PaquetesDeViaje("Oro", "Boletos de  viaje, comida y tour en zona turistica", 9000);
                        mCostoTotal = Alderaan1.calcularCostoTotal(numPersonas) + (Oro1.PrecioExtraXPersona * numPersonas);
                        Console.WriteLine("Su paquete de Alderaan incluye un kit de recuerdos gratis");
                        Console.WriteLine("El costo total antes de agregar el 10% de descuento $ " + mCostoTotal);
                        mCostoTotal = Alderaan1.calcularDescuentoAlPrecioTotal(mCostoTotal, numPersonas) ;
                        Console.WriteLine("Costo total despues de agregar el 10% de descuento $ " + mCostoTotal);
                        borrarPlaneacion(mCostoTotal);
                    }
                    if (menuKey == "2")
                    {
                        Console.WriteLine("Usted ha elegido el paquete Plata");
                        Console.WriteLine("Teclee el numero de personas que viajaran");
                        int numPersonas = Convert.ToInt32(Console.ReadLine());
                        PaquetesDeViaje Plata1 = new PaquetesDeViaje("Plata", "Boletos de viaje y comida", 5000);
                        mCostoTotal = Alderaan1.calcularCostoTotal(numPersonas) + (Plata1.PrecioExtraXPersona * numPersonas);
                        Console.WriteLine("Su paquete de Alderaan incluye un kit de recuerdos gratis");
                        Console.WriteLine("El costo total antes de agregar el 10% de descuento $ " + mCostoTotal);
                        mCostoTotal = Alderaan1.calcularDescuentoAlPrecioTotal(mCostoTotal, numPersonas);
                        Console.WriteLine("Costo total despues de agregar el 10% de descuento $ " + mCostoTotal);
                        borrarPlaneacion(mCostoTotal);
                    }
                    if (menuKey == "3")
                    {
                        Console.WriteLine("Usted ha elegido el paquete Bronce");
                        Console.WriteLine("Teclee el numero de personas que viajaran");
                        int numPersonas = Convert.ToInt32(Console.ReadLine());
                        PaquetesDeViaje Bronce1 = new PaquetesDeViaje("Bronce", "Boletos de viaje", 0);
                        mCostoTotal = Alderaan1.calcularCostoTotal(numPersonas) + (Bronce1.PrecioExtraXPersona * numPersonas);
                        Console.WriteLine("Su paquete de Alderaan incluye un kit de recuerdos gratis");
                        Console.WriteLine("El costo total antes de agregar el 10% de descuento $ " + mCostoTotal);
                        mCostoTotal = Alderaan1.calcularDescuentoAlPrecioTotal(mCostoTotal, numPersonas);
                        Console.WriteLine("Costo total despues de agregar el 10% de descuento $ " + mCostoTotal);
                        borrarPlaneacion(mCostoTotal);
                    }


                }

                if (menuKey == "4")
                {
                    Console.WriteLine("Ha  elegido el destino YavinIV");
                    Console.WriteLine("Presione Enter para Obtener precio");
                    Console.WriteLine("2. Salir");
                    menuKey = Console.ReadLine();
                    if (menuKey == "2")
                    {
                        System.Environment.Exit(1);
                    }
                    Console.WriteLine("Eliga el paquete que desee");
                    double mDescuentoTotal = 0;
                    double mCostoTotal = 0;
                    DestinosNormales YavinIV1 = new DestinosNormales("Yavin IV", 24, 4818, 10200, "Tropical", "1 Estandar", "Jungla", 1000, 7900, 
                        100, mDescuentoTotal/*, mCostoTotal*/);
                    Console.WriteLine("1. Oro");
                    Console.WriteLine("2. Plata");
                    Console.WriteLine("3. Bronce");
                    menuKey = Console.ReadLine();
                    if (menuKey == "1")
                    {
                        Console.WriteLine("Usted ha elegido el paquete Oro");
                        Console.WriteLine("Teclee el numero de personas que viajaran");
                        int numPersonas = Convert.ToInt32(Console.ReadLine());
                        PaquetesDeViaje Oro1 = new PaquetesDeViaje("Oro", "Boletos de  viaje, comida y tour en zona turistica", 9000);
                        mCostoTotal = YavinIV1.calcularCostoTotal(numPersonas) + (Oro1.PrecioExtraXPersona * numPersonas);
                        Console.WriteLine("Su paquete de YavinIV incluye un kit de recuerdos gratis");
                        Console.WriteLine("El costo total antes de agregar el 10% de descuento $ " + mCostoTotal);
                        mCostoTotal = YavinIV1.calcularDescuentoAlPrecioTotal(mCostoTotal, numPersonas);
                        Console.WriteLine("Costo total despues de agregar el 10% de descuento $ " + mCostoTotal);
                        borrarPlaneacion(mCostoTotal);

                    }
                    if (menuKey == "2")
                    {
                        Console.WriteLine("Usted ha elegido el paquete Plata");
                        Console.WriteLine("Teclee el numero de personas que viajaran");
                        int numPersonas = Convert.ToInt32(Console.ReadLine());
                        PaquetesDeViaje Plata1 = new PaquetesDeViaje("Plata", "Boletos de viaje y comida", 5000);
                        mCostoTotal = YavinIV1.calcularCostoTotal(numPersonas) + (Plata1.PrecioExtraXPersona * numPersonas);
                        Console.WriteLine("Su paquete de YavinIV incluye un kit de recuerdos gratis");
                        Console.WriteLine("El costo total antes de agregar el 10% de descuento $ " + mCostoTotal);
                        mCostoTotal = YavinIV1.calcularDescuentoAlPrecioTotal(mCostoTotal, numPersonas);
                        Console.WriteLine("Costo total despues de agregar el 10% de descuento $ " + mCostoTotal);
                        borrarPlaneacion(mCostoTotal);
                    }
                    if (menuKey == "3")
                    {
                        Console.WriteLine("Usted ha elegido el paquete Bronce");
                        Console.WriteLine("Teclee el numero de personas que viajaran");
                        int numPersonas = Convert.ToInt32(Console.ReadLine());
                        PaquetesDeViaje Bronce1 = new PaquetesDeViaje("Bronce", "Boletos de viaje", 0);
                        mCostoTotal = YavinIV1.calcularCostoTotal(numPersonas) + (Bronce1.PrecioExtraXPersona * numPersonas);
                        Console.WriteLine("Su paquete de YavinIV incluye un kit de recuerdos gratis");
                        Console.WriteLine("El costo total antes de agregar el 10% de descuento $ " + mCostoTotal);
                        mCostoTotal = YavinIV1.calcularDescuentoAlPrecioTotal(mCostoTotal, numPersonas);
                        Console.WriteLine("Costo total despues de agregar el 10% de descuento $ " + mCostoTotal);
                        borrarPlaneacion(mCostoTotal);
                    }

                   
                }
            }
        }
    }
}


