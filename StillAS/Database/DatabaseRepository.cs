using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Globalization;
using System.Data;

namespace Database
{
    public class DatabaseRepository
    {
        stillasEntities meContext = new stillasEntities();

        //[Krognos Start]
        public static int CustomerID;
        public static int BookingID;
        public void CreateModelName(string ModelName1)
        {
            var ModelN = new ModelNavn { Modelnavn1 = ModelName1 };
            meContext.ModelNavns.Add(ModelN);
            meContext.SaveChanges();
        }
        public void CreateMachine(string DemoNumber, string ModelName, string ModelNumber, string Brand, string CNumber,
            string MastType, int MastBuildingHeight, int MastLiftHeight, int MastFreeLift, string AggregatType,
            string AggregatNumber, string BatteryType, string BatteryNumber, string ChargerType, string ChargerNumber,
            string Controller, decimal Weight, decimal Height, decimal Length, decimal Width, List<string> configurationsList) // indsæt konfigurationer og maskinekonfiguration
        {
            var Machine = new Maskine { DemoNummer = DemoNumber, ModelName = ModelName, Type = ModelNumber, Fabrikant = Brand, Chassisnummer = CNumber,
                MastType = MastType, MastByggeHøjde = MastBuildingHeight, MastLøfteHøjde = MastLiftHeight, MastFriLøft = MastFreeLift,
                Aggregat = AggregatType, AggregarNummer = AggregatNumber, BatteriType = BatteryType, BatteriNummer = BatteryNumber,
                LaderType = ChargerType, LaderNummer = ChargerNumber, Betjening = Controller, Weight = Weight, Height = Height,
                Length = Length, Width = Width, DemonAnsvarligID = 1 };
            meContext.Maskines.Add(Machine);
            meContext.SaveChanges();
            
            foreach (string s in configurationsList)
            {
                var machineConfiguration = new MaskineKonfiguration();
                machineConfiguration.DemoNummer = DemoNumber;
                machineConfiguration.Konfiguration = s;
                meContext.MaskineKonfigurations.Add(machineConfiguration);
                meContext.SaveChanges();
            }

        }
        public void CreateCustomer(string Name1, string Name2, string Att, string Address, int ZIP, string City, int Phone)
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
        public void CreateBooking(string date1, string date2, string Transporter, string MessageForWorkshop, string DeliveryNote,
            int Ramp)
        {
            CreateBookingID();
            DateTime dt1 = DateTime.ParseExact(date1, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime dt2 = DateTime.ParseExact(date1, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int KundeID = CustomerID;
            int BookingsID = BookingID;
            int DemoAnsvarligID = 1;
            int SælgerID = 2;
            int VærkstedID = 3;
            int TransportørID = 4;
            string LeveringsDato = dt1.ToString("yyyy-MM-dd");
            string AfhentningsDato = dt2.ToString("yyyy-MM-dd");
            string Leverandør = Transporter;
            string BeskedTilVærksted = MessageForWorkshop;
            string BeskedTilFølgeSeddel = DeliveryNote;
            int RampeVedLevering = Ramp;

            conn = new SqlConnection(GetConnection());
            conn.Open();
            SqlCommand Com = new SqlCommand("insert into Booking values(" +
                BookingsID + ", " +
                KundeID + ", " +
                SælgerID + ", " +
                VærkstedID + ", " +
                DemoAnsvarligID + ", " +
                TransportørID + ", '" +
                LeveringsDato + "', '" +
                AfhentningsDato + "', '" +
                Leverandør + "', '" +
                BeskedTilVærksted + "', '" +
                BeskedTilFølgeSeddel + "', " +
                RampeVedLevering + ")"
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
        public void CreateBookingLine(List<string> Machine)
        {
            foreach(string X in Machine)
            {
                var Bookingline = new BookingLinje();
                Bookingline.BookingID = BookingID;
                Bookingline.DemoNummer = X;
                meContext.BookingLinjes.Add(Bookingline);
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
        //[Krognos Slut]

        // Daniels metoder
        public void RemoveMachine(string DemoNumber)
        {
            var machine = meContext.Maskines.Find(DemoNumber);
            meContext.Maskines.Remove(machine);
            meContext.SaveChanges();
        }

        public void RemoveBooking(int bookingID)
        {
            var booking = meContext.Bookings.Find(bookingID);
            meContext.Bookings.Remove(booking);
            meContext.SaveChanges();
        }

        public List<String> ShowMachine(string DemoNumber)
        {
            List<string> machineList = new List<string>();
            var machine = meContext.Maskines.Find(DemoNumber);
            machineList.Add(machine.ModelName);
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

        public List<string> GetConfigurations(string demoNr)
        {
            List<string> configurations = new List<string>();

            //foreach (var item in collection)  // For hver maskinekonfiguration hvor demonummer = demoNr
            //{

            //}

            //List<MaskineKonfiguration> machineConfigurations = new List<MaskineKonfiguration>();

            //machineConfigurations.Add(meContext.MaskineKonfigurations.Find({ DemoNummer = demoNr}));

            //configurations.Add(machineConfiguration.Konfiguration);

            //return configurations;

            // Kode efter Lazy Loading:

            List<string> configurationsList = new List<string>();
            var machines = meContext.Maskines;

            foreach (Maskine m in machines)
            {
                foreach (MaskineKonfiguration mk in m.MaskineKonfigurations)
                {
                    if (m.DemoNummer == demoNr)
                    {
                        configurationsList.Add(mk.Konfiguration);
                    }
                }
            }

            return configurationsList;
        }

        public List<string> GetAllConfigurations()
        {
            List<string> configurationsList = new List<string>();
            var configuration = meContext.Konfigurations;

            foreach (Konfiguration k in configuration)
            {
                configurationsList.Add(k.KonfigurationsNavn);
            }

            return configurationsList;
        }

        public List<string> GetCustomer(int bookingID)
        {
            List<string> customerInfo = new List<string>();

            // Hent kundeoplysninger fra databasen her:
            var booking = meContext.Bookings.Find(bookingID);
            var customer = meContext.Kundes.Find(Convert.ToInt32(booking.KundeID));

            customerInfo.Add(customer.Navn1);
            customerInfo.Add(customer.Navn2);
            customerInfo.Add(customer.Att);
            customerInfo.Add(customer.Adresse);
            customerInfo.Add(customer.Postnummer + "");
            customerInfo.Add(customer.By);
            customerInfo.Add(customer.Telefon + "");

            return customerInfo;
        }

        public List<string> GetBooking(int bookingID)
        {
            List<string> bookingInfo = new List<string>();

            // Hent bookingoplysninger fra databasen her:
            var booking = meContext.Bookings.Find(bookingID);

            bookingInfo.Add(booking.SælgerID + "");
            bookingInfo.Add(booking.LeveringsDato+"");
            bookingInfo.Add(booking.AfhentningsDato+"");
            bookingInfo.Add(booking.Leverandør);
            bookingInfo.Add(booking.BeskedTilVærksted);
            bookingInfo.Add(booking.BeskedTilFølgeSeddel);
            bookingInfo.Add(booking.RampeVedLevering+"");

            return bookingInfo;
        }

        public List<string> GetMachines(int bookingID)
        {
            //List<string> machines = new List<string>();

            // Hent maskineoplysninger fra databasen her:
            //var booking = meContext.Bookings.Find(bookingID);
            //var bookingLinje = meContext.BookingLinjes.Find(booking);

            //return machines;

            List<string> machinesList = new List<string>();
            var booking = meContext.Bookings;

            foreach (Booking b in booking)
            {
                foreach (BookingLinje bl in b.BookingLinjes)
                {
                    if (b.BookingID == bookingID)
                    {
                        machinesList.Add(bl.Maskine.DemoNummer);
                    }
                }
            }

            return machinesList;
        }
        public int GetCustomerID(int bookingID)
        {
            var booking = meContext.Bookings.Find(bookingID);
            var customer = meContext.Kundes.Find(Convert.ToInt32(booking.KundeID));

            return customer.KundeID;
        }

        // LEA ARBEJDER HERFRA ---------------------------------- >
        // Machines Listboxe
        private SqlConnection conn;
        private SqlTransaction transaction = null;
        private string get;
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
        // Edit Machines
        public string UpdatedInformation(string newDemoNumber, string ModelName, string ModelNumber, string Brand, string CNumber,
            string MastType, int MastBuildingHeight, int MastLiftHeight, int MastFreeLift, string AggregatType,
            string AggregatNumber, string BatteryType, string BatteryNumber, string ChargerType, string ChargerNumber,
            string Controller, decimal Weight, decimal Height, decimal Length, decimal Width, string oldDemoNumber, string messagebox)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnection()))
                {
                    conn.Open();
                    using (SqlCommand cmd =
                        new SqlCommand("UPDATE Maskine SET DemoNummer=@NewDemoNummer, ModelName=@ModelName, " +
                        "DemonAnsvarligID=@DemoAnsvarlig, Type=@Type, Fabrikant=@Brand, Chassisnummer=@CNumber, " +
                        "MastType=@MastType, MastByggeHøjde=@MastBuldingHeight, MastLøfteHøjde=@MastLiftHeigt, " +
                        "MastFriLøft=@MastFreeLift, Betjening=@Controller, Aggregat=@AggregatType, " +
                        "AggregarNummer=@AggregatNumber, BatteriType=@BatteryType, BatteriNummer=@BatteryNumber, " +
                        "LaderType=@ChargerType, LaderNummer=@ChargerNumber, Weight=@Weight, Height=@Height, Length=@Length, " +
                        "Width=@Width WHERE DemoNummer=@oldDemoNumber", conn))
                    {
                        cmd.Parameters.AddWithValue("@NewDemoNummer", newDemoNumber);
                        cmd.Parameters.AddWithValue("@ModelName", ModelName);
                        cmd.Parameters.AddWithValue("@DemoAnsvarlig", 1);

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
            catch (SqlException ex)
            {
                messagebox = ex.Message;
            }
            return messagebox;
        }
        // Edit Bookings
        //public void BeginTransaction()
        //{
        //    SqlConnection conn = new SqlConnection(GetConnection());
        //    conn.Open();
        //    transaction = conn.BeginTransaction(IsolationLevel.RepeatableRead);
        //}
        //public void UpdateBooking(string Name1, string Name2, string ATT, string Address, string ZipCode, 
        //    string City, string Phone, string SalesRep, string DeliveryDate, string RetrievalDate, string Carrier, 
        //    string MessageToWorkshop, string DeliveryNote, string CustomerIDs)
        //{
        //    try
        //    {
        //        CustomerID = Convert.ToInt32(CustomerIDs);
        //        using (SqlCommand updateCustomer =
        //            new SqlCommand("UPDATE Kunde SET Navn1=@Name1, Navn2=@Name2, Att=@ATT, Adresse=@Address, " +
        //            "Postnummer=@ZipCode, By=@City, Telefon=@Phone where KundeID=@CustomerID", conn))
        //        {
        //            updateCustomer.Transaction = transaction;
        //            updateCustomer.Parameters.AddWithValue("@Name1", Name1);
        //            updateCustomer.Parameters.AddWithValue("@Name2", Name2);
        //            updateCustomer.Parameters.AddWithValue("@ATT", ATT);
        //            updateCustomer.Parameters.AddWithValue("@Address", Address);
        //            updateCustomer.Parameters.AddWithValue("@ZipCode", Name2);
        //            updateCustomer.Parameters.AddWithValue("@City", City);
        //            updateCustomer.Parameters.AddWithValue("@Phone", Phone);
        //            updateCustomer.Parameters.AddWithValue("@CustomerID", CustomerID);
        //        }
        //    }
        //    catch
        //    {

        //    }
        //}
    }
}
