using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public class funcionario
    {
        //private int _tipo;
        //public funcionario(int _tipo)
        //{
        //    this._tipo = _tipo;
        //}

        public string nome { get; set; }
        public string cpf { get; set; }
        public double salario { get; set; }
        public virtual double getBonificacao()
        {  
           return salario * 0.10;
}   }   }
