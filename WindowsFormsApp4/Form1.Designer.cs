
namespace WindowsFormsApp4
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
            this.rbtnGerente = new System.Windows.Forms.RadioButton();
            this.rbtnSubGerente = new System.Windows.Forms.RadioButton();
            this.rbtnSecretaria = new System.Windows.Forms.RadioButton();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxSalario = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbtnGerente
            // 
            this.rbtnGerente.AutoSize = true;
            this.rbtnGerente.Location = new System.Drawing.Point(62, 227);
            this.rbtnGerente.Name = "rbtnGerente";
            this.rbtnGerente.Size = new System.Drawing.Size(81, 21);
            this.rbtnGerente.TabIndex = 0;
            this.rbtnGerente.TabStop = true;
            this.rbtnGerente.Text = "Gerente";
            this.rbtnGerente.UseVisualStyleBackColor = true;
            // 
            // rbtnSubGerente
            // 
            this.rbtnSubGerente.AutoSize = true;
            this.rbtnSubGerente.Location = new System.Drawing.Point(322, 227);
            this.rbtnSubGerente.Name = "rbtnSubGerente";
            this.rbtnSubGerente.Size = new System.Drawing.Size(110, 21);
            this.rbtnSubGerente.TabIndex = 1;
            this.rbtnSubGerente.TabStop = true;
            this.rbtnSubGerente.Text = "Sub Gerente";
            this.rbtnSubGerente.UseVisualStyleBackColor = true;
            // 
            // rbtnSecretaria
            // 
            this.rbtnSecretaria.AutoSize = true;
            this.rbtnSecretaria.Location = new System.Drawing.Point(574, 227);
            this.rbtnSecretaria.Name = "rbtnSecretaria";
            this.rbtnSecretaria.Size = new System.Drawing.Size(94, 21);
            this.rbtnSecretaria.TabIndex = 2;
            this.rbtnSecretaria.TabStop = true;
            this.rbtnSecretaria.Text = "Secretaria";
            this.rbtnSecretaria.UseVisualStyleBackColor = true;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(183, 122);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(270, 22);
            this.textBoxNombre.TabIndex = 3;
            // 
            // textBoxSalario
            // 
            this.textBoxSalario.Location = new System.Drawing.Point(574, 119);
            this.textBoxSalario.Name = "textBoxSalario";
            this.textBoxSalario.Size = new System.Drawing.Size(100, 22);
            this.textBoxSalario.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(322, 284);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(102, 36);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(85, 122);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(496, 122);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(52, 17);
            this.lblSalario.TabIndex = 7;
            this.lblSalario.Text = "Salario";
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Location = new System.Drawing.Point(213, 356);
            this.lblAns.MaximumSize = new System.Drawing.Size(350, 100);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(0, 17);
            this.lblAns.TabIndex = 800;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.textBoxSalario);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.rbtnSecretaria);
            this.Controls.Add(this.rbtnSubGerente);
            this.Controls.Add(this.rbtnGerente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnGerente;
        private System.Windows.Forms.RadioButton rbtnSubGerente;
        private System.Windows.Forms.RadioButton rbtnSecretaria;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxSalario;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblAns;
    }
}

