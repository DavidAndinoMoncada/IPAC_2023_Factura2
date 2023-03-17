namespace Vista
{
    partial class FacturaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NombreClientetextBox = new System.Windows.Forms.TextBox();
            this.BuscarClientebutton = new System.Windows.Forms.Button();
            this.IdentidadtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ExistenciatextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BuscarProductobutton = new System.Windows.Forms.Button();
            this.DescripcionProductotextBox = new System.Windows.Forms.TextBox();
            this.CodigotextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.SubTotaltextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ISVtextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva Factura";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FechadateTimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.UsuariotextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1089, 65);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(930, 26);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(153, 27);
            this.FechadateTimePicker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(853, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario:";
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.Location = new System.Drawing.Point(133, 26);
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.ReadOnly = true;
            this.UsuariotextBox.Size = new System.Drawing.Size(237, 27);
            this.UsuariotextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NombreClientetextBox);
            this.groupBox2.Controls.Add(this.BuscarClientebutton);
            this.groupBox2.Controls.Add(this.IdentidadtextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1089, 87);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Cliente";
            // 
            // NombreClientetextBox
            // 
            this.NombreClientetextBox.Location = new System.Drawing.Point(425, 39);
            this.NombreClientetextBox.Name = "NombreClientetextBox";
            this.NombreClientetextBox.ReadOnly = true;
            this.NombreClientetextBox.Size = new System.Drawing.Size(646, 27);
            this.NombreClientetextBox.TabIndex = 3;
            // 
            // BuscarClientebutton
            // 
            this.BuscarClientebutton.Location = new System.Drawing.Point(376, 39);
            this.BuscarClientebutton.Name = "BuscarClientebutton";
            this.BuscarClientebutton.Size = new System.Drawing.Size(30, 27);
            this.BuscarClientebutton.TabIndex = 2;
            this.BuscarClientebutton.Text = "...";
            this.BuscarClientebutton.UseVisualStyleBackColor = true;
            this.BuscarClientebutton.Click += new System.EventHandler(this.BuscarClientebutton_Click);
            // 
            // IdentidadtextBox
            // 
            this.IdentidadtextBox.Location = new System.Drawing.Point(133, 39);
            this.IdentidadtextBox.Name = "IdentidadtextBox";
            this.IdentidadtextBox.Size = new System.Drawing.Size(237, 27);
            this.IdentidadtextBox.TabIndex = 1;
            this.IdentidadtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdentidadtextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Identidad:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CantidadtextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.ExistenciatextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.BuscarProductobutton);
            this.groupBox3.Controls.Add(this.DescripcionProductotextBox);
            this.groupBox3.Controls.Add(this.CodigotextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1089, 126);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Producto";
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Location = new System.Drawing.Point(834, 85);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(237, 27);
            this.CantidadtextBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(737, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cantidad:";
            // 
            // ExistenciatextBox
            // 
            this.ExistenciatextBox.Location = new System.Drawing.Point(133, 85);
            this.ExistenciatextBox.Name = "ExistenciatextBox";
            this.ExistenciatextBox.Size = new System.Drawing.Size(237, 27);
            this.ExistenciatextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Existencia:";
            // 
            // BuscarProductobutton
            // 
            this.BuscarProductobutton.Location = new System.Drawing.Point(376, 39);
            this.BuscarProductobutton.Name = "BuscarProductobutton";
            this.BuscarProductobutton.Size = new System.Drawing.Size(30, 27);
            this.BuscarProductobutton.TabIndex = 4;
            this.BuscarProductobutton.Text = "...";
            this.BuscarProductobutton.UseVisualStyleBackColor = true;
            // 
            // DescripcionProductotextBox
            // 
            this.DescripcionProductotextBox.Location = new System.Drawing.Point(425, 39);
            this.DescripcionProductotextBox.Name = "DescripcionProductotextBox";
            this.DescripcionProductotextBox.ReadOnly = true;
            this.DescripcionProductotextBox.Size = new System.Drawing.Size(646, 27);
            this.DescripcionProductotextBox.TabIndex = 3;
            // 
            // CodigotextBox
            // 
            this.CodigotextBox.Location = new System.Drawing.Point(133, 39);
            this.CodigotextBox.Name = "CodigotextBox";
            this.CodigotextBox.Size = new System.Drawing.Size(237, 27);
            this.CodigotextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Codigo:";
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(1, 401);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.RowHeadersWidth = 51;
            this.DetalledataGridView.RowTemplate.Height = 24;
            this.DetalledataGridView.Size = new System.Drawing.Size(1112, 239);
            this.DetalledataGridView.TabIndex = 6;
            // 
            // SubTotaltextBox
            // 
            this.SubTotaltextBox.Location = new System.Drawing.Point(846, 663);
            this.SubTotaltextBox.Name = "SubTotaltextBox";
            this.SubTotaltextBox.ReadOnly = true;
            this.SubTotaltextBox.Size = new System.Drawing.Size(237, 27);
            this.SubTotaltextBox.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(749, 666);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "SubTotal:";
            // 
            // ISVtextBox
            // 
            this.ISVtextBox.Location = new System.Drawing.Point(846, 705);
            this.ISVtextBox.Name = "ISVtextBox";
            this.ISVtextBox.ReadOnly = true;
            this.ISVtextBox.Size = new System.Drawing.Size(237, 27);
            this.ISVtextBox.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(789, 708);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "ISV:";
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(846, 749);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.Size = new System.Drawing.Size(237, 27);
            this.TotaltextBox.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(734, 752);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Descuento:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(846, 791);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(237, 27);
            this.textBox1.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(715, 794);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Total a Pagar:";
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(3, 769);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(124, 49);
            this.Guardarbutton.TabIndex = 17;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Location = new System.Drawing.Point(133, 769);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(124, 49);
            this.Cancelarbutton.TabIndex = 18;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            // 
            // FacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1113, 833);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ISVtextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SubTotaltextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DetalledataGridView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FacturaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacturaForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox NombreClientetextBox;
        private System.Windows.Forms.Button BuscarClientebutton;
        private System.Windows.Forms.TextBox IdentidadtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ExistenciatextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BuscarProductobutton;
        private System.Windows.Forms.TextBox DescripcionProductotextBox;
        private System.Windows.Forms.TextBox CodigotextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.TextBox SubTotaltextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ISVtextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Cancelarbutton;
    }
}