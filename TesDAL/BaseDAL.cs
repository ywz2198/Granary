using System;
using System.Collections.Generic;
using System.Text;
using Tes.Model;
using System.Data.SqlClient;

namespace Tes.DAL
{
	/// <summary>
	/// BaseDAL类
	/// BY：狂人代码生成器 V1.0
	/// 作者：金属狂人
	/// 日期：2017年04月06日 03:44:58
	/// </summary>
	public class BaseDAL
	{

		/// <summary>
		/// 获取所有信息
		/// </summary>
		/// <param name="where">条件</param>
		/// <returns>结果集</returns>
		public static SqlDataReader GetBaseInfo(string where)
		{
			string sqlStr = "SELECT * FROM Base where ";
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
		/// 获取所有信息集合
		/// </summary>
		/// <returns>List集合</returns>
		public static List<BaseInfo> GetBaseInfoList(string where)
		{
			List<BaseInfo> infoList = new List<BaseInfo>();

			SqlDataReader reader = null;
			try
			{
				reader = GetBaseInfo(where);
			}
			catch (Exception)
			{
				throw;
			}

			while (reader.Read())
			{
				BaseInfo info = new BaseInfo();
				info.GranaryID=int.Parse(reader["GranaryID"].ToString());
				info.Reserve=reader["Reserve"].ToString();
				info.Type=reader["Type"].ToString();
				info.Name=reader["Name"].ToString();
				info.Angle=reader["Angle"].ToString();
				info.Length=reader["Length"].ToString();
				info.Width=reader["Width"].ToString();
				info.Height=reader["Height"].ToString();
				info.Back=reader["Back"].ToString();
				infoList.Add(info);
			}
			reader.Close();
			return infoList;
		}

		/// <summary>
		/// 根据 主键 获取一个实体对象
		/// <param name="GranaryID">主键</param>
		/// </summary>
		public static BaseInfo GetBaseInfoById(int GranaryID)
		{
			string strWhere = "GranaryID =" + GranaryID;
			List<BaseInfo> list = GetBaseInfoList(strWhere);
			if (list.Count > 0)
			return list[0];
			return null;
		}

		/// 添加数据
		/// </summary>
		/// <param name="info">数据表实体对象</param>
		public static bool AddBase(BaseInfo info)
		{
			string _Reserve = info.Reserve;
			string _Type = info.Type;
			string _Name = info.Name;
			string _Angle = info.Angle;
			string _Length = info.Length;
			string _Width = info.Width;
			string _Height = info.Height;
			string _Back = info.Back;

			string sql="INSERT INTO Base VALUES (@_Reserve,@_Type,@_Name,@_Angle,@_Length,@_Width,@_Height,@_Back)";
			int rst = DBManager.ExecuteUpdate(sql, new object[] { new SqlParameter("@_Reserve",_Reserve),new SqlParameter("@_Type",_Type),new SqlParameter("@_Name",_Name),new SqlParameter("@_Angle",_Angle),new SqlParameter("@_Length",_Length),new SqlParameter("@_Width",_Width),new SqlParameter("@_Height",_Height),new SqlParameter("@_Back",_Back) });
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
		/// 删除一个对象
		/// </summary>
		/// <param name="GranaryID">主键</param>
		/// <returns></returns>
		public static bool DeleteBaseInfo(BaseInfo info)
		{
			bool rst = false;
			string sqlStr = "DELETE FROM Base WHERE GranaryID=" + info.GranaryID;
			int rows = DBManager.ExecuteUpdate(sqlStr);
			if (rows>0)
			{
				rst = true;
			}
			return rst;
		}

		/// 更新数据
		/// </summary>
		/// <param name="info">数据表实体</param>
		public static bool UpdateBaseInfo(BaseInfo info)
		{
			string _Reserve = info.Reserve;
			string _Type = info.Type;
			string _Name = info.Name;
			string _Angle = info.Angle;
			string _Length = info.Length;
			string _Width = info.Width;
			string _Height = info.Height;
			string _Back = info.Back;
			string sql="UPDATE Base SET Reserve=@_Reserve, Type=@_Type, Name=@_Name, Angle=@_Angle, Length=@_Length, Width=@_Width, Height=@_Height, Back=@_Back  WHERE GranaryID="+info.GranaryID;
			int rst = DBManager.ExecuteUpdate(sql, new object[] { new SqlParameter("@_Reserve",_Reserve),new SqlParameter("@_Type",_Type),new SqlParameter("@_Name",_Name),new SqlParameter("@_Angle",_Angle),new SqlParameter("@_Length",_Length),new SqlParameter("@_Width",_Width),new SqlParameter("@_Height",_Height),new SqlParameter("@_Back",_Back) });
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
