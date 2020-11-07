namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.army = new System.Windows.Forms.ComboBox();
            this.Reset = new System.Windows.Forms.Button();
            this.Сalculate = new System.Windows.Forms.Button();
            this.vacation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата приема на работу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(214, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата увольнения";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(214, 45);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(395, 42);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 4;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Adding);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(476, 42);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Deleting);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(346, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Вы проходили воинскую службу по призыву?";
            // 
            // army
            // 
            this.army.FormattingEnabled = true;
            this.army.Items.AddRange(new object[] {
            "Нет",
            "Да, 1 год",
            "Да, 1,5 года",
            "Да, 2 года"});
            this.army.Location = new System.Drawing.Point(697, 110);
            this.army.Name = "army";
            this.army.Size = new System.Drawing.Size(121, 21);
            this.army.TabIndex = 7;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(743, 42);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 8;
            this.Reset.Text = "Сброс";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Сalculate
            // 
            this.Сalculate.Location = new System.Drawing.Point(641, 240);
            this.Сalculate.Name = "Сalculate";
            this.Сalculate.Size = new System.Drawing.Size(160, 54);
            this.Сalculate.TabIndex = 9;
            this.Сalculate.Text = "Расчитать";
            this.Сalculate.UseVisualStyleBackColor = true;
            this.Сalculate.Click += new System.EventHandler(this.Сalculate_Click);
            // 
            // vacation
            // 
            this.vacation.FormattingEnabled = true;
            this.vacation.Items.AddRange(new object[] {
            "Нет",
            "Да, за 1 ребенком",
            "Да, за 2 детьми, в разное время",
            "Да, за 3 и более детьми, в разное время"});
            this.vacation.Location = new System.Drawing.Point(574, 195);
            this.vacation.Name = "vacation";
            this.vacation.Size = new System.Drawing.Size(244, 21);
            this.vacation.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(346, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(375, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Вы находились в отпуске по уходу за ребенком?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(345, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ваш трудовой стаж:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(350, 332);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 101);
            this.textBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 491);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vacation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Сalculate);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.army);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Калькулятор подсчета трудового стажа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox army;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Сalculate;
        private System.Windows.Forms.ComboBox vacation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}

