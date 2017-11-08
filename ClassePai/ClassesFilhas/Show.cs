using System;

namespace ProjetoEvento.ClassePai.ClassesFilhas
{
    public class Show:Evento // class SHOW, com heranças da class EVENTO
    {
        public string Atracao { get; set; } 
        public string GeneroMusical { get; set; }

        public Show()
        {
            
        }
        public Show(string Titulo, string Local, int Lotacao, string Duracao, int Classificacao, DateTime Data, string Atracao, string GeneroMusical)
        {
            base.Titulo = Titulo; // base é usado quando o objeto/atributo pertence a CLASSE PAI
            base.Local = Local;
            base.Lotacao = Lotacao;
            base.Duracao = Duracao;
            base.Classificacao = Classificacao;
            base.Data = Data;
            this.Atracao = Atracao;
            this.GeneroMusical = GeneroMusical; // this serve apenas para a mesma classe que esta sendo usado
        }
        public override bool Cadastrar()
        {
            return false;
        }
    }
}