using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Collections.Specialized;

namespace INIFILE
{
    public class IniFiles
    {
        public string FileName;
        [DllImport("kernel32")]
        private static extern bool WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, byte[] retVal, int size, string filePath);
        public IniFiles(string AFileName)
        {
            FileInfo fileInfo = new FileInfo(AFileName);
            if (!fileInfo.Exists)
            {
                StreamWriter sw = new StreamWriter(AFileName, false, System.Text.Encoding.Default);
                try
                {
                    sw.Write("#表格配置档案");
                    sw.Close();
                }
                catch
                {
                    throw (new ApplicationException("Ini文件不存在"));

                }
            }
            FileName = fileInfo.FullName;


        }
        public void WriteString(string Section, string Ident, string Value)
        {
            if (!WritePrivateProfileString(Section, Ident, Value, FileName))
            {
                throw (new ApplicationException("写Ini文件出错"));
            }

        }
        public string ReadString(string Section,string Ident,string Default)
        {
            Byte[] Buffer = new Byte[65535];
            int bufLen = GetPrivateProfileString(Section, Ident, Default, Buffer, Buffer.GetUpperBound(0), FileName);
            string s = Encoding.GetEncoding(0).GetString(Buffer);
            s = s.Substring(0,bufLen);
            return s.Trim();
        }
        public int ReadInterger(string Section,string Ident,int Default)
        {
            string intStr = ReadString(Section, Ident, Convert.ToString(Default));
            try
            {
                return Convert.ToInt32(intStr);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Default;
            }
        }
        public bool ReadBool (string Section,string Ident,bool Default)
        {
            try
            {
                return Convert.ToBoolean(ReadString(Section, Ident, Convert.ToString(Default)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Default;
            }
        }
        public void WriteBool(string Section, string Ident, bool Value)
        {
            WriteString(Section, Ident, Convert.ToString(Value));
        }
        public void ReadSection(string Section, StringCollection Idents)
        {
            Byte[] Buffer = new Byte[16384];
            //Idents.Clear();  

            int bufLen = GetPrivateProfileString(Section, null, null, Buffer, Buffer.GetUpperBound(0), FileName);
            //对Section进行解析  
            GetStringsFromBuffer(Buffer, bufLen, Idents);
        }
        private void GetStringsFromBuffer(Byte[] Buffer, int bufLen, StringCollection Strings)
        {
            Strings.Clear();
            if (bufLen != 0)
            {
                int start = 0;
                for (int i = 0; i < bufLen; i++)
                {
                    if ((Buffer[i] == 0) && ((i - start) > 0))
                    {
                        String s = Encoding.GetEncoding(0).GetString(Buffer, start, i - start);
                        Strings.Add(s);
                        start = i + 1;
                    }
                }
            }
        }
        public void ReadSections(StringCollection SectionList)
        {
            //Note:必须得用Bytes来实现，StringBuilder只能取到第一个Section  
            byte[] Buffer = new byte[65535];
            int bufLen = 0;
            bufLen = GetPrivateProfileString(null, null, null, Buffer,
            Buffer.GetUpperBound(0), FileName);
            GetStringsFromBuffer(Buffer, bufLen, SectionList);
        }

        //读取指定的Section的所有Value到列表中  
        public void ReadSectionValues(string Section, NameValueCollection Values)
        {
            StringCollection KeyList = new StringCollection();
            ReadSection(Section, KeyList);
            Values.Clear();
            foreach (string key in KeyList)
            {
                Values.Add(key, ReadString(Section, key, ""));
            }
        }
        public void DeleteKey(string Section, string Ident)
        {
            WritePrivateProfileString(Section, Ident, null, FileName);
        }

        //Note:对于Win9X，来说需要实现UpdateFile方法将缓冲中的数据写入文件  
        //在Win NT, 2000和XP上，都是直接写文件，没有缓冲，所以，无须实现UpdateFile  
        //执行完对Ini文件的修改之后，应该调用本方法更新缓冲区。  
        public void UpdateFile()
        {
            WritePrivateProfileString(null, null, null, FileName);
        }

        //检查某个Section下的某个键值是否存在  
        public bool ValueExists(string Section, string Ident)
        {
            StringCollection Idents = new StringCollection();
            ReadSection(Section, Idents);
            return Idents.IndexOf(Ident) > -1;
        }

        //确保资源的释放  
        ~IniFiles()
        {
            UpdateFile();
        }
    }
}
