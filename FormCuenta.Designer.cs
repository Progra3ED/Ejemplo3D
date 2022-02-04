namespace Ejemplo3D
{
    partial class FormCuenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumeroCuenta = new System.Windows.Forms.TextBox();
            this.textBoxDpi = new System.Windows.Forms.TextBox();
            this.textBoxSaldo = new System.Windows.Forms.TextBox();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.labelNumeroCuenta = new System.Windows.Forms.Label();
            this.labelDpi = new System.Windows.Forms.Label();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.buttonSalida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número Cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dpi Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo";
            // 
            // textBoxNumeroCuenta
            // 
            this.textBoxNumeroCuenta.Location = new System.Drawing.Point(163, 96);
            this.textBoxNumeroCuenta.Name = "textBoxNumeroCuenta";
            this.textBoxNumeroCuenta.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeroCuenta.TabIndex = 3;
            // 
            // textBoxDpi
            // 
            this.textBoxDpi.Location = new System.Drawing.Point(163, 157);
            this.textBoxDpi.Name = "textBoxDpi";
            this.textBoxDpi.Size = new System.Drawing.Size(100, 20);
            this.textBoxDpi.TabIndex = 4;
            // 
            // textBoxSaldo
            // 
            this.textBoxSaldo.Location = new System.Drawing.Point(163, 226);
            this.textBoxSaldo.Name = "textBoxSaldo";
            this.textBoxSaldo.Size = new System.Drawing.Size(100, 20);
            this.textBoxSaldo.TabIndex = 5;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(163, 321);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(136, 73);
            this.buttonIngresar.TabIndex = 6;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // labelNumeroCuenta
            // 
            this.labelNumeroCuenta.AutoSize = true;
            this.labelNumeroCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroCuenta.Location = new System.Drawing.Point(715, 102);
            this.labelNumeroCuenta.Name = "labelNumeroCuenta";
            this.labelNumeroCuenta.Size = new System.Drawing.Size(22, 31);
            this.labelNumeroCuenta.TabIndex = 7;
            this.labelNumeroCuenta.Text = ".";
            // 
            // labelDpi
            // 
            this.labelDpi.AutoSize = true;
            this.labelDpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDpi.Location = new System.Drawing.Point(715, 173);
            this.labelDpi.Name = "labelDpi";
            this.labelDpi.Size = new System.Drawing.Size(22, 31);
            this.labelDpi.TabIndex = 8;
            this.labelDpi.Text = ".";
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldo.Location = new System.Drawing.Point(715, 247);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(22, 31);
            this.labelSaldo.TabIndex = 9;
            this.labelSaldo.Text = ".";
            // 
            // buttonSalida
            // 
            this.buttonSalida.Location = new System.Drawing.Point(683, 321);
            this.buttonSalida.Name = "buttonSalida";
            this.buttonSalida.Size = new System.Drawing.Size(131, 73);
            this.buttonSalida.TabIndex = 10;
            this.buttonSalida.Text = "Mostrar";
            this.buttonSalida.UseVisualStyleBackColor = true;
            this.buttonSalida.Click += new System.EventHandler(this.buttonSalida_Click);
            // 
            // FormCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 550);
            this.Controls.Add(this.buttonSalida);
            this.Controls.Add(this.labelSaldo);
            this.Controls.Add(this.labelDpi);
            this.Controls.Add(this.labelNumeroCuenta);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.textBoxSaldo);
            this.Controls.Add(this.textBoxDpi);
            this.Controls.Add(this.textBoxNumeroCuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCuenta";
            this.Text = "FormCuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumeroCuenta;
        private System.Windows.Forms.TextBox textBoxDpi;
        private System.Windows.Forms.TextBox textBoxSaldo;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Label labelNumeroCuenta;
        private System.Windows.Forms.Label labelDpi;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Button buttonSalida;
    }
}