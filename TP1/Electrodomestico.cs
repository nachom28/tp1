using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public abstract class Electrodomestico
    {
        public double PrecioBase { get; set; }
        public string? Color { get; set; }
        public char ConsumoEnergetico { get; set; }
        public double Peso { get; set; }

        public bool validarConsumoEnergetico(char letra)
        {
            if (letra >= 'A' && letra <= 'F')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool comprobarColor(string color)
        {
            if (color == "Blanco" || color == "Negro" || color == "Rojo" || color == "Azul" || color == "Verde")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual int precioFinal()
        {
            int precioFinal = 0;
            if (ConsumoEnergetico == 'A')
            {
                precioFinal += 100;
            }
            else if (ConsumoEnergetico == 'B')
            {
                precioFinal += 80;
            }
            else if (ConsumoEnergetico == 'C')
            {
                precioFinal += 60;
            }
            else if (ConsumoEnergetico == 'D')
            {
                precioFinal += 50;
            }
            else if (ConsumoEnergetico == 'E')
            {
                precioFinal += 30;
            }
            else
            {
                precioFinal += 10;
            }
            if (Peso >= 0 && Peso <= 19)
            {
                precioFinal += 10;
            }
            else if (Peso >= 20 && Peso <= 49)
            {
                precioFinal += 50;
            }
            else if (Peso >= 50 && Peso <= 79)
            {
                precioFinal += 80;
            }
            else
            {
                precioFinal += 100;
            }
            return precioFinal;
        }
    }
    public class Lavadora : Electrodomestico
    {
        public int Carga { get; set; }
        public Lavadora()
        {
            PrecioBase = 0;
            Color = "color";
            ConsumoEnergetico = 'A';
            Peso = 0;
            Carga = 0;
        }

        public Lavadora(double precio, double peso)
        {
            PrecioBase = precio;
            Peso = peso;
        }

        public Lavadora(string color, char consumo)
        {
            Color = color;
            ConsumoEnergetico = consumo;
        }

        public override int precioFinal()
        {
            int precioFinalBase = base.precioFinal();
            if (Carga > 30)
            {
                precioFinalBase += 50;
            }
            return precioFinalBase;
        }
    }

    public class Television : Electrodomestico
    {
        public int Resolucion { get; set; }
        
        public Television()
        {
            PrecioBase = 0;
            Color = "color";
            ConsumoEnergetico = 'A';
            Peso = 0;
            Resolucion = 0;
        }

        public Television(double precio, double peso, int resolucion = 0) 
            {
                PrecioBase = precio;
                Peso = peso;
                Resolucion = resolucion;
            }

        public Television(double precio, string color, char consumo, double peso, int resolucion)
        {
            PrecioBase = precio;
            Color = color;
            ConsumoEnergetico = consumo;
            Peso = peso;
            Resolucion = resolucion;
        }

        public override int precioFinal()
        {
            int precioFinalBase = base.precioFinal();
            if (Resolucion > 40)
            {
                precioFinalBase += precioFinalBase*30/100;
            }
            return precioFinalBase;
        }
    }
}