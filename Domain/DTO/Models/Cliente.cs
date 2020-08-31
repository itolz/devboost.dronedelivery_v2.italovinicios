using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace devboost.dronedelivery.felipe.DTO.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome deve ser informado!")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "O nome deve conter entre 10 e 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Latitude deve ser informada!")]
        public double Latitude { get; set; }

        [Required(ErrorMessage = "Longitude deve ser informada!")]
        public double Longitude { get; set; }

        public List<Pedido> Pedidos { get; set; }
    }
}
