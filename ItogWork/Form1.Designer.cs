namespace ItogWork
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
            this.SumZaimInRub = new System.Windows.Forms.TextBox();
            this.Sum = new System.Windows.Forms.Label();
            this.Srok = new System.Windows.Forms.Label();
            this.ProsentTab = new System.Windows.Forms.Label();
            this.Prosents = new System.Windows.Forms.NumericUpDown();
            this.SrokZaima = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Prosents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SrokZaima)).BeginInit();
            this.SuspendLayout();
            // 
            // SumZaimInRub
            // 
            this.SumZaimInRub.Location = new System.Drawing.Point(128, 23);
            this.SumZaimInRub.Name = "SumZaimInRub";
            this.SumZaimInRub.Size = new System.Drawing.Size(100, 20);
            this.SumZaimInRub.TabIndex = 0;
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Location = new System.Drawing.Point(43, 26);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(79, 13);
            this.Sum.TabIndex = 3;
            this.Sum.Text = "Сумма_займа";
            // 
            // Srok
            // 
            this.Srok.AutoSize = true;
            this.Srok.Location = new System.Drawing.Point(14, 78);
            this.Srok.Name = "Srok";
            this.Srok.Size = new System.Drawing.Size(108, 13);
            this.Srok.TabIndex = 4;
            this.Srok.Text = "Срок_займа(в днях)";
            // 
            // ProsentTab
            // 
            this.ProsentTab.AutoSize = true;
            this.ProsentTab.Location = new System.Drawing.Point(72, 121);
            this.ProsentTab.Name = "ProsentTab";
            this.ProsentTab.Size = new System.Drawing.Size(50, 13);
            this.ProsentTab.TabIndex = 5;
            this.ProsentTab.Text = "Процент";
            // 
            // Prosents
            // 
            this.Prosents.DecimalPlaces = 1;
            this.Prosents.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Prosents.Location = new System.Drawing.Point(128, 121);
            this.Prosents.Name = "Prosents";
            this.Prosents.Size = new System.Drawing.Size(120, 20);
            this.Prosents.TabIndex = 6;
            this.Prosents.ValueChanged += new System.EventHandler(this.Prosents_ValueChanged);
            // 
            // SrokZaima
            // 
            this.SrokZaima.Location = new System.Drawing.Point(128, 71);
            this.SrokZaima.Name = "SrokZaima";
            this.SrokZaima.Size = new System.Drawing.Size(120, 20);
            this.SrokZaima.TabIndex = 7;
            this.SrokZaima.ValueChanged += new System.EventHandler(this.SrokZaima_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(92, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 38);
            this.button2.TabIndex = 9;
            this.button2.Text = "Подсчет";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 276);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SrokZaima);
            this.Controls.Add(this.Prosents);
            this.Controls.Add(this.ProsentTab);
            this.Controls.Add(this.Srok);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.SumZaimInRub);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Prosents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SrokZaima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SumZaimInRub;
        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.Label Srok;
        private System.Windows.Forms.Label ProsentTab;
        private System.Windows.Forms.NumericUpDown Prosents;
        private System.Windows.Forms.NumericUpDown SrokZaima;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

