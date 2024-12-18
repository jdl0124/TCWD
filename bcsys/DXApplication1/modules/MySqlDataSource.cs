using DevExpress.DataAccess.ConnectionParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DataAccess;
using MySql.Data.MySqlClient;
using System.Web.UI.WebControls;
using DevExpress.Xpo.Helpers;


namespace bcsys.modules
{
	//internal class MySqlDataSource
	//{

	//}

	public class MySqlDataSource : SqlDataSource
	{
		public MySqlDataSource()
		{
			//ConnectionParameter = new MySqlConnectionParameters
			//{
			//	ServerName = "localhost",
			//	DatabaseName = "bcdb",
			//	UserName = "root",
			//	Password = ""
			//};
		}
	}

}
