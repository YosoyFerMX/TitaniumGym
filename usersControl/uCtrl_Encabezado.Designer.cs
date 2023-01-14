
namespace System_Titanium.usersControl
{
    partial class uCtrl_Encabezado
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uCtrl_Encabezado));
            this.label4 = new System.Windows.Forms.Label();
            this.btnExitSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerHorayFecha = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(404, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(419, 117);
            this.label4.TabIndex = 7;
            this.label4.Text = "TITANIUM";
            // 
            // btnExitSesion
            // 
            this.btnExitSesion.BackColor = System.Drawing.Color.Orange;
            this.btnExitSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitSesion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitSesion.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExitSesion.Location = new System.Drawing.Point(60, 129);
            this.btnExitSesion.Name = "btnExitSesion";
            this.btnExitSesion.Size = new System.Drawing.Size(105, 31);
            this.btnExitSesion.TabIndex = 9;
            this.btnExitSesion.Text = "Cerrar Sesión";
            this.btnExitSesion.UseVisualStyleBackColor = false;
            this.btnExitSesion.Click += new System.EventHandler(this.btnExitSesion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "BIENVENIDO: ADMINISTRADOR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // timerHorayFecha
            // 
            this.timerHorayFecha.Tick += new System.EventHandler(this.timerHorayFecha_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblHora.Location = new System.Drawing.Point(977, 54);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(137, 51);
            this.lblHora.TabIndex = 13;
            this.lblHora.Text = "HORA";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Green;
            this.lblFecha.Location = new System.Drawing.Point(932, 99);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(56, 19);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "FECHA";
            // 
            // uCtrl_Encabezado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExitSesion);
            this.Controls.Add(this.label4);
            this.Name = "uCtrl_Encabezado";
            this.Size = new System.Drawing.Size(1200, 160);
            this.Load += new System.EventHandler(this.uCtrl_Encabezado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExitSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerHorayFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
    }
}
