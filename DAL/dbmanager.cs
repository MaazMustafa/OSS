using System;
using System.Collections.Generics
using System.Data;
using MySql.Data.MySqlClient;

namespance DAL{
public class DBManager{

  public static string conString="server=localhost, database='actsdb'";
  public static List<Customer> GetAll(){
  
    MySqlConnection con=new MySqlConnection(conString);
    string query="SELECT * from customers";
    MySqlCommand cmd=new MySqlCommand(query, con);
    try{
      MySqlDataAdapter da=new MySqlDataAdapter(cmd);
      da.Fill(ds);
   
    }
    catch(Exception ee)
    {
    
    }


  }

}
