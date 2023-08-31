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
    public partial class FormCurso : MaterialForm
    {
        bool isAlteraçao = false;
        string cs = @"server=localhost;" +
                     "uid=root;" +
                     "pwd=;" +
                     "database=academico";


        public FormCurso()
        {
            InitializeComponent();
        }

        private void FormCurso_Load(object sender, EventArgs e)
        {

        }

        private void txtMatricula_Click(object sender, EventArgs e)
        {

        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome é obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTipo.Text))
            {
                MessageBox.Show("Tipo é obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTipo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtAno.Text))
            {
                MessageBox.Show("Ano de criação é obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAno.Focus();
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
                sql = "UPDATE curso set " +
                    "nome = @nome," +
                    "tipo = @tipo," +
                    "ano_criacao = @ano_criacao" +
                    " WHERE id = @id";
            }
            else
            {
                sql = "INSERT INTO curso" +
                          "(nome, tipo," +
                          " ano_criacao)" +
                          " VALUES " +
                          "(@nome, @tipo," +
                          " @ano_criacao)";
            }
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@tipo", txtTipo.Text);
            cmd.Parameters.AddWithValue("@ano_criacao", txtAno.Text);
            if (isAlteraçao)
                cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            LimpaCampos();
        }

        private bool validarFormulario()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome é obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTipo.Text))
            {
                MessageBox.Show("Tipo é obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTipo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtAno.Text))
            {
                MessageBox.Show("Ano de criação é obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAno.Focus();
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
            var sql = "SELECT * FROM curso";
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
            txtNome.Focus();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void Editar()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                isAlteraçao = true;
                var linha = dataGridView1.SelectedRows[0];
                txtId.Text = linha.Cells["id"].Value.ToString();
                txtNome.Text = linha.Cells["nome"].Value.ToString();
                txtTipo.Text = linha.Cells["tipo"].Value.ToString();
                txtAno.Text = linha.Cells["ano_criacao"].Value.ToString();
                materialTabControl1.SelectedIndex = 0;
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum curso", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente deletar?", "IFSP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    Deletar(id);
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione algum curso", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Deletar(int id)
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "DELETE FROM CURSO WHERE id = @id";
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
