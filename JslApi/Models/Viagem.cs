using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace JslApi.Models
{
    public class Viagem
    {
        public int Id { get; set; }

        [Column(TypeName = "NUMERIC(9,4)"),
            DefaultValue(0)]
        public double PesoCarga { get; set; }

        [Column(TypeName = "TIMESTAMP WITHOUT TIME ZONE"),
            DataType(DataType.DateTime)]
        public DateTime DtHrViagem { get; set; }

        [StringLength(50)]
        public string? LocalEntrega { get; set; }

        [StringLength(50)]
        public string? LocalSaida { get; set; }

        [Column(TypeName = "NUMERIC(10,4)"),
            DefaultValue(0),
            Required]
        public double TotalKm { get; set; }

        [JsonIgnore]
        public Motorista? Motorista { get; set; }
        public long MotoristaId { get; set; }

    }
}
