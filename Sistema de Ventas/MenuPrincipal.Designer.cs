namespace Sistema_de_Ventas
{
    partial class MenuPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btncerrar = new System.Windows.Forms.Button();
            this.pbMantenimiento = new System.Windows.Forms.PictureBox();
            this.pbContabilidad = new System.Windows.Forms.PictureBox();
            this.pbInventario = new System.Windows.Forms.PictureBox();
            this.pbVentas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContabilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 46);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Btncerrar
            // 
            this.Btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btncerrar.Image = global::Sistema_de_Ventas.Properties.Resources.exit;
            this.Btncerrar.Location = new System.Drawing.Point(633, 163);
            this.Btncerrar.Name = "Btncerrar";
            this.Btncerrar.Size = new System.Drawing.Size(100, 83);
            this.Btncerrar.TabIndex = 3;
            this.Btncerrar.UseVisualStyleBackColor = true;
            this.Btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            // 
            // pbMantenimiento
            // 
            this.pbMantenimiento.Image = global::Sistema_de_Ventas.Properties.Resources.mantenimiento;
            this.pbMantenimiento.Location = new System.Drawing.Point(470, 167);
            this.pbMantenimiento.Name = "pbMantenimiento";
            this.pbMantenimiento.Size = new System.Drawing.Size(100, 83);
            this.pbMantenimiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMantenimiento.TabIndex = 0;
            this.pbMantenimiento.TabStop = false;
            this.pbMantenimiento.Click += new System.EventHandler(this.pbMantenimiento_Click);
            // 
            // pbContabilidad
            // 
            this.pbContabilidad.Image = global::Sistema_de_Ventas.Properties.Resources.contabilidad1;
            this.pbContabilidad.Location = new System.Drawing.Point(309, 163);
            this.pbContabilidad.Name = "pbContabilidad";
            this.pbContabilidad.Size = new System.Drawing.Size(100, 83);
            this.pbContabilidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbContabilidad.TabIndex = 0;
            this.pbContabilidad.TabStop = false;
            // 
            // pbInventario
            // 
            this.pbInventario.Image = global::Sistema_de_Ventas.Properties.Resources.inventario;
            this.pbInventario.Location = new System.Drawing.Point(178, 163);
            this.pbInventario.Name = "pbInventario";
            this.pbInventario.Size = new System.Drawing.Size(100, 83);
            this.pbInventario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInventario.TabIndex = 0;
            this.pbInventario.TabStop = false;
            this.pbInventario.Click += new System.EventHandler(this.pbInventario_Click_1);
            // 
            // pbVentas
            // 
            this.pbVentas.Image = global::Sistema_de_Ventas.Properties.Resources.ventas;
            this.pbVentas.Location = new System.Drawing.Point(31, 163);
            this.pbVentas.Name = "pbVentas";
            this.pbVentas.Size = new System.Drawing.Size(107, 83);
            this.pbVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVentas.TabIndex = 0;
            this.pbVentas.TabStop = false;
            this.pbVentas.Click += new System.EventHandler(this.pbVentas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Inventario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contabilidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(457, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mantenimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(660, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Salir";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btncerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbMantenimiento);
            this.Controls.Add(this.pbContabilidad);
            this.Controls.Add(this.pbInventario);
            this.Controls.Add(this.pbVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pbMantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContabilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbVentas;
        private System.Windows.Forms.PictureBox pbInventario;
        private System.Windows.Forms.PictureBox pbContabilidad;
        private System.Windows.Forms.PictureBox pbMantenimiento;
        private System.Windows.Forms.Button Btncerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}