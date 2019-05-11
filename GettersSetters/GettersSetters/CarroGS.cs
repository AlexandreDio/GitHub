using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersSetters
{
    class CarroGS
    {
        private string _modelo;

        public string modelo
        {
            get { return this._modelo; }
            set { this._modelo = value; }
        }
    }
}
