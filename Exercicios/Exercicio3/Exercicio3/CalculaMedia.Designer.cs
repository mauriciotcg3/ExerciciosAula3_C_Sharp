namespace Exercicio3
{
    partial class btnLimpa
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblMat = new System.Windows.Forms.Label();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.lblN1 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.lblN2 = new System.Windows.Forms.Label();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.lblN3 = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblMediaCalc = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.limpaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(51, 43);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(66, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(140, 43);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(176, 32);
            this.txtNome.TabIndex = 1;
            // 
            // lblMat
            // 
            this.lblMat.AutoSize = true;
            this.lblMat.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMat.Location = new System.Drawing.Point(51, 78);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(81, 25);
            this.lblMat.TabIndex = 2;
            this.lblMat.Text = "Materia:";
            this.lblMat.Click += new System.EventHandler(this.lblMat_Click);
            // 
            // txtMat
            // 
            this.txtMat.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMat.Location = new System.Drawing.Point(139, 82);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(177, 32);
            this.txtMat.TabIndex = 3;
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN1.Location = new System.Drawing.Point(51, 192);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(66, 25);
            this.lblN1.TabIndex = 4;
            this.lblN1.Text = "Nota 1";
            // 
            // txtN1
            // 
            this.txtN1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN1.Location = new System.Drawing.Point(56, 220);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(61, 32);
            this.txtN1.TabIndex = 5;
            this.txtN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtN2
            // 
            this.txtN2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN2.Location = new System.Drawing.Point(123, 220);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(61, 32);
            this.txtN2.TabIndex = 7;
            this.txtN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN2.Location = new System.Drawing.Point(118, 192);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(66, 25);
            this.lblN2.TabIndex = 6;
            this.lblN2.Text = "Nota 2";
            // 
            // txtN3
            // 
            this.txtN3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN3.Location = new System.Drawing.Point(190, 220);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(61, 32);
            this.txtN3.TabIndex = 9;
            this.txtN3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblN3
            // 
            this.lblN3.AutoSize = true;
            this.lblN3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN3.Location = new System.Drawing.Point(185, 192);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(66, 25);
            this.lblN3.TabIndex = 8;
            this.lblN3.Text = "Nota 3";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(308, 163);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(63, 25);
            this.lblMedia.TabIndex = 10;
            this.lblMedia.Text = "Media";
            // 
            // lblMediaCalc
            // 
            this.lblMediaCalc.AutoSize = true;
            this.lblMediaCalc.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaCalc.Location = new System.Drawing.Point(313, 192);
            this.lblMediaCalc.Name = "lblMediaCalc";
            this.lblMediaCalc.Size = new System.Drawing.Size(52, 25);
            this.lblMediaCalc.TabIndex = 11;
            this.lblMediaCalc.Text = "        ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(308, 227);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 25);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "        ";
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnCalc.Location = new System.Drawing.Point(56, 280);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(92, 68);
            this.btnCalc.TabIndex = 13;
            this.btnCalc.Text = "Calcular Media";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // limpaBtn
            // 
            this.limpaBtn.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpaBtn.ForeColor = System.Drawing.Color.LawnGreen;
            this.limpaBtn.Location = new System.Drawing.Point(159, 280);
            this.limpaBtn.Name = "limpaBtn";
            this.limpaBtn.Size = new System.Drawing.Size(92, 68);
            this.limpaBtn.TabIndex = 14;
            this.limpaBtn.Text = "Limpa";
            this.limpaBtn.UseVisualStyleBackColor = true;
            this.limpaBtn.Click += new System.EventHandler(this.limpaBtn_Click);
            // 
            // btnLimpa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.limpaBtn);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblMediaCalc);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.lblN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.lblN1);
            this.Controls.Add(this.txtMat);
            this.Controls.Add(this.lblMat);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "btnLimpa";
            this.Text = "labelMedia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblMat;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.Label lblN3;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblMediaCalc;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button limpaBtn;
    }
}

