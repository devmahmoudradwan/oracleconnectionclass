using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;

namespace Monday_p
{
    public partial class Form1 : Form
    {
        OracleConnection con = null;
        public Form1()
        {
            this.SetConnection();
            InitializeComponent();
        }
        private void SetConnection()
        {
            String connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            con = new OracleConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            this.required(0);
            string sql = "INSERT INTO STUDENT (ID,FIRSTNAME,LASTNAME,ADDRESS,CITY)" +
                "VALUES(:i_d , :f_name , :l_name , :address , :city)";
            this.AUD(sql, 0);
            insert_btn.Enabled = false;
            update_btn.Enabled = true;
            delete_btn.Enabled = true;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            this.required(2);
            string sql = "DELETE FROM STUDENT " +
                "WHERE ID = :i_d";
            this.AUD(sql, 2);
            this.resetall();
            
        }
        private void resetall()
        {
            id_txt.Text = "";
            f_name_txt.Text = "";
            l_name_txt.Text = "";
            address_txt.Text = "";
            city_txt.Text = "";

            
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            this.required(1);
            string sql = "UPDATE STUDENT SET FIRSTNAME = :f_name , LASTNAME = :l_name , ADDRESS = :address , CITY= :city  WHERE ID = :i_d";
            this.AUD(sql, 1);
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            this.resetall();
            insert_btn.Enabled = true;
        }
        private void AUD (string Sql , int state)
        {
            string msg = "";
            int n = 0 ;
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = Sql;
            cmd.CommandType = CommandType.Text;

            switch (state)
            {
                case 0:
                    msg = "Inserted Successfully !";
                    cmd.Parameters.Add("i_d", OracleDbType.Int32, 2).Value = Int32.Parse(id_txt.Text);
                    cmd.Parameters.Add("f_name", OracleDbType.Varchar2, 25).Value = f_name_txt.Text;
                    cmd.Parameters.Add("l_name", OracleDbType.Varchar2, 25).Value = l_name_txt.Text;
                    cmd.Parameters.Add("address", OracleDbType.Varchar2, 25).Value = address_txt.Text;
                    cmd.Parameters.Add("city", OracleDbType.Varchar2, 25).Value = city_txt.Text;

                    break;
                case 1:
                    msg = "Updated Successfully !";
                    cmd.Parameters.Add("i_d", OracleDbType.Int32, 2).Value = Int32.Parse(id_txt.Text);
                    cmd.Parameters.Add("f_name", OracleDbType.Varchar2, 25).Value = f_name_txt.Text;
                    cmd.Parameters.Add("l_name", OracleDbType.Varchar2, 25).Value = l_name_txt.Text;
                    cmd.Parameters.Add("address", OracleDbType.Varchar2, 25).Value = address_txt.Text;
                    cmd.Parameters.Add("city", OracleDbType.Varchar2, 25).Value = city_txt.Text;

                    break;
                case 2:
                    msg = "Deleted Successfully !";
                    cmd.Parameters.Add("i_d", OracleDbType.Int32, 2).Value = Int32.Parse(id_txt.Text);

                    break;
                
            }
            if(state==0)
            {
               int temp = this.check("SELECT * FROM STUDENT WHERE ID = :i_d");
                if(temp==1)
                {
                    MessageBox.Show("This ID already Exists and can't be duplicated !!");
                }
                else
                {
                    n = cmd.ExecuteNonQuery();
                }
            }
            else
            {
                cmd.ExecuteReader();
            }
            if (n>0)
            {
                MessageBox.Show(msg);
            }
        }
        private void retrieve (string sql)
        {
            string msg = "Retrieved Successfully";
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("i_d", OracleDbType.Int32, 2).Value = Int32.Parse(id_txt.Text);

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            f_name_txt.Text = dr["FIRSTNAME"].ToString();
            l_name_txt.Text = dr["LASTNAME"].ToString();
            address_txt.Text = dr["ADDRESS"].ToString();
            city_txt.Text = dr["CITY"].ToString();

            MessageBox.Show(msg);
        }
        private int check(string sql)
        {
            int temp ;
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("i_d", OracleDbType.Int32, 2).Value = Int32.Parse(id_txt.Text);

            OracleDataReader dr = cmd.ExecuteReader();
             if(dr.Read())
            {
                temp = 1;
               
            }
             else
            {
                temp = 0;
            }
            return temp;


        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            this.required(3);
            string sql = "SELECT * FROM STUDENT WHERE ID = :i_d";
            this.retrieve(sql);
            update_btn.Enabled = true;
            insert_btn.Enabled = false;
            delete_btn.Enabled = true;
            reset_btn.Enabled = true;
        }

        private void check_btn_Click(object sender, EventArgs e)
        {
            this.required(4);

            string sql = "SELECT * FROM STUDENT WHERE ID = :i_d";
            int temp = this.check(sql);
            if(temp==1)
            {
                MessageBox.Show("This ID already Exists !");
            }
            else
            {
                MessageBox.Show("This ID doesn't have any Info !!");

            }
        }
        private void required(int casee)
        {
            string iid = id_txt.Text;
            string firstt = f_name_txt.Text;
            string lastt = l_name_txt.Text;
            string addresss = address_txt.Text;
            string cityy = city_txt.Text;
            switch (casee)
            {
                case 0:
                    if (iid == "" || firstt == "" || lastt=="" || addresss =="" || cityy =="")
                    {
                        MessageBox.Show("Please Fill All Data !");
                    }
                    break;
                case 1:
                    if (iid == "" || firstt == "" || lastt == "" || addresss == "" || cityy == "")
                    {
                        MessageBox.Show("Please Note that Our System require All Data to be filled!");
                    }
                    break;
                case 2:
                    if(iid=="")
                    {
                        MessageBox.Show("Please Enter ID to be deleted !");
                    }
                    break;
                case 3:
                    if (iid == "")
                    {
                        MessageBox.Show("Please Enter ID to be retrieved !");
                    }
                    break;
                case 4:
                    if (iid == "")
                    {
                        MessageBox.Show("Please Enter ID to be checked !");
                    }
                    break;
            }
        }
    }
}
