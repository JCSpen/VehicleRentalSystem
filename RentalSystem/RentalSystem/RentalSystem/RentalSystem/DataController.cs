using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;
using System.Drawing;
using System.Collections;
using Microsoft.VisualBasic.ApplicationServices;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

public class DataController
{
    protected static string DataSource = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + Application.StartupPath + @"\MightyMotorsDB.accdb";
    protected DataTable Table = new DataTable();
    protected OleDbConnection Connection = new OleDbConnection(DataSource);
    public void CreateUser(string Username, string Password, string FirstName, string LastName, string Insurance, int ID)
    {
        ExecuteNonQueryType("INSERT INTO Users([ID],Username,[Password],FirstName,LastName,InsuranceProvider) VALUES(" + ID + ",'" + Username + "','" + Password + "','" + FirstName + "','" + LastName + "','" + Insurance + "');");
    }

    public void CreateVehicle(string Make, string Model, string Reg, int Mileage, double Price, int ID)
    {
        ExecuteNonQueryType("INSERT INTO Vehicle([ID],Make,Model,Registration,Mileage,Price,CurrentRentee) VALUES(" + ID + ",'" + Make + "','" + Model + "','" + Reg + "'," + Mileage + "," + Price + ",'None');");
    }

    public int FindUserID(string Username, string Password)
    {
        return int.Parse(ExecuteNewQuery("SELECT ID FROM Users WHERE(Username = '" + Username + "' AND [Password] = '" + Password + "');"));
    }

    public string FindFirstname(int ID)
    {
        return ExecuteNewQuery("SELECT Firstname FROM Users WHERE(ID = " + ID + ");");
    }

    public string FindLastname(int ID)
    {
        return ExecuteNewQuery("SELECT Lastname FROM Users WHERE(ID = " + ID + ");");
    }
    public string FindInsuraceInfo(int ID)
    {
        return ExecuteNewQuery("SELECT InsuranceProvider FROM Users WHERE(ID = " + ID.ToString() + ");");
    }
    public string ExecuteNewQuery(string Query)
    {
        DataQuery NewQuery = new DataQuery(Query);
        return NewQuery.GetResult();
    }

    public void ExecuteNonQueryType(string Query)
    {
        DataQuery NewQuery = new DataQuery(Query);
        NewQuery.NonQuery();
    }

    public string FindVehicleID(int ID)
    {
        return ExecuteNewQuery("SELECT ID FROM Vehicle WHERE(ID = " + ID + ");");
    }
    public void FillTable(DataGridView ListingViewer)
    {
        Table.Clear();
        if (ListingViewer != null)
        {
            Table.Clear();
            ListingViewer.DataSource = null;
        }
        string query = "SELECT * FROM Vehicle";
        Connection.Open();
        OleDbCommand Command = new OleDbCommand(query, Connection);
        OleDbDataAdapter Adapter = new OleDbDataAdapter(Command);
        Adapter.Fill(Table);
        ListingViewer.DataSource = Table;
        Connection.Close();
    }

    public string[] FetchVehicleData(int ID)
    {
        string query = "SELECT * FROM Vehicle WHERE(ID = " + ID + ");";
        if (FindVehicleID(ID) != "0")
        {
            string[] Contents = new string[Table.Columns.Count];
            Table.Clear();
            Connection.Open();
            OleDbCommand Command = new OleDbCommand(query, Connection);
            OleDbDataAdapter Adapter = new OleDbDataAdapter(Command);
            Adapter.Fill(Table);
            for (int i = 0; i < Table.Columns.Count; i++)
            {
                Contents[i] = Table.Rows[0][i].ToString();
            }
            Connection.Close();
            return Contents;
        }
        return null;
    }

    public bool RentVehicle(int ID, string Username)
    {
        ExecuteNonQueryType("UPDATE Vehicle SET CurrentRentee = '" + Username + "' WHERE ID = " + ID + ";");
        return true;
    }

    public bool ReturnVehicle(int ID, string Username)
    {
        if (FindVehicleID(ID) != "0" && Username == FindRentee(ID))
        {
            ExecuteNonQueryType("UPDATE Vehicle SET CurrentRentee = 'None' WHERE ID = " + ID + ";");
            return true;
        }
        return false;
    }

    public string FindRentee(int ID)
    {
        return ExecuteNewQuery("SELECT CurrentRentee FROM Vehicle WHERE (ID = " + ID + ");");
    }

    public bool CheckRentalStatus(int ID)
    {
        string result = ExecuteNewQuery("SELECT CurrentRentee FROM Vehicle WHERE(ID = " + ID + ");");
        if (result != "None")
        {
            return true;
        }
        return false;
    }

    public void RemoveRow(int ID)
    {
        ExecuteNonQueryType("DELETE FROM Vehicle WHERE(ID = " + ID + ");");
    }
}


   





