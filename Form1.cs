namespace cripto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconver_Click(object sender, EventArgs e)
        {
            
            double op;
            
            double res;
            double cantidad = Convert.ToInt32(valor1.Text);


            if (cmbOpcciones.SelectedIndex == -1)
            {
                MessageBox.Show("no seleccionaste nada");
            }
            else
            {
               switch (cmbOpcciones.SelectedItem.ToString())


            {
                    
                case "Doge":
                    res = cantidad / 0.001;
                    txtres.Text = res.ToString();
                    break;
                case "XRP":
                    res = (cantidad/1.6);
                    txtres.Text = res.ToString();
                    break;
                case "Bitcoin":
                    res = (10000/cantidad);
                    txtres.Text = res.ToString();
                    break;
                case "BAT":
                    res = (cantidad/1);
                    txtres.Text = res.ToString();
                    break;

            }


            }

            
        }
    }
}