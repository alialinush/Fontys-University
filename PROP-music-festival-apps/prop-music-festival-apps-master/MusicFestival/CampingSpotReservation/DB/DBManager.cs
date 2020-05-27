using CampingSpotReservation.DB;
using Common;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampingSpotReservation
{
    class DBManager
    {
        private static MySqlConnection connection = new MySqlConnection(DatabaseUtils.GetConnectionString());

        /**
         * Returns a visitor based on his/her rfid number
         */
        public static Visitor GetVisitorByRfid(string rfidNumber)
        {
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT UserId,FirstName,LastName,Address,Balance,Status_,Role,Ticket.Id as TicketNumber FROM User_ " +
                "INNER JOIN Ticket ON User_.Email = Ticket.Email WHERE Ticket.RfidNumber= " + rfidNumber, connection);

            MySqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
            } catch(Exception) {
            }
           
            Visitor visitor = null;
            if(reader != null)
            {
                while (reader.Read())
                {
                    int userid = Convert.ToInt32(reader["UserId"]);
                    string firstname = Convert.ToString(reader["FirstName"]);
                    string lastname = Convert.ToString(reader["LastName"]);
                    string address = Convert.ToString(reader["Address"]);
                    double balance = Convert.ToDouble(reader["Balance"]);
                    string status = Convert.ToString(reader["Status_"]);
                    string role = Convert.ToString(reader["Role"]);
                    int ticketNumber = Convert.ToInt32(reader["TicketNumber"]);

                    visitor = new Visitor(userid, firstname, lastname, address, balance, status, role, ticketNumber);

                }
            }
            
            connection.Close();

            return visitor;
        }

        /**
         * Returns all available camping spots for a specific event
         */
        public static List<CampingSpot> GetAvailableCampingSpots(int eventId)
        {
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT Id, Capacity, Availability, Price FROM CampingSpot WHERE Availability = 'A' AND EventId=" + eventId, connection);
            MySqlDataReader reader = command.ExecuteReader();

            List<CampingSpot> campingSpots = new List<CampingSpot>();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                int capacity = Convert.ToInt32(reader["Capacity"]);
                string availability = Convert.ToString(reader["Availability"]);
                double price = Convert.ToDouble(reader["Price"]);

                campingSpots.Add(new CampingSpot(id, eventId, capacity, availability, price));
            }
            connection.Close();

            return campingSpots;
        }

        /**
         * Returns user booking for a certain event
         */
        public static UserBooking GetUserBookingForEvent(int userId, int eventId)
        {
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT Id FROM UserBooking WHERE UserId =" + userId.ToString() + " AND EventId = " + eventId.ToString(), connection);
            MySqlDataReader reader = command.ExecuteReader();

            UserBooking userBooking = null;

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);

                userBooking = new UserBooking(id, userId, eventId);
            }
            connection.Close();

            return userBooking;
        }

        /**
         * Returns booked camping spot for specific event user booking
         */
        public static CampingSpot GetCampingSpotForBooking(int userId, int eventId)
        {
            CampingSpot campingSpot = null;
            UserBooking userBooking = GetUserBookingForEvent(userId, eventId);

            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT CampingSpot.Id, CampingSpot.Capacity, CampingSpot.Availability, CampingSpot.Price FROM CampingSpot " +
                "INNER JOIN CampingSpotTicket ON CampingSpotTicket.CampingSpotId = CampingSpot.Id " +
                "WHERE CampingSpotTicket.UserBookingId = " + userBooking.Id , connection);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                int capacity = Convert.ToInt32(reader["Capacity"]);
                string availability = Convert.ToString(reader["Availability"]);
                double price = Convert.ToDouble(reader["Price"]);

                campingSpot = new CampingSpot(id, eventId, capacity, availability, price);
            }
            connection.Close();

            return campingSpot;
        }

        /**
         * Books a camping spot for specific event
         */
        public static void BookCampingSpot(int userId, int eventId, int campingSpotId, int ticektNumber)
        {
            UserBooking userBooking = GetUserBookingForEvent(userId, eventId);

            MySqlCommand command = new MySqlCommand("INSERT INTO CampingSpotTicket(UserBookingId, TicketId, CampingSpotId) " +
                "VALUES(" + userBooking.Id + "," + ticektNumber + "," + campingSpotId + ")", connection);

            connection.Open();
            command.ExecuteReader();
            connection.Close();

            UpdateCampingSpotStatus(campingSpotId);
        }

        /**
         * Updating the status of a certain camping spot from available ("A") to reserved ("R")
         */
        public static void UpdateCampingSpotStatus(int campingSpotId)
        {
            MySqlCommand command = new MySqlCommand("UPDATE CampingSpot SET Availability = 'R' WHERE Id = " + campingSpotId , connection);

            connection.Open();
            command.ExecuteReader();
            connection.Close();
        }

        /**
         * Returns all the tickets assigned to the booked camping spot
         */
        public static List<CampingSpotTicket> GetAllCampingSpotAssigneesForBooking(int userId, int eventId)
        {
            List<CampingSpotTicket> campingSpotTickets = new List<CampingSpotTicket>();

            UserBooking userBooking = GetUserBookingForEvent(userId, eventId);

            MySqlCommand command = new MySqlCommand("SELECT CampingSpotTicket.CampingSpotId, Ticket.Id as TicketNumber, Ticket.Email FROM CampingSpotTicket " +
                "INNER JOIN Ticket ON Ticket.Id = CampingSpotTicket.TicketId " +
                "WHERE CampingSpotTicket.UserBookingId= " + userBooking.Id, connection);

            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int campingSpotId = Convert.ToInt32(reader["CampingSpotId"]);
                int ticektNumber = Convert.ToInt32(reader["TicketNumber"]);
                string owner = Convert.ToString(reader["Email"]);

                campingSpotTickets.Add( new CampingSpotTicket(campingSpotId, ticektNumber, owner));
            }

            connection.Close();

            return campingSpotTickets;
        }

        /**
         * Updates the visitor balance after a purchase
         */
        public static void UpdateVisitorBalance(int userId, double newBalance)
        {
            MySqlCommand command = new MySqlCommand("UPDATE User_ SET Balance = " + newBalance.ToString() + " WHERE UserId = " + userId, connection);

            connection.Open();
            command.ExecuteReader();
            connection.Close();
        }
    }
}
