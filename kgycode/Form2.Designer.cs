namespace kgycode
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.unitdigit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_use = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uint_mn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_mn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.t_unit_use = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t_unit_seq = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.t_unit_mn2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.t_unit_mn = new System.Windows.Forms.TextBox();
            this.t_unit_cd = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.unitcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // unitdigit
            // 
            this.unitdigit.HeaderText = "길이";
            this.unitdigit.Name = "unitdigit";
            // 
            // unit_use
            // 
            this.unit_use.HeaderText = "사용여부";
            this.unit_use.Name = "unit_use";
            this.unit_use.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // unit_seq
            // 
            this.unit_seq.HeaderText = "코드SEQ";
            this.unit_seq.Name = "unit_seq";
            this.unit_seq.Width = 150;
            // 
            // uint_mn2
            // 
            this.uint_mn2.HeaderText = "코드명(축약)";
            this.uint_mn2.Name = "uint_mn2";
            this.uint_mn2.Width = 150;
            // 
            // unit_mn
            // 
            this.unit_mn.HeaderText = "코드명(원형)";
            this.unit_mn.Name = "unit_mn";
            // 
            // unit_cd
            // 
            this.unit_cd.HeaderText = "단위코드";
            this.unit_cd.Name = "unit_cd";
            // 
            // status
            // 
            this.status.HeaderText = "상태";
            this.status.Name = "status";
            this.status.Width = 80;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(363, 76);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(101, 20);
            this.comboBox3.TabIndex = 35;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(256, 76);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(101, 20);
            this.comboBox2.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 33;
            this.label6.Text = "그룹코드";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(101, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 20);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.t_unit_use);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.t_unit_seq);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.t_unit_mn2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.t_unit_mn);
            this.panel2.Controls.Add(this.t_unit_cd);
            this.panel2.Location = new System.Drawing.Point(757, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 437);
            this.panel2.TabIndex = 31;
            // 
            // t_unit_use
            // 
            this.t_unit_use.Location = new System.Drawing.Point(147, 157);
            this.t_unit_use.Name = "t_unit_use";
            this.t_unit_use.Size = new System.Drawing.Size(21, 21);
            this.t_unit_use.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "단위코드";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "사용여부";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "코드(원형)";
            // 
            // t_unit_seq
            // 
            this.t_unit_seq.Location = new System.Drawing.Point(147, 110);
            this.t_unit_seq.Name = "t_unit_seq";
            this.t_unit_seq.Size = new System.Drawing.Size(150, 21);
            this.t_unit_seq.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "코드(축약)";
            // 
            // t_unit_mn2
            // 
            this.t_unit_mn2.Location = new System.Drawing.Point(147, 82);
            this.t_unit_mn2.Name = "t_unit_mn2";
            this.t_unit_mn2.Size = new System.Drawing.Size(150, 21);
            this.t_unit_mn2.TabIndex = 18;
            this.t_unit_mn2.TextChanged += new System.EventHandler(this.t_unit_mn2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "코드SEQ";
            // 
            // t_unit_mn
            // 
            this.t_unit_mn.Location = new System.Drawing.Point(147, 54);
            this.t_unit_mn.Name = "t_unit_mn";
            this.t_unit_mn.Size = new System.Drawing.Size(150, 21);
            this.t_unit_mn.TabIndex = 17;
            this.t_unit_mn.TextChanged += new System.EventHandler(this.t_unit_mn_TextChanged);
            // 
            // t_unit_cd
            // 
            this.t_unit_cd.Location = new System.Drawing.Point(147, 20);
            this.t_unit_cd.Name = "t_unit_cd";
            this.t_unit_cd.Size = new System.Drawing.Size(150, 21);
            this.t_unit_cd.TabIndex = 16;
            this.t_unit_cd.TextChanged += new System.EventHandler(this.t_unit_cd_TextChanged);
            this.t_unit_cd.Leave += new System.EventHandler(this.t_unit_cd_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(21, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 437);
            this.panel1.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.status,
            this.unit_cd,
            this.unit_mn,
            this.uint_mn2,
            this.unit_seq,
            this.unit_use,
            this.unitcode,
            this.unitdigit});
            this.dataGridView1.Location = new System.Drawing.Point(8, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(719, 413);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // unitcode
            // 
            this.unitcode.HeaderText = "그룹코드";
            this.unitcode.Name = "unitcode";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(997, 76);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 33);
            this.button6.TabIndex = 29;
            this.button6.Text = "취소";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(916, 76);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 33);
            this.button5.TabIndex = 28;
            this.button5.Text = "확인";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(789, 76);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 33);
            this.button4.TabIndex = 27;
            this.button4.Text = "삭제";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(708, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 26;
            this.button3.Text = "수정";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(627, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 25;
            this.button2.Text = "입력";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 24;
            this.button1.Text = "조회";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 644);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn unitdigit;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_use;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn uint_mn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_mn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox t_unit_use;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_unit_seq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_unit_mn2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_unit_mn;
        private System.Windows.Forms.TextBox t_unit_cd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitcode;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}