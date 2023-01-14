
namespace System_Titanium.Presentation
{
    partial class frmAgregarMensu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.upDaawnMens = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.cmbAreas = new System.Windows.Forms.ComboBox();
            this.btnBuscarSocio = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.sdfs = new System.Windows.Forms.Label();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbOrdinario = new System.Windows.Forms.RadioButton();
            this.rdbQuienceDias = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDaawnMens)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.upDaawnMens);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpInicio);
            this.groupBox1.Controls.Add(this.cmbAreas);
            this.groupBox1.Controls.Add(this.btnBuscarSocio);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.lbltitle);
            this.groupBox1.Controls.Add(this.sdfs);
            this.groupBox1.Controls.Add(this.btnCobrar);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(30, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(144, 230);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.Size = new System.Drawing.Size(203, 26);
            this.txtMonto.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(66, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 75;
            this.label2.Text = "Monto: ";
            // 
            // upDaawnMens
            // 
            this.upDaawnMens.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDaawnMens.Location = new System.Drawing.Point(321, 295);
            this.upDaawnMens.Name = "upDaawnMens";
            this.upDaawnMens.Size = new System.Drawing.Size(60, 26);
            this.upDaawnMens.TabIndex = 74;
            this.upDaawnMens.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.upDaawnMens.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(227, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 22);
            this.label1.TabIndex = 73;
            this.label1.Text = "Mensualidades a abonar";
            // 
            // dtpInicio
            // 
            this.dtpInicio.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Location = new System.Drawing.Point(15, 295);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpInicio.TabIndex = 72;
            // 
            // cmbAreas
            // 
            this.cmbAreas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAreas.FormattingEnabled = true;
            this.cmbAreas.Location = new System.Drawing.Point(143, 187);
            this.cmbAreas.Name = "cmbAreas";
            this.cmbAreas.Size = new System.Drawing.Size(204, 28);
            this.cmbAreas.TabIndex = 71;
            this.cmbAreas.SelectedValueChanged += new System.EventHandler(this.cmbAreas_SelectedValueChanged);
            // 
            // btnBuscarSocio
            // 
            this.btnBuscarSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btnBuscarSocio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarSocio.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnBuscarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarSocio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarSocio.ForeColor = System.Drawing.Color.LightGray;
            this.btnBuscarSocio.Location = new System.Drawing.Point(353, 83);
            this.btnBuscarSocio.Name = "btnBuscarSocio";
            this.btnBuscarSocio.Size = new System.Drawing.Size(45, 26);
            this.btnBuscarSocio.TabIndex = 70;
            this.btnBuscarSocio.Text = "...";
            this.btnBuscarSocio.UseVisualStyleBackColor = false;
            this.btnBuscarSocio.Click += new System.EventHandler(this.btnBuscarSocio_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.AutoSize = true;
            this.txtCorreo.BackColor = System.Drawing.Color.Transparent;
            this.txtCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtCorreo.Location = new System.Drawing.Point(38, 270);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(161, 22);
            this.txtCorreo.TabIndex = 68;
            this.txtCorreo.Text = "Inicio de Periodo";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.BackColor = System.Drawing.Color.Transparent;
            this.lbltitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbltitle.Location = new System.Drawing.Point(79, 18);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(325, 22);
            this.lbltitle.TabIndex = 67;
            this.lbltitle.Text = "Agregue una nueva mensualidad";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sdfs
            // 
            this.sdfs.AutoSize = true;
            this.sdfs.BackColor = System.Drawing.Color.Transparent;
            this.sdfs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdfs.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdfs.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sdfs.Location = new System.Drawing.Point(76, 188);
            this.sdfs.Name = "sdfs";
            this.sdfs.Size = new System.Drawing.Size(68, 22);
            this.sdfs.TabIndex = 65;
            this.sdfs.Text = "Areas:";
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btnCobrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCobrar.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.ForeColor = System.Drawing.Color.LightGray;
            this.btnCobrar.Location = new System.Drawing.Point(80, 336);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(286, 32);
            this.btnCobrar.TabIndex = 64;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(144, 83);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(203, 26);
            this.txtNom.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(84, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 62;
            this.label3.Text = "Socio:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnCerrar.Location = new System.Drawing.Point(499, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(31, 29);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbQuienceDias);
            this.groupBox3.Controls.Add(this.rdbOrdinario);
            this.groupBox3.Location = new System.Drawing.Point(144, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 55);
            this.groupBox3.TabIndex = 78;
            this.groupBox3.TabStop = false;
            // 
            // rdbOrdinario
            // 
            this.rdbOrdinario.AutoSize = true;
            this.rdbOrdinario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOrdinario.Location = new System.Drawing.Point(7, 19);
            this.rdbOrdinario.Name = "rdbOrdinario";
            this.rdbOrdinario.Size = new System.Drawing.Size(101, 25);
            this.rdbOrdinario.TabIndex = 0;
            this.rdbOrdinario.TabStop = true;
            this.rdbOrdinario.Text = "Ordinaria";
            this.rdbOrdinario.UseVisualStyleBackColor = true;
            this.rdbOrdinario.CheckedChanged += new System.EventHandler(this.rdbOrdinario_CheckedChanged);
            // 
            // rdbQuienceDias
            // 
            this.rdbQuienceDias.AutoSize = true;
            this.rdbQuienceDias.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbQuienceDias.Location = new System.Drawing.Point(115, 19);
            this.rdbQuienceDias.Name = "rdbQuienceDias";
            this.rdbQuienceDias.Size = new System.Drawing.Size(82, 25);
            this.rdbQuienceDias.TabIndex = 1;
            this.rdbQuienceDias.TabStop = true;
            this.rdbQuienceDias.Text = "15 Días";
            this.rdbQuienceDias.UseVisualStyleBackColor = true;
            this.rdbQuienceDias.CheckedChanged += new System.EventHandler(this.rdbQuienceDias_CheckedChanged);
            // 
            // frmAgregarMensu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(531, 475);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarMensu";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarMensu";
            this.Load += new System.EventHandler(this.frmAgregarMensu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDaawnMens)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtCorreo;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label sdfs;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.ComboBox cmbAreas;
        private System.Windows.Forms.Button btnBuscarSocio;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown upDaawnMens;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbQuienceDias;
        private System.Windows.Forms.RadioButton rdbOrdinario;
    }
}