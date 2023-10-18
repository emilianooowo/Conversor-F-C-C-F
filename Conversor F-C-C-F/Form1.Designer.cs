namespace Conversor_F_C_C_F
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.FToC_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CtoF_Click = new System.Windows.Forms.Button();
            this.Clear_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FToC_Click
            // 
            this.FToC_Click.Location = new System.Drawing.Point(199, 67);
            this.FToC_Click.Name = "FToC_Click";
            this.FToC_Click.Size = new System.Drawing.Size(161, 23);
            this.FToC_Click.TabIndex = 0;
            this.FToC_Click.Text = "Convertir a Celcius";
            this.FToC_Click.UseVisualStyleBackColor = true;
            this.FToC_Click.Click += new System.EventHandler(this.FToC_Click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONVERSOR";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fahrenheit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Celsius";
            // 
            // CtoF_Click
            // 
            this.CtoF_Click.Location = new System.Drawing.Point(199, 108);
            this.CtoF_Click.Name = "CtoF_Click";
            this.CtoF_Click.Size = new System.Drawing.Size(161, 23);
            this.CtoF_Click.TabIndex = 8;
            this.CtoF_Click.Text = "Convertir a Fahrenheit";
            this.CtoF_Click.UseVisualStyleBackColor = true;
            this.CtoF_Click.Click += new System.EventHandler(this.CtoF_Click_Click);
            // 
            // Clear_Click
            // 
            this.Clear_Click.Location = new System.Drawing.Point(10, 149);
            this.Clear_Click.Name = "Clear_Click";
            this.Clear_Click.Size = new System.Drawing.Size(100, 23);
            this.Clear_Click.TabIndex = 9;
            this.Clear_Click.Text = "Clear";
            this.Clear_Click.UseVisualStyleBackColor = true;
            this.Clear_Click.Click += new System.EventHandler(this.Clear_Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 188);
            this.Controls.Add(this.Clear_Click);
            this.Controls.Add(this.CtoF_Click);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FToC_Click);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FToC_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CtoF_Click;
        private System.Windows.Forms.Button Clear_Click;
    }
}

