namespace Projeto_Posts_
{
    partial class ComponenteAnotacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponenteAnotacoes));
            this.panel3 = new System.Windows.Forms.Panel();
            this.painel_anotacoes = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.txt_anotacoes = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.painel_anotacoes);
            this.panel3.Controls.Add(this.btn_enviar);
            this.panel3.Controls.Add(this.txt_anotacoes);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(545, 525);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // painel_anotacoes
            // 
            this.painel_anotacoes.AutoScroll = true;
            this.painel_anotacoes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.painel_anotacoes.Location = new System.Drawing.Point(0, 137);
            this.painel_anotacoes.Name = "painel_anotacoes";
            this.painel_anotacoes.Size = new System.Drawing.Size(542, 384);
            this.painel_anotacoes.TabIndex = 3;
            this.painel_anotacoes.BackColorChanged += new System.EventHandler(this.painel_anotacoes_BackColorChanged);
            this.painel_anotacoes.Paint += new System.Windows.Forms.PaintEventHandler(this.painel_anotacoes_Paint);
            this.painel_anotacoes.Layout += new System.Windows.Forms.LayoutEventHandler(this.painel_anotacoes_Layout);
            this.painel_anotacoes.Resize += new System.EventHandler(this.painel_anotacoes_Resize);
            this.painel_anotacoes.Validating += new System.ComponentModel.CancelEventHandler(this.painel_anotacoes_Validating);
            this.painel_anotacoes.Validated += new System.EventHandler(this.painel_anotacoes_Validated);
            this.painel_anotacoes.ParentChanged += new System.EventHandler(this.painel_anotacoes_ParentChanged);
            // 
            // btn_enviar
            // 
            this.btn_enviar.FlatAppearance.BorderSize = 0;
            this.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enviar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.Image = ((System.Drawing.Image)(resources.GetObject("btn_enviar.Image")));
            this.btn_enviar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_enviar.Location = new System.Drawing.Point(458, 108);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(80, 23);
            this.btn_enviar.TabIndex = 2;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_anotacoes
            // 
            this.txt_anotacoes.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_anotacoes.ForeColor = System.Drawing.Color.DimGray;
            this.txt_anotacoes.Location = new System.Drawing.Point(6, 6);
            this.txt_anotacoes.Multiline = true;
            this.txt_anotacoes.Name = "txt_anotacoes";
            this.txt_anotacoes.Size = new System.Drawing.Size(536, 96);
            this.txt_anotacoes.TabIndex = 1;
            this.txt_anotacoes.Text = "Digite aqui suas anotações...\r\n";
            this.txt_anotacoes.TextChanged += new System.EventHandler(this.txt_anotacoes_TextChanged);
            this.txt_anotacoes.MouseEnter += new System.EventHandler(this.txt_anotacoes_MouseEnter);
            this.txt_anotacoes.MouseLeave += new System.EventHandler(this.txt_anotacoes_MouseLeave);
            // 
            // ComponenteAnotacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "ComponenteAnotacoes";
            this.Size = new System.Drawing.Size(548, 525);
            this.Load += new System.EventHandler(this.ComponenteAnotacoes_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_anotacoes;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.FlowLayoutPanel painel_anotacoes;
    }
}
