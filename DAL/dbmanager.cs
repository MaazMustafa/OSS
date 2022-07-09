using System;
using System.Collections.Generics
using System.Data;
using MySql.Data.MySqlClient;

namespance DAL{
public class DBManager{

  public static string conString="server=localhost, database='actsdb'";
  public static List<Customer> GetAll(){
  
    List<Customer> customers=new List<Customer>();
    MySqlConnection con=new MySqlConnection(conString);
    string query="SELECT * from customers";
    MySqlCommand cmd=new MySqlCommand(query, con);
    try{
      MySqlDataAdapter da=new MySqlDataAdapter(cmd);
      da.Fill(ds);
      DataTable dt=ds.Tables[0];
      DataRowCollection rows=dt.Rows;
      foreach(DataRow row in rows){
        Customer cst=new Customer();
        cst.Id=int.Parse(row["Id"].ToString());
        cst.FirstName=row["FirstName"].ToString();

        customers.Add(cst);
      }
   
    }
    catch(Exception ee)
    {
    
    }


  }

}
