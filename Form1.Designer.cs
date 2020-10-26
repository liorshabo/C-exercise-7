namespace Proj7
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.btn_num_shifts = new System.Windows.Forms.Button();
            this.btn_salary_sum = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(77, 48);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 0;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // btn_num_shifts
            // 
            this.btn_num_shifts.Location = new System.Drawing.Point(529, 48);
            this.btn_num_shifts.Name = "btn_num_shifts";
            this.btn_num_shifts.Size = new System.Drawing.Size(142, 23);
            this.btn_num_shifts.TabIndex = 1;
            this.btn_num_shifts.Text = "כמות משמרות";
            this.btn_num_shifts.UseVisualStyleBackColor = true;
            this.btn_num_shifts.Click += new System.EventHandler(this.num_shifts_Click);
            // 
            // btn_salary_sum
            // 
            this.btn_salary_sum.Location = new System.Drawing.Point(529, 109);
            this.btn_salary_sum.Name = "btn_salary_sum";
            this.btn_salary_sum.Size = new System.Drawing.Size(142, 23);
            this.btn_salary_sum.TabIndex = 2;
            this.btn_salary_sum.Text = "משכורת";
            this.btn_salary_sum.UseVisualStyleBackColor = true;
            this.btn_salary_sum.Click += new System.EventHandler(this.salary_sum_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(529, 172);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(142, 23);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "סיום";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 111);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 84);
            this.textBox1.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_salary_sum);
            this.Controls.Add(this.btn_num_shifts);
            this.Controls.Add(this.comboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button btn_num_shifts;
        private System.Windows.Forms.Button btn_salary_sum;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

