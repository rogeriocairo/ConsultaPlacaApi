using System.ComponentModel.DataAnnotations.Schema;

namespace ConsultaPlacaMvc.Models
{
    public class VeiculosConsulta : EntidadeBase
    {
        [Column(TypeName = "varchar(8)")]
        public string Placa { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string Proprietario { get; set; }

        [Column(TypeName = "bit")]
        public bool VeiculoRoubado { get; set; }

        [Column(TypeName = "int")]
        public int AnoFabricacao { get; set; }

        [Column(TypeName = "int")]
        public int AnoModelo { get; set; }
    }
}

