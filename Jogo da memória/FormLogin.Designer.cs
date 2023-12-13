namespace Jogo_da_memória
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.linkLabelMostrar = new System.Windows.Forms.LinkLabel();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSeta01 = new System.Windows.Forms.Button();
            this.gbAvatares = new System.Windows.Forms.GroupBox();
            this.btnDireita = new System.Windows.Forms.Button();
            this.btnEsquerda = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSeta02 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.LinkLNUtilizador = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbAvatares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(261, 124);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(284, 23);
            this.textBoxUsername.TabIndex = 0;
            this.textBoxUsername.Text = "Nome";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPassword.Location = new System.Drawing.Point(261, 169);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(284, 23);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // linkLabelMostrar
            // 
            this.linkLabelMostrar.AutoSize = true;
            this.linkLabelMostrar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelMostrar.Location = new System.Drawing.Point(551, 169);
            this.linkLabelMostrar.Name = "linkLabelMostrar";
            this.linkLabelMostrar.Size = new System.Drawing.Size(48, 15);
            this.linkLabelMostrar.TabIndex = 2;
            this.linkLabelMostrar.TabStop = true;
            this.linkLabelMostrar.Text = "Mostrar";
            this.linkLabelMostrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMostrar_LinkClicked);
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEntrar.BackgroundImage")));
            this.buttonEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEntrar.FlatAppearance.BorderSize = 0;
            this.buttonEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEntrar.Location = new System.Drawing.Point(215, 227);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(194, 80);
            this.buttonEntrar.TabIndex = 24;
            this.buttonEntrar.Tag = "c";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            this.buttonEntrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonEntrar_KeyPress);
            this.buttonEntrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonEntrar_MouseDown);
            this.buttonEntrar.MouseEnter += new System.EventHandler(this.buttonEntrar_MouseEnter);
            this.buttonEntrar.MouseLeave += new System.EventHandler(this.buttonEntrar_MouseLeave);
            this.buttonEntrar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonEntrar_MouseUp);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.BackgroundImage")));
            this.buttonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Location = new System.Drawing.Point(415, 227);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(194, 80);
            this.buttonCancelar.TabIndex = 25;
            this.buttonCancelar.Tag = "c";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            this.buttonCancelar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonCancelar_MouseDown);
            this.buttonCancelar.MouseEnter += new System.EventHandler(this.buttonCancelar_MouseEnter);
            this.buttonCancelar.MouseLeave += new System.EventHandler(this.buttonCancelar_MouseLeave);
            this.buttonCancelar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonCancelar_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btnSeta01
            // 
            this.btnSeta01.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSeta01.BackgroundImage = global::Jogo_da_memória.Properties.Resources.expand_more_FILL0_wght400_GRAD0_opsz24;
            this.btnSeta01.FlatAppearance.BorderSize = 0;
            this.btnSeta01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeta01.Location = new System.Drawing.Point(171, 190);
            this.btnSeta01.Name = "btnSeta01";
            this.btnSeta01.Size = new System.Drawing.Size(23, 21);
            this.btnSeta01.TabIndex = 27;
            this.btnSeta01.UseVisualStyleBackColor = false;
            this.btnSeta01.Click += new System.EventHandler(this.button1_Click);
            this.btnSeta01.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // gbAvatares
            // 
            this.gbAvatares.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbAvatares.Controls.Add(this.btnDireita);
            this.gbAvatares.Controls.Add(this.btnEsquerda);
            this.gbAvatares.Controls.Add(this.pictureBox2);
            this.gbAvatares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbAvatares.Location = new System.Drawing.Point(12, 217);
            this.gbAvatares.Name = "gbAvatares";
            this.gbAvatares.Size = new System.Drawing.Size(183, 109);
            this.gbAvatares.TabIndex = 28;
            this.gbAvatares.TabStop = false;
            // 
            // btnDireita
            // 
            this.btnDireita.BackgroundImage = global::Jogo_da_memória.Properties.Resources.arrow_forward_FILL0_wght400_GRAD0_opsz24;
            this.btnDireita.FlatAppearance.BorderSize = 0;
            this.btnDireita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDireita.Location = new System.Drawing.Point(159, 48);
            this.btnDireita.Name = "btnDireita";
            this.btnDireita.Size = new System.Drawing.Size(26, 27);
            this.btnDireita.TabIndex = 32;
            this.btnDireita.UseVisualStyleBackColor = true;
            this.btnDireita.Click += new System.EventHandler(this.btnDireita_Click);
            // 
            // btnEsquerda
            // 
            this.btnEsquerda.BackgroundImage = global::Jogo_da_memória.Properties.Resources.arrow_back_FILL0_wght400_GRAD0_opsz24;
            this.btnEsquerda.FlatAppearance.BorderSize = 0;
            this.btnEsquerda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsquerda.Location = new System.Drawing.Point(0, 48);
            this.btnEsquerda.Name = "btnEsquerda";
            this.btnEsquerda.Size = new System.Drawing.Size(25, 27);
            this.btnEsquerda.TabIndex = 31;
            this.btnEsquerda.UseVisualStyleBackColor = true;
            this.btnEsquerda.Click += new System.EventHandler(this.btnEsquerda_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(31, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 89);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // btnSeta02
            // 
            this.btnSeta02.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSeta02.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeta02.BackgroundImage")));
            this.btnSeta02.FlatAppearance.BorderSize = 0;
            this.btnSeta02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeta02.Location = new System.Drawing.Point(171, 190);
            this.btnSeta02.Name = "btnSeta02";
            this.btnSeta02.Size = new System.Drawing.Size(23, 21);
            this.btnSeta02.TabIndex = 29;
            this.btnSeta02.UseVisualStyleBackColor = false;
            this.btnSeta02.Click += new System.EventHandler(this.btnSeta02_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox3.Location = new System.Drawing.Point(-6, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(215, 339);
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Jogo_da_memória.Properties.Resources.L__2__removebg_preview__1_;
            this.pictureBox4.Location = new System.Drawing.Point(321, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(166, 91);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // LinkLNUtilizador
            // 
            this.LinkLNUtilizador.AutoSize = true;
            this.LinkLNUtilizador.Location = new System.Drawing.Point(457, 196);
            this.LinkLNUtilizador.Name = "LinkLNUtilizador";
            this.LinkLNUtilizador.Size = new System.Drawing.Size(88, 15);
            this.LinkLNUtilizador.TabIndex = 32;
            this.LinkLNUtilizador.TabStop = true;
            this.LinkLNUtilizador.Text = "Novo utilizador";
            this.LinkLNUtilizador.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLNUtilizador_LinkClicked);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(621, 338);
            this.Controls.Add(this.LinkLNUtilizador);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.gbAvatares);
            this.Controls.Add(this.btnSeta01);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.linkLabelMostrar);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.btnSeta02);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbAvatares.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private LinkLabel linkLabelMostrar;
        private Button buttonEntrar;
        private Button buttonCancelar;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Button btnSeta01;
        private GroupBox gbAvatares;
        private Button btnSeta02;
        private Button btnDireita;
        private Button btnEsquerda;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private LinkLabel LinkLNUtilizador;
    }
}