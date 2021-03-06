﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Globalization;
using System.Data;
using System.IO;

namespace Database
{
    public interface IDatabase
    {
        void CreateModelName(string ModelName1);

        void CreateMachine(string DemoNumber, string ModelName, string ModelNumber, string Brand, string CNumber,
                    string MastType, int MastBuildingHeight, int MastLiftHeight, int MastFreeLift, string AggregatType,
                    string AggregatNumber, string BatteryType, string BatteryNumber, string ChargerType, string ChargerNumber,
                    string Controller, decimal Weight, decimal Height, decimal Length, decimal Width, List<string> configurationsList);

        void CreateCustomer(string Name1, string Name2, string Att, string Address, int ZIP, string City, string Country, int Phone);

        void CreateCustomerID();

        void CreateBooking(string salesRep, string date1, string date2, string Transporter, string MessageForWorkshop, string DeliveryNote,
                    int Ramp);

        void CreateBookingID();

        void CreateBookingLine(List<string> Machine, string Konfig);

        List<string> DropDownDemo();

        int GetAccessLevel();
        string GetModelName(string Demo);

        List<string> GetWaiting();

        int LoginValidation(string ID1, string ID2);

        void SetBookingID(int ID);

        void Approval(int Decision);

        int UpdateWaits(int InList);
        bool CheckConnection();
        void RemoveMachine(string DemoNumber);

        void RemoveBooking(int bookingID);

        List<String> ShowMachine(string DemoNumber);

        string GetConfigurations(string demoNr);

        List<string> GetCustomer(int bookingID);

        List<string> GetAllCustomers();

        List<string> GetAdresses(string customerName);

        List<string> GetBooking(int bookingID);

        List<string> GetBookingID(string adress);

        List<string> GetMachines(int bookingID);

        DataTable GetAllBookings();

        DataTable GetBookingsByDate(DateTime date);

        List<string> GetAllDemoNumbers();

        List<string> GetBookedDates(string s);

        List<string> GetDemoNumbersByModel(string s);

        List<string> GetDemoNumbersByModelAndNumber(string model, string number);

        List<string> GetAllModels();

        string GetConfig(int BookingID);

        List<string> GetModelNumbers(string s);

        List<string> GetStatus(string Address);

        string GetConnection();

        List<string> PopulateListboxes(List<string> modelname);

        List<string> UpdateSecondListBox(string modelname, List<string> modelnumber);

        List<string> UpdateThirdListbox(string modelnumber, List<string> demonumber);

        void UpdatedInformation(string newDemoNumber, string ModelName, string ModelNumber, string Brand, string CNumber,
                    string MastType, int MastBuildingHeight, int MastLiftHeight, int MastFreeLift, string AggregatType,
                    string AggregatNumber, string BatteryType, string BatteryNumber, string ChargerType, string ChargerNumber,
                    string Controller, decimal Weight, decimal Height, decimal Length, decimal Width, string oldDemoNumber);

        void UpdateBooking(string name1, string name2, string att, string address, string zipCode,
                    string city, string phone, string country, string salesRep, string deliveryDate, 
                    string retrievalDate, string carrier, string messageToWorkshop, string deliveryNote, 
                    string loadingPlatform, int bookingIDs);

        void AddModelName(string modelname);

        void RemoveModelName(string modelname);
        DataTable GetAllUsers();
        void AddUser(string name);
        List<string> GetAllSalesRep(List<string> salesRep);
        string GetOneSalesRep(int bookingID);
        string GetCountry(int bookingID);
        List<string> GetDates(int bookingID);
        List<int> GetBookingsForCarrier(DateTime d);
        List<string> GetDemoNumbersByBooking(int id);

    }
    public class DatabaseRepository : IDatabase
    {
        stillasEntities meContext = new stillasEntities();

        public DatabaseRepository()
        {
            
        }
        public DatabaseRepository(stillasEntities se)
        {
            meContext = se;
        }

