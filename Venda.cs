using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesAggregation_FacultyProject
{
    public class Venda
    {
        public int id;
        public string data;
        public int valor;
        public List<Produtos> vetProdutos {get; set;}
        public Venda(int id, string data , int valor , List<Produtos> produtos){
            this.id = id;
            this.data = data;
            this.valor = valor;
            this.vetProdutos = produtos;
            
        }

        public string nota_fiscal(){
            Console.WriteLine("INFORMAÇÕES DA VENDA \n"
            + "Id da venda -> "+this.id+"\n"
            + "Data da venda "+this.data+"\n"
            + "TOTAL VENDA -- R$ "+this.valor+"\n"
            + "\n ITENS ADQUIRIDOS");
           
        }



    }
}