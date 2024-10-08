namespace BLOCO_DE_NOTAS
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
            button1Abrir = new Button();
            buttonSalvar = new Button();
            buttonEncriptar = new Button();
            buttonDesencriptar = new Button();
            labelNomeDoArquivo = new Label();
            textBoxConteudo = new TextBox();
            buttonLimpar = new Button();
            SuspendLayout();
            // 
            // button1Abrir
            // 
            button1Abrir.Location = new Point(13, 11);
            button1Abrir.Name = "button1Abrir";
            button1Abrir.Size = new Size(75, 23);
            button1Abrir.TabIndex = 0;
            button1Abrir.Text = "Abrir";
            button1Abrir.UseVisualStyleBackColor = true;
            button1Abrir.Click += button1Abrir_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(94, 11);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 23);
            buttonSalvar.TabIndex = 1;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonEncriptar
            // 
            buttonEncriptar.Location = new Point(175, 11);
            buttonEncriptar.Name = "buttonEncriptar";
            buttonEncriptar.Size = new Size(75, 23);
            buttonEncriptar.TabIndex = 2;
            buttonEncriptar.Text = "Encriptar";
            buttonEncriptar.UseVisualStyleBackColor = true;
            buttonEncriptar.Click += buttonEncriptar_Click;
            // 
            // buttonDesencriptar
            // 
            buttonDesencriptar.Location = new Point(256, 11);
            buttonDesencriptar.Name = "buttonDesencriptar";
            buttonDesencriptar.Size = new Size(75, 23);
            buttonDesencriptar.TabIndex = 3;
            buttonDesencriptar.Text = "Desencriptar";
            buttonDesencriptar.UseVisualStyleBackColor = true;
            buttonDesencriptar.Click += buttonDesencriptar_Click;
            // 
            // labelNomeDoArquivo
            // 
            labelNomeDoArquivo.AutoSize = true;
            labelNomeDoArquivo.Location = new Point(356, 19);
            labelNomeDoArquivo.Name = "labelNomeDoArquivo";
            labelNomeDoArquivo.Size = new Size(108, 15);
            labelNomeDoArquivo.TabIndex = 4;
            labelNomeDoArquivo.Text = "*nome do arquivo*";
            // 
            // textBoxConteudo
            // 
            textBoxConteudo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxConteudo.Location = new Point(13, 40);
            textBoxConteudo.Multiline = true;
            textBoxConteudo.Name = "textBoxConteudo";
            textBoxConteudo.Size = new Size(740, 399);
            textBoxConteudo.TabIndex = 5;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLimpar.Location = new Point(669, 445);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(75, 23);
            buttonLimpar.TabIndex = 6;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = true;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 480);
            Controls.Add(buttonLimpar);
            Controls.Add(textBoxConteudo);
            Controls.Add(labelNomeDoArquivo);
            Controls.Add(buttonDesencriptar);
            Controls.Add(buttonEncriptar);
            Controls.Add(buttonSalvar);
            Controls.Add(button1Abrir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1Abrir;
        private Button buttonSalvar;
        private Button buttonEncriptar;
        private Button buttonDesencriptar;
        private Label labelNomeDoArquivo;
        private TextBox textBoxConteudo;
        private Button buttonLimpar;
    }
}
