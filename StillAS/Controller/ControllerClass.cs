using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using Model;
using System.Data;

namespace Controller
{
    public class ControllerClass
    {
        ModelClass MC = new ModelClass();
        DatabaseRepository DBR = new DatabaseRepository();
        public static List<string> DemoMachines = new List<string>();
        //[Krognos start]
        public void CreateMachine(string DemoNumber, string ModelName, string ModelNumber, string Brand, string CNumber,
            string MastType, int MastBuildingHeight, int MastLiftHeight, int MastFreeLift, string AggregatType,
            string AggregatNumber, string BatteryType, string BatteryNumber, string ChargerType, string ChargerNumber,
            string Controller, decimal Weight, decimal Height, decimal Length, decimal Width, List<string> configurationsList)
        {
            DBR.CreateMachine(DemoNumber, ModelName, ModelNumber, Brand, CNumber, MastType, MastBuildingHeight, MastLiftHeight, 
                MastFreeLift, AggregatType, AggregatNumber, BatteryType, BatteryNumber, ChargerType, ChargerNumber, Controller,
                Weight, Height, Length, Width, configurationsList);
        }
        public void AddCustomer(string Name1, string Name2, string Att, string Address, int ZIP, string City, int Phone)
        {
            DBR.CreateCustomer(Name1, Name2, Att, Address, ZIP, City, Phone);
        }
        public void CreateBooking(string date1, string date2, string Transportør, string MessageForWorkshop, string DeliverNote,
            int Ramp)
        {
            DBR.CreateBooking(date1, date2, Transportør, MessageForWorkshop, DeliverNote, Ramp);
        }
        public List<String> DropDownDemoLoad()
        {
            return DBR.DropDownDemo();
        }
        public void CreateBookingLine()
        {
            DBR.CreateBookingLine(DemoMachines);
            DemoMachines.Clear();
        }
       // public int GetCustomerID()
        //{
        //    int ID = DatabaseRepository.CustomerID;
        //    return ID;
        //}
        public int AccessLevel()
        {
            return DBR.GetAccessLevel();
        }
        public int Validation(string ID1, string ID2)
        {
            return DBR.LoginValidation(ID1, ID2);
        }
            // SKal til Model
        public string TimeNow()
        {
            return MC.ClockNow();
        }
        //Skal til model
        public string TimeNY()
        {
            return MC.ClockNY();
        }
        public List<string> GetWaiting()
        {
            return DBR.GetWaiting();
        }
        public void SetBookingID(int ID)
        {
            DBR.SetBookingID(ID);
        }
        public void SetApproval(int Decision)
        {
            DBR.Approval(Decision);
        }
        public int UpdateNews(int InBox)
        {
            int Current = DBR.UpdateWaits(InBox);
            return Current;
        }
        //[Krognos slut]

        //Daniels metoder:
        public void RemoveMachine(string DemoNumber)
        {
            DBR.RemoveMachine(DemoNumber);
        }

        public List<string> ShowMachine(string DemoNumber)
        {
            List<string> machineInfo = DBR.ShowMachine(DemoNumber);
            return machineInfo;
        }

        public string GetConfigurations(string demoNr)
        {
            string configurations = DBR.GetConfigurations(demoNr);
            return configurations;
        }

        //public List<string> GetAllConfigurations()
        //{
        //    List<string> configurations = DBR.GetAllConfigurations();
        //    return configurations;
        //}

        public List<string> GetAllCustomers()
        {
            List<string> customers = DBR.GetAllCustomers();
            return customers;
        }

        public List<string> GetAdresses(string customerName)
        {
            List<string> adresses = DBR.GetAdresses(customerName);
            return adresses;
        }

        public List<string> GetBookingID(string adress)
        {
            List<string> bookingIDs = DBR.GetBookingID(adress);
            return bookingIDs;
        }

        public void RemoveBooking(int bookingID)
        {
            DBR.RemoveBooking(bookingID);
        }

