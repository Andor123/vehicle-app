using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesContacts.Data 
{
    public class Vehicles 
    {
        public int VehicleId { get; set; }

        [Required, StringLength(45)]
        public string RegistrationNumber { get; set; }

        [Required, StringLength(45)]
        public string PrivateCode { get; set; }

        [Required, StringLength(45)]
        public string TypeOfVehicle { get; set; }

        public DateTime DateStamp { get; set; }
    }
}