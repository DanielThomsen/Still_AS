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
        public void CreateModelName(string ModelName1)
        {
            var ModelN = new ModelNavn { Modelnavn1 = ModelName1 };
            meContext.ModelNavns.Add(ModelN);
            meContext.SaveChanges();
        }
        public void CreateMachine(string DemoNumber, string ModelName, string ModelNumber, string Brand, string CNumber,
            string MastType, int MastBuildingHeight, int MastLiftHeight, int MastFreeLift, string AggregatType,
            string AggregatNumber, string BatteryType, string BatteryNumber, string ChargerType, string ChargerNumber,
            string Controller, decimal Weight, decimal Height, decimal Length, decimal Width)
        {
            var Machine = new Maskine { DemoNummer = DemoNumber, ModelName = ModelName, Type = ModelNumber, Fabrikant = Brand, Chassisnummer = CNumber,
                MastType = MastType, MastByggeHøjde = MastBuildingHeight, MastLøfteHøjde = MastLiftHeight, MastFriLøft = MastFreeLift,
                Aggregat = AggregatType, AggregarNummer = AggregatNumber, BatteriType = BatteryType, BatteriNummer = BatteryNumber,
                LaderType = ChargerType, LaderNummer = ChargerNumber, Betjening = Controller, Weight = Weight, Height = Height,
                Length = Length, Width = Width, DemonAnsvarligID = 1 };
            meContext.Maskines.Add(Machine);
            meContext.SaveChanges();
        }

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

        // LEA ARBEJDER HERFRA ---------------------------------- >
        // Machines Listboxe
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
            //conn = new SqlConnection(GetConnection());
            //conn.Open();
            //try
            //{           
            //    get = "UPDATE Maskine SET DemoNummer = '" + newDemoNumber + "', ModelName = '" + ModelName + "', "
            //        + "DemonAnsvarligID = " + 1 + ", "
            //        + "Type = '" + ModelNumber + "', Fabrikant = '" + Brand + "', Chassisnummer = '" + CNumber + "', "
            //        + "MastType = '" + MastType + "', MastByggeHøjde = " + MastBuildingHeight + ", "
            //        + "MastLøfteHøjde = " + MastLiftHeight + ", MastFriLøft = " + MastFreeLift + ", "
            //        + "Betjening = '" + Controller + "', Aggregat = '" + AggregatType + "', "
            //        + "AggregarNummer = '" + AggregatNumber + "', BatteriType = '" + BatteryType + "', "
            //        + "BatteriNummer = '" + BatteryNumber + "', LaderType = '" + ChargerType + "', "
            //        + "LaderNummer = '" + ChargerNumber + "', Weight = " + Weight + ", Height = " + Height + ", "
            //        + "Length = " + Length + ", Width = " + Width + " WHERE DemoNummer = '" + oldDemoNumber + "'";
            //    SqlCommand com = new SqlCommand(@get, conn);
            //    com.Connection = conn;
            //    com.ExecuteNonQuery();
            //    messagebox = get;
            //}
            //catch (Exception ex)
            //{

            //}
            //conn.Close();
            //return messagebox;
        }
    }
}