        public List<string> GetCustomer(int bookingID)
        {
            List<string> customerInfo = DBR.GetCustomer(bookingID);
            return customerInfo;
        }

        public List<string> GetBooking(int bookingID)
        {
            List<string> bookingInfo = DBR.GetBooking(bookingID);
            return bookingInfo;
        }

        public List<string> GetMachines(int bookingID)
        {
            List<string> machines = DBR.GetMachines(bookingID);
            return machines;
        }

        //public List<List<string>> GetAllBookings()
        //{
        //    List<List<string>> bookings = DBR.GetAllBookings();
        //    return bookings;
        //}

        public DataTable GetAllBookings()
        {
            DataTable dt = DBR.GetAllBookings();
            return dt;
        }

        public DataTable GetBookingsByDate(DateTime date)
        {
            DataTable dt = DBR.GetBookingsByDate(date);
            return dt;
        }

        public List<string> GetAllDemoNumbers()
        {
            List<string> demoNumbers = DBR.GetAllDemoNumbers();
            return demoNumbers;
        }

        public List<string> GetBookedDates(string s)
        {
            List<string> bookedDates = DBR.GetBookedDates(s);
            return bookedDates;
        }

        public List<string> GetDemoNumbersByModel(string s)
        {
            List<string> demoNumbers = DBR.GetDemoNumbersByModel(s);
            return demoNumbers;
        }

        public List<string> GetDemoNumbersByModelAndNumber(string model, string number)
        {
            List<string> demoNumbers = DBR.GetDemoNumbersByModelAndNumber(model, number);
            return demoNumbers;
        }

        public List<string> GetAllModels()
        {
            List<string> models = DBR.GetAllModels();
            return models;
        }

        public List<string> GetModelNumbers(string s)
        {
            List<string> modelNumbers = DBR.GetModelNumbers(s);
            return modelNumbers;
        }



        // LEA ARBEJDER HERFRA ----------
        public List<string> PopulateListbox(List<string> modelname)
        {
            DBR.PopulateListboxes(modelname);
            return modelname;
        }
        public List<string> UpdateSecondListbox(string modelname, List<string> modelnumber)
        {
            DBR.UpdateSecondListBox(modelname, modelnumber);
            return modelnumber;
        }
        public List<string> UpdateThirdListbox(string modelnumber, List<string> demonumber)
        {
            DBR.UpdateThirdListbox(modelnumber, demonumber);
            return demonumber;
        }
        // EditMachine -----
        public string UpdateInformation(string DemoNumber, string ModelName, string ModelNumber, string Brand, string CNumber,
            string MastType, int MastBuildingHeight, int MastLiftHeight, int MastFreeLift, string AggregatType,
            string AggregatNumber, string BatteryType, string BatteryNumber, string ChargerType, string ChargerNumber,
            string Controller, decimal Weight, decimal Height, decimal Length, decimal Width, string oldDemoNumber, string messagebox)
        {
            DBR.UpdatedInformation(DemoNumber, ModelName, ModelNumber, Brand, CNumber, MastType, MastBuildingHeight, MastLiftHeight,
                             MastFreeLift, AggregatType, AggregatNumber, BatteryType, BatteryNumber, ChargerType, ChargerNumber,
                             Controller, Weight, Height, Length, Width, oldDemoNumber, messagebox);
            return messagebox;
        }
        // Edit Booking -----
        public void BeginTransaction()
        {
            DBR.BeginTransaction();
        }
        public void RollBackTransaction()
        {
            DBR.RollBackTransaction();
        }
        public void UpdateBooking(string name1, string name2, string att, string address, string zipCode,
            string city, string phone, string salesRep, string deliveryDate, string retrievalDate, string carrier,
            string messageToWorkshop, string deliveryNote, string loadingPlatform, int bookingID)
        {
            DBR.UpdateBooking(name1, name2, att, address, zipCode, city, phone,
                salesRep, deliveryDate, retrievalDate, carrier, messageToWorkshop, 
                deliveryNote, loadingPlatform, bookingID);
        }

    }
}
