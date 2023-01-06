namespace FigurasGeometricas
{
    partial class AreaTriangulo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblAreaEquilatero = new System.Windows.Forms.Label();
            this.tbLado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblAreaEscaleno = new System.Windows.Forms.Label();
            this.tbAltura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(260, 238);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblAreaEquilatero);
            this.tabPage1.Controls.Add(this.tbLado);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(252, 212);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Equilátero";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblAreaEquilatero
            // 
            this.lblAreaEquilatero.AutoSize = true;
            this.lblAreaEquilatero.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblAreaEquilatero.Location = new System.Drawing.Point(18, 133);
            this.lblAreaEquilatero.Name = "lblAreaEquilatero";
            this.lblAreaEquilatero.Size = new System.Drawing.Size(0, 42);
            this.lblAreaEquilatero.TabIndex = 2;
            // 
            // tbLado
            // 
            this.tbLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.tbLado.Location = new System.Drawing.Point(130, 49);
            this.tbLado.Name = "tbLado";
            this.tbLado.Size = new System.Drawing.Size(100, 49);
            this.tbLado.TabIndex = 1;
            this.tbLado.TextChanged += new System.EventHandler(this.tbLado_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(18, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lado";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblAreaEscaleno);
            this.tabPage2.Controls.Add(this.tbAltura);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tbBase);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(252, 212);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Escaleno";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblAreaEscaleno
            // 
            this.lblAreaEscaleno.AutoSize = true;
            this.lblAreaEscaleno.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblAreaEscaleno.Location = new System.Drawing.Point(6, 147);
            this.lblAreaEscaleno.Name = "lblAreaEscaleno";
            this.lblAreaEscaleno.Size = new System.Drawing.Size(0, 42);
            this.lblAreaEscaleno.TabIndex = 4;
            // 
            // tbAltura
            // 
            this.tbAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.tbAltura.Location = new System.Drawing.Point(120, 84);
            this.tbAltura.Name = "tbAltura";
            this.tbAltura.Size = new System.Drawing.Size(100, 49);
            this.tbAltura.TabIndex = 3;
            this.tbAltura.TextChanged += new System.EventHandler(this.tbAltura_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Altura";
            // 
            // tbBase
            // 
            this.tbBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.tbBase.Location = new System.Drawing.Point(120, 26);
            this.tbBase.Name = "tbBase";
            this.tbBase.Size = new System.Drawing.Size(100, 49);
            this.tbBase.TabIndex = 1;
            this.tbBase.TextChanged += new System.EventHandler(this.tbBase_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base";
            // 
            // AreaTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AreaTriangulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Área Triângulo";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAreaEscaleno;
        private System.Windows.Forms.TextBox tbAltura;
        private System.Windows.Forms.Label lblAreaEquilatero;
        private System.Windows.Forms.TextBox tbLado;
        private System.Windows.Forms.Label label3;
    }
}