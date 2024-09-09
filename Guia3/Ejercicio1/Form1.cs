using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList envios = new ArrayList();

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList();
            Mesa nuevaMesa = null;
            double precioBase;
            string descripcion;
            double largo;
            int tipoMaterial;

            precioBase = 10.1;
            descripcion = "Mesa ";
            largo = 1;
            tipoMaterial = 1;
            nuevaMesa = new Mesa(descripcion, precioBase, tipoMaterial, largo);
            lista.Add(nuevaMesa);

            precioBase = 12.2;
            descripcion = "Silla";
            tipoMaterial = 2;
            Silla nuevaSilla = new Silla(descripcion, precioBase, tipoMaterial);
            lista.Add(nuevaSilla);

            tBPrueba.Clear();

            foreach (Producto producto in lista)
            {
                tBPrueba.Text += $"{producto.VerDetalle()}\r\n";
            }
        }
    }
}
