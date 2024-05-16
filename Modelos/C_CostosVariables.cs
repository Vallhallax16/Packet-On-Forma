using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganancias_Packet_On.Clases
{
    public class C_CostosVariables
    {
        public decimal NumCajeros { get; set; }
        public decimal NumRepartidores { get; set; }
        public decimal NumEmpaquetadores { get; set; }
        public decimal NumTi { get; set; }
        public decimal NumBodegas { get; set; }
        public decimal NumEnviosPrevistos { get; set; }
        public decimal NumMantenimientos { get; set; }

        public C_CostosVariables()
        {
            this.NumCajeros = 16M;
            this.NumRepartidores = 20M;
            this.NumEmpaquetadores = 16M;
            this.NumTi = 3M;
            this.NumBodegas = 5M;
            this.NumEnviosPrevistos = 250000M;
            this.NumMantenimientos = 6M;
        }
    }
}
