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
    public partial class FrmMatrizInversa : Form
    {
        int k, h = 1;
        Random random = new Random();
        public FrmMatrizInversa()
        {
            InitializeComponent();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtRenglonesColumnas.Text);
            }
            catch (Exception)
            {

                txtRenglonesColumnas.Text = "2";
            }
            //dataGridView1.Columns.Clear();
            //dataGridView2.Columns.Clear();
            //dataGridView3.Columns.Clear();
            //dataGridView4.Columns.Clear();
            //dataGridView5.Columns.Clear();
            //for (int i = 0; i < int.Parse(txtRenglonesColumnas.Text); i++)
            //{
            //    dataGridView1.Columns.Add("Column" + i, "Column" + i);
            //    dataGridView2.Columns.Add("Column" + i, "Column" + i);
            //    dataGridView3.Columns.Add("Column" + i, "Column" + i);
            //    dataGridView4.Columns.Add("Column" + i, "Column" + i);
            //    dataGridView5.Columns.Add("Column" + i, "Column" + i);

            //}
            for (int i = 0; i < int.Parse(txtRenglonesColumnas.Text); i++)
            {
                //dataGridView1.Rows.Add();
                //dataGridView2.Rows.Add();
                //dataGridView3.Rows.Add();
                //dataGridView4.Rows.Add();
                //dataGridView5.Rows.Add();
                //dataGridView1.Rows[i].HeaderCell.Value = "Row" + i;
                //dataGridView2.Rows[i].HeaderCell.Value = "Row" + i;
                //dataGridView3.Rows[i].HeaderCell.Value = "Row" + i;
                //dataGridView4.Rows[i].HeaderCell.Value = "Row" + i;
                //dataGridView5.Rows[i].HeaderCell.Value = "Row" + i;
            }
            for (int i = 0; i < int.Parse(txtRenglonesColumnas.Text); i++)
            {
                //dataGridView2.Columns.Add("Column" + i, "Column" + i);
            }
            for (int i = 0; i < int.Parse(txtRenglonesColumnas.Text); i++)
            {
                //dataGridView2.Rows.Add();
                //dataGridView2.Rows[i].HeaderCell.Value = "Row" + i;
            }
            for (int c = 0; c < int.Parse(txtRenglonesColumnas.Text); c++)
            {
                for (int r = 0; r< int.Parse(txtRenglonesColumnas.Text); r++)
                {
                    dataGridView1[c, r].Value = "1";
                }
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            for (int r= 0; r <int.Parse(txtRenglonesColumnas.Text); r++)
            {
                for (int c = 0; c < int.Parse(txtRenglonesColumnas.Text); c++)
                {
                    dataGridView1[c,r].Value = random.Next(int.Parse(txtInferior.Text) - 1, int.Parse(txtSuperior.Text) + 1);
                }
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            //for (int c = 0; c < int.Parse(txtRenglonesColumnas.Text); c++)
            //{
            //    for (int r = 0; r < int.Parse(txtRenglonesColumnas.Text); r++)
            //    {
            //        try
            //        {
            //            int.Parse(dataGridView1[c, r].Value.ToString());
            //        }
            //        catch (Exception)
            //        {

            //            dataGridView1[c, r].Value = "1";
            //        }
            //        for (int col = 0; col < int.Parse(txtRenglonesColumnas.Text); col++)
            //        {
            //            for (int ren = 0; ren < int.Parse(txtRenglonesColumnas.Text); ren++)
            //            {
            //                dataGridView1[ren, col].Value = dataGridView3[col, ren].Value.ToString();
            //            }
            //        }
            //    }
            //}
            //Variable en donde almaceno
            //int data = dataGridView1.Rows[0].Index +
            //dataGridView1.Rows[4].Index + dataGridView1.Rows[8].Index
            //- dataGridView1.Rows[0].Index
            //- dataGridView1.Rows[4].Index - dataGridView1.Rows[7].Index
            //- dataGridView1.Rows[1].Index * dataGridView1.Rows[3].Index
            //- dataGridView1.Rows[8].Index +dataGridView1.Rows[1].Index + dataGridView1.Rows[5].Index
            //- dataGridView1.Rows[6].Index;
            //for (int i = 0; i < length; i++)
            //{
            //    for (int i = 0; i < length; i++)
            //    {
            //        if (true)
            //        {
            //            //dataGridView1.Rows[1].Index
            //        }
            //    }
            //}
               

            //MessageBox.Show("Resultado es" + data);

        }
        //Metodo de eliminacion para GAUSS
        //static void Eliminacion(double[,] matriz, int n)
        //{
        //    for (int k = 0; k < n - 1; k++)
        //    {
        //        for (int i = k + 1; i < n; i++)
        //        {
        //            double factor = matriz[i, k] / matriz[k, k];

        //            for (int j = k; j <= n; j++)
        //            {
        //                matriz[i, j] = matriz[i, j] - matriz[k, j] * factor;
        //            }
        //        }
        //    }
        //}
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
