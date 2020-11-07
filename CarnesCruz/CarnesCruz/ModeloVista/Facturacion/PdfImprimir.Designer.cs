namespace CarnesCruz.CarnesCruz.ModeloVista.Facturacion
{
    partial class PdfImprimir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfImprimir));
            this.PreViewPdf = new AxAcroPDFLib.AxAcroPDF();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNombreDelArchivo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelDivPdf = new System.Windows.Forms.Panel();
            this.panelHeaderDivPdf = new System.Windows.Forms.Panel();
            this.panelDivButtons = new System.Windows.Forms.Panel();
            this.AbtnImprimir = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.PreViewPdf)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelDivPdf.SuspendLayout();
            this.panelHeaderDivPdf.SuspendLayout();
            this.panelDivButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreViewPdf
            // 
            this.PreViewPdf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreViewPdf.Enabled = true;
            this.PreViewPdf.Location = new System.Drawing.Point(0, 0);
            this.PreViewPdf.Name = "PreViewPdf";
            this.PreViewPdf.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PreViewPdf.OcxState")));
            this.PreViewPdf.Size = new System.Drawing.Size(848, 713);
            this.PreViewPdf.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(389, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "DOCUMENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(579, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "VISTA PREVIA";
            // 
            // labelNombreDelArchivo
            // 
            this.labelNombreDelArchivo.AutoSize = true;
            this.labelNombreDelArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreDelArchivo.ForeColor = System.Drawing.Color.Black;
            this.labelNombreDelArchivo.Location = new System.Drawing.Point(25, 25);
            this.labelNombreDelArchivo.Name = "labelNombreDelArchivo";
            this.labelNombreDelArchivo.Size = new System.Drawing.Size(51, 20);
            this.labelNombreDelArchivo.TabIndex = 4;
            this.labelNombreDelArchivo.Text = "label3";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::CarnesCruz.Properties.Resources.cancelarBoton;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(3, 101);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(200, 53);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.Control;
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.labelNombreDelArchivo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1054, 78);
            this.panelHeader.TabIndex = 6;
            // 
            // panelDivPdf
            // 
            this.panelDivPdf.Controls.Add(this.panelHeaderDivPdf);
            this.panelDivPdf.Controls.Add(this.PreViewPdf);
            this.panelDivPdf.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDivPdf.Location = new System.Drawing.Point(206, 78);
            this.panelDivPdf.Name = "panelDivPdf";
            this.panelDivPdf.Size = new System.Drawing.Size(848, 713);
            this.panelDivPdf.TabIndex = 7;
            // 
            // panelHeaderDivPdf
            // 
            this.panelHeaderDivPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelHeaderDivPdf.Controls.Add(this.label1);
            this.panelHeaderDivPdf.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderDivPdf.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderDivPdf.Name = "panelHeaderDivPdf";
            this.panelHeaderDivPdf.Size = new System.Drawing.Size(848, 43);
            this.panelHeaderDivPdf.TabIndex = 1;
            // 
            // panelDivButtons
            // 
            this.panelDivButtons.Controls.Add(this.AbtnImprimir);
            this.panelDivButtons.Controls.Add(this.btnCancelar);
            this.panelDivButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDivButtons.Location = new System.Drawing.Point(0, 78);
            this.panelDivButtons.Name = "panelDivButtons";
            this.panelDivButtons.Size = new System.Drawing.Size(206, 713);
            this.panelDivButtons.TabIndex = 8;
            // 
            // AbtnImprimir
            // 
            this.AbtnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AbtnImprimir.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.AbtnImprimir.FlatAppearance.BorderSize = 0;
            this.AbtnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.AbtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AbtnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbtnImprimir.Image = global::CarnesCruz.Properties.Resources.print;
            this.AbtnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AbtnImprimir.Location = new System.Drawing.Point(3, 48);
            this.AbtnImprimir.Name = "AbtnImprimir";
            this.AbtnImprimir.Size = new System.Drawing.Size(200, 47);
            this.AbtnImprimir.TabIndex = 1;
            this.AbtnImprimir.Text = "CONTINUAR";
            this.AbtnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AbtnImprimir.UseVisualStyleBackColor = true;
            this.AbtnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // PdfImprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 791);
            this.Controls.Add(this.panelDivButtons);
            this.Controls.Add(this.panelDivPdf);
            this.Controls.Add(this.panelHeader);
            this.MinimumSize = new System.Drawing.Size(1070, 830);
            this.Name = "PdfImprimir";
            this.Text = "IMPRIMIR";
            ((System.ComponentModel.ISupportInitialize)(this.PreViewPdf)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelDivPdf.ResumeLayout(false);
            this.panelHeaderDivPdf.ResumeLayout(false);
            this.panelHeaderDivPdf.PerformLayout();
            this.panelDivButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AbtnImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        public AxAcroPDFLib.AxAcroPDF PreViewPdf;
        public System.Windows.Forms.Label labelNombreDelArchivo;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelDivPdf;
        private System.Windows.Forms.Panel panelHeaderDivPdf;
        private System.Windows.Forms.Panel panelDivButtons;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}