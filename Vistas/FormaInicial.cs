using Ganancias_Packet_On.Clases;
using Ganancias_Packet_On.Controladores;
using Ganancias_Packet_On.Vistas;
using System.Diagnostics;

namespace Ganancias_Packet_On
{
    public partial class FormaInicial : Form
    {
        private C_CostosFijos costosFijos;
        private C_CostosVariables costosVariables;
        private C_Variables variables;

        public FormaInicial()
        {
            InitializeComponent();

            costosFijos = new();
            costosVariables = new();
            variables = new();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ajustar_param_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormaAjustarParametros formaAjustar = new FormaAjustarParametros(this, costosFijos, costosVariables, variables);
            formaAjustar.Show();
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormaCalculo formaCalculo = new FormaCalculo(this, costosFijos, costosVariables, variables);
            formaCalculo.Show();
        }
    }
}
