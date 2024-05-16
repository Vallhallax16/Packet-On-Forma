using Ganancias_Packet_On.Clases;
using Ganancias_Packet_On.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganancias_Packet_On.Controladores
{
    public class Cont_Escenarios
    {
        private C_CostosFijos costosFijos;
        private C_CostosVariables costosVariables;
        private C_Variables variables;

        private Cont_CostosTotales costosTotales;
        private Cont_ReporteFinal reporteFinal;

        public int num_escenario {  get; set; }

        private FormaCalculo formaCalculo;

        public Cont_Escenarios(C_CostosFijos costosFijos, C_CostosVariables costosVariables, C_Variables variables,Cont_CostosTotales costosTotales, Cont_ReporteFinal reporteFinal , FormaCalculo fcalculo) 
        {
            this.variables = variables;
            this.costosFijos = costosFijos;
            this.costosVariables = costosVariables;

            this.costosTotales = costosTotales;
            this.reporteFinal = reporteFinal;

            num_escenario = 1;

            formaCalculo = fcalculo;

            PrimerEscenario();
            GenerarReporte("ganancia",this.variables,this.costosFijos,this.costosVariables,this.reporteFinal,this.costosTotales);
        }  

        private void PrimerEscenario()
        {
            SETEtiquetasRutinarias(variables.Porcentaje);
            SETDemasEtiquetas();
        }

        private void SETEtiquetasRutinarias(decimal cantidad)
        {
            var lbl_escenario = formaCalculo.Controls.OfType<Label>().Where(label => label.Name.Contains("lbl_Escenario")).ToList();
            lbl_escenario[0].Text = "Escenario " + num_escenario.ToString();

            var lbl_porcentaje = formaCalculo.Controls.OfType<Label>().Where(label => label.Name.Contains("lbl_Porcentaje")).ToList();

            if (cantidad < 0)
            {
                lbl_porcentaje[0].Text = "Escenario con pérdidas (" + cantidad.ToString() + "%)";
            }
            else
            {
                lbl_porcentaje[0].Text = "Porcentaje de ganancia: " + cantidad.ToString() + "%";
            }
        }

        private void SETDemasEtiquetas()
        {
            var cant_ganancias = formaCalculo.Controls.OfType<Label>().Where(label => label.Name.Contains("lbl_Ganancias_cant")).ToList();
            cant_ganancias[0].Text = reporteFinal.GananciasNetas.ToString("N2");

            var cant_precio_envio = formaCalculo.Controls.OfType<Label>().Where(label => label.Name.Contains("lbl_Envio_cant")).ToList();
            cant_precio_envio[0].Text = reporteFinal.PrecioEnvio.ToString("N2");

            var cant_gastos_tot = formaCalculo.Controls.OfType<Label>().Where(label => label.Name.Contains("lbl_Gastos_cant")).ToList();
            cant_gastos_tot[0].Text = (costosTotales.GastosTotalesValor + costosTotales.CostosEnvios).ToString("N2");
        }

        public void CambiarEscenario()
        {
            if(num_escenario == 2)
            {
                variables.Porcentaje = 0M;

                costosTotales.ObtenerGastosyEnvios(costosFijos,costosVariables,variables);
                reporteFinal.ObtenerEnvioyGanancias(costosVariables, costosTotales, variables.Porcentaje);

                var picturebox = formaCalculo.Controls.OfType<PictureBox>().ToList();
                picturebox[0].ImageLocation = @"D:\Universidad\8vo semestre\Simulacion\Proyecto individual\Ganancias Packet-On\Recursos\PACKET_ON_SinGanancias.gif";

                SETEtiquetasRutinarias(0);
                GenerarReporte("ganancia", this.variables, this.costosFijos, this.costosVariables, this.reporteFinal, this.costosTotales);
            }
            else 
            {
                variables.Porcentaje = -0.05M;

                costosTotales.ObtenerGastosyEnvios(costosFijos, costosVariables, variables);
                reporteFinal.ObtenerEnvioyGanancias(costosVariables, costosTotales, variables.Porcentaje);

                var picturebox = formaCalculo.Controls.OfType<PictureBox>().ToList();
                picturebox[0].ImageLocation = @"D:\Universidad\8vo semestre\Simulacion\Proyecto individual\Ganancias Packet-On\Recursos\PACKET-ON_Quiebra.gif";

                var lbl_perdidas = formaCalculo.Controls.OfType<Label>().Where(label => label.Name.Contains("lbl_Ganancias_tot")).ToList();
                lbl_perdidas[0].Text = "Pérdidas generadas:";

                var lbl_precio_envio = formaCalculo.Controls.OfType<Label>().Where(label => label.Name.Contains("lbl_Precio_envio")).ToList();
                lbl_precio_envio[0].Text = "Si cada envío se cobra en:";

                SETEtiquetasRutinarias(variables.Porcentaje);

                var boton_siguiente = formaCalculo.Controls.OfType<Button>().Where(label => label.Name.Contains("btn_Siguiente")).ToList();
                boton_siguiente[0].Enabled = false;

                GenerarReporte("perdida", this.variables, this.costosFijos, this.costosVariables, this.reporteFinal, this.costosTotales);
            }

            SETDemasEtiquetas();
        }

        private void GenerarReporte(string perdida_ganancia,C_Variables vars, C_CostosFijos cf, C_CostosVariables cv, Cont_ReporteFinal rf, Cont_CostosTotales ct)
        {
            Cont_EscribirCSVs escribirCSV = new();
            escribirCSV.GenerarReporte($"Escenario {num_escenario.ToString()}",num_escenario,perdida_ganancia,vars,cf,cv,rf,ct);


        }
    }
}
