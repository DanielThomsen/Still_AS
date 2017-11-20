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
        public void CreateModelName(string ModelName)
        {
            var ModelN = new ModelNavn { Modelnavn1 = ModelName };
            meContext.ModelNavns.Add(ModelN);
            meContext.SaveChanges();
        }
        public void CreateMachine(string DemoNumber, string ModelName, string ModelNumber, string Brand, string CNumber, 
            string MastType, int MastBuildingHeight, int MastLiftHeight, int MastFreeLift, string AggregatType,
            string AggregatNumber, string BatteryType, string BatteryNumber, string ChargerType, string ChargerNumber,
            string Controller, decimal Weight, decimal Height, decimal Length, decimal Width)
        {
            var Machine = new Maskine { DemoNummer = DemoNumber, ModelNavn = ModelName, Type = ModelNumber, Fabrikant = Brand, Chassisnummer = CNumber,
                MastType = MastType, MastByggeHøjde = MastBuildingHeight, MastLøfteHøjde = MastLiftHeight, MastFriLøft = MastFreeLift,
                Aggregat = AggregatType, AggregarNummer = AggregatNumber, BatteriType = BatteryType, BatteriNummer = BatteryNumber,
                LaderType = ChargerType, LaderNummer = ChargerNumber, Betjening = Controller, Weight = Weight, Height = Height,
                Length = Length, Width = Width, DemonAnsvarligID = 1};
            meContext.Maskines.Add(Machine);
            meContext.SaveChanges();
        }

        //LEA ARBEJDER HERFRA ----------------------------------
        private SqlConnection conn;
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
                string get = "select * from ModelNavn";
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
            conn.Close();
            return modelname;                     
        }
        public void UpdateListBox(string modename)
        {
            //conn = SqlConnection(GetConnection());

        }
    }
}
