using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto.Clases
{
    class ConexionBBDD
    {
        
        
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=remotemysql.com;database=mPylUpf84I;Uid=mPylUpf84I;pwd=EBA7lZ9lUa");
            conectar.Open();
            
            


            
            return conectar;
        }


       // public static MongoClient client = new MongoClient("mongodb+srv://Pablo_Admin:<Pablo-23>@job-control.ahubh.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");

    }
}
