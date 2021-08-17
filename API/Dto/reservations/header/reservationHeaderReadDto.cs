using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using API.Models;
using API.Models.reservation;
namespace API.Dto.reservations.header
{
    public class reservationHeaderReadDto
    {
        public Guid _id { get; set; }
        public Customer Customer { get; set; }
        public ReservationType reservationType { get; set; }
        public User user { get; set; }
        public DateTime createdDate { get; set; }
    }
}