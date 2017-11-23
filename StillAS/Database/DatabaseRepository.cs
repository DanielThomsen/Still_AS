using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SqlClient;

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
                Length = Length, Width = Width, DemonAnsvarligID = 1};
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
            var Customer = new Kunde
                        {
                            KundeID = CreateCustomerID(),
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
        public int CreateCustomerID()
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
            return CustomerID;
        }
        public int CreateBookingID()
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
            return BookingID;
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

        // Daniels metode
        public void RemoveMachine(string DemoNumber)
        {
            var machine = meContext.Maskines.Find(DemoNumber);
            meContext.Maskines.Remove(machine);
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
            machineList.Add(machine.MastByggeHøjde+"");
            machineList.Add(machine.MastLøfteHøjde+"");
            machineList.Add(machine.MastFriLøft+"");
            machineList.Add(machine.Aggregat);
            machineList.Add(machine.AggregarNummer);
            machineList.Add(machine.BatteriType);
            machineList.Add(machine.BatteriNummer);
            machineList.Add(machine.LaderType);
            machineList.Add(machine.LaderNummer);
            machineList.Add(machine.Betjening);
            machineList.Add(machine.Weight+"");
            machineList.Add(machine.Height+"");
            machineList.Add(machine.Length+"");
            machineList.Add(machine.Width+"");

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

        //LEA ARBEJDER HERFRA ----------------------------------
        private SqlConnection conn;
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
    }
}
