namespace CarnesCruz.CarnesCruz.ModeloVista.Facturacion
{
    partial class Pago
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
            this.textBoxCantAPagar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxDeuda = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotalAPagar = new System.Windows.Forms.Label();
            this.labelCambio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCantAPagar2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTotalAPagar2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelCambio2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxDeuda2 = new System.Windows.Forms.CheckBox();
            this.labelNombreCLiente1 = new System.Windows.Forms.Label();
            this.labelNombreCliente2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonPagar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCantAPagar
            // 
            this.textBoxCantAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantAPagar.Location = new System.Drawing.Point(135, 19);
            this.textBoxCantAPagar.Name = "textBoxCantAPagar";
            this.textBoxCantAPagar.ReadOnly = true;
            this.textBoxCantAPagar.Size = new System.Drawing.Size(169, 26);
            this.textBoxCantAPagar.TabIndex = 0;
            this.textBoxCantAPagar.TextChanged += new System.EventHandler(this.textBoxCantAPagar_TextChanged);
            this.textBoxCantAPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCantAPagar_KeyPress);
            this.textBoxCantAPagar.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCantAPagar_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "PAGO:";
            // 
            // checkBoxDeuda
            // 
            this.checkBoxDeuda.AutoSize = true;
            this.checkBoxDeuda.Checked = true;
            this.checkBoxDeuda.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDeuda.Location = new System.Drawing.Point(508, 70);
            this.checkBoxDeuda.Name = "checkBoxDeuda";
            this.checkBoxDeuda.Size = new System.Drawing.Size(100, 24);
            this.checkBoxDeuda.TabIndex = 3;
            this.checkBoxDeuda.Text = "A DEBER";
            this.checkBoxDeuda.UseVisualStyleBackColor = true;
            this.checkBoxDeuda.CheckedChanged += new System.EventHandler(this.checkBoxDeuda_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "PAGO DEL CLIENTE:";
            // 
            // labelTotalAPagar
            // 
            this.labelTotalAPagar.AutoSize = true;
            this.labelTotalAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAPagar.Location = new System.Drawing.Point(131, 63);
            this.labelTotalAPagar.Name = "labelTotalAPagar";
            this.labelTotalAPagar.Size = new System.Drawing.Size(51, 20);
            this.labelTotalAPagar.TabIndex = 5;
            this.labelTotalAPagar.Text = "label3";
            // 
            // labelCambio
            // 
            this.labelCambio.AutoSize = true;
            this.labelCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambio.Location = new System.Drawing.Point(468, 200);
            this.labelCambio.Name = "labelCambio";
            this.labelCambio.Size = new System.Drawing.Size(18, 20);
            this.labelCambio.TabIndex = 6;
            this.labelCambio.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(377, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "A DEBER:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxCantAPagar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelTotalAPagar);
            this.groupBox1.Location = new System.Drawing.Point(82, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 111);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxCantAPagar2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.labelTotalAPagar2);
            this.groupBox2.Location = new System.Drawing.Point(82, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 111);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "PAGO:";
            // 
            // textBoxCantAPagar2
            // 
            this.textBoxCantAPagar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantAPagar2.Location = new System.Drawing.Point(135, 19);
            this.textBoxCantAPagar2.Name = "textBoxCantAPagar2";
            this.textBoxCantAPagar2.ReadOnly = true;
            this.textBoxCantAPagar2.Size = new System.Drawing.Size(169, 26);
            this.textBoxCantAPagar2.TabIndex = 0;
            this.textBoxCantAPagar2.TextChanged += new System.EventHandler(this.textBoxCantAPagar2_TextChanged);
            this.textBoxCantAPagar2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCantAPagar2_KeyPress);
            this.textBoxCantAPagar2.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCantAPagar2_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total:";
            // 
            // labelTotalAPagar2
            // 
            this.labelTotalAPagar2.AutoSize = true;
            this.labelTotalAPagar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAPagar2.Location = new System.Drawing.Point(131, 63);
            this.labelTotalAPagar2.Name = "labelTotalAPagar2";
            this.labelTotalAPagar2.Size = new System.Drawing.Size(51, 20);
            this.labelTotalAPagar2.TabIndex = 5;
            this.labelTotalAPagar2.Text = "label3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(377, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "A DEBER:";
            // 
            // labelCambio2
            // 
            this.labelCambio2.AutoSize = true;
            this.labelCambio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambio2.Location = new System.Drawing.Point(468, 451);
            this.labelCambio2.Name = "labelCambio2";
            this.labelCambio2.Size = new System.Drawing.Size(18, 20);
            this.labelCambio2.TabIndex = 12;
            this.labelCambio2.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(5, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 10);
            this.panel1.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(78, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 24);
            this.label10.TabIndex = 14;
            this.label10.Text = "PAGO DEL CLIENTE:";
            // 
            // checkBoxDeuda2
            // 
            this.checkBoxDeuda2.AutoSize = true;
            this.checkBoxDeuda2.Checked = true;
            this.checkBoxDeuda2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeuda2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxDeuda2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDeuda2.Location = new System.Drawing.Point(508, 319);
            this.checkBoxDeuda2.Name = "checkBoxDeuda2";
            this.checkBoxDeuda2.Size = new System.Drawing.Size(100, 24);
            this.checkBoxDeuda2.TabIndex = 15;
            this.checkBoxDeuda2.Text = "A DEBER";
            this.checkBoxDeuda2.UseVisualStyleBackColor = true;
            this.checkBoxDeuda2.CheckedChanged += new System.EventHandler(this.checkBoxDeuda2_CheckedChanged);
            // 
            // labelNombreCLiente1
            // 
            this.labelNombreCLiente1.AutoSize = true;
            this.labelNombreCLiente1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCLiente1.Location = new System.Drawing.Point(278, 17);
            this.labelNombreCLiente1.Name = "labelNombreCLiente1";
            this.labelNombreCLiente1.Size = new System.Drawing.Size(60, 20);
            this.labelNombreCLiente1.TabIndex = 16;
            this.labelNombreCLiente1.Text = "label11";
            // 
            // labelNombreCliente2
            // 
            this.labelNombreCliente2.AutoSize = true;
            this.labelNombreCliente2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCliente2.Location = new System.Drawing.Point(278, 271);
            this.labelNombreCliente2.Name = "labelNombreCliente2";
            this.labelNombreCliente2.Size = new System.Drawing.Size(60, 20);
            this.labelNombreCliente2.TabIndex = 17;
            this.labelNombreCliente2.Text = "label12";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 559);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 16);
            this.panel2.TabIndex = 19;
            // 
            // ButtonPagar
            // 
            this.ButtonPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPagar.FlatAppearance.BorderSize = 0;
            this.ButtonPagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.ButtonPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPagar.Image = global::CarnesCruz.Properties.Resources.next;
            this.ButtonPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonPagar.Location = new System.Drawing.Point(471, 499);
            this.ButtonPagar.Name = "ButtonPagar";
            this.ButtonPagar.Size = new System.Drawing.Size(137, 44);
            this.ButtonPagar.TabIndex = 18;
            this.ButtonPagar.Text = "SIGUENTE";
            this.ButtonPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonPagar.UseVisualStyleBackColor = true;
            this.ButtonPagar.Click += new System.EventHandler(this.ButtonPagar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = global::CarnesCruz.Properties.Resources.cancelarBoton;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(12, 499);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(137, 44);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "CANCELAR";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(615, 575);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ButtonPagar);
            this.Controls.Add(this.labelNombreCliente2);
            this.Controls.Add(this.labelNombreCLiente1);
            this.Controls.Add(this.checkBoxDeuda2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelCambio2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelCambio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxDeuda);
            this.MaximumSize = new System.Drawing.Size(631, 614);
            this.MinimumSize = new System.Drawing.Size(631, 614);
            this.Name = "Pago";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAGO";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCantAPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCambio;
        public System.Windows.Forms.Label labelTotalAPagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCantAPagar2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label labelTotalAPagar2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelCambio2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label labelNombreCliente2;
        public System.Windows.Forms.Label labelNombreCLiente1;
        private System.Windows.Forms.Button ButtonPagar;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.CheckBox checkBoxDeuda;
        public System.Windows.Forms.CheckBox checkBoxDeuda2;
    }
}