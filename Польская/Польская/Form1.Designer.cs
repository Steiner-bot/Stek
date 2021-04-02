
namespace Польская
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
            this.RESH = new System.Windows.Forms.Button();
            this.OUT = new System.Windows.Forms.TextBox();
            this.R = new System.Windows.Forms.Button();
            this.IN = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RESH
            // 
            this.RESH.Location = new System.Drawing.Point(378, 12);
            this.RESH.Name = "RESH";
            this.RESH.Size = new System.Drawing.Size(137, 44);
            this.RESH.TabIndex = 0;
            this.RESH.Text = "Решение";
            this.RESH.UseVisualStyleBackColor = true;
            this.RESH.Click += new System.EventHandler(this.RESH_Click);
            // 
            // OUT
            // 
            this.OUT.Location = new System.Drawing.Point(521, 12);
            this.OUT.Multiline = true;
            this.OUT.Name = "OUT";
            this.OUT.Size = new System.Drawing.Size(217, 44);
            this.OUT.TabIndex = 1;
            this.OUT.TextChanged += new System.EventHandler(this.OUT_TextChanged);
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(235, 12);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(137, 44);
            this.R.TabIndex = 2;
            this.R.Text = "RPN";
            this.R.UseVisualStyleBackColor = true;
            this.R.Click += new System.EventHandler(this.R_Click);
            // 
            // IN
            // 
            this.IN.Location = new System.Drawing.Point(12, 12);
            this.IN.Multiline = true;
            this.IN.Name = "IN";
            this.IN.Size = new System.Drawing.Size(217, 44);
            this.IN.TabIndex = 3;
            this.IN.TextChanged += new System.EventHandler(this.IN_TextChanged);
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(744, 12);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(44, 44);
            this.X.TabIndex = 4;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = true;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 71);
            this.Controls.Add(this.X);
            this.Controls.Add(this.IN);
            this.Controls.Add(this.R);
            this.Controls.Add(this.OUT);
            this.Controls.Add(this.RESH);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RESH;
        private System.Windows.Forms.TextBox OUT;
        private System.Windows.Forms.Button R;
        private System.Windows.Forms.TextBox IN;
        private System.Windows.Forms.Button X;
    }
}

