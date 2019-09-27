using System;
using System.Collections.Generic;

namespace BookingService
{
    public class Program
    {
        public static string ViewHotelList()
        {
            using (var db = new BookingService.AppContext())
            {
                Console.WriteLine("All hotel in database:");
                foreach (var hotel in db.Hotel)
                {
                    Console.WriteLine("ID:           {0}", hotel.Id);
                    Console.WriteLine("Hotel Name:   {0}", hotel.HotelName);
                    Console.WriteLine("Room Type:    {0}", hotel.RoomType);
                    Console.WriteLine("Guest number: {0}", hotel.GuestNum);
                    Console.WriteLine("Booked?:      {0}", hotel.Booked);
                    Console.WriteLine("Created at:   {0}", hotel.CreatedAt);
                    Console.WriteLine("---------------------------------------------");
                }
            }
            return ("Error occured. No data return");
        }

        public static string ViewFlightList()
        {
            using (var db = new BookingService.AppContext())
            {
                Console.WriteLine("All flight in database:");
                foreach (var flight in db.Flight)
                {
                    Console.WriteLine("ID:                   {0}", flight.Id);
                    Console.WriteLine("Airlines:             {0}", flight.Airlines);
                    Console.WriteLine("Class:                {0}", flight.Class);
                    Console.WriteLine("Trip(One way/Return): {0}", flight.TripType);
                    Console.WriteLine("Guest number:         {0}", flight.GuestNum);
                    Console.WriteLine("Booked?:              {0}", flight.Booked);
                    Console.WriteLine("Created at:           {0}", flight.CreatedAt);
                    Console.WriteLine("---------------------------------------------");
                }
            }
            return ("Error occured. No data return");
        }

        public static string bookHotel()
        {
            Console.WriteLine("Please enter the hotel id that you want to make booking/checkout.");
            string value = Console.ReadLine();
            int hotelId = Convert.ToInt32(value);
            using(var db = new BookingService.AppContext())
            {
                var hotel = db.Hotel.Find(hotelId);
                var original = hotel.Booked;

                if(hotel.Booked == false)
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Room  {0}", hotel.HotelName, " {1} booked successfully");
                }
                else
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Room {0}", hotel.HotelName, " {1} checkout");
                }

                hotel.Booked = !hotel.Booked;
                db.SaveChanges();
            }
            return ("something");
        }

        public static string bookFlight()
        {
            Console.WriteLine("Please enter the flight id that you want to make booking.");
            string value = Console.ReadLine();
            int flightId = Convert.ToInt32(value);
            using (var db = new BookingService.AppContext())
            {
                var flight = db.Flight.Find(flightId);
                var original = flight.Booked;

                if (flight.Booked == false)
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Flight {0}", flight.Airlines, "booked successfully");
                }
                else
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Flight checkout");
                }

                flight.Booked = !flight.Booked;
                db.SaveChanges();
            }
            return ("something");
        }

        public static void Main(string[] args)
        {
            bool status = true;
            while (status)
            {
                Console.WriteLine("Welcome to the Booking Service!");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Choose an option: ");
                Console.WriteLine("\t1 - View hotel list.");
                Console.WriteLine("\t2 - View flight list.");
                Console.WriteLine("\t3 - Book hotel room.");
                Console.WriteLine("\t4 - Book flight.");
                Console.WriteLine("\t5 - Exit.");
                Console.WriteLine("Select an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("View hotel list.");
                        ViewHotelList();
                        break;
                    case "2":
                        Console.WriteLine("View flight list.");
                        ViewFlightList();
                        break;
                    case "3":
                        Console.WriteLine("Book hotel room.");
                        bookHotel();
                        break;
                    case "4":
                        Console.WriteLine("Book flight.");
                        bookFlight();
                        break;
                    case "5":
                        Console.WriteLine("Goodbye!");
                        status = false;
                        break;
                    default:
                        Console.WriteLine("Please insert a valid number!");
                        break;
                }
            }
        }
    }
}
