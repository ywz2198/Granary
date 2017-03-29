using System;
using System.Collections.Generic;
using System.Text;

namespace Tes.Model
{
	/// <summary>
	/// StorageInfo ʵ����
	/// BY�����˴��������� V1.0
	/// ���ߣ���������
	/// ���ڣ�2017��03��26�� 01:19:59
	/// </summary>
	public class StorageInfo
	{
		private int _GrainID;
		/// <summary>
		/// ��ȡ������ GrainID ��ֵ
		/// </summary>
		public int GrainID
		{
			get { return _GrainID; }
			set { _GrainID = value; }
		}

		private string _KindOfGrain;
		/// <summary>
		/// ��ȡ������ KindOfGrain ��ֵ
		/// </summary>
		public string KindOfGrain
		{
			get { return _KindOfGrain; }
			set { _KindOfGrain = value; }
		}

		private string _Keeper;
		/// <summary>
		/// ��ȡ������ Keeper ��ֵ
		/// </summary>
		public string Keeper
		{
			get { return _Keeper; }
			set { _Keeper = value; }
		}

		private string _Storage;
		/// <summary>
		/// ��ȡ������ Storage ��ֵ
		/// </summary>
		public string Storage
		{
			get { return _Storage; }
			set { _Storage = value; }
		}

		private string _Out;
		/// <summary>
		/// ��ȡ������ Out ��ֵ
		/// </summary>
		public string Out
		{
			get { return _Out; }
			set { _Out = value; }
		}

		private int _Weight;
		/// <summary>
		/// ��ȡ������ Weight ��ֵ
		/// </summary>
		public int Weight
		{
			get { return _Weight; }
			set { _Weight = value; }
		}

		private float _Water;
		/// <summary>
		/// ��ȡ������ Water ��ֵ
		/// </summary>
		public float Water
		{
			get { return _Water; }
			set { _Water = value; }
		}

		private float _Dirt;
		/// <summary>
		/// ��ȡ������ Dirt ��ֵ
		/// </summary>
		public float Dirt
		{
			get { return _Dirt; }
			set { _Dirt = value; }
		}

		private float _Incomplete;
		/// <summary>
		/// ��ȡ������ Incomplete ��ֵ
		/// </summary>
		public float Incomplete
		{
			get { return _Incomplete; }
			set { _Incomplete = value; }
		}

		private string _Property;
		/// <summary>
		/// ��ȡ������ Property ��ֵ
		/// </summary>
		public string Property
		{
			get { return _Property; }
			set { _Property = value; }
		}

		private string _Level;
		/// <summary>
		/// ��ȡ������ Level ��ֵ
		/// </summary>
		public string Level
		{
			get { return _Level; }
			set { _Level = value; }
		}

		private string _Info;
		/// <summary>
		/// ��ȡ������ Info ��ֵ
		/// </summary>
		public string Info
		{
			get { return _Info; }
			set { _Info = value; }
		}

		private string _GrowingPlace;
		/// <summary>
		/// ��ȡ������ GrowingPlace ��ֵ
		/// </summary>
		public string GrowingPlace
		{
			get { return _GrowingPlace; }
			set { _GrowingPlace = value; }
		}

		private string _Other;
		/// <summary>
		/// ��ȡ������ Other ��ֵ
		/// </summary>
		public string Other
		{
			get { return _Other; }
			set { _Other = value; }
		}

	}
}
