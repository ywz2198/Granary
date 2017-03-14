using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace GrainCondition
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-0FQSD7I; Initial Catalog = Granary; User Id = lol; Password = lol;MultipleActiveResultSets=true;");
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            con.Open();
            if (con.State == ConnectionState.Open)
                MessageBox.Show("已连接");
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (ID.Text != "" && Password.Text != "")
            {

                SqlCommand mycmd = new SqlCommand("Login", con);
                mycmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramID = new SqlParameter("@ID", SqlDbType.NChar, 10);
                paramID.Value = ID.Text;
                mycmd.Parameters.Add(paramID);
                SqlParameter paramPassword = new SqlParameter("@Password", SqlDbType.NVarChar, 50);
                paramPassword.Value = Password.Text;
                mycmd.Parameters.Add(paramPassword);
                SqlDataReader dr = mycmd.ExecuteReader(CommandBehavior.CloseConnection);



                if (dr.Read())
                {

                    MainForm  form = new MainForm(); //有没有参数得看你 Form2 的构造函数怎么写的了
                    form.Show();

                }
                else {
                    MessageBox.Show("Fuckyou");
                }
            }
            else
                MessageBox.Show("Fill the blanks");
        }
    }
}
