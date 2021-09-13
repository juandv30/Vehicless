using System;
using System.ComponentModel.DataAnnotations;

namespace Vehicless.API.Data.Entities
{
    public class VehiclePhoto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public Vehicle Vehicle { get; set; }

        [Display(Name = "Foto")]
        public Guid ImageId { get; set; }

        [Display(Name = "Foto")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://localhost:44348/images/noimage.png"
            : $"https://vehiclesjuanes.blob.core.windows.net/vehicles/{ImageId}";
    }
}
