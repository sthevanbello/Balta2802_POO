using System;
using System.Threading.Channels;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {

            var room = new Room(3);
            room.RoomSoldOutEvent += OnRoomSouldOut;
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();


            Console.ReadKey();
        }

        static void OnRoomSouldOut(object sender, EventArgs e)
        {
            Console.WriteLine("Room is full");

        }
    }
}
