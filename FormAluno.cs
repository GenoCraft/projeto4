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
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace projeto4
{
    public partial class FormAluno : MaterialForm
    {
        bool isAlteraçao = false;
        string cs = @"server=localhost;" +
                     "uid=root;" +
                     "pwd=;" +
                     "database=academico";


        public FormAluno()
        {
            InitializeComponent();
        }

        private void FormAluno_Load(object sender, EventArgs e)
        {

        }

        private void txtMatricula_Click(object sender, EventArgs e)
        {

        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                MessageBox.Show("Matricula é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("Endereco é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEndereco.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                MessageBox.Show("Bairro é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBairro.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show("Cidade é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCidade.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Senha é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                return false;
            }
            if (!DateTime.TryParse(mmtbDtNascimento.Text, out DateTime _))
            {
                MessageBox.Show("Data de nascimento é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mmtbDtNascimento.Focus();
                return false;
            }

            return true;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                Salvar();
                materialTabControl1.SelectedIndex = 1;
            }
        }

        private void Salvar()
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "";
            if (isAlteraçao)
            {
                sql = "UPDATE aluno set " +
                    "matricula = @matricula," +
                    "dt_nascimento = @dt_nascimento," +
                    "nome = @nome," +
                    "endereco = @endereco," +
                    "bairro = @bairro," +
                    "cidade = @cidade," +
                    "estado = @estado," +
                    "senha = @senha" +
                    " WHERE id = @id";
            }
            else
            {
                sql = "INSERT INTO aluno" +
                          "(matricula, dt_nascimento, nome, endereco," +
                          " bairro, cidade, estado, senha)" +
                          " VALUES " +
                          "(@matricula, @dt_nascimento, @nome, @endereco," +
                          " @bairro, @cidade, @estado, @senha)";
            }
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@matricula", txtMatricula.Text);
            DateTime.TryParse(mmtbDtNascimento.Text, out var dataNascimento);
            cmd.Parameters.AddWithValue("@dt_nascimento", dataNascimento);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
            cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
            cmd.Parameters.AddWithValue("@estado", cboEstado.Text);
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
            if(isAlteraçao)
                cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            LimpaCampos();
        }

        private bool validarFormulario()
        {
            if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                MessageBox.Show("Matrícula é obrigatória", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Focus();
                return false;
            }
            if (!DateTime.TryParse(mmtbDtNascimento.Text, out DateTime _))
            {
                MessageBox.Show("Data de nascimento inválida", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                mmtbDtNascimento.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome é obrigatório", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("Endereço é obrigatório", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEndereco.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                MessageBox.Show("Bairro é obrigatório", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBairro.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show("Cidade é obrigatória", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCidade.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cboEstado.Text))
            {
                MessageBox.Show("Estado é obrigatório", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboEstado.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Senha é obrigatória", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                return false;
            }
            return true;
        }

        private void LimpaCampos()
        {
            isAlteraçao = false;
            foreach (var control in tabPage1.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
            }
        }

        private void CarregaGrid()
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "SELECT * FROM aluno";
            var dt = new DataTable();
            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);
            sqlAd.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            materialTabControl1.SelectedIndex = 0;
            txtMatricula.Focus();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void Editar()
        {
            if(dataGridView1.SelectedRows.Count> 0)
            {
                isAlteraçao=true;
                var linha = dataGridView1.SelectedRows[0];
                txtId.Text = linha.Cells["id"].Value.ToString();
                txtMatricula.Text = linha.Cells["matricula"].Value.ToString();
                mmtbDtNascimento.Text = linha.Cells["dt_nascimento"].Value.ToString();
                txtNome.Text = linha.Cells["nome"].Value.ToString();
                txtEndereco.Text = linha.Cells["endereco"].Value.ToString();
                txtBairro.Text = linha.Cells["bairro"].Value.ToString();
                txtCidade.Text = linha.Cells["cidade"].Value.ToString();
                cboEstado.Text = linha.Cells["estado"].Value.ToString();
                txtSenha.Text = linha.Cells["senha"].Value.ToString();
                materialTabControl1.SelectedIndex= 0;
                txtMatricula.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum aluno", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                if(MessageBox.Show("Deseja realmente deletar?","IFSP",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    Deletar(id);
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione algum aluno", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Deletar(int id)
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "DELETE FROM ALUNO WHERE id = @id";
            var cmd = new MySqlCommand(sql, con);
                
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
