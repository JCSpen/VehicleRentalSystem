using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Vehicle
    {
    public int ID;
    public string Make;
    public string Model;
    public int Mileage;
    public double Price;
    public string Registration;
    public bool CurrentlyRented;
    public string RenteeName;


    public void RentVehicle(DataController Controller, string Username)
    {
        CurrentlyRented = Controller.RentVehicle(ID, Username);
    }
    public void SetVehicleData(string[] Info, DataController Controller)
    {
        ID = int.Parse(Info[0]);
        Make = Info[1];
        Model = Info[2];
        Registration = Info[3];
        Mileage = int.Parse(Info[4]);
        Price = int.Parse(Info[6]);
        CurrentlyRented = GetRentalStatus(Controller);
    }

    private bool GetRentalStatus(DataController Controller)
    {
        return Controller.CheckRentalStatus(ID);
    }

}

