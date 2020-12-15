using Android.App;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;


namespace App02_xamarin
{
    public class Conexao
    {
        //public static string conec = "SERVER=localhost;port=3306;User Id=root;database=db_cyberlab; password=";
        
       MySqlConnection con = new MySqlConnection();

        public MySqlCommand AbriCon()
        {
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = @"server=softkleen.com.br;user id=fcincoon;database=fcincoon;port=3306;password=bm*5rN60";
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
                cmd.Connection = con;
            }
            return cmd;


        }

        public void FecharCon(MySqlConnection conn)
        {
            try
            {
                if (conn.State ==  System.Data.ConnectionState.Open)
                conn.Close();
            }
            catch (Exception ex)
            {

                Toast.MakeText(Application.Context, "Erro ao fechar" + ex, ToastLength.Long).Show();
            }

        }
    }

    
}
