using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3D
{
    internal class Persona
    {
        
        //Propiedades:
        public string Dpi { get; set; }
        public string Nombre { get; set;}
        public string Apellido { get; set;}
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        

        //Métodos:
        public int edad()
        {
            //DateTime hoy = DateTime.Now;


            //int edad = hoy.Year - FechaNacimiento.Year;

            //if (FechaNacimiento.Month > hoy.Month)
            //    edad--;

            DateTime hoy = DateTime.Now;

            TimeSpan intervalo = hoy - FechaNacimiento;


            int años = (intervalo.Days / 365);

            return años;

        }

        public void normalizarNombre()
        {
            Nombre = Nombre.Trim();


            //invocar al método ToTitleCase de la clase Cultureinfo            

            Nombre = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(Nombre);

        }

    }
}
