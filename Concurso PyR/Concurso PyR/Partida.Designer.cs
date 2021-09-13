
namespace Concurso_PyR
{
    partial class Partida
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lbPuntaje = new System.Windows.Forms.Label();
            this.lbPregunta = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.pnOpciones = new System.Windows.Forms.Panel();
            this.btnOpcionCuatro = new System.Windows.Forms.Button();
            this.btnOpcionTres = new System.Windows.Forms.Button();
            this.btnOpcionDos = new System.Windows.Forms.Button();
            this.btnOpcionUno = new System.Windows.Forms.Button();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btRenaudar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lbMenu = new System.Windows.Forms.Label();
            this.imgMascota = new System.Windows.Forms.PictureBox();
            this.pnOpciones.SuspendLayout();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbNombre.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbNombre.Location = new System.Drawing.Point(83, 25);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(258, 63);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "NOMBRE:";
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(82, 105);
            this.tbNombre.Multiline = true;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(296, 31);
            this.tbNombre.TabIndex = 2;
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre_KeyPress);
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpezar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEmpezar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpezar.FlatAppearance.BorderSize = 3;
            this.btnEmpezar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEmpezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpezar.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpezar.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnEmpezar.Location = new System.Drawing.Point(413, 89);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(147, 50);
            this.btnEmpezar.TabIndex = 3;
            this.btnEmpezar.Text = "Empezar";
            this.btnEmpezar.UseVisualStyleBackColor = false;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 3;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnMenu.Location = new System.Drawing.Point(841, 25);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(147, 50);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "MENU";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Visible = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lbPuntaje
            // 
            this.lbPuntaje.AutoSize = true;
            this.lbPuntaje.BackColor = System.Drawing.Color.Transparent;
            this.lbPuntaje.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPuntaje.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbPuntaje.Location = new System.Drawing.Point(347, 25);
            this.lbPuntaje.Name = "lbPuntaje";
            this.lbPuntaje.Size = new System.Drawing.Size(62, 63);
            this.lbPuntaje.TabIndex = 6;
            this.lbPuntaje.Text = "0";
            this.lbPuntaje.Visible = false;
            // 
            // lbPregunta
            // 
            this.lbPregunta.BackColor = System.Drawing.Color.Transparent;
            this.lbPregunta.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPregunta.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbPregunta.Location = new System.Drawing.Point(53, 217);
            this.lbPregunta.Name = "lbPregunta";
            this.lbPregunta.Size = new System.Drawing.Size(877, 74);
            this.lbPregunta.TabIndex = 7;
            this.lbPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCategoria
            // 
            this.lbCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lbCategoria.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbCategoria.Location = new System.Drawing.Point(277, 139);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(435, 70);
            this.lbCategoria.TabIndex = 8;
            this.lbCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCategoria.Visible = false;
            // 
            // pnOpciones
            // 
            this.pnOpciones.BackColor = System.Drawing.Color.Transparent;
            this.pnOpciones.Controls.Add(this.btnOpcionCuatro);
            this.pnOpciones.Controls.Add(this.btnOpcionTres);
            this.pnOpciones.Controls.Add(this.btnOpcionDos);
            this.pnOpciones.Controls.Add(this.btnOpcionUno);
            this.pnOpciones.Location = new System.Drawing.Point(59, 326);
            this.pnOpciones.Name = "pnOpciones";
            this.pnOpciones.Size = new System.Drawing.Size(856, 239);
            this.pnOpciones.TabIndex = 9;
            this.pnOpciones.Visible = false;
            // 
            // btnOpcionCuatro
            // 
            this.btnOpcionCuatro.BackColor = System.Drawing.Color.Transparent;
            this.btnOpcionCuatro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOpcionCuatro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpcionCuatro.FlatAppearance.BorderSize = 3;
            this.btnOpcionCuatro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOpcionCuatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcionCuatro.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcionCuatro.ForeColor = System.Drawing.Color.LightYellow;
            this.btnOpcionCuatro.Location = new System.Drawing.Point(496, 122);
            this.btnOpcionCuatro.Name = "btnOpcionCuatro";
            this.btnOpcionCuatro.Size = new System.Drawing.Size(268, 96);
            this.btnOpcionCuatro.TabIndex = 16;
            this.btnOpcionCuatro.UseVisualStyleBackColor = false;
            this.btnOpcionCuatro.Click += new System.EventHandler(this.btnOpcionCuatro_Click);
            // 
            // btnOpcionTres
            // 
            this.btnOpcionTres.BackColor = System.Drawing.Color.Transparent;
            this.btnOpcionTres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOpcionTres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpcionTres.FlatAppearance.BorderSize = 3;
            this.btnOpcionTres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOpcionTres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcionTres.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcionTres.ForeColor = System.Drawing.Color.LightYellow;
            this.btnOpcionTres.Location = new System.Drawing.Point(93, 122);
            this.btnOpcionTres.Name = "btnOpcionTres";
            this.btnOpcionTres.Size = new System.Drawing.Size(268, 96);
            this.btnOpcionTres.TabIndex = 15;
            this.btnOpcionTres.UseVisualStyleBackColor = false;
            this.btnOpcionTres.Click += new System.EventHandler(this.btnOpcionTres_Click);
            // 
            // btnOpcionDos
            // 
            this.btnOpcionDos.BackColor = System.Drawing.Color.Transparent;
            this.btnOpcionDos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOpcionDos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpcionDos.FlatAppearance.BorderSize = 3;
            this.btnOpcionDos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOpcionDos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcionDos.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcionDos.ForeColor = System.Drawing.Color.LightYellow;
            this.btnOpcionDos.Location = new System.Drawing.Point(496, 20);
            this.btnOpcionDos.Name = "btnOpcionDos";
            this.btnOpcionDos.Size = new System.Drawing.Size(268, 96);
            this.btnOpcionDos.TabIndex = 14;
            this.btnOpcionDos.UseVisualStyleBackColor = false;
            this.btnOpcionDos.Click += new System.EventHandler(this.btnOpcionDos_Click);
            // 
            // btnOpcionUno
            // 
            this.btnOpcionUno.BackColor = System.Drawing.Color.Transparent;
            this.btnOpcionUno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOpcionUno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpcionUno.FlatAppearance.BorderSize = 3;
            this.btnOpcionUno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOpcionUno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcionUno.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcionUno.ForeColor = System.Drawing.Color.LightYellow;
            this.btnOpcionUno.Location = new System.Drawing.Point(93, 20);
            this.btnOpcionUno.Name = "btnOpcionUno";
            this.btnOpcionUno.Size = new System.Drawing.Size(268, 96);
            this.btnOpcionUno.TabIndex = 13;
            this.btnOpcionUno.UseVisualStyleBackColor = false;
            this.btnOpcionUno.Click += new System.EventHandler(this.btnOpcionUno_Click);
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(40)))));
            this.pnMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnMenu.Controls.Add(this.btRenaudar);
            this.pnMenu.Controls.Add(this.btnSalir);
            this.pnMenu.Controls.Add(this.btnInicio);
            this.pnMenu.Controls.Add(this.lbMenu);
            this.pnMenu.Location = new System.Drawing.Point(335, 162);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(386, 356);
            this.pnMenu.TabIndex = 5;
            this.pnMenu.Visible = false;
            // 
            // btRenaudar
            // 
            this.btRenaudar.BackColor = System.Drawing.Color.Transparent;
            this.btRenaudar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btRenaudar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRenaudar.FlatAppearance.BorderSize = 3;
            this.btRenaudar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btRenaudar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRenaudar.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRenaudar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btRenaudar.Location = new System.Drawing.Point(97, 260);
            this.btRenaudar.Name = "btRenaudar";
            this.btRenaudar.Size = new System.Drawing.Size(179, 52);
            this.btRenaudar.TabIndex = 8;
            this.btRenaudar.Text = "Renaudar";
            this.btRenaudar.UseVisualStyleBackColor = false;
            this.btRenaudar.Click += new System.EventHandler(this.btRenaudar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 3;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Maroon;
            this.btnSalir.Location = new System.Drawing.Point(97, 186);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(179, 49);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 3;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.btnInicio.Location = new System.Drawing.Point(97, 106);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(179, 52);
            this.btnInicio.TabIndex = 6;
            this.btnInicio.Text = "Ir a inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbMenu.Location = new System.Drawing.Point(94, 27);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(176, 63);
            this.lbMenu.TabIndex = 0;
            this.lbMenu.Text = "MENU";
            // 
            // imgMascota
            // 
            this.imgMascota.BackColor = System.Drawing.Color.Transparent;
            this.imgMascota.Image = global::Concurso_PyR.Properties.Resources.pincel;
            this.imgMascota.Location = new System.Drawing.Point(653, 12);
            this.imgMascota.Name = "imgMascota";
            this.imgMascota.Size = new System.Drawing.Size(170, 189);
            this.imgMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMascota.TabIndex = 10;
            this.imgMascota.TabStop = false;
            this.imgMascota.Visible = false;
            // 
            // Partida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = global::Concurso_PyR.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1010, 630);
            this.Controls.Add(this.imgMascota);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnEmpezar);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbPuntaje);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbPregunta);
            this.Controls.Add(this.pnOpciones);
            this.Controls.Add(this.lbCategoria);
            this.Name = "Partida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnOpciones.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMascota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lbPuntaje;
        private System.Windows.Forms.Label lbPregunta;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Panel pnOpciones;
        private System.Windows.Forms.Button btnOpcionCuatro;
        private System.Windows.Forms.Button btnOpcionTres;
        private System.Windows.Forms.Button btnOpcionDos;
        private System.Windows.Forms.Button btnOpcionUno;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btRenaudar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.PictureBox imgMascota;
    }
}