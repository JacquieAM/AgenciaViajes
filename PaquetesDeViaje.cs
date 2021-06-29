
using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaViajes
{
    //La clase paquetes de viaje no tiene clases hijas
    //Lo considere en un inicio, pero ahorraba lineas de codigo poniendo las dif clases como metodos en una sola clase
    class PaquetesDeViaje
    {
        //declaracion de variables
        protected String nombrePaquete;
        protected String incluye;
        protected double precioExtraXPersona;
        protected int numPersonas;

        //constructor
        public PaquetesDeViaje(String nombrePaquete, String incluye, double precioExtraXPersona)
        {
            this.nombrePaquete = nombrePaquete;
            this.incluye = incluye;
            this.precioExtraXPersona = precioExtraXPersona; 
        }
        //muestra la informacion de los paquetes
        public void infoPaquetes()
        {
            Console.WriteLine("\n Nombre del Paquete: " + this.nombrePaquete);
            Console.WriteLine("\n Incluye: " + this.incluye);
            Console.WriteLine("\n Precio Extra por Persona: " + this.precioExtraXPersona);

        }
        // el metodo del paquete Oro
        public void paqueteOro()
        {
            this.nombrePaquete = "Oro";
            this.incluye = "Boletos de  viaje, comida y tour en zona turistica";
            this.precioExtraXPersona = 9000;
        }
        // el metodo del paquete Plata
        public void paquetePlata()
        {
            this.nombrePaquete = "Plata";
            this.incluye = "Boletos de viaje y comida";
            this.precioExtraXPersona = 5000;
        }
        // el metodo del paquete Bronce
        public void paqueteBronce()
        {
            this.nombrePaquete = "Bronce";
            this.incluye = "Boletos de viaje";
            this.precioExtraXPersona = 0;
        }
   
        // get y setters
        public String NombrePaquete
        {
            get { return this.nombrePaquete; }
            set { this.nombrePaquete = nombrePaquete; }
        }

        public String Incluye
        {
            get { return this.incluye; }
            set { this.incluye = incluye; }
        }

        public double PrecioExtraXPersona
        {
            get { return this.precioExtraXPersona; }
            set { this.precioExtraXPersona = precioExtraXPersona; }
        }

        public int NumPersonas
        {
            get { return this.numPersonas; }
            set { this.numPersonas = numPersonas; }
        }
    }
}
