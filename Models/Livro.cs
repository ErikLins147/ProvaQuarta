using System;

namespace API.Models
{
    public class Livro
    {

        public Livro() => CriadoEm = DateTime.Now;


        public int Id { get; set; }
        public string Nome { get; set; }
        public double Autor { get; set; }
        public string Genero { get; set; }
        public int Quantidade { get; set; }
        public DateTime CriadoEm { get; set; }



        public override string ToString() =>
            $"Nome: {Nome} | Preço: {Preco:C2} | Criado em: {CriadoEm}";
    }
}