using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Models.reservation;

namespace API.Contracts.pages.reservation
{
    public interface IReservationHeaderRepository : IRepositoryBase<ReservationHeader>
    {
        Task<List<ReservationHeader>> GetHeaderByCustomerID(Guid customerId);
    }
}