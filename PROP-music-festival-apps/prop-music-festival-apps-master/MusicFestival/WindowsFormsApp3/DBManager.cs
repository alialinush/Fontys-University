using Common;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOverview
{
    class DBManager
    {
        private static MySqlConnection connection = new MySqlConnection(DatabaseUtils.GetConnectionString());
        
        /**
         * Returns count of checked in ppl
         */
        public static int GetTotalCheckedIn(int eventid)
        {
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT COUNT(UserId) AS totalcheckedin FROM user_ WHERE Status_ = 'Yes'", connection);

            MySqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
            }
            catch (Exception) { }

            int totalcheckedin = 0;
            if (reader != null)
            {
                while (reader.Read())
                {

                    totalcheckedin = Convert.ToInt32(reader["totalcheckedin"]);
                    
                }
            }

            connection.Close();

            return totalcheckedin;
        }
        public static int GetTotalVisitors(int eventid)
        {
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT COUNT(UserId) AS totalvisitors FROM user_", connection);

            MySqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
            }
            catch (Exception) { }

            int totalvisitors = 0;
            if (reader != null)
            {
                while (reader.Read())
                {

                    totalvisitors = Convert.ToInt32(reader["totalvisitors"]);

                }
            }

            connection.Close();

            return totalvisitors;
        }

        public static int GetTotalCampersCheckedornot(int eventid)
        {
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT SUM(Capacity) AS totalcamperscheckedornot FROM campingspot", connection);

            MySqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
            }
            catch (Exception) { }

            int totalcamperscheckedornot = 0;
            if (reader != null)
            {
                while (reader.Read())
                {

                    totalcamperscheckedornot = Convert.ToInt32(reader["totalcamperscheckedornot"]);

                }
            }

            connection.Close();

            return totalcamperscheckedornot;
        }
        public static int GetTotalCampers(int eventid)
        {
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT SUM(Capacity) AS totalcampers FROM campingspot WHERE Availability = 'R", connection);

            MySqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
            }
            catch (Exception) { }

            int totalcampers = 0;
            if (reader != null)
            {
                while (reader.Read())
                {

                    totalcampers = Convert.ToInt32(reader["totalcampers"]);

                }
            }

            connection.Close();

            return totalcampers;
        }
        public static int GetCountUnreservedSpots(int eventid)
        {
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT SUM(Capacity) AS totalfreespots FROM campingspot WHERE Availability = 'A", connection);

            MySqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
            }
            catch (Exception) { }

            int totalfreespots = 0;
            if (reader != null)
            {
                while (reader.Read())
                {

                    totalfreespots = Convert.ToInt32(reader["totalcampers"]);

                }
            }

            connection.Close();

            return totalfreespots;
        }
        public static int GetTotalRevCamping(int eventid)
        {
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT SUM(Price) AS totalrevcamping FROM campingspot WHERE Availability = 'R", connection);

            MySqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
            }
            catch (Exception) { }

            int totalrevcamping = 0;
            if (reader != null)
            {
                while (reader.Read())
                {

                    totalrevcamping = Convert.ToInt32(reader["totalrevcamping"]);

                }
            }

            connection.Close();

            return totalrevcamping;
        }

        //NEEDS EDITING FOR TICKET PRICE SHIT THIS IS TEMPORARY
        public static int GetTotalRevTickets(int eventid)
        {
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT COUNT(Id)*50 AS totalrevcamping FROM ticket ", connection);

            MySqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
            }
            catch (Exception) { }

            int totalrevcamping = 0;
            if (reader != null)
            {
                while (reader.Read())
                {

                    totalrevcamping = Convert.ToInt32(reader["totalrevcamping"]);

                }
            }

            connection.Close();

            return totalrevcamping;
        }
        public static int GetTotalDepositMoney(int eventid)
        {
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT SUM(Pay) AS totaldepositmoney FROM borrow_activity", connection);

            MySqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
            }
            catch (Exception) { }

            int totaldepositmoney = 0;
            if (reader != null)
            {
                while (reader.Read())
                {

                    totaldepositmoney = Convert.ToInt32(reader["totaldepositmoney"]);

                }
            }

            connection.Close();

            return totaldepositmoney;
        }
        public static int GetTotalFoodRevenue(int eventid)
        {
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT SUM(Pay) AS totalfoodrevenue FROM order_activity", connection);

            MySqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
            }
            catch (Exception) { }

            int totalfoodrevenue = 0;
            if (reader != null)
            {
                while (reader.Read())
                {

                    totalfoodrevenue = Convert.ToInt32(reader["totalfoodrevenue"]);

                }
            }

            connection.Close();

            return totalfoodrevenue;
        }

        public static int GetTotalNotCheckedIn(int eventid)
        {
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT COUNT(UserId) AS totalnotcheckedin FROM user_ WHERE Status_ = 'No'", connection);

            MySqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
            }
            catch (Exception) { }

            int totalnotcheckedin = 0;
            if (reader != null)
            {
                while (reader.Read())
                {

                    totalnotcheckedin = Convert.ToInt32(reader["totalnotcheckedin"]);

                }
            }

            connection.Close();

            return totalnotcheckedin;
        }
        public static getinfo GetInfo(int userId)
        {
            connection.Open();
            
            MySqlCommand command = new MySqlCommand("SELECT FirstName, LastName, UserId, Email, Address, Balance, Status_, Role FROM user_ WHERE UserId = " + userId, connection);
            MySqlDataReader reader = null;
            
            try
            {
                reader = command.ExecuteReader();
            }
            catch (Exception) { }

            getinfo getInfo = null;
            if (reader != null)
            {
                while (reader.Read())
                {
                    int userid = Convert.ToInt32(reader["UserId"]);
                    string email = Convert.ToString(reader["Email"]);
                    string firstname = Convert.ToString(reader["FirstName"]);
                    string lastname = Convert.ToString(reader["LastName"]);
                    string address = Convert.ToString(reader["Address"]);
                    double balance = Convert.ToDouble(reader["Balance"]);
                    string status = Convert.ToString(reader["Status_"]);
                    string role = Convert.ToString(reader["Role"]);
                    getInfo = new getinfo(firstname, lastname, userid, email, address, balance, status, role);
                }
            }

            connection.Close();

            return getInfo;

        }
        //public static int GetInfo(int eventid, int lookforid) { return ; }
        //{
        //    connection.Open();

        //    MySqlCommand command = new MySqlCommand("SELECT COUNT(UserId) AS totalcheckedin FROM user_ WHERE Status_ = 'Yes'", connection);

        //    MySqlDataReader reader = null;
        //    try
        //    {
        //        reader = command.ExecuteReader();
        //    }
        //    catch (Exception) { }

        //    int totalcheckedin = 0;
        //    if (reader != null)
        //    {
        //        while (reader.Read())
        //        {

        //            totalcheckedin = Convert.ToInt32(reader["totalcheckedin"]);

        //        }
        //    }

        //    connection.Close();

        //    return totalcheckedin;
        //}
        public static List<peoplecheckedin> GetPeopleCheckedIn(int eventid, string firstname, string lastname)
        {
            connection.Open();
            List<peoplecheckedin> peopleCheckedin = new List<peoplecheckedin>();
            MySqlCommand command = new MySqlCommand("SELECT FirstName, LastName FROM user_ WHERE Status_ = 'Yes'", connection);

            MySqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
            }
            catch (Exception) { }

            firstname="";
            lastname = "";
            if (reader != null)
            {
                while (reader.Read())
                {
                    firstname = Convert.ToString(reader["firstname"]);
                    lastname = Convert.ToString(reader["lastname"]);

                    peopleCheckedin.Add(new peoplecheckedin(firstname, lastname));
                }
            }

            connection.Close();

            return peopleCheckedin;
        }
        public static List<peoplenotcheckedin> GetPeopleNotCheckedIn(int eventid, string firstname, string lastname)
        {
            connection.Open();
            List<peoplenotcheckedin> peopleNotCheckedin = new List<peoplenotcheckedin>();
            MySqlCommand command = new MySqlCommand("SELECT FirstName, LastName FROM user_ WHERE Status_ = 'No'", connection);

            MySqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
            }
            catch (Exception) { }

            firstname = "";
            lastname = "";
            if (reader != null)
            {
                while (reader.Read())
                {
                    firstname = Convert.ToString(reader["firstname"]);
                    lastname = Convert.ToString(reader["lastname"]);

                    peopleNotCheckedin.Add(new peoplenotcheckedin(firstname, lastname));
                }
            }

            connection.Close();

            return peopleNotCheckedin;
        }
        public static List<ReservedSpots> GetReservedSpots(int eventid, int id)
        {
            connection.Open();
            List<ReservedSpots> reservedspots = new List<ReservedSpots>();
            MySqlCommand command = new MySqlCommand("SELECT Id FROM campingspot WHERE Availability = 'R'", connection);

            MySqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
            }
            catch (Exception) { }

            id=0;
            
            if (reader != null)
            {
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);

                    reservedspots.Add(new ReservedSpots(id));
                    
                }
            }

            connection.Close();

            return reservedspots;
        }
        public static List<UnReservedSpots> GetUnReservedSpots(int eventid, int id)
        {
            connection.Open();
            List<UnReservedSpots> unreservedspots = new List<UnReservedSpots>();
            MySqlCommand command = new MySqlCommand("SELECT Id FROM campingspot WHERE Availability = 'A'", connection);

            MySqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
            }
            catch (Exception) { }

            id=0;
            if (reader != null)
            {
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);

                    unreservedspots.Add(new UnReservedSpots(id));

                }
            }

            connection.Close();

            return unreservedspots;
        }
        //
        //public static Visitor GetVisitorByRfid(string rfidNumber)
        //{
        //    connection.Open();

        //    MySqlCommand command = new MySqlCommand("SELECT COUNT(UserId) FROM user_ ", connection);

        //    MySqlDataReader reader = null;
        //    try
        //    {
        //        reader = command.ExecuteReader();
        //    }
        //    catch (Exception) { }

        //    Visitor visitor = null;
        //    if (reader != null)
        //    {
        //        while (reader.Read())
        //        {

        //            int userid = Convert.ToInt32(reader["UserId"]);

        //        }
        //    }

        //    connection.Close();

        //    return visitor;
        //}
        ///**
        // * Returns all available camping spots for a specific event
        // */
        //public static List<CampingSpot> GetAvailableCampingSpots(int eventId)
        //{
        //    connection.Open();

        //    MySqlCommand command = new MySqlCommand("SELECT Id, Capacity, Availability, Price FROM CampingSpot WHERE Availability = 'A' AND EventId=" + eventId, connection);
        //    MySqlDataReader reader = command.ExecuteReader();

        //    List<CampingSpot> campingSpots = new List<CampingSpot>();

        //    while (reader.Read())
        //    {
        //        int id = Convert.ToInt32(reader["Id"]);
        //        int capacity = Convert.ToInt32(reader["Capacity"]);
        //        string availability = Convert.ToString(reader["Availability"]);
        //        double price = Convert.ToDouble(reader["Price"]);

        //        campingSpots.Add(new CampingSpot(id, eventId, capacity, availability, price));
        //    }
        //    connection.Close();

        //    return campingSpots;
        //}

        ///**
        // * Returns user booking for a certain event
        // */
        //public static UserBooking GetUserBookingForEvent(int userId, int eventId)
        //{
        //    connection.Open();

        //    MySqlCommand command = new MySqlCommand("SELECT Id FROM UserBooking WHERE UserId =" + userId.ToString() + " AND EventId = " + eventId.ToString(), connection);
        //    MySqlDataReader reader = command.ExecuteReader();

        //    UserBooking userBooking = null;

        //    while (reader.Read())
        //    {
        //        int id = Convert.ToInt32(reader["Id"]);

        //        userBooking = new UserBooking(id, userId, eventId);
        //    }
        //    connection.Close();

        //    return userBooking;
        //}

        ///**
        // * Returns booked camping spot for specific event user booking
        // */
        //public static CampingSpot GetCampingSpotForBooking(int userId, int eventId)
        //{
        //    CampingSpot campingSpot = null;
        //    UserBooking userBooking = GetUserBookingForEvent(userId, eventId);

        //    connection.Open();

        //    MySqlCommand command = new MySqlCommand("SELECT CampingSpot.Id, CampingSpot.Capacity, CampingSpot.Availability, CampingSpot.Price FROM CampingSpot " +
        //        "INNER JOIN CampingSpotTicket ON CampingSpotTicket.CampingSpotId = CampingSpot.Id " +
        //        "WHERE CampingSpotTicket.UserBookingId = " + userBooking.Id, connection);

        //    MySqlDataReader reader = command.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        int id = Convert.ToInt32(reader["Id"]);
        //        int capacity = Convert.ToInt32(reader["Capacity"]);
        //        string availability = Convert.ToString(reader["Availability"]);
        //        double price = Convert.ToDouble(reader["Price"]);

        //        campingSpot = new CampingSpot(id, eventId, capacity, availability, price);
        //    }
        //    connection.Close();

        //    return campingSpot;
        //}

        ///**
        // * Books a camping spot for specific event
        // */
        //public static void BookCampingSpot(int userId, int eventId, int campingSpotId, int ticektNumber)
        //{
        //    UserBooking userBooking = GetUserBookingForEvent(userId, eventId);

        //    MySqlCommand command = new MySqlCommand("INSERT INTO CampingSpotTicket(UserBookingId, TicketId, CampingSpotId) " +
        //        "VALUES(" + userBooking.Id + "," + ticektNumber + "," + campingSpotId + ")", connection);

        //    connection.Open();
        //    command.ExecuteReader();
        //    connection.Close();

        //    UpdateCampingSpotStatus(campingSpotId);
        //}

        ///**
        // * Updating the status of a certain camping spot from available ("A") to reserved ("R")
        // */
        //public static void UpdateCampingSpotStatus(int campingSpotId)
        //{
        //    MySqlCommand command = new MySqlCommand("UPDATE CampingSpot SET Availability = 'R' WHERE Id = " + campingSpotId, connection);

        //    connection.Open();
        //    command.ExecuteReader();
        //    connection.Close();
        //}

        ///**
        // * Returns all the tickets assigned to the booked camping spot
        // */
        //public static List<CampingSpotTicket> GetAllCampingSpotAssigneesForBooking(int userId, int eventId)
        //{
        //    List<CampingSpotTicket> campingSpotTickets = new List<CampingSpotTicket>();

        //    UserBooking userBooking = GetUserBookingForEvent(userId, eventId);

        //    MySqlCommand command = new MySqlCommand("SELECT CampingSpotTicket.CampingSpotId, Ticket.Id as TicketNumber, Ticket.Email FROM CampingSpotTicket " +
        //        "INNER JOIN Ticket ON Ticket.Id = CampingSpotTicket.TicketId " +
        //        "WHERE CampingSpotTicket.UserBookingId= " + userBooking.Id, connection);

        //    connection.Open();
        //    MySqlDataReader reader = command.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        int campingSpotId = Convert.ToInt32(reader["CampingSpotId"]);
        //        int ticektNumber = Convert.ToInt32(reader["TicketNumber"]);
        //        string owner = Convert.ToString(reader["Email"]);

        //        campingSpotTickets.Add(new CampingSpotTicket(campingSpotId, ticektNumber, owner));
        //    }

        //    connection.Close();

        //    return campingSpotTickets;
        //}

        ///**
        // * Updates the visitor balance after a purchase
        // */
        //public static void UpdateVisitorBalance(int userId, double newBalance)
        //{
        //    MySqlCommand command = new MySqlCommand("UPDATE User_ SET Balance = " + newBalance.ToString() + " WHERE UserId = " + userId, connection);

        //    connection.Open();
        //    command.ExecuteReader();
        //    connection.Close();
        //}
    }
}
