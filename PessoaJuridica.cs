namespace AtividadeCodificacao.Classes
{
    public class PessoaJuridica : Pessoa
    {
        public string? Cnpj { get; set; }

        //método para inserir um objeto em arquivo txt
        public void Inserir(PessoaJuridica pj) {
            using (StreamWriter sw = new StreamWriter($"{pj.Nome}.txt")) 
            {
                sw.WriteLine($"{pj.Nome},{pj.Rendimento},{pj.Cnpj}");
            }
        }   
    }
}