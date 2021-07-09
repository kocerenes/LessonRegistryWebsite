using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class SqlServerDal
    {
         public static SqlConnection sqlServerConnection = new SqlConnection(@"Data Source=DESKTOP-74SU5I6\SQLEXPRESS;Initial Catalog=LessonRegistry;Integrated Security=True");
    }
}
