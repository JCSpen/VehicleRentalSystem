using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class DataQuery : DataController
{
    protected string? QueryResult;
    protected int? QueryResultException;
    protected string Query;
    public DataQuery(string CurrentQuery)
    {
        Query = CurrentQuery; //Query passed as parameters
    }

    protected void ExecuteQuery() //Used for value related searches
    {
        OleDbCommand Command = GetCommand();
        try
        {
            QueryResult = (string?)Command.ExecuteScalar(); //If null or non string, catch clause is activated
        }
        catch
        {
            QueryResultException = (int?)Command.ExecuteScalar(); //If still null error stance is returned (SEE BELOW)
        }
        Connection.Close();
    }

    private OleDbCommand GetCommand() //Creates the SQL command and returns it
    {
        OleDbCommand Command = new OleDbCommand(DataSource);
        Connection.Open();
        Command.CommandText = Query;
        Command.Connection = Connection;
        Command.CommandType = CommandType.Text;
        return Command;
    }

    public void NonQuery() //Used for INSERT, UPDATE AND DELETE 
    {
        OleDbCommand Command = GetCommand();
        Command.ExecuteNonQuery();
        Connection.Close();
    }
    public string GetResult() //Returns query results
    {
        ExecuteQuery();
        if (QueryResult != null)
            return QueryResult; //String
        else if(QueryResultException != null)
            return QueryResultException.ToString(); //Int
        else
            return "0"; //Error thrown, value doesn't exist
        
    }
   
   
}


