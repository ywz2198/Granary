using System;
using System.Collections.Generic;
using System.Text;

namespace Tes.Model
{
	/// <summary>
	/// BaseInfo ʵ����
	/// BY�����˴��������� V1.0
	/// ���ߣ���������
	/// ���ڣ�2017��04��06�� 03:44:58
	/// </summary>
	public class BaseInfo
	{
		private int _GranaryID;
		/// <summary>
		/// ��ȡ������ GranaryID ��ֵ
		/// </summary>
		public int GranaryID
		{
			get { return _GranaryID; }
			set { _GranaryID = value; }
		}

		private string _Reserve;
		/// <summary>
		/// ��ȡ������ Reserve ��ֵ
		/// </summary>
		public string Reserve
		{
			get { return _Reserve; }
			set { _Reserve = value; }
		}

		private string _Type;
		/// <summary>
		/// ��ȡ������ Type ��ֵ
		/// </summary>
		public string Type
		{
			get { return _Type; }
			set { _Type = value; }
		}

		private string _Name;
		/// <summary>
		/// ��ȡ������ Name ��ֵ
		/// </summary>
		public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}

		private string _Angle;
		/// <summary>
		/// ��ȡ������ Angle ��ֵ
		/// </summary>
		public string Angle
		{
			get { return _Angle; }
			set { _Angle = value; }
		}

		private string _Length;
		/// <summary>
		/// ��ȡ������ Length ��ֵ
		/// </summary>
		public string Length
		{
			get { return _Length; }
			set { _Length = value; }
		}

		private string _Width;
		/// <summary>
		/// ��ȡ������ Width ��ֵ
		/// </summary>
		public string Width
		{
			get { return _Width; }
			set { _Width = value; }
		}

		private string _Height;
		/// <summary>
		/// ��ȡ������ Height ��ֵ
		/// </summary>
		public string Height
		{
			get { return _Height; }
			set { _Height = value; }
		}

		private string _Back;
		/// <summary>
		/// ��ȡ������ Back ��ֵ
		/// </summary>
		public string Back
		{
			get { return _Back; }
			set { _Back = value; }
		}

	}
}
