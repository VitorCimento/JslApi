using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace JslApi.Models
{
    public class Motorista
    {
        public long Id { get; set; }
        
        [StringLength(60),
            Required]
        public string? Nome { get; set; }

        [StringLength(60),
            Required]
        public string? Sobrenome { get; set; }

        [StringLength(25),
            Required]
        public string? CaminhaoMarca { get; set; }

        [StringLength(25),
            Required]
        public string? CaminhaoModelo { get; set; }

        [StringLength(7),
            Required]
        public string? CaminhaoPlaca { get; set; }

        [Required]
        public int CaminhaoEixos { get; set; }

        [StringLength(50),
            Required]
        public string? EndLogradouro { get; set; }

        [StringLength(10),
            Required]
        public string? EndNumero { get; set; }

        [StringLength(50),
            Required]
        public string? EndBairro { get; set; }

        [StringLength(50),
            Required]
        public string? EndCidade { get; set; }

        [StringLength(9),
            Required]
        public string? EndCep { get; set; }

        [StringLength(2),
            Required]
        public string? EndUf { get; set; }

        [JsonIgnore]
        public List<Viagem>? Viagens { get; set; }

    }
}
