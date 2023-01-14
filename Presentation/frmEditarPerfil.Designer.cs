
namespace System_Titanium.Presentation
{
    partial class frmEditarPerfil
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarPerfil));
            this.picbBuscarImg = new System.Windows.Forms.PictureBox();
            this.btnSelectImg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNvaContra = new System.Windows.Forms.TextBox();
            this.txtRepContra = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.erProvUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.erProvContra = new System.Windows.Forms.ErrorProvider(this.components);
            this.erProvRepContr = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picbBuscarImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erProvUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erProvContra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erProvRepContr)).BeginInit();
            this.SuspendLayout();
            // 
            // picbBuscarImg
            // 
            this.picbBuscarImg.Image = ((System.Drawing.Image)(resources.GetObject("picbBuscarImg.Image")));
            this.picbBuscarImg.Location = new System.Drawing.Point(128, 30);
            this.picbBuscarImg.Name = "picbBuscarImg";
            this.picbBuscarImg.Size = new System.Drawing.Size(156, 170);
            this.picbBuscarImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbBuscarImg.TabIndex = 0;
            this.picbBuscarImg.TabStop = false;
            // 
            // btnSelectImg
            // 
            this.btnSelectImg.BackColor = System.Drawing.Color.Turquoise;
            this.btnSelectImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectImg.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectImg.Location = new System.Drawing.Point(46, 219);
            this.btnSelectImg.Name = "btnSelectImg";
            this.btnSelectImg.Size = new System.Drawing.Size(311, 38);
            this.btnSelectImg.TabIndex = 1;
            this.btnSelectImg.Text = "Seleccionar Imagen";
            this.btnSelectImg.UseVisualStyleBackColor = false;
            this.btnSelectImg.Click += new System.EventHandler(this.btnSelectImg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(12, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nuevo nombre de Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(60, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nueva contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(53, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Repetir Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(192, 288);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(181, 24);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtNvaContra
            // 
            this.txtNvaContra.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNvaContra.Location = new System.Drawing.Point(192, 325);
            this.txtNvaContra.Name = "txtNvaContra";
            this.txtNvaContra.Size = new System.Drawing.Size(181, 24);
            this.txtNvaContra.TabIndex = 6;
            this.txtNvaContra.TextChanged += new System.EventHandler(this.txtNvaContra_TextChanged);
            // 
            // txtRepContra
            // 
            this.txtRepContra.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepContra.Location = new System.Drawing.Point(192, 361);
            this.txtRepContra.Name = "txtRepContra";
            this.txtRepContra.Size = new System.Drawing.Size(181, 24);
            this.txtRepContra.TabIndex = 7;
            this.txtRepContra.TextChanged += new System.EventHandler(this.txtRepContra_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Turquoise;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(36, 431);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(146, 54);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Turquoise;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(211, 431);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(146, 54);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // erProvUsuario
            // 
            this.erProvUsuario.ContainerControl = this;
            // 
            // erProvContra
            // 
            this.erProvContra.ContainerControl = this;
            // 
            // erProvRepContr
            // 
            this.erProvRepContr.ContainerControl = this;
            // 
            // frmEditarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(409, 544);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtRepContra);
            this.Controls.Add(this.txtNvaContra);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectImg);
            this.Controls.Add(this.picbBuscarImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmEditarPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbBuscarImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erProvUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erProvContra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erProvRepContr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbBuscarImg;
        private System.Windows.Forms.Button btnSelectImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtNvaContra;
        private System.Windows.Forms.TextBox txtRepContra;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider erProvUsuario;
        private System.Windows.Forms.ErrorProvider erProvContra;
        private System.Windows.Forms.ErrorProvider erProvRepContr;
    }
}