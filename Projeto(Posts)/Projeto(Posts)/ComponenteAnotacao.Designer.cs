namespace Projeto_Posts_
{
    partial class ComponenteAnotacao
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponenteAnotacao));
            this.txt_conteudo = new System.Windows.Forms.TextBox();
            this.txt_data_hora = new System.Windows.Forms.Label();
            this.foto_perfil = new Projeto_Login_com_foto_.OvalPictureBox();
            this.btn_deletar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto_perfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_deletar)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_conteudo
            // 
            this.txt_conteudo.BackColor = System.Drawing.Color.White;
            this.txt_conteudo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_conteudo.Enabled = false;
            this.txt_conteudo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_conteudo.ForeColor = System.Drawing.Color.DimGray;
            this.txt_conteudo.Location = new System.Drawing.Point(21, 32);
            this.txt_conteudo.Multiline = true;
            this.txt_conteudo.Name = "txt_conteudo";
            this.txt_conteudo.ReadOnly = true;
            this.txt_conteudo.Size = new System.Drawing.Size(471, 110);
            this.txt_conteudo.TabIndex = 0;
            this.txt_conteudo.Text = "Minha anotação";
            this.txt_conteudo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_conteudo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_data_hora
            // 
            this.txt_data_hora.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data_hora.ForeColor = System.Drawing.Color.Black;
            this.txt_data_hora.Location = new System.Drawing.Point(120, 171);
            this.txt_data_hora.Name = "txt_data_hora";
            this.txt_data_hora.Size = new System.Drawing.Size(394, 27);
            this.txt_data_hora.TabIndex = 1;
            this.txt_data_hora.Text = "data hora";
            this.txt_data_hora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txt_data_hora.Click += new System.EventHandler(this.label1_Click);
            // 
            // foto_perfil
            // 
            this.foto_perfil.BackColor = System.Drawing.Color.DarkGray;
            this.foto_perfil.Image = ((System.Drawing.Image)(resources.GetObject("foto_perfil.Image")));
            this.foto_perfil.Location = new System.Drawing.Point(21, 149);
            this.foto_perfil.Name = "foto_perfil";
            this.foto_perfil.Size = new System.Drawing.Size(51, 50);
            this.foto_perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto_perfil.TabIndex = 2;
            this.foto_perfil.TabStop = false;
            // 
            // btn_deletar
            // 
            this.btn_deletar.Image = ((System.Drawing.Image)(resources.GetObject("btn_deletar.Image")));
            this.btn_deletar.Location = new System.Drawing.Point(490, 2);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(24, 24);
            this.btn_deletar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_deletar.TabIndex = 3;
            this.btn_deletar.TabStop = false;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // ComponenteAnotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.foto_perfil);
            this.Controls.Add(this.txt_data_hora);
            this.Controls.Add(this.txt_conteudo);
            this.Name = "ComponenteAnotacao";
            this.Size = new System.Drawing.Size(515, 202);
            this.Load += new System.EventHandler(this.ComponentePost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foto_perfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_deletar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_conteudo;
        private System.Windows.Forms.Label txt_data_hora;
        private Projeto_Login_com_foto_.OvalPictureBox foto_perfil;
        private System.Windows.Forms.PictureBox btn_deletar;
    }
}
