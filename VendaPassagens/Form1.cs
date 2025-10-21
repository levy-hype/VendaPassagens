using MySql.Data.MySqlClient;

namespace VendaPassagens
{
    class Conexao
    {
        // String de conexão para o banco de dados MySQL criado no XAMPP
        public static readonly string stringConexao =
     "Server=localhost;Port=3306;Database=VendaPassagens;Uid=root;Pwd=;";
    }

    class PassagemAerea
    {
        public int Id { get; set; }
        public string Origem { get; set; } = "";
        public string Destino { get; set; } = "";
        public DateTime DataHoraVoo { get; set; }
        public string CompanhiaAerea { get; set; } = "";
        public decimal Preco { get; set; }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtSenha.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            // Valida o login usando o banco de dados
            if (ValidarLoginComBanco(usuario, senha))
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.FormClosed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para validar o login com o banco de dados
        private bool ValidarLoginComBanco(string usuario, string senha)
        {
            using (var conn = new MySqlConnection(Conexao.stringConexao))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(1) FROM usuarios WHERE username = @user AND password = @pass";

                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", usuario);
                    cmd.Parameters.AddWithValue("@pass", senha);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Pode deixar vazio
        }
    }
}