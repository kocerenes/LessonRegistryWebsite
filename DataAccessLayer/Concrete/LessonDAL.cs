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
    public class LessonDAL
    {
        public List<Lesson> List()
        {
            List<Lesson> lessons = new List<Lesson>();
            SqlCommand command = new SqlCommand("Select * from Lessons", SqlServerDal.sqlServerConnection);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }

            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Lesson lesson = new Lesson();
                lesson.Id = short.Parse(dataReader["ID"].ToString());
                lesson.Name = dataReader["LessonName"].ToString();
                lesson.QuotaMin = byte.Parse(dataReader["QuotaMin"].ToString());
                lesson.QuotaMax = byte.Parse(dataReader["QuotaMax"].ToString());
                lessons.Add(lesson);
            }
            dataReader.Close();
            return lessons;
        }

        public int AddReference(References reference)
        {
            SqlCommand command = new SqlCommand("insert into References (StudenID,LessonID) values (@p1,@p2)",SqlServerDal.sqlServerConnection);
            command.Parameters.AddWithValue("@p1", reference.StudentId);
            command.Parameters.AddWithValue("@p2", reference.LessonId);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            return command.ExecuteNonQuery();
        }
    }
}
