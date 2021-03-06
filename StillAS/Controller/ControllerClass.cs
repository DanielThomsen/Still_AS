﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using Model;
using System.Data;

namespace Controller
{
    public class DatabaseFactory
    {
        // Singleton pga. dette:
        private static DatabaseFactory df;

        public static DatabaseFactory Df
        {
            get
            {
                if (df == null)
                {
                    df = new DatabaseFactory();
                }
                return df;
            }
        }


        public static IDatabase SelectDatabase()
        {
            // Her vil der kunne vælges hvilken databaser der bruges. Da der kun er én database i øjeblikket er det bare den der retuneres.
            return new DatabaseRepository();
        }
    }
    public class ControllerClass
    {
        private ModelClass MC = new ModelClass();
        private IDatabase DBR = DatabaseFactory.SelectDatabase();

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
        public void AddCustomer(string Name1, string Name2, string Att, string Address, int ZIP, string City, string Country, int Phone)
        {
            DBR.CreateCustomer(Name1, Name2, Att, Address, ZIP, City, Country, Phone);
        }
        public void CreateBooking(string salesRep, string date1, string date2, string Transportør, string MessageForWorkshop, string DeliverNote,
            int Ramp)
        {
            DBR.CreateBooking(salesRep, date1, date2, Transportør, MessageForWorkshop, DeliverNote, Ramp);
        }
        public List<String> DropDownDemoLoad()
        {
            return DBR.DropDownDemo();
        }
        public void CreateBookingLine(string Konfigs)
        {
            DBR.CreateBookingLine(DemoMachines, Konfigs);
            DemoMachines.Clear();
        }
        public string GetConfigs(int BookingID)
        {
            string Config = DBR.GetConfig(BookingID);
            return Config;
        }
        public string GetModelName(string Demo)
        {
            return DBR.GetModelName(Demo);
        }
        public List<string> GetStatus(string address)
        {
            List<string> status = DBR.GetStatus(address);
            return status;
        }
        public int AccessLevel()
        {
            return DBR.GetAccessLevel();
        }
        public string BookingIntSpawner(string Booking)
        {
            string Toint = MC.BooingIntSpawner(Booking);
           return Toint;
        }
        public int Validation(string ID1, string ID2)
        {
            return DBR.LoginValidation(ID1, ID2);
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
        public string TimeNow()
        {
            return MC.ClockNow();
        }
        public string TimeNY()
        {
            return MC.ClockNY();
        }
        //[Krognos slut]

        //Daniels metoder:

        public bool CheckConnection()
        {
            bool checker = DBR.CheckConnection();
            return checker;
        }
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

        public List<int> GetBookingsForCarrier(DateTime d)
        {
            List<int> list = DBR.GetBookingsForCarrier(d);
            return list;
        }

        public List<string> GetDemoNumbersByBooking(int id)
        {
            List<string> list = DBR.GetDemoNumbersByBooking(id);
            return list;
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
        public void UpdateInformation(string DemoNumber, string ModelName, string ModelNumber, string Brand, string CNumber,
            string MastType, int MastBuildingHeight, int MastLiftHeight, int MastFreeLift, string AggregatType,
            string AggregatNumber, string BatteryType, string BatteryNumber, string ChargerType, string ChargerNumber,
            string Controller, decimal Weight, decimal Height, decimal Length, decimal Width, string oldDemoNumber)
        {
            DBR.UpdatedInformation(DemoNumber, ModelName, ModelNumber, Brand, CNumber, MastType, MastBuildingHeight, MastLiftHeight,
                             MastFreeLift, AggregatType, AggregatNumber, BatteryType, BatteryNumber, ChargerType, ChargerNumber,
                             Controller, Weight, Height, Length, Width, oldDemoNumber);
        }
        public void UpdateBooking(string name1, string name2, string att, string address, string zipCode,
            string city, string phone, string country, string salesRep, string deliveryDate, string retrievalDate, 
            string carrier, string messageToWorkshop, string deliveryNote, string loadingPlatform, int bookingID)
        {
            DBR.UpdateBooking(name1, name2, att, address, zipCode, city, phone, country,
                salesRep, deliveryDate, retrievalDate, carrier, messageToWorkshop, 
                deliveryNote, loadingPlatform, bookingID);
        }
        public void AddModelName(string modelname)
        {
            DBR.AddModelName(modelname);
        }
        public void RemoveModelName(string modelname)
        {
            DBR.RemoveModelName(modelname);
        }
        public DataTable GetAllUsers()
        {
            return DBR.GetAllUsers();         
        }
        public void AddUser(string name)
        {
            DBR.AddUser(name);
        }
        public List<string> GetAllSalesRep(List<string> salesRep)
        {
            return DBR.GetAllSalesRep(salesRep);
        }
        public string GetOneSalesRep(int bookingID)
        {
            return DBR.GetOneSalesRep(bookingID);
        }
        public string GetCountry(int bookingID)
        {
            return DBR.GetCountry(bookingID);
        }
        public List<string> GetDates(int bookingID)
        {
            return DBR.GetDates(bookingID);
        }
    }
}
