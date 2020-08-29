using devboost.dronedelivery.felipe.DTO.Models;

namespace devboost.dronedelivery.felipe.DTO.Extensions
{
    public static class PedidoExtensions
    {
        public static Point GetPoint(this Cliente cliente)
        {
            return new Point(cliente.Latitude, cliente.Longitude);
        }
    }
}
