namespace Jogo_da_memória
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonLoginAP1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsLabelAutor = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLabelData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLabelHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnOpcoes01 = new System.Windows.Forms.Button();
            this.pbTitulo = new System.Windows.Forms.PictureBox();
            this.pbEisten = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnJogarAP1 = new System.Windows.Forms.Button();
            this.btnLoja = new System.Windows.Forms.Button();
            this.pbOpcoes = new System.Windows.Forms.PictureBox();
            this.btnCloseOpcoes = new System.Windows.Forms.Button();
            this.btnCredit = new System.Windows.Forms.Button();
            this.btnTutorial = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEisten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpcoes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoginAP1
            // 
            this.buttonLoginAP1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonLoginAP1.BackColor = System.Drawing.Color.Transparent;
            this.buttonLoginAP1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLoginAP1.BackgroundImage")));
            this.buttonLoginAP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLoginAP1.FlatAppearance.BorderSize = 0;
            this.buttonLoginAP1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoginAP1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLoginAP1.Location = new System.Drawing.Point(578, 417);
            this.buttonLoginAP1.Name = "buttonLoginAP1";
            this.buttonLoginAP1.Size = new System.Drawing.Size(232, 108);
            this.buttonLoginAP1.TabIndex = 23;
            this.buttonLoginAP1.Tag = "o";
            this.buttonLoginAP1.UseVisualStyleBackColor = false;
            this.buttonLoginAP1.Click += new System.EventHandler(this.buttonLoginAP1_MouseEnter);
            this.buttonLoginAP1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonLoginAP1_MouseClick);
            this.buttonLoginAP1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonLoginAP1_MouseDown);
            this.buttonLoginAP1.MouseEnter += new System.EventHandler(this.buttonLoginAP1_MouseEnter);
            this.buttonLoginAP1.MouseLeave += new System.EventHandler(this.buttonLoginAP1_MouseLeave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLabelAutor,
            this.toolStripStatusLabel1,
            this.tsLabelData,
            this.toolStripStatusLabel2,
            this.tsLabelHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 766);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1386, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsLabelAutor
            // 
            this.tsLabelAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsLabelAutor.Name = "tsLabelAutor";
            this.tsLabelAutor.Size = new System.Drawing.Size(124, 17);
            this.tsLabelAutor.Text = "©Lucas Pierre Oliveira";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // tsLabelData
            // 
            this.tsLabelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsLabelData.Name = "tsLabelData";
            this.tsLabelData.Size = new System.Drawing.Size(31, 17);
            this.tsLabelData.Text = "Data";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // tsLabelHora
            // 
            this.tsLabelHora.Name = "tsLabelHora";
            this.tsLabelHora.Size = new System.Drawing.Size(0, 17);
            // 
            // btnOpcoes01
            // 
            this.btnOpcoes01.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOpcoes01.BackColor = System.Drawing.Color.Transparent;
            this.btnOpcoes01.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpcoes01.BackgroundImage")));
            this.btnOpcoes01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpcoes01.FlatAppearance.BorderSize = 0;
            this.btnOpcoes01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcoes01.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpcoes01.Location = new System.Drawing.Point(578, 531);
            this.btnOpcoes01.Name = "btnOpcoes01";
            this.btnOpcoes01.Size = new System.Drawing.Size(232, 108);
            this.btnOpcoes01.TabIndex = 29;
            this.btnOpcoes01.Tag = "o";
            this.btnOpcoes01.UseVisualStyleBackColor = false;
            this.btnOpcoes01.Click += new System.EventHandler(this.btnOpcoes01_Click);
            this.btnOpcoes01.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnOpcoes01_MouseDown);
            this.btnOpcoes01.MouseEnter += new System.EventHandler(this.btnOpcoes01_MouseEnter);
            this.btnOpcoes01.MouseLeave += new System.EventHandler(this.btnOpcoes01_MouseLeave);
            this.btnOpcoes01.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnOpcoes01_MouseUp);
            // 
            // pbTitulo
            // 
            this.pbTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.pbTitulo.Image = global::Jogo_da_memória.Properties.Resources.Titulo_Cerébro_Cartoon;
            this.pbTitulo.Location = new System.Drawing.Point(463, -8);
            this.pbTitulo.Name = "pbTitulo";
            this.pbTitulo.Size = new System.Drawing.Size(466, 419);
            this.pbTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTitulo.TabIndex = 30;
            this.pbTitulo.TabStop = false;
            // 
            // pbEisten
            // 
            this.pbEisten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbEisten.BackColor = System.Drawing.Color.Transparent;
            this.pbEisten.Image = ((System.Drawing.Image)(resources.GetObject("pbEisten.Image")));
            this.pbEisten.Location = new System.Drawing.Point(951, 496);
            this.pbEisten.Name = "pbEisten";
            this.pbEisten.Size = new System.Drawing.Size(423, 267);
            this.pbEisten.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEisten.TabIndex = 31;
            this.pbEisten.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 479);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // btnJogarAP1
            // 
            this.btnJogarAP1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnJogarAP1.BackColor = System.Drawing.Color.Transparent;
            this.btnJogarAP1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJogarAP1.BackgroundImage")));
            this.btnJogarAP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJogarAP1.FlatAppearance.BorderSize = 0;
            this.btnJogarAP1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogarAP1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnJogarAP1.Location = new System.Drawing.Point(578, 417);
            this.btnJogarAP1.Name = "btnJogarAP1";
            this.btnJogarAP1.Size = new System.Drawing.Size(232, 108);
            this.btnJogarAP1.TabIndex = 33;
            this.btnJogarAP1.Tag = "o";
            this.btnJogarAP1.UseVisualStyleBackColor = false;
            this.btnJogarAP1.Click += new System.EventHandler(this.btnJogarAP1_Click);
            this.btnJogarAP1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogarAP1_MouseDown);
            this.btnJogarAP1.MouseEnter += new System.EventHandler(this.btnJogarAP1_MouseEnter);
            this.btnJogarAP1.MouseLeave += new System.EventHandler(this.btnJogarAP1_MouseLeave);
            this.btnJogarAP1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogarAP1_MouseUp);
            // 
            // btnLoja
            // 
            this.btnLoja.Location = new System.Drawing.Point(1181, 431);
            this.btnLoja.Name = "btnLoja";
            this.btnLoja.Size = new System.Drawing.Size(177, 60);
            this.btnLoja.TabIndex = 34;
            this.btnLoja.Tag = "o";
            this.btnLoja.Text = "button1";
            this.btnLoja.UseVisualStyleBackColor = true;
            // 
            // pbOpcoes
            // 
            this.pbOpcoes.BackColor = System.Drawing.Color.Transparent;
            this.pbOpcoes.Image = ((System.Drawing.Image)(resources.GetObject("pbOpcoes.Image")));
            this.pbOpcoes.Location = new System.Drawing.Point(445, 44);
            this.pbOpcoes.Name = "pbOpcoes";
            this.pbOpcoes.Size = new System.Drawing.Size(500, 700);
            this.pbOpcoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOpcoes.TabIndex = 35;
            this.pbOpcoes.TabStop = false;
            this.pbOpcoes.Tag = "o";
            // 
            // btnCloseOpcoes
            // 
            this.btnCloseOpcoes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseOpcoes.BackgroundImage")));
            this.btnCloseOpcoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseOpcoes.FlatAppearance.BorderSize = 0;
            this.btnCloseOpcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseOpcoes.Location = new System.Drawing.Point(951, 27);
            this.btnCloseOpcoes.Name = "btnCloseOpcoes";
            this.btnCloseOpcoes.Size = new System.Drawing.Size(60, 60);
            this.btnCloseOpcoes.TabIndex = 36;
            this.btnCloseOpcoes.Text = "o";
            this.btnCloseOpcoes.UseVisualStyleBackColor = true;
            this.btnCloseOpcoes.Click += new System.EventHandler(this.btnCloseOpcoes_Click);
            // 
            // btnCredit
            // 
            this.btnCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnCredit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCredit.FlatAppearance.BorderSize = 0;
            this.btnCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCredit.Font = new System.Drawing.Font("Milky Nice", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCredit.Location = new System.Drawing.Point(578, 550);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(231, 46);
            this.btnCredit.TabIndex = 116;
            this.btnCredit.Text = "Crétidos";
            this.btnCredit.UseVisualStyleBackColor = false;
            // 
            // btnTutorial
            // 
            this.btnTutorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnTutorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTutorial.FlatAppearance.BorderSize = 0;
            this.btnTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutorial.Font = new System.Drawing.Font("Milky Nice", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTutorial.Location = new System.Drawing.Point(578, 476);
            this.btnTutorial.Name = "btnTutorial";
            this.btnTutorial.Size = new System.Drawing.Size(231, 46);
            this.btnTutorial.TabIndex = 115;
            this.btnTutorial.Text = "Tutorial";
            this.btnTutorial.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Milky Nice", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(578, 625);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(231, 85);
            this.btnExit.TabIndex = 114;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.btnCredit);
            this.Controls.Add(this.btnTutorial);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCloseOpcoes);
            this.Controls.Add(this.btnLoja);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pbEisten);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbOpcoes);
            this.Controls.Add(this.pbTitulo);
            this.Controls.Add(this.buttonLoginAP1);
            this.Controls.Add(this.btnJogarAP1);
            this.Controls.Add(this.btnOpcoes01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(816, 498);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "o";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEisten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpcoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonLoginAP1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsLabelAutor;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel tsLabelData;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel tsLabelHora;
        private Button btnOpcoes01;
        private PictureBox pbTitulo;
        private PictureBox pbEisten;
        private PictureBox pictureBox1;
        private Button btnJogarAP1;
        private Button btnLoja;
        private PictureBox pbOpcoes;
        private Button btnCloseOpcoes;
        private Button btnCredit;
        private Button btnTutorial;
        private Button btnExit;
    }
}