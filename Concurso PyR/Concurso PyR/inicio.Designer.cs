
namespace Concurso_PyR
{
    partial class inicio
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
            this.panelInicial = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRecords = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panelInicial.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInicial
            // 
            this.panelInicial.BackColor = System.Drawing.Color.Transparent;
            this.panelInicial.Controls.Add(this.btnSalir);
            this.panelInicial.Controls.Add(this.btnRecords);
            this.panelInicial.Controls.Add(this.btnJugar);
            this.panelInicial.Controls.Add(this.lbTitulo);
            this.panelInicial.Location = new System.Drawing.Point(0, 0);
            this.panelInicial.MaximumSize = new System.Drawing.Size(780, 524);
            this.panelInicial.MinimumSize = new System.Drawing.Size(780, 524);
            this.panelInicial.Name = "panelInicial";
            this.panelInicial.Size = new System.Drawing.Size(780, 524);
            this.panelInicial.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 3;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Maroon;
            this.btnSalir.Location = new System.Drawing.Point(448, 350);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(171, 57);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRecords
            // 
            this.btnRecords.BackColor = System.Drawing.Color.Transparent;
            this.btnRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecords.FlatAppearance.BorderSize = 3;
            this.btnRecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecords.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecords.ForeColor = System.Drawing.Color.Black;
            this.btnRecords.Location = new System.Drawing.Point(112, 350);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(171, 57);
            this.btnRecords.TabIndex = 2;
            this.btnRecords.Text = "RECORDS";
            this.btnRecords.UseVisualStyleBackColor = false;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.Transparent;
            this.btnJugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnJugar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJugar.FlatAppearance.BorderSize = 3;
            this.btnJugar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugar.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnJugar.Location = new System.Drawing.Point(275, 227);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(180, 68);
            this.btnJugar.TabIndex = 1;
            this.btnJugar.Text = "JUGAR";
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbTitulo.Location = new System.Drawing.Point(91, 75);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(603, 49);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Concurso Preguntas y Respuestas";
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Concurso_PyR.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 520);
            this.Controls.Add(this.panelInicial);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(798, 559);
            this.Name = "inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelInicial.ResumeLayout(false);
            this.panelInicial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInicial;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRecords;
    }
}