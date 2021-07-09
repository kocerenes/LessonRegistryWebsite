using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class StudentDAL
    {
        public bool Add(Student student)
        {
            SqlCommand command = new SqlCommand("insert into Students (Name,Surname,Number,Photo,Password,Balance) values (@p1,@p2,@p3,@p4,@p5,@p6)", SqlServerDal.sqlServerConnection);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }

            command.Parameters.AddWithValue("@p1", student.Name);
            command.Parameters.AddWithValue("@p2", student.Surname);
            command.Parameters.AddWithValue("@p3", student.Number);
            command.Parameters.AddWithValue("@p4", student.Photo);
            command.Parameters.AddWithValue("@p5", student.Password);
            command.Parameters.AddWithValue("@p6", student.Balance);

            return command.ExecuteNonQuery()>0;
        }

        public List<Student> List()
        {
            List<Student> students = new List<Student>();
            SqlCommand command = new SqlCommand("Select * from Students", SqlServerDal.sqlServerConnection);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }

            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Student student = new Student();
                student.Id = Convert.ToInt32(dataReader["ID"].ToString());
                student.Name = dataReader["Name"].ToString();
                student.Surname= dataReader["Surname"].ToString();
                student.Number = dataReader["Number"].ToString();
                student.Photo = dataReader["Photo"].ToString();
                student.Password = dataReader["Password"].ToString();
                student.Balance = Convert.ToDecimal(dataReader["Balance"].ToString());
                students.Add(student);
            }
            dataReader.Close();
            return students;
        }

        public bool Delete(int id)
        {
            SqlCommand command = new SqlCommand("Delete from Students where Id=@p1", SqlServerDal.sqlServerConnection);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            command.Parameters.AddWithValue("@p1", id);
            return command.ExecuteNonQuery() > 0;
        }

        public List<Student> ListById(int id)
        {
            List<Student> students = new List<Student>();
            SqlCommand command = new SqlCommand("Select * from Students where ID=@p1", SqlServerDal.sqlServerConnection);
            command.Parameters.AddWithValue("@p1", id);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Student student = new Student();
                student.Name = dataReader["Name"].ToString();
                student.Surname = dataReader["Surname"].ToString();
                student.Number = dataReader["Number"].ToString();
                student.Photo= dataReader["Photo"].ToString();
                student.Password = dataReader["Password"].ToString();
                student.Balance = Convert.ToDecimal(dataReader["Balance"].ToString());
                students.Add(student);
            }
            dataReader.Close();
            return students;
        }

        public bool StudentUpdate(Student student)
        {
            SqlCommand command = new SqlCommand("Update Students set Name=@p1,Surname=@p2,Number=@p3,Photo=@p4,Password=@p5,Balance=@p6 where ID=@p7", SqlServerDal.sqlServerConnection);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            command.Parameters.AddWithValue("@p1", student.Name);
            command.Parameters.AddWithValue("@p2", student.Surname);
            command.Parameters.AddWithValue("@p3", student.Number);
            command.Parameters.AddWithValue("@p4", student.Photo);
            command.Parameters.AddWithValue("@p5", student.Password);
            command.Parameters.AddWithValue("@p6", student.Balance);
            command.Parameters.AddWithValue("@p7", student.Id);
            return command.ExecuteNonQuery() > 0;
        }

    }
}
