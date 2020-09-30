namespace CarnesCruz.CarnesCruz.ModeloVista.Reporte
{
    partial class Reporte
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewHistoriaCompras = new System.Windows.Forms.DataGridView();
            this.textBoxBuscarCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.msjAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.btnAbonarDeuda = new System.Windows.Forms.Button();
            this.BtnCancelarNota = new System.Windows.Forms.Button();
            this.ButtonGenerarReporte = new System.Windows.Forms.Button();
            this.pictureBoxClearCliente = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoriaCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClearCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHistoriaCompras
            // 
            this.dataGridViewHistoriaCompras.AllowUserToAddRows = false;
            this.dataGridViewHistoriaCompras.AllowUserToDeleteRows = false;
            this.dataGridViewHistoriaCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHistoriaCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewHistoriaCompras.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewHistoriaCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistoriaCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewHistoriaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistoriaCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHistoriaCompras.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewHistoriaCompras.Location = new System.Drawing.Point(48, 159);
            this.dataGridViewHistoriaCompras.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewHistoriaCompras.Name = "dataGridViewHistoriaCompras";
            this.dataGridViewHistoriaCompras.ReadOnly = true;
            this.dataGridViewHistoriaCompras.RowTemplate.Height = 24;
            this.dataGridViewHistoriaCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHistoriaCompras.Size = new System.Drawing.Size(1042, 348);
            this.dataGridViewHistoriaCompras.TabIndex = 27;
            this.dataGridViewHistoriaCompras.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHistoriaCompras_CellDoubleClick);
            // 
            // textBoxBuscarCliente
            // 
            this.textBoxBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarCliente.Location = new System.Drawing.Point(112, 118);
            this.textBoxBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBuscarCliente.Name = "textBoxBuscarCliente";
            this.textBoxBuscarCliente.Size = new System.Drawing.Size(320, 26);
            this.textBoxBuscarCliente.TabIndex = 26;
            this.textBoxBuscarCliente.TextChanged += new System.EventHandler(this.textBoxBuscarCliente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(46, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(461, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "REPORTE DE CARTERA";
            // 
            // btnAbonarDeuda
            // 
            this.btnAbonarDeuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbonarDeuda.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAbonarDeuda.FlatAppearance.BorderSize = 0;
            this.btnAbonarDeuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAbonarDeuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbonarDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbonarDeuda.Image = global::CarnesCruz.Properties.Resources.piggy;
            this.btnAbonarDeuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbonarDeuda.Location = new System.Drawing.Point(49, 512);
            this.btnAbonarDeuda.Name = "btnAbonarDeuda";
            this.btnAbonarDeuda.Size = new System.Drawing.Size(161, 48);
            this.btnAbonarDeuda.TabIndex = 32;
            this.btnAbonarDeuda.Text = "Abonar Deuda";
            this.btnAbonarDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbonarDeuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbonarDeuda.UseVisualStyleBackColor = true;
            this.btnAbonarDeuda.Click += new System.EventHandler(this.btnAbonarDeuda_Click);
            // 
            // BtnCancelarNota
            // 
            this.BtnCancelarNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelarNota.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.BtnCancelarNota.FlatAppearance.BorderSize = 0;
            this.BtnCancelarNota.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnCancelarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarNota.Image = global::CarnesCruz.Properties.Resources.cancel;
            this.BtnCancelarNota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarNota.Location = new System.Drawing.Point(216, 512);
            this.BtnCancelarNota.Name = "BtnCancelarNota";
            this.BtnCancelarNota.Size = new System.Drawing.Size(161, 48);
            this.BtnCancelarNota.TabIndex = 31;
            this.BtnCancelarNota.Text = "Cancelar Nota";
            this.BtnCancelarNota.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelarNota.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelarNota.UseVisualStyleBackColor = true;
            this.BtnCancelarNota.Click += new System.EventHandler(this.BtnCancelarNota_Click);
            // 
            // ButtonGenerarReporte
            // 
            this.ButtonGenerarReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonGenerarReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGenerarReporte.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonGenerarReporte.FlatAppearance.BorderSize = 0;
            this.ButtonGenerarReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.ButtonGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGenerarReporte.Image = global::CarnesCruz.Properties.Resources.Reporte;
            this.ButtonGenerarReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonGenerarReporte.Location = new System.Drawing.Point(955, 12);
            this.ButtonGenerarReporte.Name = "ButtonGenerarReporte";
            this.ButtonGenerarReporte.Size = new System.Drawing.Size(180, 51);
            this.ButtonGenerarReporte.TabIndex = 30;
            this.ButtonGenerarReporte.Text = "Generar Reporte";
            this.ButtonGenerarReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonGenerarReporte.UseVisualStyleBackColor = true;
            this.ButtonGenerarReporte.Click += new System.EventHandler(this.ButtonGenerarReporte_Click);
            // 
            // pictureBoxClearCliente
            // 
            this.pictureBoxClearCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClearCliente.Image = global::CarnesCruz.Properties.Resources.limpiar;
            this.pictureBoxClearCliente.Location = new System.Drawing.Point(454, 118);
            this.pictureBoxClearCliente.Name = "pictureBoxClearCliente";
            this.pictureBoxClearCliente.Size = new System.Drawing.Size(38, 26);
            this.pictureBoxClearCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClearCliente.TabIndex = 28;
            this.pictureBoxClearCliente.TabStop = false;
            this.pictureBoxClearCliente.Click += new System.EventHandler(this.pictureBoxClearCliente_Click);
            this.pictureBoxClearCliente.MouseEnter += new System.EventHandler(this.pictureBoxClearCliente_MouseEnter);
            this.pictureBoxClearCliente.MouseLeave += new System.EventHandler(this.pictureBoxClearCliente_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Buscar";
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1147, 587);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAbonarDeuda);
            this.Controls.Add(this.BtnCancelarNota);
            this.Controls.Add(this.ButtonGenerarReporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxClearCliente);
            this.Controls.Add(this.dataGridViewHistoriaCompras);
            this.Controls.Add(this.textBoxBuscarCliente);
            this.Controls.Add(this.label1);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoriaCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClearCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClearCliente;
        private System.Windows.Forms.DataGridView dataGridViewHistoriaCompras;
        private System.Windows.Forms.TextBox textBoxBuscarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip msjAyuda;
        private System.Windows.Forms.Button ButtonGenerarReporte;
        private System.Windows.Forms.Button BtnCancelarNota;
        private System.Windows.Forms.Button btnAbonarDeuda;
        private System.Windows.Forms.Label label4;
    }
}