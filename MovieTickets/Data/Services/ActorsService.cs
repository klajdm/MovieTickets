using Microsoft.EntityFrameworkCore;
using MovieTickets.Data.Base;
using MovieTickets.Models;

namespace MovieTickets.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}