        //[Krognos Start]
        private static int CustomerID;
        private static int BookingID;
        private static int AccessLevel;
        private static string Bruger;
        public void CreateModelName(string ModelName1)
        {
            var ModelN = new ModelNavn { Modelnavn1 = ModelName1 };
            meContext.ModelNavns.Add(ModelN);
            meContext.SaveChanges();
        }
        public void CreateMachine(string DemoNumber, string ModelName, string ModelNumber, string Brand, string CNumber,
            string MastType, int MastBuildingHeight, int MastLiftHeight, int MastFreeLift, string AggregatType,
            string AggregatNumber, string BatteryType, string BatteryNumber, string ChargerType, string ChargerNumber,
            string Controller, decimal Weight, decimal Height, decimal Length, decimal Width, List<string> configurationsList)
        {
            var Machine = new Maskine { DemoNummer = DemoNumber, ModelName = ModelName, Type = ModelNumber, Fabrikant = Brand, Chassisnummer = CNumber,
                MastType = MastType, MastByggeHøjde = MastBuildingHeight, MastLøfteHøjde = MastLiftHeight, MastFriLøft = MastFreeLift,
                Aggregat = AggregatType, AggregarNummer = AggregatNumber, BatteriType = BatteryType, BatteriNummer = BatteryNumber,
                LaderType = ChargerType, LaderNummer = ChargerNumber, Betjening = Controller, Weight = Weight, Height = Height,
                Length = Length, Width = Width};
            meContext.Maskines.Add(Machine);
            meContext.SaveChanges();
        }
        public void CreateCustomer(string Name1, string Name2, string Att, string Address, int ZIP, string City, string Country, int Phone)
        {
            CreateCustomerID();
            var Customer = new Kunde
            {
                KundeID = CustomerID,
                Navn1 = Name1,
                Navn2 = Name2,
                Att = Att,
                Adresse = Address,
                Postnummer = ZIP,
                By = City,
                Land = Country,
                Telefon = Phone
        };
                        meContext.Kundes.Add(Customer);
                        meContext.SaveChanges();
        }
        public void CreateCustomerID()
        {
            conn = new SqlConnection(GetConnection());
            conn.Open();
            string ID = "";
            string count = "select * from Kunde order by KundeID desc";
            SqlCommand ReadCom = new SqlCommand(count, conn);
            SqlDataReader myReader = null;
            myReader = ReadCom.ExecuteReader();
            if (myReader.Read())
            {
                ID = myReader["KundeID"].ToString();
            }
            if (ID == "")
            {
                ID = "0";
            }
            CustomerID = Convert.ToInt32(ID) + 1;
            conn.Close();
        }
        public void CreateBooking(string salesRep, string date1, string date2, string Transporter, string MessageForWorkshop, string DeliveryNote,
            int Ramp)
        {
            CreateBookingID();
            DateTime dt1 = DateTime.ParseExact(date1, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime dt2 = DateTime.ParseExact(date2, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int KundeID = CustomerID;
            int BookingsID = BookingID;
            string Username = Bruger;
            string Salesman = salesRep;
            string LeveringsDato = dt1.ToString("yyyy-MM-dd");
            string AfhentningsDato = dt2.ToString("yyyy-MM-dd");
            string Leverandør = Transporter;
            string BeskedTilVærksted = MessageForWorkshop;
            string BeskedTilFølgeSeddel = DeliveryNote;
            int RampeVedLevering = Ramp;
            string Status = "Waiting";

            conn = new SqlConnection(GetConnection());
            conn.Open();
            SqlCommand Com = new SqlCommand("insert into Booking values(" +
                BookingsID + ", " +
                KundeID + ", '" +
                Username + "', '" +
                Salesman + "', '" +
                LeveringsDato + "', '" +
                AfhentningsDato + "', '" +
                Leverandør + "', '" +
                BeskedTilVærksted + "', '" +
                BeskedTilFølgeSeddel + "', " +
                RampeVedLevering + ", '" + 
                Status + "')"
                );
            Com.Connection = conn;
            Com.ExecuteNonQuery();
            conn.Close();
        }
        public void CreateBookingID()
        {
            conn = new SqlConnection(GetConnection());
            conn.Open();
            string ID = "";
            string count = "select * from Booking order by BookingID desc";
            SqlCommand ReadCom = new SqlCommand(count, conn);
            SqlDataReader myReader = null;
            myReader = ReadCom.ExecuteReader();
            if (myReader.Read())
            {
                ID = myReader["BookingID"].ToString();
            }
            if (ID == "")
            {
                ID = "0";
            }
            BookingID = Convert.ToInt32(ID) + 1;
            conn.Close();
        }
        public void CreateBookingLine(List<string> Machine, string Konfig)
        {
            foreach(string X in Machine)
            {
                var BookingLinje = new BookingLinje { BookingID = BookingID, DemoNummer = X, KonfigurationTekst = Konfig };
                meContext.BookingLinjes.Add(BookingLinje);
                meContext.SaveChanges();
            }
        }
        public List<string> DropDownDemo()
        {
            List<string> Demos = new List<string>();
            foreach (var X in meContext.Maskines)
            {
                Demos.Add(X.DemoNummer);
            }
            return Demos;
        }
        public int GetAccessLevel()
        {
            return AccessLevel;
        }

        public string GetConfig(int BookingID)
        {
            string config = "";
            conn = new SqlConnection(GetConnection());
            conn.Open();
            try
            {
                get = "select KonfigurationTekst from Bookinglinje where BookingID = " + BookingID + "";
                SqlCommand com = new SqlCommand(@get, conn);
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        config = reader["KonfigurationTekst"].ToString();
                    }
                }
            }
            catch
            {

            }
            conn.Close();
            return config;
        }
        public string GetModelName(string Demo)
        {
            string ModelName = meContext.Maskines.Find(Demo).ModelName;
            return ModelName;
        }
        public List<string> GetStatus(string Address)
        {
            List<string> status = new List<string>();
            var bookings = meContext.Bookings;
            foreach (Booking b in bookings)
            {
                if (b.Kunde.Adresse == Address)
                {
                    status.Add(b.Status.ToString());
                }
            }
            return status;
        }
        public List<string> GetWaiting()
        { 
            List<string> bookingList = new List<string>();
            var bookings = meContext.Bookings;

            foreach (Booking b in bookings)
            {
                if (b.Status == "Waiting")
                {
                    bookingList.Add(b.BookingID.ToString());
                }
            }

            return bookingList;
        }
        public int LoginValidation(string ID1, string ID2)
        {
            Bruger = ID1;
            int Validation;
            conn = new SqlConnection(GetConnection());
            conn.Open();
            string User = "";
            string Password = "";
            string count = "select * from Bruger where Username = '" + ID1 + "'";
            SqlCommand ReadCom = new SqlCommand(count, conn);
            SqlDataReader myReader = null;
            myReader = ReadCom.ExecuteReader();
            if (myReader.Read())
            {
                User = myReader["Username"].ToString();
                Password = myReader["Adgangskode"].ToString();
                AccessLevel = Convert.ToInt32(myReader["AccessLevel"]);
            }
            if (User == "")
            {
                User = "0";
            }
            if (User == ID1 && Password == ID2)
            {
                Validation = 0;
            }
            else
            {
                Validation = 1;
            }
            conn.Close();
            return Validation;
        }
        public void SetBookingID(int ID)
        {
            BookingID = ID;
        }
        public void Approval(int Decision)
        {
            if (Decision == 0)
            {
                meContext.Bookings.Find(BookingID).Status = "Approved";
            }
            else
            {
                meContext.Bookings.Find(BookingID).Status = "Not Approved";
            }
            meContext.SaveChanges();
        }
        public int UpdateWaits(int InList)
        {
            int Holder = 0;
            int Current;
            foreach (Booking X in meContext.Bookings)
            {
                if (X.Status == "Waiting")
                {
                    Holder++;
                }
            }
            if (Holder > InList)
            {
                Current = Holder;
            }
            return Holder;
        }
        public void RemoveBooking(int bookingID)
        {
            conn = new SqlConnection(GetConnection());
            conn.Open();
            try
            {
                string deleteBooking = "delete from Bookinglinje where BookingID = " + bookingID + " delete from Booking where BookingID = " + bookingID;
                SqlCommand com = new SqlCommand(@deleteBooking, conn);
                com.ExecuteNonQuery();
            }
            catch
            {

            }
            conn.Close();
        }
        //[Krognos Slut]

