namespace cripto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbOpcciones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valor1 = new System.Windows.Forms.TextBox();
            this.txtres = new System.Windows.Forms.TextBox();
            this.cmb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbOpcciones
            // 
            this.cmbOpcciones.FormattingEnabled = true;
            this.cmbOpcciones.Items.AddRange(new object[] {
            "Doge",
            "XRP",
            "Bitcoin",
            "BAT"});
            this.cmbOpcciones.Location = new System.Drawing.Point(320, 74);
            this.cmbOpcciones.Name = "cmbOpcciones";
            this.cmbOpcciones.Size = new System.Drawing.Size(121, 23);
            this.cmbOpcciones.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Criptomonedas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "total-precio";
            // 
            // valor1
            // 
            this.valor1.Location = new System.Drawing.Point(320, 157);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(100, 23);
            this.valor1.TabIndex = 4;
            // 
            // txtres
            // 
            this.txtres.Location = new System.Drawing.Point(320, 228);
            this.txtres.Name = "txtres";
            this.txtres.ReadOnly = true;
            this.txtres.Size = new System.Drawing.Size(100, 23);
            this.txtres.TabIndex = 5;
            // 
            // cmb
            // 
            this.cmb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmb.Location = new System.Drawing.Point(294, 273);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(164, 85);
            this.cmb.TabIndex = 6;
            this.cmb.Text = "Conversion";
            this.cmb.UseVisualStyleBackColor = false;
            this.cmb.Click += new System.EventHandler(this.btnconver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.txtres);
            this.Controls.Add(this.valor1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOpcciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbOpcciones;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox valor1;
        private TextBox res;
        private Button cmb;
        private TextBox txtres;
    }
}