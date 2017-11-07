namespace Task3_GenericVector
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Evaluate = new System.Windows.Forms.Button();
            this.richTextBox_result = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_v1 = new System.Windows.Forms.TextBox();
            this.textBox_v2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Evaluate
            // 
            this.button_Evaluate.Location = new System.Drawing.Point(572, 36);
            this.button_Evaluate.Name = "button_Evaluate";
            this.button_Evaluate.Size = new System.Drawing.Size(75, 23);
            this.button_Evaluate.TabIndex = 0;
            this.button_Evaluate.Text = "Evaluate";
            this.button_Evaluate.UseVisualStyleBackColor = true;
            this.button_Evaluate.Click += new System.EventHandler(this.button_Evaluate_Click);
            // 
            // richTextBox_result
            // 
            this.richTextBox_result.Location = new System.Drawing.Point(12, 150);
            this.richTextBox_result.Name = "richTextBox_result";
            this.richTextBox_result.Size = new System.Drawing.Size(784, 427);
            this.richTextBox_result.TabIndex = 1;
            this.richTextBox_result.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vector1: x(space)y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vector2: x(space)y";
            // 
            // textBox_v1
            // 
            this.textBox_v1.Location = new System.Drawing.Point(125, 36);
            this.textBox_v1.Name = "textBox_v1";
            this.textBox_v1.Size = new System.Drawing.Size(276, 20);
            this.textBox_v1.TabIndex = 3;
            // 
            // textBox_v2
            // 
            this.textBox_v2.Location = new System.Drawing.Point(124, 87);
            this.textBox_v2.Name = "textBox_v2";
            this.textBox_v2.Size = new System.Drawing.Size(276, 20);
            this.textBox_v2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 589);
            this.Controls.Add(this.textBox_v2);
            this.Controls.Add(this.textBox_v1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_result);
            this.Controls.Add(this.button_Evaluate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Evaluate;
        private System.Windows.Forms.RichTextBox richTextBox_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_v1;
        private System.Windows.Forms.TextBox textBox_v2;
    }
}

