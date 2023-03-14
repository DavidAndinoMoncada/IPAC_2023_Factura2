namespace Vista
{
    partial class ProductosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductosForm));
            this.label1 = new System.Windows.Forms.Label();
            this.CodigotextBox = new System.Windows.Forms.TextBox();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.ExistenciatextBox = new System.Windows.Forms.TextBox();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FotopictureBox = new System.Windows.Forms.PictureBox();
            this.AdjuntarImagenbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Modificarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.EstaActivocheckBox = new System.Windows.Forms.CheckBox();
            this.ProductosdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.FotopictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // CodigotextBox
            // 
            this.CodigotextBox.Enabled = false;
            this.CodigotextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigotextBox.Location = new System.Drawing.Point(147, 56);
            this.CodigotextBox.Name = "CodigotextBox";
            this.CodigotextBox.Size = new System.Drawing.Size(326, 30);
            this.CodigotextBox.TabIndex = 1;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Enabled = false;
            this.DescripciontextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripciontextBox.Location = new System.Drawing.Point(147, 107);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(326, 30);
            this.DescripciontextBox.TabIndex = 2;
            // 
            // ExistenciatextBox
            // 
            this.ExistenciatextBox.Enabled = false;
            this.ExistenciatextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExistenciatextBox.Location = new System.Drawing.Point(147, 159);
            this.ExistenciatextBox.Name = "ExistenciatextBox";
            this.ExistenciatextBox.Size = new System.Drawing.Size(326, 30);
            this.ExistenciatextBox.TabIndex = 3;
            this.ExistenciatextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExistenciatextBox_KeyPress);
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Enabled = false;
            this.PreciotextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreciotextBox.Location = new System.Drawing.Point(147, 212);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(326, 30);
            this.PreciotextBox.TabIndex = 4;
            this.PreciotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreciotextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Existencia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio:";
            // 
            // FotopictureBox
            // 
            this.FotopictureBox.BackColor = System.Drawing.Color.White;
            this.FotopictureBox.Location = new System.Drawing.Point(523, 56);
            this.FotopictureBox.Name = "FotopictureBox";
            this.FotopictureBox.Size = new System.Drawing.Size(185, 162);
            this.FotopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotopictureBox.TabIndex = 9;
            this.FotopictureBox.TabStop = false;
            // 
            // AdjuntarImagenbutton
            // 
            this.AdjuntarImagenbutton.Enabled = false;
            this.AdjuntarImagenbutton.Image = ((System.Drawing.Image)(resources.GetObject("AdjuntarImagenbutton.Image")));
            this.AdjuntarImagenbutton.Location = new System.Drawing.Point(705, 184);
            this.AdjuntarImagenbutton.Name = "AdjuntarImagenbutton";
            this.AdjuntarImagenbutton.Size = new System.Drawing.Size(45, 34);
            this.AdjuntarImagenbutton.TabIndex = 10;
            this.AdjuntarImagenbutton.UseVisualStyleBackColor = true;
            this.AdjuntarImagenbutton.Click += new System.EventHandler(this.AdjuntarImagenbutton_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Enabled = false;
            this.Cancelarbutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelarbutton.Location = new System.Drawing.Point(579, 332);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(101, 34);
            this.Cancelarbutton.TabIndex = 23;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Enabled = false;
            this.Eliminarbutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminarbutton.Location = new System.Drawing.Point(458, 332);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(101, 34);
            this.Eliminarbutton.TabIndex = 22;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Enabled = false;
            this.Guardarbutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardarbutton.Location = new System.Drawing.Point(338, 332);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(101, 34);
            this.Guardarbutton.TabIndex = 21;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Modificarbutton
            // 
            this.Modificarbutton.Enabled = false;
            this.Modificarbutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificarbutton.Location = new System.Drawing.Point(220, 332);
            this.Modificarbutton.Name = "Modificarbutton";
            this.Modificarbutton.Size = new System.Drawing.Size(101, 34);
            this.Modificarbutton.TabIndex = 20;
            this.Modificarbutton.Text = "Modificar";
            this.Modificarbutton.UseVisualStyleBackColor = true;
            this.Modificarbutton.Click += new System.EventHandler(this.Modificarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevobutton.Location = new System.Drawing.Point(101, 332);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(101, 34);
            this.Nuevobutton.TabIndex = 19;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Esta Activo";
            // 
            // EstaActivocheckBox
            // 
            this.EstaActivocheckBox.AutoSize = true;
            this.EstaActivocheckBox.Location = new System.Drawing.Point(147, 265);
            this.EstaActivocheckBox.Name = "EstaActivocheckBox";
            this.EstaActivocheckBox.Size = new System.Drawing.Size(18, 17);
            this.EstaActivocheckBox.TabIndex = 26;
            this.EstaActivocheckBox.UseVisualStyleBackColor = true;
            // 
            // ProductosdataGridView
            // 
            this.ProductosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosdataGridView.Location = new System.Drawing.Point(-2, 389);
            this.ProductosdataGridView.Name = "ProductosdataGridView";
            this.ProductosdataGridView.RowHeadersWidth = 51;
            this.ProductosdataGridView.RowTemplate.Height = 24;
            this.ProductosdataGridView.Size = new System.Drawing.Size(941, 186);
            this.ProductosdataGridView.TabIndex = 27;
            // 
            // ProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 574);
            this.Controls.Add(this.ProductosdataGridView);
            this.Controls.Add(this.EstaActivocheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Modificarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.AdjuntarImagenbutton);
            this.Controls.Add(this.FotopictureBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.ExistenciatextBox);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.CodigotextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductosForm";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.ProductosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FotopictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodigotextBox;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.TextBox ExistenciatextBox;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox FotopictureBox;
        private System.Windows.Forms.Button AdjuntarImagenbutton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Modificarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox EstaActivocheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView ProductosdataGridView;
    }
}