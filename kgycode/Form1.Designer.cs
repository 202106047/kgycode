namespace kgycode
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpcd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpnm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.digit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.use = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.t_use = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t_length = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.t_digit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.t_grpnm = new System.Windows.Forms.TextBox();
            this.t_grpcd = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "조회";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(618, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "입력";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(699, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "수정";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(780, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 33);
            this.button4.TabIndex = 3;
            this.button4.Text = "삭제";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(907, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 33);
            this.button5.TabIndex = 4;
            this.button5.Text = "확인";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(988, 30);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 33);
            this.button6.TabIndex = 5;
            this.button6.Text = "취소";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 437);
            this.panel1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.status,
            this.grpcd,
            this.grpnm,
            this.digit,
            this.length,
            this.use});
            this.dataGridView1.Location = new System.Drawing.Point(8, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(719, 413);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // status
            // 
            this.status.HeaderText = "상태";
            this.status.Name = "status";
            this.status.Width = 80;
            // 
            // grpcd
            // 
            this.grpcd.HeaderText = "그룹코드";
            this.grpcd.Name = "grpcd";
            // 
            // grpnm
            // 
            this.grpnm.HeaderText = "그룹코드명";
            this.grpnm.Name = "grpnm";
            // 
            // digit
            // 
            this.digit.HeaderText = "단위코드 길이";
            this.digit.Name = "digit";
            this.digit.Width = 150;
            // 
            // length
            // 
            this.length.HeaderText = "단위코드명 길이";
            this.length.Name = "length";
            this.length.Width = 150;
            // 
            // use
            // 
            this.use.HeaderText = "사용안함";
            this.use.Name = "use";
            this.use.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.t_use);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.t_length);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.t_digit);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.t_grpnm);
            this.panel2.Controls.Add(this.t_grpcd);
            this.panel2.Location = new System.Drawing.Point(748, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 437);
            this.panel2.TabIndex = 11;
            // 
            // t_use
            // 
            this.t_use.Location = new System.Drawing.Point(147, 157);
            this.t_use.Name = "t_use";
            this.t_use.Size = new System.Drawing.Size(21, 21);
            this.t_use.TabIndex = 21;
            this.t_use.TextChanged += new System.EventHandler(this.t_grpcd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "그룹코드";
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
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "그룹코드명";
            // 
            // t_length
            // 
            this.t_length.Location = new System.Drawing.Point(147, 110);
            this.t_length.Name = "t_length";
            this.t_length.Size = new System.Drawing.Size(150, 21);
            this.t_length.TabIndex = 19;
            this.t_length.TextChanged += new System.EventHandler(this.t_grpcd_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "단위코드길이";
            // 
            // t_digit
            // 
            this.t_digit.Location = new System.Drawing.Point(147, 82);
            this.t_digit.Name = "t_digit";
            this.t_digit.Size = new System.Drawing.Size(150, 21);
            this.t_digit.TabIndex = 18;
            this.t_digit.TextChanged += new System.EventHandler(this.t_grpcd_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "단위코드명 길이";
            // 
            // t_grpnm
            // 
            this.t_grpnm.Location = new System.Drawing.Point(147, 54);
            this.t_grpnm.Name = "t_grpnm";
            this.t_grpnm.Size = new System.Drawing.Size(150, 21);
            this.t_grpnm.TabIndex = 17;
            this.t_grpnm.TextChanged += new System.EventHandler(this.t_grpcd_TextChanged);
            // 
            // t_grpcd
            // 
            this.t_grpcd.Location = new System.Drawing.Point(147, 20);
            this.t_grpcd.Name = "t_grpcd";
            this.t_grpcd.Size = new System.Drawing.Size(150, 21);
            this.t_grpcd.TabIndex = 16;
            this.t_grpcd.TextChanged += new System.EventHandler(this.t_grpcd_TextChanged);
            this.t_grpcd.Leave += new System.EventHandler(this.t_grpcd_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 626);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox t_use;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_length;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_digit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_grpnm;
        private System.Windows.Forms.TextBox t_grpcd;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn grpcd;
        private System.Windows.Forms.DataGridViewTextBoxColumn grpnm;
        private System.Windows.Forms.DataGridViewTextBoxColumn digit;
        private System.Windows.Forms.DataGridViewTextBoxColumn length;
        private System.Windows.Forms.DataGridViewTextBoxColumn use;
    }
}

