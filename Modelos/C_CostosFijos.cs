using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganancias_Packet_On.Clases
{
    public class C_CostosFijos
    {
        public decimal RentaOficinas { get; set; }
        public decimal Administracion { get; set; }
        public decimal Operativos { get; set; }
        public decimal MantenimientoApp { get; set; }
        public decimal RegistroDominio { get; set; }
        public decimal LicenciasSoftware { get; set; }

        public C_CostosFijos()
        {
            this.RentaOficinas = 45000M;
            this.Administracion = 25600M;
            this.Operativos = 25600M;
            this.MantenimientoApp = 8500M;
            this.RegistroDominio = 8500M;
            this.LicenciasSoftware = 14500M;
        }
    }
}
