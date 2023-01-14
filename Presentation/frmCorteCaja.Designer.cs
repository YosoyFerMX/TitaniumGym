
namespace System_Titanium.Presentation
{
    partial class frmCorteCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCorteCaja));
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfcaja = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRetiroCorte = new System.Windows.Forms.TextBox();
            this.txtefectivoContado = new System.Windows.Forms.TextBox();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnArqueo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMovcaja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(503, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 32);
            this.label3.TabIndex = 73;
            this.label3.Text = "Ajustes\r\nde Caja";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfcaja
            // 
            this.btnConfcaja.BackColor = System.Drawing.Color.Transparent;
            this.btnConfcaja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfcaja.BackgroundImage")));
            this.btnConfcaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfcaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfcaja.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfcaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfcaja.Location = new System.Drawing.Point(487, 12);
            this.btnConfcaja.Name = "btnConfcaja";
            this.btnConfcaja.Size = new System.Drawing.Size(81, 66);
            this.btnConfcaja.TabIndex = 72;
            this.btnConfcaja.UseVisualStyleBackColor = false;
            this.btnConfcaja.Click += new System.EventHandler(this.btnConfcaja_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(71, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 22);
            this.label11.TabIndex = 75;
            this.label11.Text = "Efectivo Contado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(303, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 22);
            this.label1.TabIndex = 77;
            this.label1.Text = "Retiro por Corte";
            // 
            // txtRetiroCorte
            // 
            this.txtRetiroCorte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetiroCorte.ForeColor = System.Drawing.Color.Olive;
            this.txtRetiroCorte.Location = new System.Drawing.Point(308, 135);
            this.txtRetiroCorte.Name = "txtRetiroCorte";
            this.txtRetiroCorte.Size = new System.Drawing.Size(138, 27);
            this.txtRetiroCorte.TabIndex = 76;
            this.txtRetiroCorte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRetiroCorte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRetiroCorte_KeyPress);
            // 
            // txtefectivoContado
            // 
            this.txtefectivoContado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtefectivoContado.ForeColor = System.Drawing.Color.Olive;
            this.txtefectivoContado.Location = new System.Drawing.Point(85, 135);
            this.txtefectivoContado.Name = "txtefectivoContado";
            this.txtefectivoContado.Size = new System.Drawing.Size(138, 27);
            this.txtefectivoContado.TabIndex = 78;
            this.txtefectivoContado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtefectivoContado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtefectivoContado_KeyPress);
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btnCobrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCobrar.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.ForeColor = System.Drawing.Color.LightGray;
            this.btnCobrar.Location = new System.Drawing.Point(118, 212);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(286, 32);
            this.btnCobrar.TabIndex = 79;
            this.btnCobrar.Text = "Guardar";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnArqueo
            // 
            this.btnArqueo.BackColor = System.Drawing.Color.Transparent;
            this.btnArqueo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArqueo.BackgroundImage")));
            this.btnArqueo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnArqueo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArqueo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnArqueo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArqueo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArqueo.ForeColor = System.Drawing.Color.LightGray;
            this.btnArqueo.Location = new System.Drawing.Point(226, 130);
            this.btnArqueo.Name = "btnArqueo";
            this.btnArqueo.Size = new System.Drawing.Size(32, 36);
            this.btnArqueo.TabIndex = 80;
            this.btnArqueo.UseVisualStyleBackColor = false;
            this.btnArqueo.Click += new System.EventHandler(this.btnArqueo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(503, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 48);
            this.label2.TabIndex = 82;
            this.label2.Text = "Salida\r\nde\r\nEfectivo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMovcaja
            // 
            this.btnMovcaja.BackColor = System.Drawing.Color.Transparent;
            this.btnMovcaja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMovcaja.BackgroundImage")));
            this.btnMovcaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMovcaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovcaja.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMovcaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovcaja.Location = new System.Drawing.Point(487, 130);
            this.btnMovcaja.Name = "btnMovcaja";
            this.btnMovcaja.Size = new System.Drawing.Size(81, 66);
            this.btnMovcaja.TabIndex = 81;
            this.btnMovcaja.UseVisualStyleBackColor = false;
            this.btnMovcaja.Click += new System.EventHandler(this.btnMovcaja_Click);
            // 
            // frmCorteCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(588, 298);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMovcaja);
            this.Controls.Add(this.btnArqueo);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.txtefectivoContado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRetiroCorte);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConfcaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCorteCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Corte de Caja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfcaja;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRetiroCorte;
        private System.Windows.Forms.TextBox txtefectivoContado;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnArqueo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMovcaja;
    }
}