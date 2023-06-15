using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesAggregation_FacultyProject
{
    public class Pessoas
    {
        private  int codigo;
        private string nome;
        private string sobrenome;
        private int idade;

        public Pessoas(){

        }

        public int getCodigo(){
            return this.codigo;
        }
        public string getNome(){
            return this.nome;
        }
        public string getSobrnome(){
            return this.sobrenome;
        }
        public int getIdade(){
            return this.idade;
        }   
        public void setCodigo(int Codigo){
            this.codigo = Codigo;
        }

        public void setNome(string Nome){
            this.nome = Nome;
        }

        public void setSobrenome(string Sobrenome){
            this.sobrenome = Sobrenome;
        }

        public void setIdade(int Idade){
            this.idade = Idade;
        }

        public void mostrar(){
            Console.WriteLine("Pessoa de código-> "+this.codigo
            +"\n Nome -> "+this.nome
            +"\n Sobrenome -> "+this.sobrenome
            +"\n Idade -> "+this.idade+"\n\n");
        }
    }
}