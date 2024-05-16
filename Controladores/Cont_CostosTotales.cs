using Ganancias_Packet_On.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganancias_Packet_On.Controladores
{
    public class Cont_CostosTotales
    {
        public decimal GastosTotalesValor { get; private set; }
        public decimal CostosEnvios { get; private set; }
        
        public Cont_CostosTotales(C_CostosFijos costFijos, C_CostosVariables costVar, C_Variables vars)
        {
            ObtenerGastosyEnvios(costFijos, costVar, vars);
        }

        private decimal CalcularTotalFijos(C_CostosFijos costFijos)
        {
            decimal acum = 0;
            acum += costFijos.RentaOficinas;
            acum += costFijos.Administracion;
            acum += costFijos.Operativos;
            acum += costFijos.MantenimientoApp;
            acum += costFijos.RegistroDominio;
            acum += costFijos.LicenciasSoftware;

            return acum;
        }

        private decimal CalcularTotalVariables(C_CostosVariables costVar, C_Variables vars)
        {
            decimal acum = 0;

            acum += costVar.NumCajeros * vars.SalCajero;
            acum += costVar.NumRepartidores * vars.SalRepartidor;
            acum += costVar.NumEmpaquetadores * vars.SalEmpaquetador;
            acum += costVar.NumTi * vars.SalTI;
            acum += costVar.NumBodegas * vars.CostoBodega;
            acum += costVar.NumMantenimientos * vars.CostoMantenimiento;
            acum += vars.Improvistos;

            return acum;
        }

        public void ObtenerGastosyEnvios(C_CostosFijos costFijos, C_CostosVariables costVar, C_Variables vars)
        {
            GastosTotalesValor = CalcularTotalFijos(costFijos);
            GastosTotalesValor += CalcularTotalVariables(costVar, vars);
            GastosTotalesValor = Math.Round(GastosTotalesValor, 2);

            CostosEnvios = vars.CostoEnvio * costVar.NumEnviosPrevistos;
            CostosEnvios = Math.Round(CostosEnvios, 2);
        }
    }
}
