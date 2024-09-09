using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public abstract class Producto
    {
        private string descripcion;
        protected double precioBase;
        protected int tipoMaterial;

        public Producto(string descripcion, double precioBase, int tipoMaterial)
        {
            this.descripcion = descripcion;
            this.precioBase = precioBase;
            this.tipoMaterial = tipoMaterial;
        }

        public abstract double CalcularPrecio();

        virtual public string VerDetalle()
        {
            string material = "NN";
            if (tipoMaterial == 0)
                material = "Pino";
            else if (tipoMaterial == 1)
                material = "Algarrobo";
            else if (tipoMaterial == 2)
                material = "Caoba";

            return $"{descripcion,15}{material,10}{precioBase,10:f2}";
        }
    }
}
