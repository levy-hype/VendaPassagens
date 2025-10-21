using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VendaPassagens
{
    public partial class Form3 : Form
    {
        private PassagemAerea passagemAtual;
        private bool modoEdicao = false;

       
        public Form3()
        {
            InitializeComponent();
            this.Text = "Adicionar Nova Passagem";
            passagemAtual = new PassagemAerea();
            modoEdicao = false;
        }

        // Construtor para "Editar"
        public Form3(int idPassagem)
        {
            InitializeComponent();
            this.Text = "Editar Passagem";
            modoEdicao = true;

            passagemAtual = BuscarPassagemDoBanco(idPassagem);
            CarregarDadosParaCampos();
        }

        private PassagemAerea BuscarPassagemDoBanco(int id)
        {
            PassagemAerea p = new PassagemAerea();
            using (var conn = new MySqlConnection(Conexao.stringConexao))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM passagens WHERE Id = @Id";
                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            p.Id = reader.GetInt32("Id");
                            p.Origem = reader.GetString("Origem");
                            p.Destino = reader.GetString("Destino");
                            p.DataHoraVoo = reader.GetDateTime("DataHoraVoo");
                            p.CompanhiaAerea = reader.GetString("CompanhiaAerea");
                            p.Preco = reader.GetDecimal("Preco");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar passagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return p;
        }

        private void CarregarDadosParaCampos()
        {
            if (passagemAtual != null)
            {
                txtOrigem.Text = passagemAtual.Origem;
                txtDestino.Text = passagemAtual.Destino;
                dtpDataHora.Value = passagemAtual.DataHoraVoo;
                txtCompanhia.Text = passagemAtual.CompanhiaAerea;
                numPreco.Value = passagemAtual.Preco;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrigem.Text) ||
                string.IsNullOrWhiteSpace(txtDestino.Text) ||
                numPreco.Value <= 0)
            {
                MessageBox.Show("Por favor, preencha Origem, Destino e Preço.", "Campos Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            passagemAtual.Origem = txtOrigem.Text;
            passagemAtual.Destino = txtDestino.Text;
            passagemAtual.DataHoraVoo = dtpDataHora.Value;
            passagemAtual.CompanhiaAerea = txtCompanhia.Text;
            passagemAtual.Preco = numPreco.Value;

            SalvarNoBanco();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SalvarNoBanco()
        {
            using (var conn = new MySqlConnection(Conexao.stringConexao))
            {
                try
                {
                    conn.Open();
                    string query = "";

                    if (modoEdicao)
                    {
                        query = @"UPDATE passagens SET 
                                    Origem = @Origem, 
                                    Destino = @Destino, 
                                    DataHoraVoo = @DataHora, 
                                    CompanhiaAerea = @Companhia, 
                                    Preco = @Preco
                                  WHERE Id = @Id";
                    }
                    else
                    {
                        query = @"INSERT INTO passagens (Origem, Destino, DataHoraVoo, CompanhiaAerea, Preco)
                                  VALUES (@Origem, @Destino, @DataHora, @Companhia, @Preco)";
                    }

                    var cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Origem", passagemAtual.Origem);
                    cmd.Parameters.AddWithValue("@Destino", passagemAtual.Destino);
                    cmd.Parameters.AddWithValue("@DataHora", passagemAtual.DataHoraVoo);
                    cmd.Parameters.AddWithValue("@Companhia", passagemAtual.CompanhiaAerea);
                    cmd.Parameters.AddWithValue("@Preco", passagemAtual.Preco);

                    if (modoEdicao)
                    {
                        cmd.Parameters.AddWithValue("@Id", passagemAtual.Id);
                    }

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Passagem salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar passagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
