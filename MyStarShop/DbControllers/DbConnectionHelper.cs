using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
using MyStarShop.DbControllers.Products;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStarShop.DbControllers;

public class DbConnectionHelper : IDisposable
{
    SqlConnection connection;
    public DbConnectionHelper()
    {

    }

    private SqlConnection OpenConnecting()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
        connection = new SqlConnection(connectionString);
        connection.Open();
        return connection;
    }
    public List<TableType> DbShowList<TableType>(string query)  //Buraya kontrol yazılabilir.
    {

       return OpenConnecting().Query<TableType>(query).ToList();
    }

    public int DbDataCount(string query)
    {
        return OpenConnecting().QuerySingle<int>(query);
    }

    public void Dispose()
    {
        connection.Close();
        connection.Dispose();
        Debug.WriteLine("Bağlantılar Kapandı");
    }
}

