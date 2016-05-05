using System;
using System.Text;

namespace Util
{
	/// <summary>
	/// DatabaseInfo ��ժҪ˵����
	/// </summary>
	public class DatabaseInfo
	{
		public DatabaseInfo()
		{
		}

		/// <summary>
		/// ���Խ������ָ�ʽ�����ݿ������ַ���
		/// 1. ��������=(local);���ݿ�����=EDNSM;�û�����=sa;�û�����=123456
		/// 2. Data Source=(local);Initial Catalog=EDNSM;User ID=sa;Password=123456
		/// 3. server=(local);uid=sa;pwd=;
		/// </summary>
		/// <param name="connectionString"></param>
		public DatabaseInfo(string connectionString)
		{
			#region ��������

			this.server = this.GetSubItemValue(connectionString, "��������");
			if (this.server == null)
			{
				this.server = this.GetSubItemValue(connectionString, "Data Source");
			}
			if (this.server == null)
			{
				this.server = this.GetSubItemValue(connectionString, "server");
			}

			#endregion

			#region ���ݿ���

			this.database = this.GetSubItemValue(connectionString, "���ݿ�����");
			if (this.database == null)
			{
				this.database = this.GetSubItemValue(connectionString, "Initial Catalog");
			}
			if (this.database == null)
			{
				this.database = this.GetSubItemValue(connectionString, "database");
			}

			#endregion

			#region �û�����

			this.userID = this.GetSubItemValue(connectionString, "�û�����");
			if (this.userID == null)
			{
				this.userID = this.GetSubItemValue(connectionString, "User ID");
			}
			if (this.userID == null)
			{
				this.userID = this.GetSubItemValue(connectionString, "uid");
			}

			#endregion

			#region �û�����

			this.password = this.GetSubItemValue(connectionString, "�û�����");
			if (this.password == null)
			{
				this.password = this.GetSubItemValue(connectionString, "Password");
			}
			if (this.password == null)
			{
				this.password = this.GetSubItemValue(connectionString, "pwd");
			}

			#endregion
		}

		#region ����������

		public string Server
		{
			get { return server; }
			set { this.server = value; }
		}

		public string Database
		{
			get { return database; }
			set { this.database = value; }
		}

		public string UserId
		{
			get { return userID; }
			set { this.userID = value; }
		}

		public string Password
		{
			get { return password; }
			set { this.password = value; }
		}

		private string server;
		private string database;
		private string userID;
		private string password;

		#endregion

		/// <summary>
		/// ���ܺ�������ַ���
		/// </summary>
		public string EncryptConnectionString
		{
			get { return EncodeBase64(this.ConnectionString); }
		}


		/// <summary>
		/// û�м��ܵ��ַ���
		/// </summary>
		public string ConnectionString
		{
			get
			{
                string connString = "";
                if (!string.IsNullOrEmpty(UserId) && !string.IsNullOrEmpty(Password))
                {
                    connString = string.Format("Persist Security Info=False;Data Source={0};Initial Catalog={1};User ID={2};Password={3};Packet Size=4096;Pooling=true;Max Pool Size=100;Min Pool Size=1",
                                                  this.server, this.database, this.userID, this.password);
                }
                else
                {
                    connString = string.Format("Persist Security Info=False;Data Source={0};Initial Catalog={1};Integrated Security=SSPI;Packet Size=4096;Pooling=true;Max Pool Size=100;Min Pool Size=1",
                                                  this.server, this.database);
                }
				return connString;
			}
		}

		/// <summary>
		/// �ṩOLEDB����Դ�������ַ���
		/// </summary>
		public string OleDbConnectionString
		{
			get
			{
				string connectionPrefix = "Driver={SQL Server};";
				return connectionPrefix + this.ConnectionString;
			}
		}

		#region ��������

		/// <summary>
		/// ��ȡ�����ַ����е��ӽڵ��ֵ, ��������ڷ���Null
		/// </summary>
		/// <param name="itemValueString">���ֵ���ַ���</param>
		/// <param name="subKeyName"></param>
		/// <returns></returns>
		private string GetSubItemValue(string itemValueString, string subKeyName)
		{
			string[] item = itemValueString.Split(new char[] {';'});
			for (int i = 0; i < item.Length; i++)
			{
				string itemValue = item[i].ToLower();
				if (itemValue.IndexOf(subKeyName.ToLower()) >= 0) //�������ָ���Ĺؼ���
				{
					int startIndex = item[i].IndexOf("="); //�Ⱥſ�ʼ��λ��
					return item[i].Substring(startIndex + 1); //��ȡ�Ⱥź����ֵ��ΪValue
				}
			}
			return null;
		}


		private string EncodeBase64(string source)
		{
			byte[] buffer1 = Encoding.UTF8.GetBytes(source);
			return Convert.ToBase64String(buffer1, 0, buffer1.Length);
		}

		#endregion
	}
}