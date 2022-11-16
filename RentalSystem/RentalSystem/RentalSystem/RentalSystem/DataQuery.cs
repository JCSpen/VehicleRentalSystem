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
        Query = CurrentQuery;
    }

    protected void ExecuteQuery()
    {
        OleDbCommand Command = new OleDbCommand(DataSource);
        Connection.Open();
        Command.CommandText = Query;
        Command.Connection = Connection;
        Command.CommandType = CommandType.Text;
        try
        {
            QueryResult = (string?)Command.ExecuteScalar();
        }
        catch
        {
            QueryResultException = (int?)Command.ExecuteScalar();
        }
        Connection.Close();
    }

    public void NonQuery()
    {
        OleDbCommand Command = new OleDbCommand(DataSource);
        Connection.Open();
        Command.CommandText = Query;
        Command.Connection = Connection;
        Command.CommandType = CommandType.Text;
        Command.ExecuteNonQuery();
        Connection.Close();
    }
    public string GetResult()
    {
        ExecuteQuery();
        if (QueryResult != null)
            return QueryResult;
        else if(QueryResultException != null)
            return QueryResultException.ToString();
        else
            return "0";
        
    }
   
   
}


