
namespace Presentacion
{
    partial class frmAgregar
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
            this.AgregarMarca = new System.Windows.Forms.ComboBox();
            this.AgregarCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AgregarCodigo = new System.Windows.Forms.TextBox();
            this.AgregarNombre = new System.Windows.Forms.TextBox();
            this.AgregarDescripción = new System.Windows.Forms.TextBox();
            this.AgregarPrecio = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelarA = new System.Windows.Forms.Button();
            this.AgregarURL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // AgregarMarca
            // 
            this.AgregarMarca.FormattingEnabled = true;
            this.AgregarMarca.Location = new System.Drawing.Point(96, 188);
            this.AgregarMarca.Name = "AgregarMarca";
            this.AgregarMarca.Size = new System.Drawing.Size(121, 21);
            this.AgregarMarca.TabIndex = 0;
            // 
            // AgregarCategoria
            // 
            this.AgregarCategoria.FormattingEnabled = true;
            this.AgregarCategoria.Location = new System.Drawing.Point(96, 221);
            this.AgregarCategoria.Name = "AgregarCategoria";
            this.AgregarCategoria.Size = new System.Drawing.Size(121, 21);
            this.AgregarCategoria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Marca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Categoría";
            // 
            // AgregarCodigo
            // 
            this.AgregarCodigo.Location = new System.Drawing.Point(96, 36);
            this.AgregarCodigo.Name = "AgregarCodigo";
            this.AgregarCodigo.Size = new System.Drawing.Size(100, 20);
            this.AgregarCodigo.TabIndex = 8;
            this.AgregarCodigo.TextChanged += new System.EventHandler(this.AgregarCodigo_TextChanged);
            // 
            // AgregarNombre
            // 
            this.AgregarNombre.Location = new System.Drawing.Point(96, 75);
            this.AgregarNombre.Name = "AgregarNombre";
            this.AgregarNombre.Size = new System.Drawing.Size(100, 20);
            this.AgregarNombre.TabIndex = 9;
            this.AgregarNombre.TextChanged += new System.EventHandler(this.AgregarNombre_TextChanged);
            // 
            // AgregarDescripción
            // 
            this.AgregarDescripción.Location = new System.Drawing.Point(96, 113);
            this.AgregarDescripción.Name = "AgregarDescripción";
            this.AgregarDescripción.Size = new System.Drawing.Size(221, 20);
            this.AgregarDescripción.TabIndex = 10;
            this.AgregarDescripción.TextChanged += new System.EventHandler(this.AgregarDescripción_TextChanged);
            // 
            // AgregarPrecio
            // 
            this.AgregarPrecio.Location = new System.Drawing.Point(96, 154);
            this.AgregarPrecio.MaxLength = 10;
            this.AgregarPrecio.Name = "AgregarPrecio";
            this.AgregarPrecio.Size = new System.Drawing.Size(100, 20);
            this.AgregarPrecio.TabIndex = 11;
            this.AgregarPrecio.TextChanged += new System.EventHandler(this.AgregarPrecio_TextChanged);
            this.AgregarPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AgregarPrecio_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(96, 309);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelarA
            // 
            this.btnCancelarA.Location = new System.Drawing.Point(233, 309);
            this.btnCancelarA.Name = "btnCancelarA";
            this.btnCancelarA.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarA.TabIndex = 13;
            this.btnCancelarA.Text = "CANCELAR";
            this.btnCancelarA.UseVisualStyleBackColor = true;
            this.btnCancelarA.Click += new System.EventHandler(this.btnCancelarA_Click);
            // 
            // AgregarURL
            // 
            this.AgregarURL.Location = new System.Drawing.Point(96, 255);
            this.AgregarURL.Name = "AgregarURL";
            this.AgregarURL.Size = new System.Drawing.Size(221, 20);
            this.AgregarURL.TabIndex = 15;
            this.AgregarURL.TextChanged += new System.EventHandler(this.AgregarURL_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Imagen URL";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 405);
            this.Controls.Add(this.AgregarURL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancelarA);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.AgregarPrecio);
            this.Controls.Add(this.AgregarDescripción);
            this.Controls.Add(this.AgregarNombre);
            this.Controls.Add(this.AgregarCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgregarCategoria);
            this.Controls.Add(this.AgregarMarca);
            this.Name = "frmAgregar";
            this.Text = "Agregar Artículo";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AgregarMarca;
        private System.Windows.Forms.ComboBox AgregarCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AgregarCodigo;
        private System.Windows.Forms.TextBox AgregarNombre;
        private System.Windows.Forms.TextBox AgregarDescripción;
        private System.Windows.Forms.TextBox AgregarPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelarA;
        private System.Windows.Forms.TextBox AgregarURL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}