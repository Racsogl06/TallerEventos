using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEventos.Clases
{
    internal class Tarea
    {
        public string nombre { get; set; }
        public string estado { get; set; }

        public readonly DateTime fechaCreacion;


        public Tarea(string nombre, string estado)
        {
            this.fechaCreacion = DateTime.Now;
            this.nombre = nombre;
            this.estado = estado;
        }

    }
}
