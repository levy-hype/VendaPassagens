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

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CarregarPassagensDoBanco();
        }

        private void CarregarPassagensDoBanco()
        {
            var listaDePassagens = new List<PassagemAerea>();

            using (var conn = new MySqlConnection(Conexao.stringConexao))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Id, Origem, Destino, DataHoraVoo, CompanhiaAerea, Preco FROM passagens";
                    var cmd = new MySqlCommand(query, conn);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaDePassagens.Add(new PassagemAerea
                            {
                                Id = reader.GetInt32("Id"),
                                Origem = reader.GetString("Origem"),
                                Destino = reader.GetString("Destino"),
                                DataHoraVoo = reader.GetDateTime("DataHoraVoo"),
                                CompanhiaAerea = reader.GetString("CompanhiaAerea"),
                                Preco = reader.GetDecimal("Preco")
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar passagens: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            dgvPassagens.DataSource = null;
            dgvPassagens.DataSource = listaDePassagens;

            // Ajustes visuais
            dgvPassagens.Columns["Id"].Width = 50;
            dgvPassagens.Columns["Preco"].DefaultCellStyle.Format = "C2";
            dgvPassagens.Columns["DataHoraVoo"].HeaderText = "Data/Hora do Voo";
            dgvPassagens.Columns["CompanhiaAerea"].HeaderText = "Companhia";
            dgvPassagens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            var resultado = form3.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarPassagensDoBanco();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPassagens.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione uma passagem para editar.", "Seleção Necessária", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idSelecionado = (int)dgvPassagens.SelectedRows[0].Cells["Id"].Value;

            Form3 form3 = new Form3(idSelecionado);
            var resultado = form3.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarPassagensDoBanco();
            }
        }
    }
}