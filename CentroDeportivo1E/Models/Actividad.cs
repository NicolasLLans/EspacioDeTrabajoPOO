using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeportivo1E.Models
{
    internal class Actividad
    {
        private int id;
        private string nombre;
        private int precio;

        public Actividad(int id, string nombre, int precio)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
        }
    public int Id
    {
        get { return id; }
        private set { id = value; }
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int Precio
    {
        get { return precio; }
        set { precio = value; }
    }

    }
}
