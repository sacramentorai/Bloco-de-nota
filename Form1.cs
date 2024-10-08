namespace BLOCO_DE_NOTAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filename;

        private void button1Abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            var result = ofd.ShowDialog(this);
            filename = ofd.FileName;
            if (result == DialogResult.OK)
            {
                string text = File.ReadAllText(filename);
                textBoxConteudo.Text = text;
                labelNomeDoArquivo.Text = filename;
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filename))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                var resul = sfd.ShowDialog(this);
                if (resul != DialogResult.OK) return;

                filename = sfd.FileName;
                labelNomeDoArquivo.Text = filename;
                if (!File.Exists(filename)) File.Create(filename).Close();

            }
            File.WriteAllText(filename, textBoxConteudo.Text);
            MessageBox.Show("Arquivo salvo com sucesso.");
        }


        private void buttonEncriptar_Click(object sender, EventArgs e)
        {
            string textoEncriptado = "";
            foreach (char c in textBoxConteudo.Text)
            {
                textoEncriptado += (char)(c + 4);
            }
            textBoxConteudo.Text = textoEncriptado;
        }

        private void buttonDesencriptar_Click(object sender, EventArgs e)
        {
            string textoDesencriptado = "";
            foreach (char c in textBoxConteudo.Text)
            {
                textoDesencriptado += (char)(c - 4);
            }
            textBoxConteudo.Text = textoDesencriptado;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxConteudo.Clear();
        }
    }
}
