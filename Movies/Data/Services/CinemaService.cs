using Movies.Data.Base;
using Movies.Models;

namespace Movies.Data.Services
{
    public class CinemaService:EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemaService(AppDbContext context) : base(context)
        {

        }
    }
}
