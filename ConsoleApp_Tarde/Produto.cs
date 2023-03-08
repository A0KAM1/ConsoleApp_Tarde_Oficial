using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tarde
{
    public class Produto
    {
        private int Id; //atributos
        private string Descricao;
        private decimal Valor;

        public Produto(int id, string descricao, decimal valor) //método construtor, define que Atributo <- recebe parâmetro setado
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
        }

        //Mostra valores

        public int getId()
        {
            return Id;
        }

        public string getDescricao()
        {
            return Descricao;
        }

        public decimal getValor()
        {
            return Valor;
        }

        //Recebe valores

        public void setId(int id)
        {
            Id = id;
        }

        public void setDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public void setValor(decimal valor) //nao tem retorno, por isso é void
        {
            if (valor > 0)
            {
                Valor = valor;
            }
        }
    }
}
