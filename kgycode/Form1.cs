using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace kgycode
{
    public partial class Form1 : Form
    {
        static String mysql_str = "server=127.0.0.1;port=3306;Database=kgy;Uid=root;Pwd=1234;Charset=utf8";
        MySqlConnection conn = new MySqlConnection(mysql_str);
        MySqlCommand cmd;  //sql문장을 실행시킬때
        MySqlDataReader reader;   //sql문장을 실행시키고 결과받을때


        public Form1()
        {
            InitializeComponent();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
               // MessageBox.Show("데이터베이스에 연결하였습니다.", "Information");
                

            }
            else
            {
                MessageBox.Show("이미 연결되어 있슴.", "Information");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sql문을 만든다
            

            string sql1 = "select cdg_grpcd, cdg_grpnm, cdg_digit, cdg_length, cdg_use, cdg_kind from kgy_cdg";
            if (reader != null) reader.Close();
            cmd = new MySqlCommand();  //cmd sql위한 준비작업
            cmd.Connection = conn;
            cmd.CommandText = sql1;   //실행시킬 sql문장이 무엇인지 지정
            //cmd.Prepare();
            //cmd.Parameters.AddWithValue("@name1", textBox1.Text + "%");
            //@number가 어떤 textbox값인지 알려줌
            reader = cmd.ExecuteReader();
            int i = 0;
            while (reader.Read() == true)
            {
                //read해서 data가 읽히면 계속 작업
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = (string)reader["cdg_grpcd"];
                dataGridView1.Rows[i].Cells[1].Value = (string)reader["cdg_grpnm"];
                dataGridView1.Rows[i].Cells[2].Value = (int)reader["cdg_digit"];
                dataGridView1.Rows[i].Cells[3].Value = (int)reader["cdg_length"];
                dataGridView1.Rows[i].Cells[4].Value = (string)reader["cdg_use"];
               //  dataGridView1.Rows[i].Cells[5].Value = (string)reader["cdg_kind"];
                i++;

            }
            if (i == 0)
            {
                MessageBox.Show("조회될 data가 없습니다.");
            }
            
        }
    }
}
