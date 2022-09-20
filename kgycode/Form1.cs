

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace kgycode
{
    public partial class Form1 : Form
    {
        static String mysql_str = "server=127.0.0.1;port=3306;Database=kgy;Uid=root;Pwd=1234;Charset=utf8";
        MySqlConnection conn = new MySqlConnection(mysql_str);
        MySqlCommand cmd;  //sql문장을 실행시킬때
        MySqlDataReader reader;   //sql문장을 실행시키고 결과받을때
        
        private bool Select_sw = false; // true이벤트 처리시 return (text.change)
        private bool Select_cgsw = false; //true이벤트 처리시 return (select_change)

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {


            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                init_btn();
            }
            else
            {
                MessageBox.Show("이미 연결되어 있음", "Information");
            }
        }

        private void init_btn()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = false;
            button6.Enabled = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //sql문을 만든다

            dataGridView1.Rows.Clear();

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
                dataGridView1.Rows[i].Cells[1].Value = (string)reader["cdg_grpcd"];
                dataGridView1.Rows[i].Cells[2].Value = (string)reader["cdg_grpnm"];
                dataGridView1.Rows[i].Cells[3].Value = (int)reader["cdg_digit"];
                dataGridView1.Rows[i].Cells[4].Value = (int)reader["cdg_length"];
                dataGridView1.Rows[i].Cells[5].Value = (string)reader["cdg_use"];
                //  dataGridView1.Rows[i].Cells[5].Value = (string)reader["cdg_kind"];
                i++;
            }

            if (i == 0)
            {
                MessageBox.Show("조회될 data가 없습니다.");
            }
            this.dataGridView1_SelectionChanged(null, null);
        }

        private void cfm_btn()
        {
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cfm_btn();

            var rowIdx = dataGridView1.CurrentRow == null ? 0 : dataGridView1.CurrentRow.Index;

            if (dataGridView1.Rows.Count == 0)
            {
                Select_cgsw = true;
                rowIdx = dataGridView1.Rows.Add();
                Select_cgsw = false;
            }
            else
            {
                rowIdx++;
                dataGridView1.Rows.Insert(rowIdx);
            }
            dataGridView1.Rows[rowIdx].Cells["status"].Value = 'A';
            dataGridView1.CurrentCell = dataGridView1.Rows[rowIdx].Cells[0];

            t_grpcd.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (Select_cgsw == true) return;
            if (dataGridView1.Rows.Count == 0) return;
            //그리드뷰에 행이 없을때는 수행하지 않음
            if (dataGridView1.SelectedRows.Count == 0) return;
            //그리드뷰에 선택된 행이 없을때는 수행하지 않음
            if (dataGridView1.SelectedRows.Count == 0) return;

            Control ctl;
            Type type;
            PropertyInfo pi;

            Select_sw = true;

            for (int col = 0; col < dataGridView1.ColumnCount; col++)
            {
                if (dataGridView1.Columns[col].Name == "status")
                {
                    if (!(dataGridView1.SelectedRows[0].Cells[col].Value?.ToString() == "A"))
                    {
                        t_grpcd.Enabled = false;
                    }
                    else
                    {
                        t_grpcd.Enabled = true;
                    }
                }

                ctl = GetControlByName(panel2, dataGridView1.Columns[col].Name);
                if (ctl == null) continue;
                type = ctl.GetType();
                pi = null;
                pi = type.GetProperty("Text");
                if (pi != null)
                {
                    pi.SetValue(ctl, dataGridView1.SelectedRows[0].Cells[col].Value?.ToString());
                    //?를 사용한 이유는 값이 널이면 널반환, 아니면 value값을 스트링으로 변환해서 반환
                }

            }
            Select_sw = false;

        }
        private Control GetControlByName(Control control, string col_name)
        {

            string ctl_name = "t_" + col_name;

            Control[] ctl = control.Controls.Find(ctl_name, true);
            return ctl.Length == 0 ? null : ctl[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 자료를 먼저 선택하세요");
                return;
            }

            DataGridViewRow row = dataGridView1.CurrentRow;
            //신규 입력중인 자료는 단순하게 Grid에서 제거만 한다.
            if ((string)row.Cells["status"].Value == "A")
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                return;
            }
            DialogResult result = MessageBox.Show(row.Cells["grpcd"].Value +
                "자료를 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            //삭제하겠다고

            if (reader != null) reader.Close();

            try
            {
                //sql로 data 삭제는 여기서 지금은 생략
                
                String del_sql = "delete from kgy_cdg where cdg_grpcd =  @cdg_grpcd";
                cmd = new MySqlCommand();  //cmd sql위한 준비작업
                cmd.Connection = conn;
                cmd.CommandText = del_sql;   //실행시킬 sql문장이 무엇인지 지정
                                          // cmd.Prepare();
                cmd.Parameters.AddWithValue("@cdg_grpcd", row.Cells["grpcd"].Value.ToString());
                cmd.ExecuteNonQuery();

                dataGridView1.Rows.RemoveAt(row.Index);
                MessageBox.Show("자료가 정상적으로 삭제되었습니다");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                //if (con! = null) conn.Close();
            }
            if (dataGridView1.RowCount != 0) return;
        }

        private void t_grpcd_TextChanged(object sender, EventArgs e)
        {

            if (Select_sw == true) return;//GridView 선택 시 최초값 설정에 따른 이벤트는 무시

            //여기는 텍스트값이 변경될 때 이벤트가 발생
            //현재 그리드뷰에 선택된 행이 없으면 할일없음

            if (dataGridView1.SelectedRows.Count < -0) return; //선택된게 없을 때 컨트롤 바꿔줌
            Control ctl = sender as Control;
            DataGridViewRow row = dataGridView1.CurrentRow;
            if (row == null) return;
            //MessageBox.Show(ctl.Name.ToString());
            //이벤트가 일어난 컨트롤의 이름을 알 수 있음

            Type type = ctl.GetType();
            PropertyInfo pi = null;
            string aa;
            pi = type.GetProperty("Text");
            if (pi == null) return;
            string col_name = ctl.Name.Substring(2);
            row.Cells[col_name].Value = pi.GetValue(ctl);

            int value;
            aa = pi.GetValue(ctl).ToString();

            if ((row.Cells["status"].Value == null) || (row.Cells["status"].Value.ToString() == ""))
            {
                row.Cells["status"].Value = "U";
                cfm_btn();
            }

            if ((aa == "") || (aa == null)) return;
            if ((ctl.Name.ToString() == "t_digit") || (ctl.Name.ToString() == "t_length"))
            {
                //값이 숫자가 아니면 error;                    
                if (int.TryParse(aa, out value) == false)
                {
                    MessageBox.Show("number error");
                    return;
                }

            }

            if (ctl.Name.ToString() == "t_use")
            {
                if (!(pi.GetValue(ctl).ToString() == "Y" || pi.GetValue(ctl).ToString() == "N"))
                {
                    MessageBox.Show("Y/N으로 입력하세요");
                    return;
                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* if (dataGridView1.SelectedRows.Count < 1)
             {
                 MessageBox.Show("수정할 자료를 먼저 선택하세요");
                 return;
             }
             DataGridViewRow row = dataGridView1.CurrentRow;
             if ((string)row.Cells["status"].Value == null || (string)row.Cells["status"].Value =="")
             {
                 row.Cells["status"].Value = "U";
             } */

        }

        private void t_grpcd_Leave(object sender, EventArgs e)
        {
            //그룹코드를 입력후 빠져나왔을 때 일어나는 이벤트
            //그리드 상에 같은 코드가 있는지 확인

            if (t_grpcd.Text == "") return;
            if (dataGridView1.SelectedRows.Count <= 0) //선택된 게 없을때 컨트롤 바꿔도
            {
                MessageBox.Show("입력버튼을 먼저 선택하세요");
                t_grpcd.Text = "";
                t_grpcd.Focus();
                return;
            }

            int rowidx = dataGridView1.CurrentRow.Index;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i != rowidx)
                {
                    if (dataGridView1.Rows[i].Cells["grpcd"].Value == null) continue;
                    if (dataGridView1.Rows[i].Cells["grpcd"].Value.ToString() == t_grpcd.Text)
                    {
                        t_grpcd.Focus();
                        MessageBox.Show(t_grpcd.Text + "코드는 입력 될 자료이거나 입력되어 있는 코드입니다");
                        t_grpcd.Text = "";
                        dataGridView1.Rows[rowidx].Cells["grpcd"].Value = "";
                        return;
                    }
                }
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            //그리드뷰를 다 읽어보고 (U,A만) 비어있는지 확인절차 필요            
            for (int i = 0; i < dataGridView1.RowCount; i++) //행
            {
                if ((dataGridView1.Rows[i].Cells[0].Value == null) ||
                    (dataGridView1.Rows[i].Cells[0].Value.ToString() == ""))
                    continue;

                for (int col = 1; col < dataGridView1.ColumnCount; col++)
                {
                    if ((dataGridView1.Rows[i].Cells[col].Value == null) ||
                        (dataGridView1.Rows[i].Cells[col].Value.ToString() == ""))
                    {
                        MessageBox.Show(i + 1 + "번째 data를 정확히 입력하세요");
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[col];
                        return;
                    }
                }

                if (reader != null) reader.Close();

                //모든 입력작업이 될 준비단계
                for (int j = 0; j < dataGridView1.RowCount; j++) //행
                {
                    if (dataGridView1.Rows[j].Cells[0].Value == null) continue;

                    for (int col = 1; col < dataGridView1.ColumnCount; col++)
                    {
                        if (dataGridView1.Rows[j].Cells[0].Value.ToString() == "A")
                        {
                            //insert 
                            //insert sql 생성
                            //insert into kgy_cdg (cdg_grpcd, cdg_grpnm,cdg_digit,cdg_length,cdg_use)
                            // values('1', '1', 2, 0, 'Y')

                            String del_sql = "insert into kgy_cdg (cdg_grpcd, cdg_grpnm,cdg_digit,cdg_length,cdg_use) " +
                                                      "values(@val1, @val2,@val3, @val4, @val5 )";
                            cmd = new MySqlCommand();  //cmd sql위한 준비작업
                            cmd.Connection = conn;
                            cmd.CommandText = del_sql;   //실행시킬 sql문장이 무엇인지 지정
                                                         // cmd.Prepare();
                            cmd.Parameters.AddWithValue("@val1", dataGridView1.Rows[i].Cells[1].Value.ToString());
                            cmd.Parameters.AddWithValue("@val2", dataGridView1.Rows[i].Cells[2].Value.ToString());
                            cmd.Parameters.AddWithValue("@val3", dataGridView1.Rows[i].Cells[3].Value.ToString());
                            cmd.Parameters.AddWithValue("@val4", dataGridView1.Rows[i].Cells[4].Value.ToString());
                            cmd.Parameters.AddWithValue("@val5", dataGridView1.Rows[i].Cells[5].Value.ToString());
                            cmd.ExecuteNonQuery();

                            dataGridView1.Rows[j].Cells[0].Value = "";

                        }
                        else
                        {
                            //update sql 생성
                            //uadate kgy_cdg set cdg_grpnm='2', cdg_digit=3, cdg_length=1,  cdg_use='Y'
                            //where cdg_grpcd = '1'

                            String update_sql = "update kgy_cdg set " +
                                                            "cdg_grpcd=@val1, " +
                                                            "cdg_grpnm=@val2, " +
                                                            "cdg_digit=@val3, " +
                                                            "cdg_length=@val4, " +
                                                            "cdg_use=@val5 " +
                                                            "where cdg_grpcd=@val1";
                                                     
                            cmd = new MySqlCommand();  //cmd sql위한 준비작업
                            cmd.Connection = conn;
                            cmd.CommandText = update_sql;

;   //실행시킬 sql문장이 무엇인지 지정
                                                         // cmd.Prepare();
                            cmd.Parameters.AddWithValue("@val1", dataGridView1.Rows[i].Cells[1].Value.ToString());
                            cmd.Parameters.AddWithValue("@val2", dataGridView1.Rows[i].Cells[2].Value.ToString());
                            cmd.Parameters.AddWithValue("@val3", dataGridView1.Rows[i].Cells[3].Value.ToString());
                            cmd.Parameters.AddWithValue("@val4", dataGridView1.Rows[i].Cells[4].Value.ToString());
                            cmd.Parameters.AddWithValue("@val5", dataGridView1.Rows[i].Cells[5].Value.ToString());
                            cmd.ExecuteNonQuery();

                            dataGridView1.Rows[j].Cells[0].Value = "";
                        }
                        //sql 실행
                        init_btn(); //원상복구
                    }

                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            init_btn();
            this.button1_Click(null, null); // 조회버튼을 클릭한 상태
        }
    }
}
