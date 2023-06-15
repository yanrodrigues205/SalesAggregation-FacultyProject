using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesAggregation_FacultyProject
{
    public class Conta
    {
        public int id;
        public string banco;
        public string cidade;
        public List<Pessoas> vetPessoas {get; set;}

        public Conta(int id, string banco, string cidade, List<Pessoas> pessoas){
            this.id = id;
            this.banco = banco;
            this.cidade = cidade;
            this.vetPessoas = pessoas;
        }

        public void imprimir(){
            Console.WriteLine("DADOS DA CONTA \n"+
            "\n Código "+this.id+
            "\n Banco "+this.banco+
            "\n Cidade "+this.cidade+
            "\n Membros Utilizadores da mesma! \n\n");
            foreach(Pessoas p in vetPessoas){
                p.mostrar();
            }
        }
        
        
    }
}