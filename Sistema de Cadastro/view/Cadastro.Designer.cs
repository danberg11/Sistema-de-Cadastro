namespace Sistema_de_Cadastro.view
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbx_nome = new TextBox();
            tbx_posicao = new TextBox();
            cbx_idade = new ComboBox();
            btn_botao = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Humnst777 Blk BT", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(292, 21);
            label1.Name = "label1";
            label1.Size = new Size(237, 26);
            label1.TabIndex = 0;
            label1.Text = "Escolinha de Futebol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 122);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 191);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "Posição:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(56, 263);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 3;
            label4.Text = "Idade:";
            // 
            // tbx_nome
            // 
            tbx_nome.BackColor = SystemColors.MenuBar;
            tbx_nome.Location = new Point(131, 123);
            tbx_nome.Name = "tbx_nome";
            tbx_nome.Size = new Size(234, 23);
            tbx_nome.TabIndex = 4;
            tbx_nome.TextChanged += textBox1_TextChanged;
            // 
            // tbx_posicao
            // 
            tbx_posicao.BackColor = SystemColors.MenuBar;
            tbx_posicao.Location = new Point(131, 192);
            tbx_posicao.Name = "tbx_posicao";
            tbx_posicao.Size = new Size(175, 23);
            tbx_posicao.TabIndex = 6;
            // 
            // cbx_idade
            // 
            cbx_idade.BackColor = SystemColors.MenuBar;
            cbx_idade.FormattingEnabled = true;
            cbx_idade.Items.AddRange(new object[] { "Sub- 11 Atletas de 10 a 11 Anos.", "Sub- 13 Atletas de 12 a 13 Anos.", "Sub- 15 Atletas de 14 a 15 Anos.", "Sub- 17 Atletas de 16 a 17 Anos.", "Sub- 20 Atletas de 18,19 e 20 Anos." });
            cbx_idade.Location = new Point(131, 264);
            cbx_idade.Name = "cbx_idade";
            cbx_idade.Size = new Size(121, 23);
            cbx_idade.TabIndex = 7;
            // 
            // btn_botao
            // 
            btn_botao.BackColor = SystemColors.MenuBar;
            btn_botao.Location = new Point(292, 347);
            btn_botao.Name = "btn_botao";
            btn_botao.Size = new Size(220, 31);
            btn_botao.TabIndex = 8;
            btn_botao.Text = "Inscrever-se";
            btn_botao.UseVisualStyleBackColor = false;
            btn_botao.Click += button1_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btn_botao);
            Controls.Add(cbx_idade);
            Controls.Add(tbx_posicao);
            Controls.Add(tbx_nome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbx_nome;
        private TextBox tbx_posicao;
        private ComboBox cbx_idade;
        private Button btn_botao;
    }
}