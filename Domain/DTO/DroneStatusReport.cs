using devboost.dronedelivery.felipe.DTO.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace devboost.dronedelivery.felipe.DTO
{
    public class DroneStatusReport
    {
        public int DroneId { get; set; }
        public bool Situacao { get; set; }

        public Pedido Pedido { get; set; }
    }
}
