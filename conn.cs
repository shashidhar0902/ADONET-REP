using System.Data.SqlClient;
class Employee{
  
}
class DBApp{
  
  pulic static void EstConn(){
    string str = @"server=localhost;database=userdb;trusted_connection=true;";
    var conn = new SqlConnection(str);
    conn.Open();
    Console.WriteLine("Connection Established");
  }
  
  public static void CloseConn(){
    conn.Close();
    conn.Dispose();
  }
  pulbic static void Main(string[] args){
    EstConn();
    CloseConn();
    
  }
}
