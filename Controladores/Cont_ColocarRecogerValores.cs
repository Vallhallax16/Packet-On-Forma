using Ganancias_Packet_On.Clases;
using Ganancias_Packet_On.Vistas;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganancias_Packet_On.Controladores
{
    public class Cont_ColocarRecogerValores
    {
        private C_CostosFijos cFijos;
        private C_CostosVariables cVariables;
        private C_Variables variables;

        private C_CostosFijos temp_cFijos;
        private C_CostosVariables temp_cVariables;
        private C_Variables temp_variables;

        private FormaAjustarParametros formaAjuste;

        public Cont_ColocarRecogerValores()
        {

        }

        public Cont_ColocarRecogerValores(C_CostosFijos cFijos, C_CostosVariables cVariables, C_Variables variables, FormaAjustarParametros formaAjuste)
        {
            this.cFijos = cFijos;
            this.cVariables = cVariables;
            this.variables = variables; 
            this.formaAjuste = formaAjuste;

            temp_cFijos = cFijos;
            temp_cVariables = cVariables;
            temp_variables = variables;
        }

        public void ColocarValores(short paginas)
        {
            switch (paginas - 1) 
            {
                case 0:
                    var elemento = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_0")).ToList();
                    elemento[0].Text = variables.Porcentaje.ToString();

                    elemento = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_1")).ToList();
                    elemento[0].Text = variables.SalRepartidor.ToString();

                    elemento = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_2")).ToList();
                    elemento[0].Text = variables.SalCajero.ToString();

                    elemento = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_3")).ToList();
                    elemento[0].Text = variables.SalEmpaquetador.ToString();

                    elemento = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_4")).ToList();
                    elemento[0].Text = variables.SalTI.ToString();

                    elemento = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_5")).ToList();
                    elemento[0].Text = variables.CostoBodega.ToString();

                    elemento = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_6")).ToList();
                    elemento[0].Text = variables.CostoMantenimiento.ToString();

                    elemento = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_7")).ToList();
                    elemento[0].Text = variables.Improvistos.ToString();

                    elemento = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_8")).ToList();
                    elemento[0].Text = variables.CostoEnvio.ToString();

                    break;

                case 1:
                    var elemento2 = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_0")).ToList();
                    elemento2[0].Text = cVariables.NumCajeros.ToString();

                    elemento2 = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_1")).ToList();
                    elemento2[0].Text = cVariables.NumRepartidores.ToString();

                    elemento2 = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_2")).ToList();
                    elemento2[0].Text = cVariables.NumEmpaquetadores.ToString();

                    elemento2 = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_3")).ToList();
                    elemento2[0].Text = cVariables.NumTi.ToString();

                    elemento2 = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_4")).ToList();
                    elemento2[0].Text = cVariables.NumBodegas.ToString();

                    elemento2 = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_5")).ToList();
                    elemento2[0].Text = cVariables.NumEnviosPrevistos.ToString();

                    elemento2 = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_6")).ToList();
                    elemento2[0].Text = cVariables.NumMantenimientos.ToString();
                    break;

                case 2:
                    var elemento3 = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_0")).ToList();
                    elemento3[0].Text = cFijos.RentaOficinas.ToString();

                    elemento3 = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_1")).ToList();
                    elemento3[0].Text = cFijos.Administracion.ToString();

                    elemento3 = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_2")).ToList();
                    elemento3[0].Text = cFijos.Operativos.ToString();

                    elemento3 = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_3")).ToList();
                    elemento3[0].Text = cFijos.MantenimientoApp.ToString();

                    elemento3 = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_4")).ToList();
                    elemento3[0].Text = cFijos.RegistroDominio.ToString();

                    elemento3 = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_5")).ToList();
                    elemento3[0].Text = cFijos.LicenciasSoftware.ToString();
                    break;
            }   
        }

        public void RecogerValores(short paginas)
        {
            switch (paginas - 1)
            {
                case 0:
                    var elemento = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_0")).ToList();
                    temp_variables.Porcentaje = Convert.ToDecimal(elemento[0].Text);

                    elemento = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_1")).ToList();
                    temp_variables.SalRepartidor = Convert.ToDecimal(elemento[0].Text);

                    elemento = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_2")).ToList();
                    temp_variables.SalCajero = Convert.ToDecimal(elemento[0].Text);

                    elemento = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_3")).ToList();
                    temp_variables.SalEmpaquetador = Convert.ToDecimal(elemento[0].Text);

                    elemento = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_4")).ToList();
                    temp_variables.SalTI = Convert.ToDecimal(elemento[0].Text);

                    elemento = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_5")).ToList();
                    temp_variables.CostoBodega = Convert.ToDecimal(elemento[0].Text);

                    elemento = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_6")).ToList();
                    temp_variables.CostoMantenimiento = Convert.ToDecimal(elemento[0].Text);

                    elemento = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_7")).ToList();
                    temp_variables.Improvistos = Convert.ToDecimal(elemento[0].Text);

                    elemento = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_8")).ToList();
                    temp_variables.CostoEnvio = Convert.ToDecimal(elemento[0].Text);

                    break;

                case 1:
                    var elemento2 = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_0")).ToList();
                    temp_cVariables.NumCajeros = Convert.ToDecimal(elemento2[0].Text);

                    elemento2 = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_1")).ToList();
                    temp_cVariables.NumRepartidores = Convert.ToDecimal(elemento2[0].Text);

                    elemento2 = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_2")).ToList();
                    temp_cVariables.NumEmpaquetadores = Convert.ToDecimal(elemento2[0].Text);

                    elemento2 = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_3")).ToList();
                    temp_cVariables.NumTi = Convert.ToDecimal(elemento2[0].Text);

                    elemento2 = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_4")).ToList();
                    temp_cVariables.NumBodegas = Convert.ToDecimal(elemento2[0].Text);

                    elemento2 = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_5")).ToList();
                    temp_cVariables.NumEnviosPrevistos = Convert.ToDecimal(elemento2[0].Text);

                    elemento2 = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_6")).ToList();
                    temp_cVariables.NumMantenimientos = Convert.ToDecimal(elemento2[0].Text);
                    break;

                case 2:
                    var elemento3 = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_0")).ToList();
                    temp_cFijos.RentaOficinas = Convert.ToDecimal(elemento3[0].Text);

                    elemento3 = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_1")).ToList();
                    temp_cFijos.Administracion = Convert.ToDecimal(elemento3[0].Text);

                    elemento3 = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_2")).ToList();
                    temp_cFijos.Operativos = Convert.ToDecimal(elemento3[0].Text);

                    elemento3 = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_3")).ToList();
                    temp_cFijos.MantenimientoApp = Convert.ToDecimal(elemento3[0].Text);

                    elemento3 = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_4")).ToList();
                    Debug.WriteLine($"Se recogio {elemento3[0].Text} de la forma");
                    temp_cFijos.RegistroDominio = Convert.ToDecimal(elemento3[0].Text);

                    elemento3 = formaAjuste.Controls.OfType<TextBox>().Where(label => label.Name.Contains("txtb_5")).ToList();
                    temp_cFijos.LicenciasSoftware = Convert.ToDecimal(elemento3[0].Text);
                    break;
            }
        }

        public void ReasignarValores()
        {
            variables.Improvistos = temp_variables.Improvistos; ;
            variables.Porcentaje = temp_variables.Porcentaje;
            variables.SalCajero = temp_variables.SalCajero;
            variables.SalEmpaquetador = temp_variables.SalEmpaquetador;
            variables.SalRepartidor = temp_variables.SalRepartidor;
            variables.SalTI = temp_variables.SalTI;
            variables.CostoBodega = temp_variables.CostoBodega;
            variables.CostoEnvio = temp_variables.CostoEnvio;
            variables.CostoMantenimiento = temp_variables.CostoMantenimiento;

            cFijos.LicenciasSoftware = temp_cFijos.LicenciasSoftware;
            cFijos.MantenimientoApp = temp_cFijos.MantenimientoApp;
            cFijos.Operativos = temp_cFijos.Operativos;
            cFijos.RegistroDominio = temp_cFijos.RegistroDominio;
            cFijos.RentaOficinas = temp_cFijos.RentaOficinas;
            cFijos.Administracion = temp_cFijos.Administracion;

            cVariables.NumBodegas = temp_cVariables.NumBodegas;
            cVariables.NumCajeros = temp_cVariables.NumCajeros;
            cVariables.NumEmpaquetadores = temp_cVariables.NumEmpaquetadores;
            cVariables.NumEnviosPrevistos = temp_cVariables.NumEnviosPrevistos;
            cVariables.NumMantenimientos = temp_cVariables.NumMantenimientos;
            cVariables.NumRepartidores = temp_cVariables.NumRepartidores;
            cVariables.NumTi = temp_cVariables.NumTi;
        }
    }
}