        // Daniels metoder
        public bool CheckConnection()
        {
            var user = meContext.Brugers;
            bool checker = true;

            try
            {
                if (user.Count() <= 0)
                {
                    checker = false;
                }
            }
            catch (Exception)
            {

                checker = false;
            }
            

            return checker;
        }
        public void RemoveMachine(string DemoNumber)
        {
            conn = new SqlConnection(GetConnection());
            conn.Open();
            try
            {
                string deleteModelName = "alter table Bookinglinje nocheck constraint all delete from Maskine where Demonummer = '" + DemoNumber + "' alter table Bookinglinje check constraint all";
                SqlCommand com = new SqlCommand(@deleteModelName, conn);
                com.ExecuteNonQuery();
            }
            catch
            {

            }
            conn.Close();
        }


        public List<String> ShowMachine(string DemoNumber)
        {
            List<string> machineList = new List<string>();
            var machine = meContext.Maskines.Find(DemoNumber);
            machineList.Add(machine.Type);
            machineList.Add(machine.Fabrikant);
            machineList.Add(machine.Chassisnummer);
            machineList.Add(machine.MastType);
            machineList.Add(machine.MastByggeHøjde + "");
            machineList.Add(machine.MastLøfteHøjde + "");
            machineList.Add(machine.MastFriLøft + "");
            machineList.Add(machine.Aggregat);
            machineList.Add(machine.AggregarNummer);
            machineList.Add(machine.BatteriType);
            machineList.Add(machine.BatteriNummer);
            machineList.Add(machine.LaderType);
            machineList.Add(machine.LaderNummer);
            machineList.Add(machine.Betjening);
            machineList.Add(machine.Weight + "");
            machineList.Add(machine.Height + "");
            machineList.Add(machine.Length + "");
            machineList.Add(machine.Width + "");

            return machineList;

        }

