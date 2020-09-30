namespace CarnesCruz.CarnesCruz.ModeloVista.Reporte
{
    partial class PdfRuta
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.textBoxNombreArchivo = new System.Windows.Forms.TextBox();
            this.btnPathCarpeta = new System.Windows.Forms.Button();
            this.btnNombreArchivo = new System.Windows.Forms.Button();
            this.labelRutaArchivo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 259);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 16);
            this.panel2.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "GUARDAR ARCHIVO";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::CarnesCruz.Properties.Resources.cancelarBoton;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(221, 159);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 44);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // textBoxNombreArchivo
            // 
            this.textBoxNombreArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreArchivo.Location = new System.Drawing.Point(221, 54);
            this.textBoxNombreArchivo.Name = "textBoxNombreArchivo";
            this.textBoxNombreArchivo.ReadOnly = true;
            this.textBoxNombreArchivo.Size = new System.Drawing.Size(382, 29);
            this.textBoxNombreArchivo.TabIndex = 24;
            // 
            // btnPathCarpeta
            // 
            this.btnPathCarpeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPathCarpeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPathCarpeta.FlatAppearance.BorderSize = 0;
            this.btnPathCarpeta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnPathCarpeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPathCarpeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPathCarpeta.Location = new System.Drawing.Point(609, 118);
            this.btnPathCarpeta.Name = "btnPathCarpeta";
            this.btnPathCarpeta.Size = new System.Drawing.Size(124, 31);
            this.btnPathCarpeta.TabIndex = 23;
            this.btnPathCarpeta.Text = "Carpeta";
            this.btnPathCarpeta.UseVisualStyleBackColor = true;
            this.btnPathCarpeta.Click += new System.EventHandler(this.btnPathCarpeta_Click);
            // 
            // btnNombreArchivo
            // 
            this.btnNombreArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNombreArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNombreArchivo.FlatAppearance.BorderSize = 0;
            this.btnNombreArchivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnNombreArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNombreArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNombreArchivo.Location = new System.Drawing.Point(609, 52);
            this.btnNombreArchivo.Name = "btnNombreArchivo";
            this.btnNombreArchivo.Size = new System.Drawing.Size(124, 31);
            this.btnNombreArchivo.TabIndex = 22;
            this.btnNombreArchivo.Text = "Editar";
            this.btnNombreArchivo.UseVisualStyleBackColor = true;
            this.btnNombreArchivo.Click += new System.EventHandler(this.btnNombreArchivo_Click);
            // 
            // labelRutaArchivo
            // 
            this.labelRutaArchivo.AutoEllipsis = true;
            this.labelRutaArchivo.AutoSize = true;
            this.labelRutaArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRutaArchivo.Location = new System.Drawing.Point(217, 118);
            this.labelRutaArchivo.Name = "labelRutaArchivo";
            this.labelRutaArchivo.Size = new System.Drawing.Size(60, 24);
            this.labelRutaArchivo.TabIndex = 21;
            this.labelRutaArchivo.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre del Archivo:";
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImprimir.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonImprimir.FlatAppearance.BorderSize = 0;
            this.buttonImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImprimir.Image = global::CarnesCruz.Properties.Resources.next;
            this.buttonImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonImprimir.Location = new System.Drawing.Point(403, 158);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(137, 44);
            this.buttonImprimir.TabIndex = 19;
            this.buttonImprimir.Text = "SIGUIENTE";
            this.buttonImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonImprimir.UseVisualStyleBackColor = true;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Almacenar en Carpeta:";
            // 
            // PdfRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(744, 275);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.textBoxNombreArchivo);
            this.Controls.Add(this.btnPathCarpeta);
            this.Controls.Add(this.btnNombreArchivo);
            this.Controls.Add(this.labelRutaArchivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.label1);
            this.Name = "PdfRuta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PdfRuta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox textBoxNombreArchivo;
        private System.Windows.Forms.Button btnPathCarpeta;
        private System.Windows.Forms.Button btnNombreArchivo;
        public System.Windows.Forms.Label labelRutaArchivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}