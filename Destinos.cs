using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaViajes
{//Clase padre
    class Destinos
    {
        //declaracion de variables, son protected ya que seran usadas por sus clases hijas
        protected String nombre;
        protected int periodoRotacion;
        protected int periodoOrbita;
        protected int diametro;
        protected String clima;
        protected String gravedad;
        protected String terreno;
        protected int poblacion;
        protected double precioXPersona;
        protected double cargosExtraXPersona;
        protected double costoTotal;
        protected int numeroPersonas;
    

        //constructor
        public Destinos(String nombre, int periodoRotacion, int periodoOrbita,
            int diametro, String clima, String gravedad, String terreno, int poblacion, double precioXPersona, double cargosExtraXPersona) {
            this.nombre = nombre;
            this.periodoRotacion = periodoRotacion;
            this.periodoOrbita = periodoOrbita;
            this.diametro = diametro;
            this.clima = clima;
            this.gravedad = gravedad;
            this.terreno = terreno;
            this.poblacion = poblacion;
            this.precioXPersona = precioXPersona;
            this.cargosExtraXPersona = cargosExtraXPersona;
            //this.costoTotal = costoTotal;
        }

        //este metodo muetsra la info de las variables
        public void info()
        {
            Console.WriteLine("\n Nombre del destino: " + this.nombre);
            Console.WriteLine("\n Periodo de Rotacion: " + this.periodoRotacion);
            Console.WriteLine("\n Periodo de Orbita: " + this.periodoOrbita);
            Console.WriteLine("\n Diametro: " + this.diametro);
            Console.WriteLine("\n Clima: " + this.clima);
            Console.WriteLine("\n Gravedad: " + this.gravedad);
            Console.WriteLine("\n Terreno: " + this.terreno);
            Console.WriteLine("\n Poblacion: " + this.poblacion);
            Console.WriteLine("\n Precio por Persona: " + this.precioXPersona);
            Console.WriteLine("\n Cargos Extra por Persona: " + this.cargosExtraXPersona);
            Console.WriteLine("\n Costo Total: " + this.costoTotal);
        }

        //metodo para calcular el costo totall
        public double calcularCostoTotal(int numeroPersonas)
        {
            this.numeroPersonas = numeroPersonas;
            this.costoTotal = (numeroPersonas * precioXPersona) + (numeroPersonas * cargosExtraXPersona);
            return this.costoTotal;

        }

        //get setters

      public String Nombre
        {
            get { return this.nombre; }
            set { this.nombre = nombre; }
        }

        public int PeriodoRotacion
        {
            get { return this.periodoRotacion; }
            set { this.periodoRotacion = periodoRotacion; }
        }

        public int PeriodoOrbita
        {
            get { return this.periodoOrbita; }
            set { this.periodoOrbita = periodoOrbita; }
        }

        public int Diametro {
            get { return this.diametro; }
            set { this.diametro = diametro; }
        }

        public String Clima
        {
            get { return this.clima; }
            set { this.clima = clima; }
        }

        public String Gravedad
        {
            get { return this.gravedad; }
            set { this.gravedad = gravedad; }
        }

        public String Terreno
        {
            get { return this.terreno; }
            set { this.terreno = terreno; }
        }

        public int Poblacion
        {
            get { return this.poblacion; }
            set { this.poblacion = poblacion; }
        }

        public double PrecioXPersona
        {
            get { return this.precioXPersona; }
            set { this.precioXPersona = precioXPersona; }
        }

        public double CargosExtraXPersona
        {
            get { return this.cargosExtraXPersona; }
            set { this.cargosExtraXPersona = cargosExtraXPersona; }
        }

        public double CostoTotal
        {
            get { return this.costoTotal; }
            set { this.costoTotal = costoTotal; }
        }

        public int NumeroPersonas
        {
            get { return this.numeroPersonas; }
            set { this.numeroPersonas = numeroPersonas; }
        }

    
    }
}


