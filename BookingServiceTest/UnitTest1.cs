using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BookingServiceTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void ViewHotelTest()
        {

            using (var db = new BookingService.AppContext())
            {
                Console.WriteLine("All hotel in database:");
                foreach (var hotel in db.Hotel)
                {
                    Console.WriteLine(" - {0}", hotel.Id);
                    Console.WriteLine(" - {0}", hotel.HotelName);
                    Console.WriteLine(" - {0}", hotel.RoomType);
                    Console.WriteLine(" - {0}", hotel.GuestNum);
                    Console.WriteLine(" - {0}", hotel.Booked);
                    Console.WriteLine(" - {0}", hotel.CreatedAt);
                }
            }
        }

        [TestMethod]
        public void CreateHotelTest()
        {
            using (var db = new BookingService.AppContext())
            {
                db.Hotel.Add(new BookingService.Hotel { HotelName = "G Hotel Hotel", RoomType = "Family Suite", GuestNum = 4, Booked = false });
                var count = db.SaveChanges();

                Console.WriteLine("Hotel inserted is updated in database");
                foreach (var hotel in db.Hotel)
                {
                    Console.WriteLine(" - {0}", hotel.HotelName);
                }
            }
        }

        [TestMethod]
        public void CreateFlightTest()
        {
            using (var db = new BookingService.AppContext())
            {
                db.Flight.Add(new BookingService.Flight { Airlines = "Malaysia Airlines", Class = "Business Class", TripType = "", Booked = false });
                var count = db.SaveChanges();

                Console.WriteLine("Flight inserted is updated in database");
                foreach (var flight in db.Flight)
                {
                    Console.WriteLine(" - {0}", flight.Airlines);
                }
            }
        }
    }
}
