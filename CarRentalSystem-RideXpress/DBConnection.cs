using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem_RideXpress
{
    public static class DBConnection
    {
        public static readonly string ConnectionString =
           // @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gamik\OneDrive\Documents\RideXpress.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false";
            "Data Source=GAMIKA\\SQLEXPRESS;Initial Catalog=RideXpress;Integrated Security = True"; 
    }
}
