﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;

namespace Controller
{
    public class ControllerClass
    {
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

        public List<string> GetConfigurations(string demoNr)
        {
            List<string> configurations = DBR.GetConfigurations(demoNr);
            return configurations;
        }

        public List<string> GetAllConfigurations()
        {
            List<string> configurations = DBR.GetAllConfigurations();
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
        // EditMachine
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
    }
}
