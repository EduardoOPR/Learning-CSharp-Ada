using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Aula2.Desafio7.Produtos
{
    internal class Produto
    {

        private string _codigo;
        private string _nome;
        private float _valorUnitario;

        public Produto( string codigo, float valorUnitario, string nome)
        {
            this._codigo = codigo;
            this._nome = nome;
            this._valorUnitario = valorUnitario;

        }

        //Get e Set
        public string getCodigo{ get{ return _codigo; } set { _codigo = value; } }
        public string getNome { get { return _nome; } set { _nome = value; } }
        public float getValorUnitario{ get { return _valorUnitario; } set { _valorUnitario = value; } }
    }
}
