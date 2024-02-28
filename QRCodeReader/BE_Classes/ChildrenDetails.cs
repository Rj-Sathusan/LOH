using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LOH
{
  
    public class ChildrenDetails : DAL.NewDataAccessLayer
    {
        private int id { get; set; }
        private string name { get; set; }
        private string fatherName { get; set; }
        private string motherName { get; set; }
        private int age { get; set; }
        private string gender { get; set; }
        private string indexNo { get; set; }
        private DateTime dateOfBirth { get; set; }
        private string imagePath { get; set; }
        private string address { get; set; }

        public bool Save(string action)
        {
            MySqlParameter[] param = {
            new MySqlParameter("@p_id", MySqlDbType.Int32) { Value = id },
            new MySqlParameter("@p_Name", MySqlDbType.VarChar, 50) { Value = name },
            new MySqlParameter("@p_FatherName", MySqlDbType.VarChar, 50) { Value = fatherName },
            new MySqlParameter("@p_MotherName", MySqlDbType.VarChar, 50) { Value = motherName },
            new MySqlParameter("@p_Age", MySqlDbType.Int32) { Value = age },
            new MySqlParameter("@p_Gender", MySqlDbType.VarChar, 10) { Value = gender },
            new MySqlParameter("@p_IndexNo", MySqlDbType.VarChar, 20) { Value = indexNo },
            new MySqlParameter("@p_DateOfBirth", MySqlDbType.Date) { Value = dateOfBirth },
            new MySqlParameter("@p_ImagePath", MySqlDbType.VarChar, 255) { Value = imagePath },
            new MySqlParameter("@p_adress", MySqlDbType.VarChar, 255) { Value = address }
        };

            switch (action)
            {
                case "save":
                    return run_procedure("InsertChildDetails", action, param);

                case "edit":
                    return run_procedure("UpdateChildDetails", action, param);

                case "delete":
                    return run_procedure("DeleteChildDetails", action, param);

                default:
                    return false;
            }
        }

        public Tuple<int, int> GetAttendanceCountAndTotalDays(string indexNo, int year)
        {
            Tuple<int, int> result = null;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(Configurations.Config.ConnectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("GetAttendanceCountByIndexNoAndYear", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@p_IndexNo", indexNo);
                        command.Parameters.AddWithValue("@p_Year", year);
                        command.Parameters.Add("@p_Count", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                        command.Parameters.Add("@p_TotalDaysCount", MySqlDbType.Int32).Direction = ParameterDirection.Output;

                        command.ExecuteNonQuery();

                        int attendanceCount = Convert.ToInt32(command.Parameters["@p_Count"].Value);
                        int totalDaysCount = Convert.ToInt32(command.Parameters["@p_TotalDaysCount"].Value);

                        result = Tuple.Create(attendanceCount, totalDaysCount);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving data: " + ex.Message, "Error");
            }

            return result;
        }



        public void BindChildrenDetails(DataGridView dgv = null)
        {
            try
            {
                BindGrid(dgv, view_all("GetAllChildDetails"));
            }
            catch { }
        }

        public void BindAttendenceDetails(DataGridView dgv = null)
        {
            try
            {
                BindGrid(dgv, view_all("GetAllAttendence"));
            }
            catch { }
        }


        public ChildrenDetails() { }

        public string RegisterAttendence(string index,DateTime date )
        {
            DataTable dt = new DataTable();
            string name = null;


            MySqlParameter[] param = new MySqlParameter[3];

            param[0] = new MySqlParameter("@p_IndexNo", MySqlDbType.Text);
            param[0].Value = index;
            param[1] = new MySqlParameter("@p_Date", MySqlDbType.Date);
            param[1].Value = date;
            param[2] = new MySqlParameter("@p_Name", MySqlDbType.VarChar, 100);
            param[2].Direction = ParameterDirection.Output; // Specify that it's an output parameter

            if (OpenConnection())
            {
                dt = SelectData("InsertAttendanceWithYear", param);
                // Retrieve the value of the output parameter after executing the stored procedure
                name = param[2].Value.ToString();
                CloseConnection();
            }

            return name;
        }
        public ChildrenDetails(int childId, string childName, string father, string mother, int childAge, string childGender, string index, DateTime dob, string image,string address)
        {
            id = childId;
            name = childName;
            fatherName = father;
            motherName = mother;
            age = childAge;
            gender = childGender;
            indexNo = index;
            dateOfBirth = dob;
            imagePath = image;
            this.address = address;
        }


    }

}
