using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatos
{
    public partial class FrmEstructuraDeDatos : Form
    {
        float alumno1 = 3.14f;
        double maestro1 = 3.14;
        Alumnos alumno = new Alumnos();
        Maestros maestro = new Maestros();
        public FrmEstructuraDeDatos()
        {
            InitializeComponent();
            alumno1.ToString();
            alumno.ToString();
            maestro1.ToString();
            maestro.ToString();
        }

        private void FrmEstructuraDeDatos_Load(object sender, EventArgs e)
        {

        }

        private void triangularYDeterminanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Triangular Anonima
            new FrmTriangularYDeterminante().ShowDialog();
            //Triangular con objeto
            //Instancia de la forma FrmTriangularYDeterminante
            //FrmTriangularYDeterminante frmTriangularYDeterminante = new FrmTriangularYDeterminante();
            //frmTriangularYDeterminante.ShowDialog();

            
        }
    }
    //Clases abstractas 
    class Alumnos
    {

    }

    class Maestros
    {

    }
}

