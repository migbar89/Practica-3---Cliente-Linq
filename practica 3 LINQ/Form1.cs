using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace practica_3_LINQ
{
    public partial class Form1 : Form
    {
        List<clientes> listafiltrada;
        List<clientes> listacliente = new List<clientes>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            StreamReader stream = new StreamReader("datosclientes.txt");
            while (stream.Peek() > 0)
            {
                string linea = stream.ReadLine();
                String[] array = linea.Split(';');
                clientes cli = new clientes(array);
                listacliente.Add(cli);


            }

            //
            listafiltrada = listacliente;
            cargardatos();
        }
        void cargardatos()
        {
            dataGridView1.DataSource = null;
            if(listafiltrada.Count==0)
                dataGridView1.DataSource = listacliente;
            else
                dataGridView1.DataSource = listafiltrada;
        }
        private void ctcedula_TextChanged(object sender, EventArgs e)
        {
            filtro();
        }
        void filtro()
        {
           var query = from clientes in listacliente select clientes;
            if (ctcedula.Text.Trim().Length > 0)
            {
                query = query.Where(p => p.cedula.Contains(ctcedula.Text.Trim()));
            }
            if (ctnombre.Text.Trim().Length > 0)
            {
                query = query.Where(p => p.nombre.ToUpper().Contains(ctnombre.Text.Trim().ToUpper()));
            }
            if (ctapellido.Text.Trim().Length > 0)
            {
                query = query.Where(p => p.apellido.ToUpper().Contains(ctapellido.Text.Trim().ToUpper()));
            }
            listafiltrada = query.ToList();
            //MessageBox.Show("lista filtrada=" + listafiltrada.Count.ToString());
            cargardatos();

        }

      
    }
}
