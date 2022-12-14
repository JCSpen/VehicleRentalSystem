using Microsoft.IdentityModel.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalSystem
{
    public partial class MightyMotors : Form
    {
        //Data Controlling Class
        public DataController Controller = new DataController();
        //Local instance of the User
        public User CurrentUser { get; set; }
        public MightyMotors(User CurrentUser)
        {
            this.CurrentUser = CurrentUser;
            InitializeComponent();
        }

        private void MightyMotors_Load(object sender, EventArgs e)
        {
            //Displays all Vehicles in the database
            Controller.FillTable(TableView);
        }

        private void AdminSubmitBtn_Click(object sender, EventArgs e)
        {
            int n;
            if (ClearanceKeyBox.Text.ToLower() == "admin") //Checks for admin key
            {
                if (MakeBox.Text == "" || ModelBox.Text == "" || RegBox.Text == "" || MileageBox.Text == "" || PriceBox.Text == "") //Makes sure boxes aren't empty
                {
                    MessageBox.Show("Please fill out all boxes before submitting");
                }
                else if(!int.TryParse(MileageBox.Text, out n) || !int.TryParse(PriceBox.Text, out n)) //Makes sure correct data types are used
                {
                    MessageBox.Show("Please use correct data types!");
                }
                else
                { 
                    Controller.CreateVehicle(MakeBox.Text, ModelBox.Text, RegBox.Text, int.Parse(MileageBox.Text), int.Parse(PriceBox.Text), GenerateID()); //Creates new vehicle
                }
            }
            else
            {
                MessageBox.Show("Clearance Key is Invalid!"); //Flags incorrect admin key
            }
        }

        public int GenerateID() //Randomly generates a new ID number
        {
            Random RNG = new Random();
            string Output = "";
            for(int i = 0; i < 6; i++)
            {
                Output = Output + RNG.Next(0, 9).ToString();
            }
            return int.Parse(Output); //Returns the generated ID number
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            Controller.FillTable(TableView); //Refreshes the table
        }

        private void IDBtn_Click(object sender, EventArgs e)
        {
            int Exception;
            string[] VehicleData = new string[7];
            bool LockOut = false;
            if (RemoveBox.Checked && RemoveKeyBox.Text == "Admin") //Checks for admin key
            {
                if (int.TryParse(VehicleIDBox.Text, out Exception)) //Checks if ID box has an integer input
                {
                    Controller.RemoveRow(int.Parse(VehicleIDBox.Text)); //Removes Vehicle from the System
                    MessageBox.Show("Admin authorised Vehicle has been removed from the system!");
                }
                else
                {
                    MessageBox.Show("NON INTEGER CHARACTER DETECTED PLEASE TRY AGAIN!"); //Flags incorrect data types
                }
            }
            else
            if (MoreInfoCheckBox.Checked || RentBox.Checked || ReturnCheckBox.Checked && RemoveBox.Checked == false) 
            {
                if (MoreInfoCheckBox.Checked && RentBox.Checked) //Ensures more than one box is not ticked
                {
                    MessageBox.Show("Please only tick one box");
                }
                else
                {
                    if (int.TryParse(VehicleIDBox.Text, out Exception)) //Ensures integer valye
                    {
                        VehicleData = Controller.FetchVehicleData(int.Parse(VehicleIDBox.Text));

                        if (VehicleData != null) //Checks if vehicle searched exists
                        {
                            CurrentUser.UserVehicle.SetVehicleData(VehicleData, Controller);
                        }
                        else
                        {
                            MessageBox.Show("The ID Entered is not recognised by our system please try again!"); //Flags non existent vehicles
                            LockOut = true;
                        }
                        if (MoreInfoCheckBox.Checked && !LockOut)
                        {
                            string RentStatus;
                            if (CurrentUser.UserVehicle.CurrentlyRented)
                            {
                                RentStatus = "***THIS VEHICLE IS NOT AVAILABLE FOR RENT AT THIS CURRENT TIME!"; //Shows if vehicle is available
                            }
                            else
                            {
                                RentStatus = "This Vehicle is currently available!";
                            }
                            MessageBox.Show(RentStatus + "\n" + "Vehicle ID: " + CurrentUser.UserVehicle.ID + "\n" + "Vehicle Make: " + CurrentUser.UserVehicle.Make + "\n" + "Vehicle Model: " + CurrentUser.UserVehicle.Model + "\n" + "Vehicle Mileage: " + CurrentUser.UserVehicle.Mileage + "\n" + "Price to rent per week (£): " + CurrentUser.UserVehicle.Price + "\n" + "Vehicle Registration: " + CurrentUser.UserVehicle.Registration + "\n");
                        }
                        else if(ReturnCheckBox.Checked && !LockOut)
                        {
                            bool CurrentRentee = Controller.ReturnVehicle(int.Parse(VehicleIDBox.Text),CurrentUser.Username);
                            if (CurrentRentee)
                            { 
                                MessageBox.Show("Thank you for returning this vehicle!");
                            }
                            else
                            {
                                MessageBox.Show("You are not currently renting this vehicle!");
                            }
                        }
                        else
                        {
                            CurrentUser.UserVehicle.RentVehicle(Controller, CurrentUser.Username);
                        }
                    }
                    else
                    {
                        MessageBox.Show("NON INTEGER CHARACTER DETECTED PLEASE TRY AGAIN!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please tick one of the selection boxes");
            }
        }
    }
}
