using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments
{
    public class Room
    {
        public int Seats { get; set; }
        private int seatsInUse;

        public Room(int seats)
        {
            Seats = seats;
            seatsInUse = 0;
        }

        public void ReserveSeat()
        {
            seatsInUse++;

            if (seatsInUse >= Seats)
            {
                OnRoomSoldOut(EventArgs.Empty);
            }
            else
            {
                Console.WriteLine("Seat reserved");
            }
        }

        public event EventHandler RoomSoldOutEvent;


        protected virtual void OnRoomSoldOut(EventArgs e)
        {
            EventHandler handler = RoomSoldOutEvent;
            handler?.Invoke(this, e);
        }

        public static void OnRoomSouldOut(object sender, EventArgs e)
        {
            Console.WriteLine("Room is full");

        }
    }
}
