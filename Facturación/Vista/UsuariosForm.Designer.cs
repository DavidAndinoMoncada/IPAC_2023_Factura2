namespace Vista
{
    partial class UsuariosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosForm));
            this.label1 = new System.Windows.Forms.Label();
            this.CodigotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.ContraseñatextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CorreotextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RolcomboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EstaActivocheckBox = new System.Windows.Forms.CheckBox();
            this.FotopictureBox = new System.Windows.Forms.PictureBox();
            this.AdjuntarFotobutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Modificarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.UsuariosdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.FotopictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // CodigotextBox
            // 
            this.CodigotextBox.Enabled = false;
            this.CodigotextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigotextBox.Location = new System.Drawing.Point(145, 57);
            this.CodigotextBox.Name = "CodigotextBox";
            this.CodigotextBox.Size = new System.Drawing.Size(318, 30);
            this.CodigotextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña:";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Enabled = false;
            this.NombretextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombretextBox.Location = new System.Drawing.Point(145, 105);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(318, 30);
            this.NombretextBox.TabIndex = 4;
            // 
            // ContraseñatextBox
            // 
            this.ContraseñatextBox.Enabled = false;
            this.ContraseñatextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraseñatextBox.Location = new System.Drawing.Point(145, 153);
            this.ContraseñatextBox.Name = "ContraseñatextBox";
            this.ContraseñatextBox.PasswordChar = '*';
            this.ContraseñatextBox.Size = new System.Drawing.Size(318, 30);
            this.ContraseñatextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Correo:";
            // 
            // CorreotextBox
            // 
            this.CorreotextBox.Enabled = false;
            this.CorreotextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreotextBox.Location = new System.Drawing.Point(145, 201);
            this.CorreotextBox.Name = "CorreotextBox";
            this.CorreotextBox.Size = new System.Drawing.Size(318, 30);
            this.CorreotextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rol:";
            // 
            // RolcomboBox
            // 
            this.RolcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RolcomboBox.Enabled = false;
            this.RolcomboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RolcomboBox.FormattingEnabled = true;
            this.RolcomboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.RolcomboBox.Location = new System.Drawing.Point(145, 249);
            this.RolcomboBox.Name = "RolcomboBox";
            this.RolcomboBox.Size = new System.Drawing.Size(318, 30);
            this.RolcomboBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Esta Activo:";
            // 
            // EstaActivocheckBox
            // 
            this.EstaActivocheckBox.AutoSize = true;
            this.EstaActivocheckBox.Enabled = false;
            this.EstaActivocheckBox.Location = new System.Drawing.Point(146, 309);
            this.EstaActivocheckBox.Name = "EstaActivocheckBox";
            this.EstaActivocheckBox.Size = new System.Drawing.Size(18, 17);
            this.EstaActivocheckBox.TabIndex = 11;
            this.EstaActivocheckBox.UseVisualStyleBackColor = true;
            // 
            // FotopictureBox
            // 
            this.FotopictureBox.BackColor = System.Drawing.Color.White;
            this.FotopictureBox.Location = new System.Drawing.Point(544, 61);
            this.FotopictureBox.Name = "FotopictureBox";
            this.FotopictureBox.Size = new System.Drawing.Size(194, 147);
            this.FotopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotopictureBox.TabIndex = 12;
            this.FotopictureBox.TabStop = false;
            // 
            // AdjuntarFotobutton
            // 
            this.AdjuntarFotobutton.Enabled = false;
            this.AdjuntarFotobutton.Image = ((System.Drawing.Image)(resources.GetObject("AdjuntarFotobutton.Image")));
            this.AdjuntarFotobutton.Location = new System.Drawing.Point(735, 173);
            this.AdjuntarFotobutton.Name = "AdjuntarFotobutton";
            this.AdjuntarFotobutton.Size = new System.Drawing.Size(47, 35);
            this.AdjuntarFotobutton.TabIndex = 13;
            this.AdjuntarFotobutton.UseVisualStyleBackColor = true;
            this.AdjuntarFotobutton.Click += new System.EventHandler(this.AdjuntarFotobutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevobutton.Location = new System.Drawing.Point(94, 371);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(101, 34);
            this.Nuevobutton.TabIndex = 14;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Modificarbutton
            // 
            this.Modificarbutton.Enabled = false;
            this.Modificarbutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificarbutton.Location = new System.Drawing.Point(213, 371);
            this.Modificarbutton.Name = "Modificarbutton";
            this.Modificarbutton.Size = new System.Drawing.Size(101, 34);
            this.Modificarbutton.TabIndex = 15;
            this.Modificarbutton.Text = "Modificar";
            this.Modificarbutton.UseVisualStyleBackColor = true;
            this.Modificarbutton.Click += new System.EventHandler(this.Modificarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Enabled = false;
            this.Guardarbutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardarbutton.Location = new System.Drawing.Point(331, 371);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(101, 34);
            this.Guardarbutton.TabIndex = 16;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Enabled = false;
            this.Eliminarbutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminarbutton.Location = new System.Drawing.Point(451, 371);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(101, 34);
            this.Eliminarbutton.TabIndex = 17;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Enabled = false;
            this.Cancelarbutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelarbutton.Location = new System.Drawing.Point(572, 371);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(101, 34);
            this.Cancelarbutton.TabIndex = 18;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UsuariosdataGridView
            // 
            this.UsuariosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosdataGridView.Location = new System.Drawing.Point(0, 462);
            this.UsuariosdataGridView.Name = "UsuariosdataGridView";
            this.UsuariosdataGridView.RowHeadersWidth = 51;
            this.UsuariosdataGridView.RowTemplate.Height = 24;
            this.UsuariosdataGridView.Size = new System.Drawing.Size(942, 172);
            this.UsuariosdataGridView.TabIndex = 19;
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(941, 632);
            this.Controls.Add(this.UsuariosdataGridView);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Modificarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.AdjuntarFotobutton);
            this.Controls.Add(this.FotopictureBox);
            this.Controls.Add(this.EstaActivocheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RolcomboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CorreotextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ContraseñatextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodigotextBox);
            this.Controls.Add(this.label1);
            this.Name = "UsuariosForm";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.UsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FotopictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodigotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox ContraseñatextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CorreotextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox RolcomboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox EstaActivocheckBox;
        private System.Windows.Forms.PictureBox FotopictureBox;
        private System.Windows.Forms.Button AdjuntarFotobutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Modificarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView UsuariosdataGridView;
    }
}