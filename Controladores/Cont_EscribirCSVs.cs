using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using Ganancias_Packet_On.Clases;

namespace Ganancias_Packet_On.Controladores
{
    public class Cont_EscribirCSVs
    {

        public Cont_EscribirCSVs() 
        {
           
        }

        public void GenerarReporte(string nombre_sin_ext, int escenario, string perdida_ganancia, C_Variables variables, C_CostosFijos costosFijos, C_CostosVariables costosVariables, Cont_ReporteFinal reporteFinal, Cont_CostosTotales costosTotales)
        {
            using (var pre_escritor = new StreamWriter(nombre_sin_ext + ".csv"))
            using (var escritor = new CsvWriter(pre_escritor, CultureInfo.InvariantCulture))
            {
                escritor.WriteField("Reporte de escenario " + escenario.ToString());
                escritor.NextRecord();
                escritor.NextRecord();

                escritor.WriteField($"Porcentaje de {perdida_ganancia}: {variables.Porcentaje}%");
                escritor.NextRecord();

                Cont_paginacion paginacion = new Cont_paginacion();
                var lista = paginacion.GETEtiquetas();

                short i = 0;

                foreach (string[] arreglo in lista)
                {
                    switch(i)
                    {
                        case 0:
                            escritor.WriteField("Salarios y otras variables");
                            escritor.NextRecord();
                            escritor.WriteField(arreglo[1]);
                            escritor.WriteField(variables.SalRepartidor);
                            escritor.NextRecord();
                            escritor.WriteField(arreglo[2]);
                            escritor.WriteField(variables.SalCajero);
                            escritor.NextRecord();
                            escritor.WriteField(arreglo[3]);
                            escritor.WriteField(variables.SalEmpaquetador);
                            escritor.NextRecord();
                            escritor.WriteField(arreglo[4]);
                            escritor.WriteField(variables.SalTI);
                            escritor.NextRecord();
                            escritor.WriteField(arreglo[5]);
                            escritor.WriteField(variables.CostoBodega);
                            escritor.NextRecord();
                            escritor.WriteField(arreglo[6]);
                            escritor.WriteField(variables.CostoMantenimiento);
                            escritor.NextRecord();
                            escritor.WriteField(arreglo[7]);
                            escritor.WriteField(variables.Improvistos);
                            escritor.NextRecord();
                            escritor.WriteField(arreglo[8]);
                            escritor.WriteField(variables.CostoEnvio);
                            escritor.NextRecord();
                            escritor.NextRecord();
                            break;

                        case 1:
                            escritor.WriteField("Cantidades");
                            escritor.NextRecord();
                            escritor.WriteField(arreglo[0].Replace('ú','u'));
                            escritor.WriteField(costosVariables.NumCajeros);
                            escritor.NextRecord();
                            escritor.WriteField(arreglo[1].Replace('ú', 'u'));
                            escritor.WriteField(costosVariables.NumRepartidores);
                            escritor.NextRecord();
                            escritor.WriteField(arreglo[2].Replace('ú', 'u'));
                            escritor.WriteField(costosVariables.NumEmpaquetadores);
                            escritor.NextRecord();
                            escritor.WriteField(arreglo[3].Replace('ú', 'u'));
                            escritor.WriteField(costosVariables.NumTi);
                            escritor.NextRecord();
                            escritor.WriteField(arreglo[4].Replace('ú', 'u'));
                            escritor.WriteField(costosVariables.NumBodegas);
                            escritor.NextRecord();
                            escritor.WriteField(arreglo[5].Replace('ú', 'u'));
                            escritor.WriteField(costosVariables.NumEnviosPrevistos);
                            escritor.NextRecord();
                            escritor.WriteField(arreglo[6].Replace('ú', 'u'));
                            escritor.WriteField(costosVariables.NumMantenimientos);
                            escritor.NextRecord();
                            escritor.NextRecord();
                            break;

                        case 2:
                            escritor.WriteField("Gastos fijos");
                            escritor.NextRecord();
                            escritor.WriteField(arreglo[0]);
                            escritor.WriteField(costosFijos.RentaOficinas);
                            escritor.NextRecord();
                            escritor.WriteField(arreglo[1]);
                            escritor.WriteField(costosFijos.Administracion);
                            escritor.NextRecord();
                            escritor.WriteField(arreglo[2]);
                            escritor.WriteField(costosFijos.Operativos);
                            escritor.NextRecord();
                            escritor.WriteField(arreglo[3]);
                            escritor.WriteField(costosFijos.MantenimientoApp);
                            escritor.NextRecord();
                            escritor.WriteField(arreglo[4]);
                            escritor.WriteField(costosFijos.RegistroDominio);
                            escritor.NextRecord();
                            escritor.WriteField(arreglo[0]);
                            escritor.WriteField(costosFijos.LicenciasSoftware);
                            escritor.NextRecord();
                            escritor.NextRecord();
                            break;
                    }

                    i++;
                }

                if(perdida_ganancia == "perdida")
                {
                    escritor.WriteField("Perdidas generadas: ");
                    escritor.WriteField(reporteFinal.GananciasNetas);
                    escritor.NextRecord();
                    escritor.WriteField("Las perdidas empiezan si el envio se cobra en: ");
                    escritor.WriteField(reporteFinal.PrecioEnvio);
                }
                else
                {
                    escritor.WriteField("Ganancias netas generadas: ");
                    escritor.WriteField(reporteFinal.GananciasNetas);
                    escritor.NextRecord();
                    escritor.WriteField("Los envios deben cobrarse en: ");
                    escritor.WriteField(reporteFinal.PrecioEnvio);
                }

                escritor.NextRecord();
                escritor.WriteField("Gastos totales: ");
                escritor.WriteField(costosTotales.GastosTotalesValor + costosTotales.CostosEnvios);
            }
        }
    }
}
