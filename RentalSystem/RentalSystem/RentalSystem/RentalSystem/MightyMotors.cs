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
        public DataController Controller = new DataController();
        public User CurrentUser { get; set; }
        public MightyMotors(User CurrentUser)
        {
            this.CurrentUser = CurrentUser;
            InitializeComponent();
        }

        private void MightyMotors_Load(object sender, EventArgs e)
        {
            Controller.FillTable(TableView);
        }

        private void AdminSubmitBtn_Click(object sender, EventArgs e)
        {
            int n;
            if (ClearanceKeyBox.Text.ToLower() == "admin")
            {
                if (MakeBox.Text == "" || ModelBox.Text == "" || RegBox.Text == "" || MileageBox.Text == "" || PriceBox.Text == "")
                {
                    MessageBox.Show("Please fill out all boxes before submitting");
                }
                else if(!int.TryParse(MileageBox.Text, out n) || !int.TryParse(PriceBox.Text, out n))
                {
                    MessageBox.Show("Please use correct data types!");
                }
                else
                { 
                    Controller.CreateVehicle(MakeBox.Text, ModelBox.Text, RegBox.Text, int.Parse(MileageBox.Text), int.Parse(PriceBox.Text), GenerateID());
                }
            }
            else
            {
                MessageBox.Show("Clearance Key is Invalid!");
            }
        }

        public int GenerateID()
        {
            Random RNG = new Random();
            string Output = "";
            for(int i = 0; i < 6; i++)
            {
                Output = Output + RNG.Next(0, 9).ToString();
            }
            return int.Parse(Output);
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            Controller.FillTable(TableView);
        }

        private void IDBtn_Click(object sender, EventArgs e)
        {
            int Exception;
            string[] VehicleData = new string[7];
            bool LockOut = false;
            if (RemoveBox.Checked && RemoveKeyBox.Text == "Admin")
            {
                if (int.TryParse(VehicleIDBox.Text, out Exception))
                {
                    Controller.RemoveRow(int.Parse(VehicleIDBox.Text));
                    MessageBox.Show("Admin authorised Vehicle has been removed from the system!");
                }
                else
                {
                    MessageBox.Show("NON INTEGER CHARACTER DETECTED PLEASE TRY AGAIN!");
                }
            }
            else
            if (MoreInfoCheckBox.Checked || RentBox.Checked || ReturnCheckBox.Checked && RemoveBox.Checked == false)
            {
                if (MoreInfoCheckBox.Checked && RentBox.Checked)
                {
                    MessageBox.Show("Please only tick one box");
                }
                else
                {
                    if (int.TryParse(VehicleIDBox.Text, out Exception))
                    {
                        VehicleData = Controller.FetchVehicleData(int.Parse(VehicleIDBox.Text));

                        if (VehicleData != null)
                        {
                            CurrentUser.UserVehicle.SetVehicleData(VehicleData, Controller);
                        }
                        else
                        {
                            MessageBox.Show("The ID Entered is not recognised by our system please try again!");
                            LockOut = true;
                        }
                        if (MoreInfoCheckBox.Checked && !LockOut)
                        {
                            string RentStatus;
                            if (CurrentUser.UserVehicle.CurrentlyRented)
                            {
                                RentStatus = "***THIS VEHICLE IS NOT AVAILABLE FOR RENT AT THIS CURRENT TIME!";
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
