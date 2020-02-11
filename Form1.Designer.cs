namespace Cajero_automatico
{
    partial class Form1
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
            this.txtCantidadProduc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCantidadProdu = new System.Windows.Forms.Label();
            this.txtCantidadPagre = new System.Windows.Forms.TextBox();
            this.btnPagare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRetiro = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnCompletar = new System.Windows.Forms.Button();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFibo = new System.Windows.Forms.Label();
            this.lblFbncc = new System.Windows.Forms.Label();
            this.txtFbncc = new System.Windows.Forms.TextBox();
            this.btnFbncc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCantidadProduc
            // 
            this.txtCantidadProduc.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadProduc.Location = new System.Drawing.Point(119, 90);
            this.txtCantidadProduc.Name = "txtCantidadProduc";
            this.txtCantidadProduc.Size = new System.Drawing.Size(100, 26);
            this.txtCantidadProduc.TabIndex = 33;
            this.txtCantidadProduc.TextChanged += new System.EventHandler(this.txtP_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Dinero";
            // 
            // lblCantidadProdu
            // 
            this.lblCantidadProdu.AutoSize = true;
            this.lblCantidadProdu.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProdu.Location = new System.Drawing.Point(116, 147);
            this.lblCantidadProdu.Name = "lblCantidadProdu";
            this.lblCantidadProdu.Size = new System.Drawing.Size(109, 19);
            this.lblCantidadProdu.TabIndex = 31;
            this.lblCantidadProdu.Text = "Respuesta: ?";
            // 
            // txtCantidadPagre
            // 
            this.txtCantidadPagre.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadPagre.Location = new System.Drawing.Point(119, 118);
            this.txtCantidadPagre.Name = "txtCantidadPagre";
            this.txtCantidadPagre.Size = new System.Drawing.Size(100, 26);
            this.txtCantidadPagre.TabIndex = 30;
            // 
            // btnPagare
            // 
            this.btnPagare.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagare.Location = new System.Drawing.Point(30, 143);
            this.btnPagare.Name = "btnPagare";
            this.btnPagare.Size = new System.Drawing.Size(80, 27);
            this.btnPagare.TabIndex = 29;
            this.btnPagare.Text = "Pago";
            this.btnPagare.UseVisualStyleBackColor = true;
            this.btnPagare.Click += new System.EventHandler(this.btnPagare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Pago";
            // 
            // btnRetiro
            // 
            this.btnRetiro.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetiro.Location = new System.Drawing.Point(451, 36);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(85, 27);
            this.btnRetiro.TabIndex = 27;
            this.btnRetiro.Text = "Retirar";
            this.btnRetiro.UseVisualStyleBackColor = true;
            this.btnRetiro.Click += new System.EventHandler(this.btnRetiro_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(542, 6);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 26);
            this.txtCantidad.TabIndex = 26;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(538, 40);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(109, 19);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "Respuesta: ?";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(454, 9);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(82, 19);
            this.lblCantidad.TabIndex = 24;
            this.lblCantidad.Text = "Cantidad";
            // 
            // btnCompletar
            // 
            this.btnCompletar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompletar.Location = new System.Drawing.Point(30, 40);
            this.btnCompletar.Name = "btnCompletar";
            this.btnCompletar.Size = new System.Drawing.Size(87, 25);
            this.btnCompletar.TabIndex = 41;
            this.btnCompletar.Text = "Resolver";
            this.btnCompletar.UseVisualStyleBackColor = true;
            this.btnCompletar.Click += new System.EventHandler(this.btnCompletar_Click);
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.Location = new System.Drawing.Point(116, 44);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(109, 19);
            this.lblRespuesta.TabIndex = 40;
            this.lblRespuesta.Text = "Respuesta: ?";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(119, 9);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 26);
            this.txtNumero.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "Numero";
            // 
            // lblFibo
            // 
            this.lblFibo.AutoSize = true;
            this.lblFibo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFibo.Location = new System.Drawing.Point(26, 199);
            this.lblFibo.Name = "lblFibo";
            this.lblFibo.Size = new System.Drawing.Size(87, 19);
            this.lblFibo.TabIndex = 37;
            this.lblFibo.Text = "Fibonacci";
            // 
            // lblFbncc
            // 
            this.lblFbncc.AutoSize = true;
            this.lblFbncc.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFbncc.Location = new System.Drawing.Point(112, 229);
            this.lblFbncc.Name = "lblFbncc";
            this.lblFbncc.Size = new System.Drawing.Size(109, 19);
            this.lblFbncc.TabIndex = 36;
            this.lblFbncc.Text = "Respuesta: ?";
            // 
            // txtFbncc
            // 
            this.txtFbncc.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFbncc.Location = new System.Drawing.Point(119, 196);
            this.txtFbncc.Name = "txtFbncc";
            this.txtFbncc.Size = new System.Drawing.Size(102, 26);
            this.txtFbncc.TabIndex = 35;
            // 
            // btnFbncc
            // 
            this.btnFbncc.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFbncc.Location = new System.Drawing.Point(26, 225);
            this.btnFbncc.Name = "btnFbncc";
            this.btnFbncc.Size = new System.Drawing.Size(87, 26);
            this.btnFbncc.TabIndex = 34;
            this.btnFbncc.Text = "Resolver";
            this.btnFbncc.UseVisualStyleBackColor = true;
            this.btnFbncc.Click += new System.EventHandler(this.btnFbncc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 427);
            this.Controls.Add(this.btnCompletar);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFibo);
            this.Controls.Add(this.lblFbncc);
            this.Controls.Add(this.txtFbncc);
            this.Controls.Add(this.btnFbncc);
            this.Controls.Add(this.txtCantidadProduc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCantidadProdu);
            this.Controls.Add(this.txtCantidadPagre);
            this.Controls.Add(this.btnPagare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRetiro);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCantidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Cajero Automatico ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantidadProduc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCantidadProdu;
        private System.Windows.Forms.TextBox txtCantidadPagre;
        private System.Windows.Forms.Button btnPagare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRetiro;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnCompletar;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFibo;
        private System.Windows.Forms.Label lblFbncc;
        private System.Windows.Forms.TextBox txtFbncc;
        private System.Windows.Forms.Button btnFbncc;
    }
}

