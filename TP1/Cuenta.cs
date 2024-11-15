using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Cuenta
    {
        public string Titular { get; set; }
        public decimal Cantidad { get; set; }

        public Cuenta()
        {
            Titular = "nombre";
            Cantidad = 1;
        }
        
        public Cuenta(string titular, decimal cantidad = 0)
        {
            Titular = titular;
            Cantidad = cantidad;
        }

        public void Deposito(decimal cantidad)
        {
            if (Cantidad < 0)
            {
                //No hacer nada
            }
            else
            {
                Cantidad += Cantidad;
            }
        }

        public void Retiro(decimal cantidad)
        {
            if (Cantidad > 0)
            {
                if (cantidad > Cantidad)
                {
                    Cantidad = 0;
                }
                else
                {
                    Cantidad -= cantidad;
                }
            }
        }
    }
}