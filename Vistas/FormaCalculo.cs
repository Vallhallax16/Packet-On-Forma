using Ganancias_Packet_On.Clases;
using Ganancias_Packet_On.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ganancias_Packet_On.Vistas
{
    public partial class FormaCalculo : Form
    {
        private FormaInicial formaInicial;
        private C_CostosFijos costosFijos;
        private C_CostosVariables costosVariables;
        private C_Variables variables;

        private Cont_Escenarios cont_Escenarios;

        public FormaCalculo()
        {
            InitializeComponent();
        }

        public FormaCalculo(FormaInicial inicia, C_CostosFijos costosFijos, C_CostosVariables costosVariables, C_Variables variables)
        {
            InitializeComponent();

            formaInicial = inicia;
            this.costosFijos = costosFijos;
            this.costosVariables = costosVariables;
            this.variables = variables;

            Cont_CostosTotales costosTotales = new(costosFijos, costosVariables, variables);
            Cont_ReporteFinal reporteFinal = new(costosVariables, costosTotales, variables.Porcentaje);

            cont_Escenarios = new(costosFijos, costosVariables, variables, costosTotales, reporteFinal, this);
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            if(cont_Escenarios.num_escenario == 3)
            {
                MessageBox.Show("¡Reportes generados en Excel!","Aviso de reportes",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            formaInicial.Show();
            this.Close();
        }

        private void BotonSiguiente_Click(object sender, EventArgs e)
        {
            cont_Escenarios.num_escenario = cont_Escenarios.num_escenario + 1;
            cont_Escenarios.CambiarEscenario();
        }
    }
}
