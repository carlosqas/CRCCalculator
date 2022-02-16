namespace CRCCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNoCRC = new System.Windows.Forms.Label();
            this.textBoxNoCRC = new System.Windows.Forms.TextBox();
            this.labelWithCRC = new System.Windows.Forms.Label();
            this.textBoxWithCRC = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNoCRC
            // 
            this.labelNoCRC.AutoSize = true;
            this.labelNoCRC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoCRC.Location = new System.Drawing.Point(8, 12);
            this.labelNoCRC.Name = "labelNoCRC";
            this.labelNoCRC.Size = new System.Drawing.Size(246, 19);
            this.labelNoCRC.TabIndex = 0;
            this.labelNoCRC.Text = "Digite o array de bytes sem espaço";
            // 
            // textBoxNoCRC
            // 
            this.textBoxNoCRC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNoCRC.Location = new System.Drawing.Point(12, 34);
            this.textBoxNoCRC.Name = "textBoxNoCRC";
            this.textBoxNoCRC.Size = new System.Drawing.Size(281, 20);
            this.textBoxNoCRC.TabIndex = 1;
            // 
            // labelWithCRC
            // 
            this.labelWithCRC.AutoSize = true;
            this.labelWithCRC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWithCRC.Location = new System.Drawing.Point(8, 63);
            this.labelWithCRC.Name = "labelWithCRC";
            this.labelWithCRC.Size = new System.Drawing.Size(179, 19);
            this.labelWithCRC.TabIndex = 2;
            this.labelWithCRC.Text = "Array de bytes com CRC8";
            // 
            // textBoxWithCRC
            // 
            this.textBoxWithCRC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxWithCRC.Location = new System.Drawing.Point(12, 85);
            this.textBoxWithCRC.Name = "textBoxWithCRC";
            this.textBoxWithCRC.ReadOnly = true;
            this.textBoxWithCRC.Size = new System.Drawing.Size(281, 20);
            this.textBoxWithCRC.TabIndex = 3;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(12, 120);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(281, 32);
            this.buttonCalc.TabIndex = 4;
            this.buttonCalc.Text = "Calcular";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(308, 167);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.textBoxWithCRC);
            this.Controls.Add(this.labelWithCRC);
            this.Controls.Add(this.textBoxNoCRC);
            this.Controls.Add(this.labelNoCRC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRC8 Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNoCRC;
        private System.Windows.Forms.TextBox textBoxNoCRC;
        private System.Windows.Forms.Label labelWithCRC;
        private System.Windows.Forms.TextBox textBoxWithCRC;
        private System.Windows.Forms.Button buttonCalc;
    }
}

