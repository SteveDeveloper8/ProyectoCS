using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Expediente
    {
        private int codigo;
        private List<string> historialDelictivo;
        private List<Cargo> cargos;

        public Expediente(int codigo, List<string> historialDelictivo, List<Cargo> cargos)
        {
            this.codigo = codigo;
            this.historialDelictivo = historialDelictivo;
            this.cargos = cargos;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public List<string> HistorialDelictivo { get => historialDelictivo; set => historialDelictivo = value; }
        public List<Cargo> Cargos { get => cargos; set => cargos = value; }
    }
}
