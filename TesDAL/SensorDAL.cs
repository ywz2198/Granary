using System;
using System.Collections.Generic;
using System.Text;
using Tes.Model;
using System.Data.SqlClient;

namespace Tes.DAL
{
	/// <summary>
	/// SensorDAL��
	/// BY�����˴��������� V1.0
	/// ���ߣ���������
	/// ���ڣ�2017��03��26�� 10:00:27
	/// </summary>
	public class SensorDAL
	{

		/// <summary>
		/// ��ȡ������Ϣ
		/// </summary>
		/// <param name="where">����</param>
		/// <returns>�����</returns>
		public static SqlDataReader GetSensorInfo(string where)
		{
			string sqlStr = "SELECT * FROM Sensor where ";
			if (String.IsNullOrEmpty(where))
			{
				sqlStr += "1=1";
			}
			else
			{
				sqlStr += where;
			}
			SqlDataReader reader = null;
			try
			{
				reader = DBManager.ExecuteQuery(sqlStr);
			}
			catch(Exception ex)
			{
				throw ex;
			}
			return reader;
		}

		/// <summary>
		/// ��ȡ������Ϣ����
		/// </summary>
		/// <returns>List����</returns>
		public static List<SensorInfo> GetSensorInfoList(string where)
		{
			List<SensorInfo> infoList = new List<SensorInfo>();

			SqlDataReader reader = null;
			try
			{
				reader = GetSensorInfo(where);
			}
			catch (Exception)
			{
				throw;
			}

			while (reader.Read())
			{
				SensorInfo info = new SensorInfo();
				info.DataID=int.Parse(reader["DataID"].ToString());
				info.TypeOfSensor=reader["TypeOfSensor"].ToString();
				info.Granary=int.Parse(reader["Granary"].ToString());
				info.Group=int.Parse(reader["Group"].ToString());
				info.Line=int.Parse(reader["Line"].ToString());
				info.Floor=int.Parse(reader["Floor"].ToString());
				info.Data=decimal .Parse(reader["Data"].ToString());
				info.Time=reader["Time"].ToString();
				infoList.Add(info);
			}
			reader.Close();
			return infoList;
		}
        //��ʱ���ȡ����
        public static List<SensorInfo > GetDataByDatetime(DateTime datetime1,DateTime datetime2)
        {
            List<SensorInfo > data = new List<SensorInfo >();
            SqlDataReader reader;
            string date1 = datetime1.ToString();
            string date2 = datetime2.ToString();
            

            string sqlstr ="[Group]=1 and Time BETWEEN CONVERT(datetime,'"+date1+ "',120) and CONVERT(datetime,'"+date2+"',120)";
            try
            {
              reader =  GetSensorInfo(sqlstr);
            }
            
            catch(Exception)
            {
                throw;
            }
            while(reader.Read())
            {
                SensorInfo x = new SensorInfo();
                
                x.DataID = int.Parse(reader["DataID"].ToString());
                x.TypeOfSensor = reader["TypeOfSensor"].ToString();
                x.Granary = int.Parse(reader["Granary"].ToString());
                x.Group = int.Parse(reader["Group"].ToString());
                x.Line = int.Parse(reader["Line"].ToString());
                x.Floor = int.Parse(reader["Floor"].ToString());
                x.Data = decimal.Parse(reader["Data"].ToString());
                x.Time = reader["Time"].ToString();
                
                data.Add(x);
            }
            reader.Close();
            return data;


        }
		/// <summary>
		/// ���� ���� ��ȡһ��ʵ�����
		/// <param name="DataID">����</param>
		/// </summary>
		public static SensorInfo GetSensorInfoById(int DataID)
		{
			string strWhere = "DataID =" + DataID;
			List<SensorInfo> list = GetSensorInfoList(strWhere);
			if (list.Count > 0)
			return list[0];
			return null;
		}

		/// �������
		/// </summary>
		/// <param name="info">���ݱ�ʵ�����</param>
		public static bool AddSensor(SensorInfo info)
		{
			string _TypeOfSensor = info.TypeOfSensor;
			int _Granary = info.Granary;
			int _Group = info.Group;
			int _Line = info.Line;
			int _Floor = info.Floor;
			decimal  _Data = info.Data;
			string _Time = info.Time;

			string sql="INSERT INTO Sensor VALUES (@_TypeOfSensor,@_Granary,@_Group,@_Line,@_Floor,@_Data,@_Time)";
			int rst = DBManager.ExecuteUpdate(sql, new object[] { new SqlParameter("@_TypeOfSensor",_TypeOfSensor),new SqlParameter("@_Granary",_Granary),new SqlParameter("@_Group",_Group),new SqlParameter("@_Line",_Line),new SqlParameter("@_Floor",_Floor),new SqlParameter("@_Data",_Data),new SqlParameter("@_Time",_Time) });
			if(rst>0)
			{ 
				return true;
			}
			else
			{ 
				return false;
			}
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		/// <param name="DataID">����</param>
		/// <returns></returns>
		public static bool DeleteSensorInfo(SensorInfo info)
		{
			bool rst = false;
			string sqlStr = "DELETE FROM Sensor WHERE DataID=" + info.DataID;
			int rows = DBManager.ExecuteUpdate(sqlStr);
			if (rows>0)
			{
				rst = true;
			}
			return rst;
		}

		/// ��������
		/// </summary>
		/// <param name="info">���ݱ�ʵ��</param>
		public static bool UpdateSensorInfo(SensorInfo info)
		{
			string _TypeOfSensor = info.TypeOfSensor;
			int _Granary = info.Granary;
			int _Group = info.Group;
			int _Line = info.Line;
			int _Floor = info.Floor;
			decimal  _Data = info.Data;
			string _Time = info.Time;
			string sql="UPDATE Sensor SET TypeOfSensor=@_TypeOfSensor, Granary=@_Granary, Group=@_Group, Line=@_Line, Floor=@_Floor, Data=@_Data, Time=@_Time  WHERE DataID="+info.DataID;
			int rst = DBManager.ExecuteUpdate(sql, new object[] { new SqlParameter("@_TypeOfSensor",_TypeOfSensor),new SqlParameter("@_Granary",_Granary),new SqlParameter("@_Group",_Group),new SqlParameter("@_Line",_Line),new SqlParameter("@_Floor",_Floor),new SqlParameter("@_Data",_Data),new SqlParameter("@_Time",_Time) });
			if(rst>0)
			{ 
				return true;
			}
			else
			{ 
				return false;
			}
		}
	}
}
