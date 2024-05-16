using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ganancias_Packet_On.Clases;
using Ganancias_Packet_On.Controladores;

namespace Ganancias_Packet_On.Vistas
{
    public partial class FormaAjustarParametros : Form
    {
        private FormaInicial formaInicial;
        private C_Variables variables;
        private C_CostosFijos costosFijos;
        private C_CostosVariables costosVariables;
        private Cont_ColocarRecogerValores cont_ColocarRecoger;

        private short pagina;

        public FormaAjustarParametros()
        {
            InitializeComponent();
        }

        public FormaAjustarParametros(FormaInicial formaInicial, C_CostosFijos cfijos, C_CostosVariables cvariables, C_Variables variables)
        {
            this.formaInicial = formaInicial;
            pagina = 1;

            InitializeComponent();

            btn_Anterior.Enabled = false;
            costosVariables = cvariables;
            costosFijos = cfijos;
            this.variables = variables;

            cont_ColocarRecoger = new(cfijos,cvariables,variables,this);
            cont_ColocarRecoger.ColocarValores(pagina);
        }

        private void btn_Regresar_Click_1(object sender, EventArgs e)
        {

            cont_ColocarRecoger.RecogerValores(pagina);
            cont_ColocarRecoger.ReasignarValores();

            formaInicial.Show();

            this.Close();
        }

        private void btn_Siguiente_Click(object sender, EventArgs e)
        {
            Cont_paginacion paginacion = new(this);

            cont_ColocarRecoger.RecogerValores(pagina);

            pagina = paginacion.Siguiente_pag(pagina, btn_Anterior, btn_Siguiente);

            cont_ColocarRecoger.ColocarValores(pagina);
        }

        private void btn_Anterior_Click(object sender, EventArgs e)
        {
            Cont_paginacion paginacion = new(this);

            cont_ColocarRecoger.RecogerValores(pagina);

            pagina = paginacion.Anterior_pag(pagina, btn_Anterior, btn_Siguiente);

            cont_ColocarRecoger.ColocarValores(pagina);
        }
    }
}
