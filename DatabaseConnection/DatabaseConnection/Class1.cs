using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Windows.Forms;


namespace DatabaseConnection
{
    class Class1
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-5932C9I;Initial Catalog=master;Integrated Security=True");
        SqlCommand cmd;
        SqlCommandBuilder cmdb;
        SqlDataAdapter adpt;
        DataSet ds;
        public int add_data(int PrnNo, string fName, string lName, int Age, float AttendancePercentage, string Gender, string feesPaid)
        {
            if (Age > 18)
            {
                string str = "INSERT INTO student_table VALUES (@PrnNo, @fName, @lName, @Age, @AttendancePercentage, @Gender, @feesPaid)";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@PrnNo", PrnNo);
                cmd.Parameters.AddWithValue("@fName", fName);
                cmd.Parameters.AddWithValue("@lName", lName);
                cmd.Parameters.AddWithValue("@Age", Age);
                cmd.Parameters.AddWithValue("@AttendancePercentage", AttendancePercentage);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@feesPaid", feesPaid);
                con.Open();
                int no = cmd.ExecuteNonQuery();
                con.Close();
                return no;
            }
            else
            {
                MessageBox.Show("Age must be greater than 18.");
                return 0;
            }
        }


        public DataSet show_data()
        {
            string str = "select * from student_table";
            adpt = new SqlDataAdapter(str, con);
            cmdb = new SqlCommandBuilder(adpt);
            ds = new DataSet();
            adpt.Fill(ds);
            return (ds);
        }
        
        public int update_data(int PrnNo, string fName, string lName, int Age, float AttendancePercentage, string Gender, string feesPaid)
        {
            string str = "update student_table set fName ='" + fName + "',lName='" + lName + "',age="+Age+ ",AttendancePercentage="+ AttendancePercentage+",Gender='"+Gender+"',feesPaid='"+feesPaid+"' where PrnNo =" + PrnNo;
            cmd = new SqlCommand(str, con);
            con.Open();
            int no = cmd.ExecuteNonQuery();
            con.Close();
            return (no);

        }
        public DataSet show_id_data(int PrnNo)
        {
            string str = "select * from student_table where PrnNo='" + PrnNo + "'";
            adpt = new SqlDataAdapter(str, con);
            cmdb = new SqlCommandBuilder(adpt);
            ds = new DataSet();
            adpt.Fill(ds);
            return (ds);
        }
        
        public int delete_data(int PrnNo)
        {
            string str = "delete from student_table where PrnNo='" + PrnNo+"'";
            con.Open();
            cmd = new SqlCommand(str, con);
            int no = cmd.ExecuteNonQuery();
            con.Close();
            return no;
        }

        public int add_data_register( string username, string password)
        {
            //insert into GUI values(1001,'fgf','hdfhjdgf');
            string str = "insert into registered values('" + username + "','" + password + "')";
            cmd = new SqlCommand(str, con);
            con.Open();
            int no = cmd.ExecuteNonQuery();
            con.Close();
            return (no);
        }

        public bool check_login(string username, string password)
        {
            string str = "SELECT COUNT(*) from registered WHERE Username = @username and password=@password";
            int count = 0;

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-5932C9I;Initial Catalog=master;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(str, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    // Execute the query and retrieve the result
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Check if there are any rows returned
                        if (reader.Read())
                        {
                            // Retrieve the count from the first column of the first row
                            count = reader.GetInt32(0);
                        }
                    }
                }
            }

            // If count is greater than 0, login is successful; otherwise, login failed
            return count > 0;

        }
        public int show_id()
        {
            
            //con.Open();
            string str = "select MAX (PrnNo) from student_table ";
            cmd = new SqlCommand(str, con);
            con.Open();
            object result = cmd.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                int no = Convert.ToInt32(result);
                con.Close();
                return no;
            }
            else
            {
                // Handle the case where no value is returned, such as returning a default value or throwing an exception.
                con.Close();
                // For example, you could return a default value like -1
                return -1;
            }


        }
        public int add(int PrnNo, string fname, string phoneNo)
        {
            if (phoneNo.Length ==10)
            {
                string str = "INSERT INTO stud VALUES (@PrnNo, @fname, @phoneNo)";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@PrnNo", PrnNo);
                cmd.Parameters.AddWithValue("@fName", fname);
                cmd.Parameters.AddWithValue("@phoneNo", phoneNo);
                
                con.Open();
                int no = cmd.ExecuteNonQuery();
                con.Close();
                return no;
            }
            else
            {
                MessageBox.Show("phone number must be valid .");
                return 0;
            }
        }
    }
}
