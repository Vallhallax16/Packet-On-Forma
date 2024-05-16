using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganancias_Packet_On.Clases
{
    public class C_Variables
    {
        public decimal SalRepartidor { get; set; }
        public decimal SalCajero { get; set; }
        public decimal SalEmpaquetador { get; set; }
        public decimal SalTI { get; set; }
        public decimal CostoBodega { get; set; }
        public decimal CostoEnvio { get; set; }
        public decimal CostoMantenimiento { get; set; }
        public decimal Improvistos { get; set; }
        public decimal Porcentaje { get; set; }

        public C_Variables()
        {
            this.SalRepartidor = 60000M;
            this.SalCajero = 62000M;
            this.SalEmpaquetador = 58000M;
            this.SalTI = 162000M;
            this.CostoBodega = 35000M;
            this.CostoEnvio = 15.65M;
            this.CostoMantenimiento = 22500M;
            this.Improvistos = 16000M;
            this.Porcentaje = 20M;
        }
    }
}
