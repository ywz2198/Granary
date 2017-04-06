using System;
using System.Collections.Generic;
using System.Text;
using Tes.Model;
using  Tes.DAL;

namespace Tes.BLL
{
	/// <summary>
	/// BaseBLL��
	/// BY�����˴��������� V1.0
	/// ���ߣ���������
	/// ���ڣ�2017��04��06�� 03:44:58
	/// </summary>
	public class BaseBLL
	{


		/// <summary>
		/// ��ȡ������Ϣ����
		/// </summary>
		/// <returns>List����</returns>
		public static List<BaseInfo> GetBaseInfoList(string where)
		{
			try
			{
				return BaseDAL.GetBaseInfoList(where);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// ���� ���� ��ȡһ��ʵ�����
		/// <param name="GranaryID">����</param>
		/// </summary>
		public static BaseInfo GetBaseInfoById(int GranaryID)
		{
			try
			{
				return BaseDAL.GetBaseInfoById(GranaryID);
			}
			catch
			{
				throw;
			}
		}

		/// �������
		/// </summary>
		/// <param name="info">���ݱ�ʵ�����</param>
		public static bool AddBase(BaseInfo info)
		{
			try
			{
				return BaseDAL.AddBase(info);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// ��������ɾ��һ������
		/// </summary>
		/// <param name="_GranaryID">����</param>
		/// <returns></returns>
		public static bool DeleteBaseInfo(BaseInfo info)
		{
			try
			{
				return BaseDAL.DeleteBaseInfo(info);
			}
			catch
			{
				throw;
			}
		}

		/// ��������
		/// </summary>
		/// <param name="info">���ݱ�ʵ��</param>
		public static bool UpdateBaseInfo(BaseInfo info)
		{
			try
			{
				return BaseDAL.UpdateBaseInfo(info);
			}
			catch
			{
				throw;
			}
		}
	}
}
