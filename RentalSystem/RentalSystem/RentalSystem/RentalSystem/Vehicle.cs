using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Vehicle
    {
    /*
     Each user holds an instance of a vehicle. For example if a user looks at a vehicle in detail, the information is saved locally so that it does not
    need to be fetched should they decide to rent it. Low level version of using a Cache.
     */
    public int ID;
    public string Make;
    public string Model;
    public int Mileage;
    public double Price;
    public string Registration;
    public bool CurrentlyRented;
    public string RenteeName;


    public void RentVehicle(DataController Controller, string Username) //Rents a vehicle
    {
        CurrentlyRented = Controller.RentVehicle(ID, Username);
    }
    public void SetVehicleData(string[] Info, DataController Controller) //Sets values into an Array
    {
        ID = int.Parse(Info[0]);
        Make = Info[1];
        Model = Info[2];
        Registration = Info[3];
        Mileage = int.Parse(Info[4]);
        Price = int.Parse(Info[6]);
        CurrentlyRented = GetRentalStatus(Controller);
    }

    private bool GetRentalStatus(DataController Controller) //Gets the rental status of a vehicle
    {
        return Controller.CheckRentalStatus(ID);
    }

}

