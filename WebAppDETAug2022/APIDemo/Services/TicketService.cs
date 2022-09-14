using APIDemo.Models;

namespace APIDemo.Services
{
    public class TicketService
    {
        static List<Ticket> Tickets { get; }
        static TicketService()
        {
            Tickets = new List<Ticket>
                {
                    new Ticket {  Id = 1, BookedFor="Movie 1",Price=200,Qty=2},
                    new Ticket {  Id = 2, BookedFor="Movie 2", Price=300,Qty=3},
                    new Ticket {  Id = 3, BookedFor="Movie 3", Price=350,Qty=5}
                };
        }
        public static List<Ticket> GetAll() => Tickets;

        public static Ticket Get(int id)
        {
            Ticket ticket = Tickets.FirstOrDefault(p => p.Id == id);
            return ticket;
        }
    }
}