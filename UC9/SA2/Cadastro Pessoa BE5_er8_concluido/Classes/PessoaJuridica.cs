using System.Text.RegularExpressions;
using Cadastro_Pessoa_BE5.Interfaces;

namespace Cadastro_Pessoa_BE5.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {

        public string ?cnpj { get; set; }
        public string ?razaoSocial { get; set; }
        
        public string caminho { get; private set;} = "Database/PessoaJuridica.csv";
        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                return 0;
            }
            else if (rendimento > 3000 && rendimento <= 6000)
            {
                return (rendimento / 100) * 2;
            }
            else if (rendimento > 6000 && rendimento <= 10000)
            {
                return (rendimento / 100) * 3.5f;
            }
            else
            {
                return (rendimento / 100) * 5;
            }
        }

        public bool ValidarCnpj(string cnpj)
        {
            //command + ponto para chamar a importação do Regex (no windows ctrl + ponto) -- Regular Expressions
            if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)")) 
            {
                if(cnpj.Length == 18)
                {
                    if(cnpj.Substring(11,4) == "0001") //ele vai iniciar no caractere 11 e vai pegar 4 caracteres 00.000.000/0001-00
                    { 
                        return true;
                    }   
                }
                else if(cnpj.Length == 14)
                {
                    if(cnpj.Substring(8,4) == "0001") //ele vai iniciar no caractere 8 e vai pegar 4 caracteres 00000000000100
                    {
                        return true;
                    }
                } 
            }
            return false;
        }

        public void Inserir(PessoaJuridica pj)
        {
            VerificarPastaArquivo(caminho);

            string[] pjString = {$"{pj.nome},{pj.cnpj},{pj.razaoSocial}"};

            File.AppendAllLines(caminho, pjString);
        }

        public List<PessoaJuridica> Ler()
        {
            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();
            
            string[] linhas = File.ReadAllLines(caminho);

            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.nome = atributos[0];
                cadaPj.cnpj = atributos[1];
                cadaPj.razaoSocial = atributos[2];

                listaPj.Add(cadaPj);
            }
            return listaPj;
        }
    }
}

