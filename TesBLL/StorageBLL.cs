using System;
using System.Collections.Generic;
using System.Text;
using Tes.Model;
using  Tes.DAL;

namespace Tes.BLL
{
	/// <summary>
	/// StorageBLL��
	/// BY�����˴��������� V1.0
	/// ���ߣ���������
	/// ���ڣ�2017��03��26�� 01:19:59
	/// </summary>
	public class StorageBLL
	{


		/// <summary>
		/// ��ȡ������Ϣ����
		/// </summary>
		/// <returns>List����</returns>
		public static List<StorageInfo> GetStorageInfoList(string where)
		{
			try
			{
				return StorageDAL.GetStorageInfoList(where);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// ���� ���� ��ȡһ��ʵ�����
		/// <param name="GrainID">����</param>
		/// </summary>
		public static StorageInfo GetStorageInfoById(int GrainID)
		{
			try
			{
				return StorageDAL.GetStorageInfoById(GrainID);
			}
			catch
			{
				throw;
			}
		}

		/// �������
		/// </summary>
		/// <param name="info">���ݱ�ʵ�����</param>
		public static bool AddStorage(StorageInfo info)
		{
			try
			{
				return StorageDAL.AddStorage(info);
			}
			catch
			{
				throw;
			}
		}

      
        /// <summary>
        /// ��������ɾ��һ������
        /// </summary>
        /// <param name="_GrainID">����</param>
        /// <returns></returns>
        public static bool DeleteStorageInfo(StorageInfo info)
		{
			try
			{
				return StorageDAL.DeleteStorageInfo(info);
			}
			catch
			{
				throw;
			}
		}

		/// ��������
		/// </summary>
		/// <param name="info">���ݱ�ʵ��</param>
		public static bool UpdateStorageInfo(StorageInfo info)
		{
			try
			{
				return StorageDAL.UpdateStorageInfo(info);
			}
			catch
			{
				throw;
			}
		}
	}
}
