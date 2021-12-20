namespace Client
{
    partial class TopAlumnoGradoCursoAño
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
            this.cboGrado = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.Documento_alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_name_alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono_alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo_alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.Group = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboAñoLectivo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboGrado
            // 
            this.cboGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrado.FormattingEnabled = true;
            this.cboGrado.Location = new System.Drawing.Point(20, 106);
            this.cboGrado.Name = "cboGrado";
            this.cboGrado.Size = new System.Drawing.Size(110, 21);
            this.cboGrado.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgDatos
            // 
            this.dtgDatos.AllowUserToAddRows = false;
            this.dtgDatos.AllowUserToDeleteRows = false;
            this.dtgDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Documento_alumno,
            this.Full_name_alumno,
            this.Telefono_alumno,
            this.Correo_alumno});
            this.dtgDatos.Location = new System.Drawing.Point(21, 232);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.ReadOnly = true;
            this.dtgDatos.RowHeadersVisible = false;
            this.dtgDatos.Size = new System.Drawing.Size(578, 261);
            this.dtgDatos.TabIndex = 2;
            // 
            // Documento_alumno
            // 
            this.Documento_alumno.DataPropertyName = "Documento_alumno";
            this.Documento_alumno.HeaderText = "Doc. Identidad";
            this.Documento_alumno.Name = "Documento_alumno";
            this.Documento_alumno.ReadOnly = true;
            // 
            // Full_name_alumno
            // 
            this.Full_name_alumno.DataPropertyName = "Full_name_alumno";
            this.Full_name_alumno.HeaderText = "Nombre Completo";
            this.Full_name_alumno.Name = "Full_name_alumno";
            this.Full_name_alumno.ReadOnly = true;
            // 
            // Telefono_alumno
            // 
            this.Telefono_alumno.DataPropertyName = "Telefono_alumno";
            this.Telefono_alumno.HeaderText = "Teléfono";
            this.Telefono_alumno.Name = "Telefono_alumno";
            this.Telefono_alumno.ReadOnly = true;
            // 
            // Correo_alumno
            // 
            this.Correo_alumno.DataPropertyName = "Correo_alumno";
            this.Correo_alumno.HeaderText = "Correo";
            this.Correo_alumno.Name = "Correo_alumno";
            this.Correo_alumno.ReadOnly = true;
            // 
            // cboCurso
            // 
            this.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(20, 156);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(254, 21);
            this.cboCurso.TabIndex = 3;
            // 
            // Group
            // 
            this.Group.Controls.Add(this.label3);
            this.Group.Controls.Add(this.label2);
            this.Group.Controls.Add(this.label1);
            this.Group.Controls.Add(this.cboAñoLectivo);
            this.Group.Controls.Add(this.cboGrado);
            this.Group.Controls.Add(this.cboCurso);
            this.Group.Location = new System.Drawing.Point(21, 21);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(295, 190);
            this.Group.TabIndex = 4;
            this.Group.TabStop = false;
            this.Group.Text = "Propiedades:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Curso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Grado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Año Lectivo:";
            // 
            // cboAñoLectivo
            // 
            this.cboAñoLectivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAñoLectivo.FormattingEnabled = true;
            this.cboAñoLectivo.Location = new System.Drawing.Point(20, 44);
            this.cboAñoLectivo.Name = "cboAñoLectivo";
            this.cboAñoLectivo.Size = new System.Drawing.Size(110, 21);
            this.cboAñoLectivo.TabIndex = 4;
            // 
            // TopAlumnoGradoCursoAño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 505);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.dtgDatos);
            this.Controls.Add(this.button1);
            this.Name = "TopAlumnoGradoCursoAño";
            this.Text = "Consulta Top AlumnoGradoCursoAño";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.Group.ResumeLayout(false);
            this.Group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboGrado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgDatos;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.GroupBox Group;
        private System.Windows.Forms.ComboBox cboAñoLectivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento_alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_name_alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono_alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo_alumno;
    }
}

