using Cadastro_Pessoa_BE5.Interfaces;

namespace Cadastro_Pessoa_BE5.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {

        public string ?cpf { get; set; }

        public string ?dataNascimento { get; set; }
        
        
        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;
            double anos = (dataAtual - dataNasc).TotalDays / 365; //TotalDays converte para dias.
            if (anos >= 18){
                return true;
            }
            return false; //não precisa do else pq caso seja verdadeira o primeiro return ja para a sentença.
        }

        public bool ValidarDataNascimento(string dataNasc)
        {
            DateTime dataConvertida;
            //verificar se a string esta em um formato valido
            if(DateTime.TryParse(dataNasc, out dataConvertida)){ //try parse tenta converter e coloca na saída 
                //Console.WriteLine($"{dataConvertida}");
                DateTime dataAtual = DateTime.Today;
                double anos = (dataAtual - dataConvertida).TotalDays / 365; 
                if (anos >= 18){
                    return true;
                }
                return false; 
            }
            return false; 
        }

        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 1500)
            {
                return rendimento * 0.03f;
            }
            else if (rendimento > 1500 && rendimento <= 3500)
            {
                return rendimento * 0.05f;
            }
            else if (rendimento > 3500 && rendimento < 6000)
            {
                return rendimento * 0.07f;
            }
            else
            {
                return rendimento * 0.09f;
            }
        }
    }
}