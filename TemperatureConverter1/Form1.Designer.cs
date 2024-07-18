namespace TemperatureConverter1
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
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.rbC2F = new System.Windows.Forms.RadioButton();
            this.rbF2C = new System.Windows.Forms.RadioButton();
            this.rbC2K = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rbF2K = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.Location = new System.Drawing.Point(197, 19);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(255, 25);
            this.lblTemperature.TabIndex = 0;
            this.lblTemperature.Text = "Temperature Converter";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(54, 72);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(107, 18);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "Enter a Value : ";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(518, 72);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(58, 18);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result :";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(54, 119);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(87, 18);
            this.lblSelect.TabIndex = 3;
            this.lblSelect.Text = "Select Unit :";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(57, 93);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(86, 20);
            this.txtValue.TabIndex = 4;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(483, 93);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(124, 20);
            this.txtResult.TabIndex = 5;
            // 
            // rbC2F
            // 
            this.rbC2F.AutoSize = true;
            this.rbC2F.Location = new System.Drawing.Point(57, 140);
            this.rbC2F.Name = "rbC2F";
            this.rbC2F.Size = new System.Drawing.Size(124, 17);
            this.rbC2F.TabIndex = 6;
            this.rbC2F.TabStop = true;
            this.rbC2F.Text = "Celcius to Fahrenheit";
            this.rbC2F.UseVisualStyleBackColor = true;
            // 
            // rbF2C
            // 
            this.rbF2C.AutoSize = true;
            this.rbF2C.Location = new System.Drawing.Point(57, 186);
            this.rbF2C.Name = "rbF2C";
            this.rbF2C.Size = new System.Drawing.Size(124, 17);
            this.rbF2C.TabIndex = 7;
            this.rbF2C.TabStop = true;
            this.rbF2C.Text = "Fahrenheit to Celcius";
            this.rbF2C.UseVisualStyleBackColor = true;
            // 
            // rbC2K
            // 
            this.rbC2K.AutoSize = true;
            this.rbC2K.Location = new System.Drawing.Point(57, 163);
            this.rbC2K.Name = "rbC2K";
            this.rbC2K.Size = new System.Drawing.Size(108, 17);
            this.rbC2K.TabIndex = 8;
            this.rbC2K.TabStop = true;
            this.rbC2K.Text = "Celscius to Kelvin";
            this.rbC2K.UseVisualStyleBackColor = true;
            this.rbC2K.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(52, 248);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(124, 32);
            this.btnConvert.TabIndex = 9;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(279, 248);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(124, 32);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(483, 248);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 32);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rbF2K
            // 
            this.rbF2K.AutoSize = true;
            this.rbF2K.Location = new System.Drawing.Point(57, 209);
            this.rbF2K.Name = "rbF2K";
            this.rbF2K.Size = new System.Drawing.Size(119, 17);
            this.rbF2K.TabIndex = 12;
            this.rbF2K.TabStop = true;
            this.rbF2K.Text = "Fahrenheit to Kelvin";
            this.rbF2K.UseVisualStyleBackColor = true;
            this.rbF2K.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(651, 313);
            this.Controls.Add(this.rbF2K);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.rbC2K);
            this.Controls.Add(this.rbF2C);
            this.Controls.Add(this.rbC2F);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblTemperature);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.RadioButton rbC2F;
        private System.Windows.Forms.RadioButton rbF2C;
        private System.Windows.Forms.RadioButton rbC2K;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rbF2K;
    }
}

