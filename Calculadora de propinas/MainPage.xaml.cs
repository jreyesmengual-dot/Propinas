namespace Calculadora_de_propinas
{
    public partial class MainPage : ContentPage
    {
        decimal propina;
        decimal propinaPersona;
        decimal total;
        decimal TotalPersona;
        public MainPage()
        {
            InitializeComponent();
            Limpiar();


        }
    
        public void Cacular_Button(object sender, EventArgs e)
        {
            decimal consumo = Convert.ToDecimal(ConsumoEntry.Text);
            decimal NumPersonas = Convert.ToDecimal(NumPersonaEntry.Text);
            decimal porcentaje = Convert.ToDecimal(PropinaEntry.Text);
            propina = consumo * (porcentaje / 100);
            propinaPersona = propina / NumPersonas;
            total = consumo + propina;
            TotalPersona = total / NumPersonas;
            Mostrar();


        }

        private void Limpiar_Button(object sender, EventArgs e)
        {
            Limpiar();

        }
        public void Mostrar()
        {

            ImportePropinaOUT.Text = $"${propina:F2}";
            PersonaPropinaOUT.Text = $"${propinaPersona:F2}";
            ImporteTotalOUT.Text = $"${total:F2}";
            TotalOUT.Text = $"${TotalPersona:F2}";
        }
        public void Limpiar()
        {
            ImportePropinaOUT.Text = "$0.00";
            PersonaPropinaOUT.Text = "$0.00";
            ImporteTotalOUT.Text = "$0.00";
            TotalOUT.Text = "$0.00";


        }
    }



}

