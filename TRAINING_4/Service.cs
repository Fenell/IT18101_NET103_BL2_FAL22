using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAINING_4
{
    internal class Service
    {
        private SqlCommand _cmd;
        SqlDataAdapter _adapter;
        private DataTable _dt;
        Company _company;
        private readonly string _stringcnn =
            @"Data Source=DESKTOP-CFK23F4\SQLEXPRESS;Initial Catalog=CompanyService;Integrated Security=True";

        public Service()
        {
            GetAllPerson();
        }

        public DataTable GetAllPerson()
        {
            using (var _conn = new SqlConnection(_stringcnn))
            {
                _conn.Open();
                string query = "SELECT * FROM PERSON";
                _dt = new DataTable();
                _cmd = new SqlCommand(query, _conn);
                _adapter = new SqlDataAdapter(_cmd);
                _adapter.Fill(_dt);
            }

            return _dt;
        }

        public List<Company> DtToList()
        {
            DataTable dt = new DataTable();
            List<Company> list = new List<Company>();
            dt = GetAllPerson();
            //dt.Columns.Add("Name", typeof(string));
            //dt.Columns.Add("Giới tính", typeof(string));
            //dt.Columns.Add("Ngày sinh", typeof(DateTime));
            //dt.Columns.Add("Địa chỉ", typeof(string));
            //dt.Columns.Add("Số điện thoại", typeof(string));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                _company = new Company();
                _company.Name = dt.Rows[i]["NAME"].ToString();
                _company.Sex = Convert.ToInt32(dt.Rows[i]["SEX"]);
                _company.DayOfBirth = Convert.ToDateTime(dt.Rows[i]["BIRTH"]);
                _company.Address = dt.Rows[i]["ADDRESS"].ToString();
                _company.Phone = dt.Rows[i]["PHONE"].ToString();
                list.Add(_company);
            }

            return list;
        }

        public bool IsAdd(Company company)
        {
            try
            {
                using (var conn = new SqlConnection(_stringcnn))
                {
                    conn.Open();
                    string query = "INSERT INTO PERSON VALUES (@id ,@name, @sex, @birth,@address, @phone)";
                    _cmd = new SqlCommand(query, conn);
                    _cmd.Parameters.AddWithValue("@id", company.Id);
                    _cmd.Parameters.AddWithValue("@name", company.Name);
                    _cmd.Parameters.AddWithValue("@sex", company.Sex);
                    _cmd.Parameters.AddWithValue("@birth", company.DayOfBirth);
                    _cmd.Parameters.AddWithValue("@address", company.Address);
                    _cmd.Parameters.AddWithValue("@phone", company.Phone);
                    _cmd.ExecuteNonQuery();
                }

            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }



    }
}
