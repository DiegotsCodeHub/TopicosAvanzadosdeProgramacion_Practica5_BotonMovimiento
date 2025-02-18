namespace CruzPatinoDiego_Practica5_BotonMovimiento
{
    public partial class FrmPrincipal : Form
    {
        //generacion de random
        Random Random = new Random();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btn_movercosas_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MoverBoton()//metodo para generar las coordenadas 
        {
            // Genera nuevas coordenadas aleatorias dentro de los límites del formulario
            int mayorX = this.ClientSize.Width - btn_movercosas.Size.Width;
            int mayorY = this.ClientSize.Height - btn_movercosas.Size.Height;
            int nuevoX = Random.Next(0, mayorX);
            int nuevoY = Random.Next(0, mayorY);

            // Establece la nueva posición del botón
            btn_movercosas.Location = new System.Drawing.Point(nuevoX, nuevoY);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoverBoton();
        }
    }
}
