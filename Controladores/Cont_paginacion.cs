using Ganancias_Packet_On.Vistas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ganancias_Packet_On.Controladores
{
    public class Cont_paginacion
    {
        private string[] etiquetas = ["Porcentaje de ganancia:", "Salario del repartidor:", "Salario del cajero:", "Salario del empaquetador:", "Salario Lic. en TI:", "Renta de bodega:", "Costo del mantenimiento:", "Imprevistos:","Costo del envío:"];
        private string[] etiquetas2 = ["Número de cajeros:","Número de repartidores:","Número de empaquetadores:","Número de Lic. en TI:","Número de bodegas:","Número de envíos previstos:","Número de mantenimientos"];
        private string[] etiquetas3 = ["Renta de oficinas:","Gastos administrativos:","Gastos operativos:","Mantenimiento de la app:","Página web:","Licencias de software:"];
        private ArrayList lista = new();
        private FormaAjustarParametros formaajuste;

        public Cont_paginacion()
        {
            lista.Add(etiquetas);
            lista.Add(etiquetas2);
            lista.Add(etiquetas3);
        }
        
        public Cont_paginacion(FormaAjustarParametros fAjuste)
        {
            lista.Add(etiquetas);
            lista.Add(etiquetas2);
            lista.Add(etiquetas3);

            formaajuste = fAjuste;
        }

        public short Siguiente_pag(short pag, Button anterior, Button siguiente)
        {
            pag++;
            
            if(!anterior.Enabled)
            {
                anterior.Enabled = true;
            }

            if(pag == 3)
            {
                siguiente.Enabled = false;
            }
            else
            {
                siguiente.Enabled = true;

            }

            Asigar_etiquetas(pag);

            return pag;
        }

        public short Anterior_pag(short pag, Button anterior, Button siguiente)
        {
            pag--;

            if(!siguiente.Enabled)
            {
                siguiente.Enabled = true;
            }

            if(pag == 1)
            {
                anterior.Enabled = false;
            }
            else
            {
                anterior.Enabled = true;
            }

            Asigar_etiquetas(pag);

            return pag;
        }

        private void Asigar_etiquetas(short pagina)
        {
            short i;

            string[] actuales = (string[])lista[pagina - 1];

            var lista_objs_lbl = formaajuste.Controls.OfType<Label>().Where(label => label.Name.Contains("lbl_")).ToList();
            var lista_objs_txtb = formaajuste.Controls.OfType<TextBox>().ToList();

            for (i = 0; i < actuales.Length; i++)
            {
                if (!lista_objs_lbl[i].Visible)
                {
                    lista_objs_lbl[i].Visible = true;
                    lista_objs_txtb[i].Visible = true;
                }
                var elegido = lista_objs_lbl.Where(label => label.Name.Contains("lbl_" + i)).ToList();
                elegido[0].Text = actuales[i];
            }

            if(i < lista_objs_lbl.Count)
            {
                for (short k = i; k < lista_objs_lbl.Count; k++)
                {
                    var elegido = lista_objs_lbl.Where(label => label.Name.Contains("lbl_" + k)).ToList();
                    elegido[0].Visible = false;

                    var elegido_txtb = lista_objs_txtb.Where(label => label.Name.Contains("txtb_" + k)).ToList();
                    elegido_txtb[0].Visible = false;
                }
            }    
        }

        public ArrayList GETEtiquetas()
        {
            ArrayList lista = new();

            lista.Add(etiquetas);
            lista.Add(etiquetas2);
            lista.Add(etiquetas3);

            return lista;
        }
    }
}
