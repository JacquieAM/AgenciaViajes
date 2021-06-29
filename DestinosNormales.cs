using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaViajes
{//Clase hija de Destinos
    class DestinosNormales : Destinos
    {
        double descuentoTotal;
        public DestinosNormales(string nombre, int periodoRotacion, int periodoOrbita, int diametro, string clima, string gravedad, string terreno,
            int poblacion, double precioXPersona, double cargosExtraXPersona, /*double costoTotal,*/ double descuentoTotal) : base(nombre, periodoRotacion, periodoOrbita, 
                diametro, clima, gravedad,terreno, poblacion, precioXPersona, cargosExtraXPersona/*, costoTotal*/)
        {
            this.descuentoTotal = descuentoTotal;
        }

       
        //se muestra la info de  la clase 
        public void infoTotal()
        {
            //aqui se muestra el metodo para mostrar la info de la clase padre
            info();
            Console.WriteLine("\n Descuento Total: " + descuentoTotal);
        }

        //agregar descuento del 10% al precio total

        public double calcularDescuentoAlPrecioTotal(double costoTotal, int numeroPersonas)
        {
            this.costoTotal = costoTotal;
            this.numeroPersonas = numeroPersonas;
           
            this.descuentoTotal = this.costoTotal * .10;
            this.costoTotal = this.costoTotal - this.descuentoTotal;
            return this.costoTotal;
        }
    }
}
