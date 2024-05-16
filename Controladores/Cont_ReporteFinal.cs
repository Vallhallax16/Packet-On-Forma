using Ganancias_Packet_On.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganancias_Packet_On.Controladores
{
    public class Cont_ReporteFinal
    {
        public decimal PrecioEnvio { get; private set; }
        public decimal GananciasBrutas { get; private set; }
        public decimal GananciasNetas { get; private set; }

        public Cont_ReporteFinal(C_CostosVariables costVar, Cont_CostosTotales costosTot, decimal porcentaje)
        {
            ObtenerEnvioyGanancias(costVar, costosTot, porcentaje);
        }

        public void ObtenerEnvioyGanancias(C_CostosVariables costVar, Cont_CostosTotales costosTot, decimal porcentaje)
        {
            PrecioEnvio = -(costosTot.GastosTotalesValor + costosTot.CostosEnvios) / (((porcentaje / 100) - 1) * costVar.NumEnviosPrevistos);
            PrecioEnvio = Math.Round(PrecioEnvio, 2);

            GananciasBrutas = PrecioEnvio * costVar.NumEnviosPrevistos;
            GananciasBrutas = Math.Round(GananciasBrutas, 2);

            GananciasNetas = GananciasBrutas - costosTot.GastosTotalesValor - costosTot.CostosEnvios;
            GananciasNetas = Math.Round(GananciasNetas, 2);
        }
    }
}
