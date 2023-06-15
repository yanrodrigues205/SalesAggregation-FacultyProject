using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesAggregation_FacultyProject
{
    public class Produtos
    {
        private int codigo {get; set;}
        private string nome {get; set;}
        private string descricao {get; set;}
        private int quantidade {get; set;}
        private int valor{get; set;}


        public Produtos(){}

        public void mostrar(){
            Console.WriteLine("Produto código-> "+this.codigo
            +"\n Nome -> "+this.nome
            +"\n Descrição -> "+this.descricao
            +"\n Quantidade -> "+this.quantidade+"\n\n");
        }

        public void setCodigo(int Codigo){
            this.codigo = Codigo;
        }
        public void setNome(string Nome){
            this.nome = Nome;
        }
        public void setDecricao(string Descricao){
            this.descricao = Descricao;
        }
        public void setQuantidade(int Quantidade){
            this.quantidade = Quantidade;
        }

        public void setValor(int Valor){
            this.valor = Valor;
        }

        public int getQuantidade(){
            return this.quantidade;
        }

        public int getValor(){
            return this.valor;
        }

        public string apresentar(){
            System.Console.WriteLine("\n Código -> "+this.codigo
            + " "+ this.nome+ " QTD:"+this.quantidade+" R$ "+this.valor);
        }
   }
}