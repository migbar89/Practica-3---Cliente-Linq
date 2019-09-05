using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_3_LINQ
{
    class clientes
    {
        private string[] array;

        public clientes(string[] array)
        {
            idcliente =int.Parse( array[0]);
            cedula = array[1];
            nombre = array[2];
            apellido = array[3];
            fecha_nac = array[4];
            telefono = array[5];
            celular = array[6];

            direccion = array[7];
            correo = array[8];
            municipio = array[9];
            estado_civil = int.Parse(array[10]);
            if(array[11].Trim().Length>0)
                sexo =array[11];

        }

        public int idcliente
        { set; get; }

        public string cedula
        { set; get; }
        public string nombre
        { set; get; }
        public string apellido
        { set; get; }
        public string fecha_nac
        { set; get; }
        public string telefono
        { set; get; }
        public string celular
        { set; get; }
        public string direccion
        { set; get; }
        public string correo
        { set; get; }
        public string municipio
        { set; get; }
        public int estado_civil
        { set; get; }
        public string sexo
        { set; get; }


    }
}