        public string GetConfigurations(string demoNr)
        {
            string configurations = "";
            return configurations;

        }

        public List<string> GetCustomer(int bookingID)
        {
            List<string> customerInfo = new List<string>();
            var booking = meContext.Bookings.Find(bookingID);
            var customer = meContext.Kundes.Find(Convert.ToInt32(booking.KundeID));

            customerInfo.Add(customer.Navn1);
            customerInfo.Add(customer.Navn2);
            customerInfo.Add(customer.Att);
            customerInfo.Add(customer.Adresse);
            customerInfo.Add(customer.Postnummer + "");
            customerInfo.Add(customer.By);
            customerInfo.Add(customer.Land);
            customerInfo.Add(customer.Telefon + "");

            return customerInfo;
        }

        public List<string> GetAllCustomers()
        {
            List<string> customersList = new List<string>();
            var customers = meContext.Kundes;

            foreach (Kunde k in customers)
            {
                customersList.Add(k.Navn1);
            }

            return customersList;
        }

        public List<string> GetAdresses(string customerName)
        {
            List<string> adressList = new List<string>();
            var adresses = meContext.Kundes;

            foreach (Kunde k in adresses)
            {
                if (k.Navn1 == customerName)
                {
                    adressList.Add(k.Adresse);
                }
            }

            return adressList;
        }

        public List<string> GetBooking(int bookingID)
        {
            List<string> bookingInfo = new List<string>();

            var booking = meContext.Bookings.Find(bookingID);

            string dDate = booking.LeveringsDato.ToString().Substring(0, 10);
            string rDate = booking.AfhentningsDato.ToString().Substring(0, 10);
            bookingInfo.Add(dDate);
            bookingInfo.Add(rDate);
            bookingInfo.Add(booking.Leverandør);
            bookingInfo.Add(booking.BeskedTilVærksted);
            bookingInfo.Add(booking.BeskedTilFølgeSeddel);
            bookingInfo.Add(booking.RampeVedLevering+"");

            return bookingInfo;
        }

        public List<string> GetBookingID(string adress)
        {
            List<string> bookingList = new List<string>();
            var bookings = meContext.Bookings;

            foreach (Booking b in bookings)
            {
                if (b.Kunde.Adresse == adress)
                {
                    bookingList.Add(b.BookingID.ToString());
                }
            }

            return bookingList;
        }

