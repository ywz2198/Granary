using System;
using System.Collections.Generic;
using System.Text;
using Tes.Model;
using System.Data.SqlClient;

namespace Tes.DAL
{
	/// <summary>
	/// StorageDAL��
	/// BY�����˴��������� V1.0
	/// ���ߣ���������
	/// ���ڣ�2017��03��26�� 01:19:59
	/// </summary>
	public class StorageDAL
	{

		/// <summary>
		/// ��ȡ������Ϣ
		/// </summary>
		/// <param name="where">����</param>
		/// <returns>�����</returns>
		public static SqlDataReader GetStorageInfo(string where)
		{
			string sqlStr = "SELECT * FROM Storage where ";
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
		public static List<StorageInfo> GetStorageInfoList(string where)
		{
			List<StorageInfo> infoList = new List<StorageInfo>();

			SqlDataReader reader = null;
			try
			{
				reader = GetStorageInfo(where);
			}
			catch (Exception)
			{
				throw;
			}

			while (reader.Read())
			{
				StorageInfo info = new StorageInfo();
				info.GrainID=int.Parse(reader["GrainID"].ToString());
				info.KindOfGrain=reader["KindOfGrain"].ToString();
				info.Keeper=reader["Keeper"].ToString();
				info.Storage=reader["Storage"].ToString();
				info.Out=reader["Out"].ToString();
				info.Weight=int.Parse(reader["Weight"].ToString());
				info.Water=float.Parse(reader["Water"].ToString());
				info.Dirt=float.Parse(reader["Dirt"].ToString());
				info.Incomplete=float.Parse(reader["Incomplete"].ToString());
				info.Property=reader["Property"].ToString();
				info.Level=reader["Level"].ToString();
				info.Info=reader["Info"].ToString();
				info.GrowingPlace=reader["GrowingPlace"].ToString();
				info.Other=reader["Other"].ToString();
				infoList.Add(info);
			}
			reader.Close();
			return infoList;
		}

		/// <summary>
		/// ���� ���� ��ȡһ��ʵ�����
		/// <param name="GrainID">����</param>
		/// </summary>
		public static StorageInfo GetStorageInfoById(int GrainID)
		{
			string strWhere = "GrainID =" + GrainID;
			List<StorageInfo> list = GetStorageInfoList(strWhere);
			if (list.Count > 0)
			return list[0];
			return null;
		}

		/// �������
		/// </summary>
		/// <param name="info">���ݱ�ʵ�����</param>
		public static bool AddStorage(StorageInfo info)
		{
            int _GrainID = info.GrainID;
			string _KindOfGrain = info.KindOfGrain;
			string _Keeper = info.Keeper;
			string _Storage = info.Storage;
			string _Out = info.Out;
			int _Weight = info.Weight;
			float _Water = info.Water;
			float _Dirt = info.Dirt;
			float _Incomplete = info.Incomplete;
			string _Property = info.Property;
			string _Level = info.Level;
			string _Info = info.Info;
			string _GrowingPlace = info.GrowingPlace;
			string _Other = info.Other;

			string sql="INSERT INTO Storage VALUES (@_GrainID,@_KindOfGrain,@_Keeper,@_Storage,@_Out,@_Weight,@_Water,@_Dirt,@_Incomplete,@_Property,@_Level,@_Info,@_GrowingPlace,@_Other)";
			int rst = DBManager.ExecuteUpdate(sql, new object[] {new SqlParameter ("@_GrainID",_GrainID ), new SqlParameter("@_KindOfGrain",_KindOfGrain),new SqlParameter("@_Keeper",_Keeper),new SqlParameter("@_Storage",_Storage),new SqlParameter("@_Out",_Out),new SqlParameter("@_Weight",_Weight),new SqlParameter("@_Water",_Water),new SqlParameter("@_Dirt",_Dirt),new SqlParameter("@_Incomplete",_Incomplete),new SqlParameter("@_Property",_Property),new SqlParameter("@_Level",_Level),new SqlParameter("@_Info",_Info),new SqlParameter("@_GrowingPlace",_GrowingPlace),new SqlParameter("@_Other",_Other) });
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
		/// <param name="GrainID">����</param>
		/// <returns></returns>
		public static bool DeleteStorageInfo(StorageInfo info)
		{
			bool rst = false;
			string sqlStr = "DELETE FROM Storage WHERE GrainID=" + info.GrainID;
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
		public static bool UpdateStorageInfo(StorageInfo info)
		{
			string _KindOfGrain = info.KindOfGrain;
			string _Keeper = info.Keeper;
			string _Storage = info.Storage;
			string _Out = info.Out;
			int _Weight = info.Weight;
			float _Water = info.Water;
			float _Dirt = info.Dirt;
			float _Incomplete = info.Incomplete;
			string _Property = info.Property;
			string _Level = info.Level;
			string _Info = info.Info;
			string _GrowingPlace = info.GrowingPlace;
			string _Other = info.Other;
			string sql="UPDATE Storage SET KindOfGrain=@_KindOfGrain, Keeper=@_Keeper, Storage=@_Storage, Out=@_Out, Weight=@_Weight, Water=@_Water, Dirt=@_Dirt, Incomplete=@_Incomplete, Property=@_Property, Level=@_Level, Info=@_Info, GrowingPlace=@_GrowingPlace, Other=@_Other  WHERE GrainID="+info.GrainID;
			int rst = DBManager.ExecuteUpdate(sql, new object[] { new SqlParameter("@_KindOfGrain",_KindOfGrain),new SqlParameter("@_Keeper",_Keeper),new SqlParameter("@_Storage",_Storage),new SqlParameter("@_Out",_Out),new SqlParameter("@_Weight",_Weight),new SqlParameter("@_Water",_Water),new SqlParameter("@_Dirt",_Dirt),new SqlParameter("@_Incomplete",_Incomplete),new SqlParameter("@_Property",_Property),new SqlParameter("@_Level",_Level),new SqlParameter("@_Info",_Info),new SqlParameter("@_GrowingPlace",_GrowingPlace),new SqlParameter("@_Other",_Other) });
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
