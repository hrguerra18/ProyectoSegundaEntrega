﻿namespace PAYMETF
{
    partial class FrmCartera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCartera));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataIngresos = new System.Windows.Forms.DataGridView();
            this.DataCartera = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.DataClientes = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDinerodisponible = new System.Windows.Forms.TextBox();
            this.txtDineroprestado = new System.Windows.Forms.TextBox();
            this.txtDeudores = new System.Windows.Forms.TextBox();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.btnGenerarExcel = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataCartera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataClientes)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.Minimizar);
            this.panel1.Controls.Add(this.Cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 29);
            this.panel1.TabIndex = 0;
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(742, 3);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(20, 20);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 2;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Location = new System.Drawing.Point(768, 3);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(20, 20);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cerrar.TabIndex = 1;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(170, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "INGRESOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(557, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "CARTERA";
            // 
            // DataIngresos
            // 
            this.DataIngresos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataIngresos.Location = new System.Drawing.Point(36, 63);
            this.DataIngresos.Name = "DataIngresos";
            this.DataIngresos.Size = new System.Drawing.Size(358, 150);
            this.DataIngresos.TabIndex = 3;
            // 
            // DataCartera
            // 
            this.DataCartera.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataCartera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataCartera.Location = new System.Drawing.Point(404, 63);
            this.DataCartera.Name = "DataCartera";
            this.DataCartera.Size = new System.Drawing.Size(358, 150);
            this.DataCartera.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(170, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "CLIENTES";
            // 
            // DataClientes
            // 
            this.DataClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataClientes.Location = new System.Drawing.Point(36, 232);
            this.DataClientes.Name = "DataClientes";
            this.DataClientes.Size = new System.Drawing.Size(358, 150);
            this.DataClientes.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(60, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "DEUDORES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "DINERO PRESTADO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(76, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "CAPITAL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "DINERO DISPONIBLE";
            // 
            // txtDinerodisponible
            // 
            this.txtDinerodisponible.Location = new System.Drawing.Point(140, 12);
            this.txtDinerodisponible.Name = "txtDinerodisponible";
            this.txtDinerodisponible.Size = new System.Drawing.Size(100, 20);
            this.txtDinerodisponible.TabIndex = 11;
            // 
            // txtDineroprestado
            // 
            this.txtDineroprestado.Location = new System.Drawing.Point(140, 43);
            this.txtDineroprestado.Name = "txtDineroprestado";
            this.txtDineroprestado.Size = new System.Drawing.Size(100, 20);
            this.txtDineroprestado.TabIndex = 12;
            // 
            // txtDeudores
            // 
            this.txtDeudores.Location = new System.Drawing.Point(140, 79);
            this.txtDeudores.Name = "txtDeudores";
            this.txtDeudores.Size = new System.Drawing.Size(100, 20);
            this.txtDeudores.TabIndex = 13;
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(140, 114);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(100, 20);
            this.txtCapital.TabIndex = 14;
            // 
            // btnGenerarExcel
            // 
            this.btnGenerarExcel.BackColor = System.Drawing.Color.White;
            this.btnGenerarExcel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerarExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarExcel.Image")));
            this.btnGenerarExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGenerarExcel.Location = new System.Drawing.Point(243, 12);
            this.btnGenerarExcel.Name = "btnGenerarExcel";
            this.btnGenerarExcel.Size = new System.Drawing.Size(118, 123);
            this.btnGenerarExcel.TabIndex = 15;
            this.btnGenerarExcel.Text = "GENERAR EXCEL";
            this.btnGenerarExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerarExcel.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(647, 388);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(121, 29);
            this.btnCerrar.TabIndex = 16;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnGenerarExcel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtCapital);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtDeudores);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtDineroprestado);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtDinerodisponible);
            this.panel2.Location = new System.Drawing.Point(404, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 150);
            this.panel2.TabIndex = 17;
            // 
            // FrmCartera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.DataClientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataCartera);
            this.Controls.Add(this.DataIngresos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCartera";
            this.Text = "Cartera";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataIngresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataCartera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataClientes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DataIngresos;
        private System.Windows.Forms.DataGridView DataCartera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDinerodisponible;
        private System.Windows.Forms.TextBox txtDineroprestado;
        private System.Windows.Forms.TextBox txtDeudores;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.Button btnGenerarExcel;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel2;
    }
}