        public List<string> GetMachines(int bookingID)
        {
            List<string> machinesList = new List<string>();
            var booking = meContext.Bookings;

            foreach (Booking b in booking)
            {
                foreach (BookingLinje bl in b.BookingLinjes)
                {
                    if (b.BookingID == bookingID)
                    {
                        machinesList.Add(bl.DemoNummer);
                    }
                }
            }

            return machinesList;
        }
        public DataTable GetAllBookings()
        {

            DataTable dtBookings = new DataTable();

            string connString = GetConnection();

            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("select b.bookingid, b.status, leveringsdato, afhentningsdato, m.modelname, m.type, m.DemoNummer from booking b join BookingLinje bl on b.bookingid = bl.bookingid join Maskine m on bl.demonummer = m.demonummer order by b.status asc", con))
                {
                    con.Open();
                    var dataReader = cmd.ExecuteReader();

                    dtBookings.Load(dataReader);
                }
            }

            return dtBookings;
        }

        public DataTable GetBookingsByDate(DateTime date)
        {
            string connString = GetConnection();
            DataTable dtBookings = new DataTable();
            DateTime updatedDate = date;
            

            for (int i = 0; i < 7; i++)
            {
                string newDate = updatedDate.ToString("yyyy-MM-dd h:mm tt");
                newDate.Substring(0, 10);
                updatedDate = updatedDate.AddDays(1);

                using (SqlConnection con = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand("select b.bookingid, b.status, leveringsdato, afhentningsdato, m.modelname, m.type, m.DemoNummer from booking b join BookingLinje bl on b.bookingid = bl.bookingid join Maskine m on bl.demonummer = m.demonummer where LeveringsDato = '" + newDate + "' order by b.status asc", con))
                    {
                        con.Open();
                        var dataReader = cmd.ExecuteReader();

                        dtBookings.Load(dataReader);
                    }
                }
            }

            return dtBookings;
        }

        public class BookingData
        {
            public /*DateTime*/ string deliveryDate;
            public /*DateTime*/ string retrivalDate;
            public string modelName;
            public string modelNumber;
            public string demoNumber;
        }

        public List<string> GetAllDemoNumbers()
        {
            List<string> demoNumbers = new List<string>();
            var machine = meContext.Maskines;

            foreach (Maskine m in machine)
            {
                demoNumbers.Add(m.DemoNummer);
            }

            return demoNumbers;
        }

        public List<string> GetBookedDates(string s)
        {
            List<string> bookedDates = new List<string>();

            var bookingLinjer = meContext.BookingLinjes;

            foreach (BookingLinje bl in bookingLinjer)
            {
                if (bl.DemoNummer == s)
                {
                    DateTime date1 = bl.Booking.LeveringsDato.Value;
                    DateTime date2 = bl.Booking.AfhentningsDato.Value.AddDays(1);

                    double daysCount = (date2 - date1).TotalDays;

                    for (int i = 0; i < daysCount; i++)
                    {
                     
                        string dateString = date1.AddDays(i).ToString().Substring(0, 10);
                        bookedDates.Add(dateString);
                    }
                }
            }

            return bookedDates;
        }

        public List<string> GetDemoNumbersByModel(string s)
        {
            List<string> demoNumbers = new List<string>();

            var machines = meContext.Maskines;

            foreach (Maskine m in machines)
            {
                if (m.ModelName == s)
                {
                    demoNumbers.Add(m.DemoNummer);
                }
            }

            return demoNumbers;
        }

        public List<string> GetDemoNumbersByModelAndNumber(string model, string number)
        {
            List<string> demoNumbers = new List<string>();

            var machines = meContext.Maskines;

            foreach (Maskine m in machines)
            {
                if (m.ModelName == model && m.Type == number)
                {
                    demoNumbers.Add(m.DemoNummer);
                }
            }

            return demoNumbers;
        }

        public List<string> GetAllModels()
        {
            List<string> models = new List<string>();

            var model = meContext.ModelNavns;
            foreach (ModelNavn mn in model)
            {
                models.Add(mn.Modelnavn1);
            }

            return models;
        }

        public List<string> GetModelNumbers(string s)
        {
            List<string> modelNumbers = new List<string>();

            var machines = meContext.Maskines;

            foreach (Maskine m in machines)
            {
                if (m.ModelName == s)
                {
                    modelNumbers.Add(m.Type);
                }
            }

            return modelNumbers;
        }

        public List<int> GetBookingsForCarrier(DateTime d)
        {
            var bookings = meContext.Bookings;
            List<int> list = new List<int>();
            

            foreach (Booking b in bookings)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (b.LeveringsDato.ToString() == d.AddDays(i).ToString() && b.Status == "Approved")
                    {
                        list.Add(b.BookingID);
                    }
                }
            }

            return list;
        }

        public List<string> GetDemoNumbersByBooking(int id)
        {
            List<string> list = new List<string>();

            var bookinglinjes = meContext.BookingLinjes;

            foreach (BookingLinje bl in bookinglinjes)
            {
                if (bl.BookingID == id)
                {
                    list.Add(bl.DemoNummer);
                }
            }

            return list;
        }

        // LEA ARBEJDER HERFRA ---------------------------------- >
        // Machines Listboxe
        private SqlConnection conn;
        private string get;

        public object Properties { get; private set; }

        public string GetConnection()
        {
            return "Data Source=mssql6.gear.host;Initial Catalog=stillas;User Id=stillas;Password=Sb3ZRHQ!_nAI";
        }
        public List<string> PopulateListboxes(List<string> modelname)
        {
            conn = new SqlConnection(GetConnection());
            conn.Open();
            try
            {
                get = "select * from ModelNavn";
                SqlCommand com = new SqlCommand(@get, conn);
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        modelname.Add(reader["ModelNavn"].ToString());
                    }
                }
            }
            catch
            {

            }
            modelname.Sort();
            conn.Close();
            return modelname;
        }
        public List<string> UpdateSecondListBox(string modelname, List<string> modelnumber)
        {
            conn = new SqlConnection(GetConnection());
            conn.Open();
            try
            {
                get = "select Maskine.Type from Maskine join ModelNavn on Maskine.ModelName = ModelNavn.Modelnavn where ModelName = '" + modelname + "'";
                SqlCommand com = new SqlCommand(@get, conn);
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        modelnumber.Add(reader["Type"].ToString());
                    }
                }
            }
            catch
            {

            }
            modelnumber.Sort();
            conn.Close();
            return modelnumber;
        }
        public List<string> UpdateThirdListbox(string modelnumber, List<string> demonumber)
        {
            conn = new SqlConnection(GetConnection());
            conn.Open();
            try
            {
                get = "select DemoNummer from Maskine where Type = '" + modelnumber + "'";
                SqlCommand com = new SqlCommand(@get, conn);
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        demonumber.Add(reader["DemoNummer"].ToString());
                    }
                }
            }
            catch
            {

            }
            conn.Close();
            return demonumber;
        }
        public void UpdatedInformation(string newDemoNumber, string ModelName, string ModelNumber, string Brand, string CNumber,
            string MastType, int MastBuildingHeight, int MastLiftHeight, int MastFreeLift, string AggregatType,
            string AggregatNumber, string BatteryType, string BatteryNumber, string ChargerType, string ChargerNumber,
            string Controller, decimal Weight, decimal Height, decimal Length, decimal Width, string oldDemoNumber)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnection()))
                {
                    conn.Open();
                    using (SqlCommand cmd =
                        new SqlCommand("UPDATE Maskine SET DemoNummer=@NewDemoNummer, ModelName=@ModelName, " +
                        "Type=@Type, Fabrikant=@Brand, Chassisnummer=@CNumber,MastType=@MastType, " +
                        "MastByggeHøjde=@MastBuldingHeight, MastLøfteHøjde=@MastLiftHeigt, " +
                        "MastFriLøft=@MastFreeLift, Betjening=@Controller, Aggregat=@AggregatType, " +
                        "AggregarNummer=@AggregatNumber, BatteriType=@BatteryType, BatteriNummer=@BatteryNumber, " +
                        "LaderType=@ChargerType, LaderNummer=@ChargerNumber, Weight=@Weight, Height=@Height, " +
                        "Length=@Length, Width=@Width WHERE DemoNummer=@oldDemoNumber", conn))
                    {
                        cmd.Parameters.AddWithValue("@NewDemoNummer", newDemoNumber);
                        cmd.Parameters.AddWithValue("@ModelName", ModelName);

                        cmd.Parameters.AddWithValue("@Type", ModelNumber);
                        cmd.Parameters.AddWithValue("@Brand", Brand);
                        cmd.Parameters.AddWithValue("@CNumber", CNumber);

                        cmd.Parameters.AddWithValue("@MastType", MastType);
                        cmd.Parameters.AddWithValue("@MastBuldingHeight", MastBuildingHeight);
                        cmd.Parameters.AddWithValue("@MastLiftHeigt", MastLiftHeight);
                       

                        cmd.Parameters.AddWithValue("@MastFreeLift", MastFreeLift);
                        cmd.Parameters.AddWithValue("@Controller", Controller);
                        cmd.Parameters.AddWithValue("@AggregatType", AggregatType);

                        cmd.Parameters.AddWithValue("@AggregatNumber", AggregatNumber);
                        cmd.Parameters.AddWithValue("@BatteryType", BatteryType);
                        cmd.Parameters.AddWithValue("@BatteryNumber", BatteryNumber);

                        cmd.Parameters.AddWithValue("@ChargerType", ChargerType);
                        cmd.Parameters.AddWithValue("@ChargerNumber", ChargerNumber);
                        cmd.Parameters.AddWithValue("@Weight", Weight);

                        cmd.Parameters.AddWithValue("@Height", Height);
                        cmd.Parameters.AddWithValue("@Length", Length);
                        cmd.Parameters.AddWithValue("@Width", Width);

                        cmd.Parameters.AddWithValue("@oldDemoNumber", oldDemoNumber);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch 
            {
            }
        }
        
        public void UpdateBooking(string name1, string name2, string att, string address, string zipCode,
            string city, string phone, string country, string salesRep, string deliveryDate, string retrievalDate, string carrier,
            string messageToWorkshop, string deliveryNote, string loadingPlatform, int bookingIDs)
        {
                conn = new SqlConnection(GetConnection());
                conn.Open();
                var booking = meContext.Bookings.Find(bookingIDs);
                var customer = meContext.Kundes.Find(Convert.ToInt32(booking.KundeID));

                CustomerID = customer.KundeID;
                using (SqlCommand updateCustomer =
                    new SqlCommand("UPDATE Kunde SET Navn1=@Name1, Navn2=@Name2, Att=@ATT, Adresse=@Address, " +
                    "Postnummer=@ZipCode, [By]=@City, Telefon=@Phone, Land=@Country where KundeID=@CustomerID", conn))
                {
                    updateCustomer.Parameters.AddWithValue("@Name1", name1);
                    updateCustomer.Parameters.AddWithValue("@Name2", name2);
                    updateCustomer.Parameters.AddWithValue("@ATT", att);
                    updateCustomer.Parameters.AddWithValue("@Address", address);
                    updateCustomer.Parameters.AddWithValue("@ZipCode", zipCode);
                    updateCustomer.Parameters.AddWithValue("@City", city);
                    updateCustomer.Parameters.AddWithValue("@Phone", phone);
                    updateCustomer.Parameters.AddWithValue("@Country", country);              
                    updateCustomer.Parameters.AddWithValue("@CustomerID", CustomerID);
                    updateCustomer.ExecuteNonQuery();
                }
                using (SqlCommand updateDeliveryInformation =
                   new SqlCommand("UPDATE Booking SET Navn=@salesRep, LeveringsDato=@deliveryDate, " + // Der stod SælgerID i stedet for Navn
                   "AfhentningsDato=@retrievalDate, Leverandør=@carrier, BeskedTilVærksted=@messageToWorkshop, " +
                   "BeskedTilFølgeSeddel=@deliveryNote, RampeVedLevering=@loadingPlatform where BookingID=@bookingID", conn))
                {
                DateTime dt1 = DateTime.ParseExact(deliveryDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                DateTime dt2 = DateTime.ParseExact(retrievalDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                string delivery = dt1.ToString("yyyy-MM-dd");
                string retrievel = dt2.ToString("yyyy-MM-dd");

                    updateDeliveryInformation.Parameters.AddWithValue("@salesRep", salesRep);
                    updateDeliveryInformation.Parameters.AddWithValue("@deliveryDate", delivery);
                    updateDeliveryInformation.Parameters.AddWithValue("@retrievalDate", retrievel);
                    updateDeliveryInformation.Parameters.AddWithValue("@carrier", carrier);
                    updateDeliveryInformation.Parameters.AddWithValue("@messageToWorkshop", messageToWorkshop);
                    updateDeliveryInformation.Parameters.AddWithValue("@deliveryNote", deliveryNote);
                    updateDeliveryInformation.Parameters.AddWithValue("@loadingPlatform", loadingPlatform);
                    updateDeliveryInformation.Parameters.AddWithValue("@bookingID", bookingIDs);

                    updateDeliveryInformation.ExecuteNonQuery();
                }               
    
            conn.Close();
        }
        public void AddModelName(string modelname)
        {
            conn = new SqlConnection(GetConnection());
            conn.Open();
            try
            {
                string insertModelName = "insert into ModelNavn(Modelnavn) values ('" + modelname + "')";
                SqlCommand com = new SqlCommand(@insertModelName, conn);
                com.ExecuteNonQuery();
            }
            catch
            {

            }
            conn.Close();
        }
        public void RemoveModelName(string modelname)
        {
            conn = new SqlConnection(GetConnection());
            conn.Open();
            try
            {
                string deleteModelName = "alter table Bookinglinje nocheck constraint all delete from Maskine where ModelName = '"+ modelname +"' delete from ModelNavn where Modelnavn = '" + modelname +"' alter table Bookinglinje check constraint all";
                SqlCommand com = new SqlCommand(@deleteModelName, conn);
                com.ExecuteNonQuery();
            }
            catch
            {

            }
            conn.Close();
        }
        public DataTable dat = new DataTable();
        public DataTable GetAllUsers()
        {
            dat.Clear();
            conn = new SqlConnection(GetConnection());
            conn.Open();
            try
            {
                string selectUsers = "select * from Sælger";
                SqlDataAdapter sda = new SqlDataAdapter(selectUsers, conn);
                sda.Fill(dat);
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return dat;
        }
        public void AddUser(string name)
        {
            conn = new SqlConnection(GetConnection());
            conn.Open();
            try
            {
                SqlCommand insertUser = new SqlCommand("insert into Sælger (Navn) " +
                    "values ('" + name + "')");
                insertUser.Connection = conn;
                insertUser.ExecuteNonQuery();
            }
            catch
            {

            }
            conn.Close();
        }
        public List<string> GetAllSalesRep(List<string> salesRep)
        {
            conn = new SqlConnection(GetConnection());
            conn.Open();
            try
            {
                string selectUsers = "select * from Sælger"; 
                SqlCommand com = new SqlCommand(@selectUsers, conn);
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        salesRep.Add(reader["Navn"].ToString());
                    }
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return salesRep;
        }
        public string GetOneSalesRep(int bookingID)
        {
            string salesRep = "";
            conn = new SqlConnection(GetConnection());
            conn.Open();
            try
            {
                string selectUser = "select Navn from Booking where BookingID = " + bookingID;
                SqlCommand com = new SqlCommand(@selectUser, conn);
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        salesRep = (reader["Navn"].ToString());
                    }
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return salesRep;
        }
        public string GetCountry(int bookingID)
        {
            string country = "";
            conn = new SqlConnection(GetConnection());
            conn.Open();
            try
            {
                string selectUser = "select Land from Kunde k " +
                    "join booking b on k.KundeID = b.KundeID " +
                    "where b.BookingID = " + bookingID; 
                SqlCommand com = new SqlCommand(@selectUser, conn);
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        country = (reader["Land"].ToString());
                    }
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return country;
        }
        public List<string> GetDates(int bookingID)
        {
            List<string> Dates = new List<string>();
            conn = new SqlConnection(GetConnection());
            conn.Open();
            try
            {
                string selectUser = "select LeveringsDato, AfhentningsDato from Booking " +
                "where BookingID = " + bookingID; 
                SqlCommand com = new SqlCommand(@selectUser, conn);
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dates.Add(reader["LeveringsDato"].ToString());
                        Dates.Add(reader["AfhentningsDato"].ToString());
                    }
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return Dates;           
        }
    }
}
