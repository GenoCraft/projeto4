
using ReaLTaiizor.Forms;
namespace projeto4
{
    public partial class Principal : MaterialForm
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cadastroDeAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAluno formAluno = new FormAluno();
            formAluno.MdiParent = this;
            formAluno.Show();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void cadastroDeProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfessor formProfessor = new FormProfessor();
            formProfessor.MdiParent = this;
            formProfessor.Show();
        }

        private void cadastroDeCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCurso formCurso = new FormCurso();
            formCurso.MdiParent = this;
            formCurso.Show();
        }

        private void relatórioDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formRelAluno = new FormRelatorioAluno();
            formRelAluno.MdiParent = this;
            formRelAluno.Show();
        }

        private void relatórioDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formRelProfessor = new FormRelatorioProfessor();
            formRelProfessor.MdiParent = this;
            formRelProfessor.Show();
        }

        private void relatórioDeCursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formRelCurso = new FormRelatorioCurso();
            formRelCurso.MdiParent = this;
            formRelCurso.Show();
        }
    }
}