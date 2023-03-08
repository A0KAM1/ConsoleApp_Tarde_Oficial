using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tarde
{
    public class Endereco
    { //Id, CEP, Endereco, Numero, Bairro, Cidade
        int Id;
        string Rua;
        int Numero;
        string Bairro;
        string Cidade;
        public Endereco(int id, string rua, int numero, string bairro, string cidade)
        {
            Id = id;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
        }
        public int getId()
        {
            return Id;
        }
        public string getRua()
        {
            return Rua;
        }
        public int getNumero()
        {
            return Numero;
        }
        public string getBairro()
        {
            return Bairro;
        }
        public string getCidade()
        {
            return Cidade;
        }
        //---------------------------------------------
        public void setId(int id)
        {
            Id = id;
        }
        public void setRua(string rua)
        {
            Rua = rua;
        }
        public void setNumero(int numero)
        {
            Numero = numero;
        }
        public void setBairro(string bairro)
        {
            Bairro = bairro;
        }
        public void setCidade(string cidade)
        {
            Cidade = cidade;
        }
    }
}
