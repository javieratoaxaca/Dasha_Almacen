using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dasha_Almancen.Presentacion
{
    public class P_Articulos
    {
        public int Codigo_Ar {  get; set; }
        public string Descripcion_Ar { get; set; }
        public string Marca_Ar {  get; set; }
        public int Codigo_Um {  get; set; }
        public int Codigo_Ca {  get; set; }
        public decimal Stock_Actual {  get; set; }
        public string Fecha_crea { get; set; }
        public string Fecha_Modifica { get; set; }
        public int Estado {  get; set; }
    }
}
