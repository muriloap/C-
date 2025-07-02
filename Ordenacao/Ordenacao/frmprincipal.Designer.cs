namespace Ordenacao
{
    partial class frmprincipal
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
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtValor3 = new System.Windows.Forms.TextBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lblCresc1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCresc2 = new System.Windows.Forms.Label();
            this.lblCresc3 = new System.Windows.Forms.Label();
            this.lblDecresc1 = new System.Windows.Forms.Label();
            this.lblDecresc2 = new System.Windows.Forms.Label();
            this.lblDecresc3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValor1
            // 
            this.txtValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor1.Location = new System.Drawing.Point(46, 68);
            this.txtValor1.Multiline = true;
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(91, 40);
            this.txtValor1.TabIndex = 0;
            this.txtValor1.Text = "0";
            this.txtValor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor1.TextChanged += new System.EventHandler(this.txtValor1_TextChanged);
            // 
            // txtValor2
            // 
            this.txtValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor2.Location = new System.Drawing.Point(143, 68);
            this.txtValor2.Multiline = true;
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(91, 40);
            this.txtValor2.TabIndex = 1;
            this.txtValor2.Text = "0";
            this.txtValor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor2.TextChanged += new System.EventHandler(this.txtValor2_TextChanged);
            // 
            // txtValor3
            // 
            this.txtValor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor3.Location = new System.Drawing.Point(240, 68);
            this.txtValor3.Multiline = true;
            this.txtValor3.Name = "txtValor3";
            this.txtValor3.Size = new System.Drawing.Size(91, 40);
            this.txtValor3.TabIndex = 2;
            this.txtValor3.Text = "0";
            this.txtValor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor3.TextChanged += new System.EventHandler(this.txtValor3_TextChanged);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.Location = new System.Drawing.Point(143, 157);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(91, 40);
            this.btnOrdenar.TabIndex = 3;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // lblCresc1
            // 
            this.lblCresc1.Location = new System.Drawing.Point(154, 238);
            this.lblCresc1.Name = "lblCresc1";
            this.lblCresc1.Size = new System.Drawing.Size(55, 41);
            this.lblCresc1.TabIndex = 4;
            this.lblCresc1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCresc1.Click += new System.EventHandler(this.lblCresc_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Crescente:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Decrescente:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblCresc2
            // 
            this.lblCresc2.Location = new System.Drawing.Point(215, 238);
            this.lblCresc2.Name = "lblCresc2";
            this.lblCresc2.Size = new System.Drawing.Size(55, 41);
            this.lblCresc2.TabIndex = 8;
            this.lblCresc2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCresc2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCresc3
            // 
            this.lblCresc3.Location = new System.Drawing.Point(276, 238);
            this.lblCresc3.Name = "lblCresc3";
            this.lblCresc3.Size = new System.Drawing.Size(55, 41);
            this.lblCresc3.TabIndex = 9;
            this.lblCresc3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDecresc1
            // 
            this.lblDecresc1.Location = new System.Drawing.Point(154, 321);
            this.lblDecresc1.Name = "lblDecresc1";
            this.lblDecresc1.Size = new System.Drawing.Size(55, 41);
            this.lblDecresc1.TabIndex = 10;
            this.lblDecresc1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDecresc2
            // 
            this.lblDecresc2.Location = new System.Drawing.Point(215, 321);
            this.lblDecresc2.Name = "lblDecresc2";
            this.lblDecresc2.Size = new System.Drawing.Size(55, 41);
            this.lblDecresc2.TabIndex = 11;
            this.lblDecresc2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDecresc3
            // 
            this.lblDecresc3.Location = new System.Drawing.Point(276, 321);
            this.lblDecresc3.Name = "lblDecresc3";
            this.lblDecresc3.Size = new System.Drawing.Size(55, 41);
            this.lblDecresc3.TabIndex = 12;
            this.lblDecresc3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 469);
            this.Controls.Add(this.lblDecresc3);
            this.Controls.Add(this.lblDecresc2);
            this.Controls.Add(this.lblDecresc1);
            this.Controls.Add(this.lblCresc3);
            this.Controls.Add(this.lblCresc2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCresc1);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.txtValor3);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Name = "frmprincipal";
            this.Text = "Ordenação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtValor3;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label lblCresc1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCresc2;
        private System.Windows.Forms.Label lblCresc3;
        private System.Windows.Forms.Label lblDecresc1;
        private System.Windows.Forms.Label lblDecresc2;
        private System.Windows.Forms.Label lblDecresc3;
    }
}

