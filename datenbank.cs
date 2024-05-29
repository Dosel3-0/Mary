using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    public class Datenbank
    {
        private MySqlConnection con;

        public Datenbank()
        {
            string conStr = "SERVER=localhost;DATABASE=mitarbeiter;"+
                "UID=root;PASSWORD=''";
            con = new MySqlConnection(conStr);

        }

        private void oeffnen()
        {
            try
            {
                con.Open();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }    
        }


        private void schliessen()
        {
            if(con != null) { con.Close(); }
        }

        public List<Kontinent> getKontinente()
        {
            List<Kontinent> liKo = new List<Kontinent>();
            oeffnen();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM spirits;";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                liKo.Add(
                    new Kontinent(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                        dr.IsDBNull(1) ? "" : dr.GetString(1),
                        dr.IsDBNull(2) ? "" : dr.GetString(2),
                        dr.IsDBNull(3) ? "" : dr.GetString(3)
                        )
                    ); 
            }
            dr.Close();
            schliessen();
            return liKo;
        }
    
        public void saveKontinent(int knr, string kname)
        {
            oeffnen();
            MySqlCommand cmd = con.CreateCommand();
            string s = string.Format("update spirits" +
                "set spiritname = {0}" +
                "where spiritnr = {1};", 
                kname, knr);
            cmd.CommandText = s;
            cmd.ExecuteNonQuery();
            schliessen();
            
        }
    }
}
