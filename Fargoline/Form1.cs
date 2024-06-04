namespace Fargoline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contenedor contenedor = new Contenedor();
            contenedor.NumeroC = txtconte.Text;
            contenedor.TipoC = cbconte.Text;
            contenedor.TamanoC = cbtama.Text;
            contenedor.PesoC = Convert.ToDecimal(txtpeso.Text);
            contenedor.TaraC = Convert.ToDecimal(txttara.Text);



            /* refresca cuando guarda */

            refrescar();

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            if (id != null)
            {
                contenedor.id = id;
                int result = ContenedorDAL.modificar(contenedor);

                if (result > 0)
                {
                    MessageBox.Show("Se guardo: " + contenedor.NumeroC);
                }
                else
                {
                    MessageBox.Show("ErrorError de edicion...");
                }
            }
            else
            {

                int result = ContenedorDAL.AgregaConte(contenedor);

                if (result > 0)
                {
                    MessageBox.Show("Se guardo: " + contenedor.NumeroC);
                }
                else
                {
                    MessageBox.Show("Error al guardar...");
                }
            }

            refrescar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* refresca cuando se carga*/
            refrescar();
        }

        public void refrescar()
        {
            /*muestra de datos*/
            dataGridView1.DataSource = ContenedorDAL.PresentarRegistro();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtid.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["id"].Value);
            txtconte.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["NumeroC"].Value);
            cbconte.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["TipoC"].Value);
            cbtama.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["TamanoC"].Value);
            txtpeso.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["PesoC"].Value);
            txttara.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["TaraC"].Value);
        }

        private void btnelimina_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);


                int resultado = ContenedorDAL.elimina(id);
                if (resultado > 0)
                {
                    MessageBox.Show("Se elimino");
                }
                else
                {
                    MessageBox.Show("Error...");
                }
            }
            refrescar();
        }

        private void btnedita_Click(object sender, EventArgs e)
        {
            txtconte.Clear();
            txtpeso.Clear();
            txttara.Clear();
        }
    }
}