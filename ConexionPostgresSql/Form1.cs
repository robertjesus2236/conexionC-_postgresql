namespace ConexionPostgresSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        conexionPSQL conectandose = new conexionPSQL();
        private void Conectar_Click(object sender, EventArgs e)
        {
           
            conectandose.Conectar();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Desconectar_Click(object sender, EventArgs e)
        {
            conectandose.Desconectar();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            dtgv_Consulta.DataSource = conectandose.Consultar(txt_Nombre.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}