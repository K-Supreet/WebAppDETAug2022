using System.Xml.Linq;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Services
{
    public class TicketServices
    {
        static List<Ticket> Tickets { get; }
        static int nextId = 3;
        static TicketServices()
        {
            Tickets = new List<Ticket>
                {
                    new Ticket { Id=1,Category="PlatinumPlus",Price=5000,MaxLimit=200000},
                    new Ticket { Id=2,Category="Platinum",Price=4000,MaxLimit=300000 },
                    new Ticket { Id=3,Category="Gold",Price=3000,MaxLimit=500000 },
                    new Ticket { Id=4,Category="Silver",Price=2000,MaxLimit=500000 },
                    new Ticket { Id=5,Category="General",Price=8000,MaxLimit=100000 },
                };
        }
        public static List<Ticket> GetAll() => Tickets;

        // public static Tickets? Get(int id) => Ticket.FirstOrDefault(p => p.Id == id);

        public static void Add(Ticket Ticket)
        {
            Tickets.Add(Ticket);
        }

        //public static void Delete(int id)
        //{
        //    var Tickets = Get(id);
        //    if (Tickets is null)
        //        return;

        //    Ticket.Remove(Tickets);
        //}

        private static object Get(int id)
        {
            throw new NotImplementedException();
        }

        //public static void Update(Tickets Tickets)
        //{
        //    var index = Ticket.FindIndex(p => p.Id == Tickets.Id);
        //    if (index == -1)
        //        return;

        //    Ticket[index] = Tickets;
        //}
    }
}




