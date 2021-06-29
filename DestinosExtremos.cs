using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaViajes
{
    class DestinosExtremos : Destinos
    {//Clase hija de Destinos
        double cargoExtraTotal;
        

        public DestinosExtremos(string nombre, int periodoRotacion, int periodoOrbita, int diametro, string clima,
            string gravedad, string terreno, int poblacion, double precioXPersona,
            double cargosExtraXPersona,  double cargoExtraTotal) : base(nombre, periodoRotacion, periodoOrbita, diametro, clima, gravedad, 
                terreno, poblacion, precioXPersona, cargosExtraXPersona)
        {
            this.cargoExtraTotal = cargoExtraTotal;
        }

        //se muestra la info de  la clase 
        public void infoTotal() {
            //aqui se muestra el metodo para mostrar la info de la clase padre
            info();
            Console.WriteLine("\n Cargo Extra al precio Final: " + cargoExtraTotal);
        }


        //aplica un 5% de cargo extra al precio final total
        public double calcularCargoExtraTotal(double costoTotal, int numeroPersonas)
        {
            this.costoTotal = costoTotal;
            this.numeroPersonas = numeroPersonas;
            
            this.cargoExtraTotal = this.costoTotal * .05;
            this.costoTotal = this.costoTotal + this.cargoExtraTotal;
            return this.costoTotal;

        }

        

    }
}
