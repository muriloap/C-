﻿namespace Medias
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValor1
            // 
            this.txtValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor1.Location = new System.Drawing.Point(48, 72);
            this.txtValor1.Multiline = true;
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(92, 48);
            this.txtValor1.TabIndex = 0;
            this.txtValor1.Text = "0";
            this.txtValor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor1.TextChanged += new System.EventHandler(this.txtValor1_TextChanged);
            // 
            // txtValor2
            // 
            this.txtValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor2.Location = new System.Drawing.Point(184, 72);
            this.txtValor2.Multiline = true;
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(92, 48);
            this.txtValor2.TabIndex = 1;
            this.txtValor2.Text = "0";
            this.txtValor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValor3
            // 
            this.txtValor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor3.Location = new System.Drawing.Point(325, 72);
            this.txtValor3.Multiline = true;
            this.txtValor3.Name = "txtValor3";
            this.txtValor3.Size = new System.Drawing.Size(92, 48);
            this.txtValor3.TabIndex = 2;
            this.txtValor3.Text = "0";
            this.txtValor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(184, 170);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(92, 48);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(496, 333);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValor3);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Name = "frmprincipal";
            this.Text = "Medias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtValor3;
        private System.Windows.Forms.Button btnCalcular;
    }
}

