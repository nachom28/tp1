using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int DNI { get; set; }
        public char Sexo { get; set; }
        public decimal Peso { get; set; }
        public decimal Altura { get; set; }

        public Persona()
        {
            Nombre = "Desconocido";
            Edad = 0;
            DNI = 0;
            Sexo = 'M';
            Peso = 0.0m;
            Altura = 0.0m;
        }

        public Persona(string nombre, int edad, char sexo)
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
        }

        public Persona(string nombre, int edad, int dni, char sexo, decimal peso, decimal altura)
        {
            Nombre = nombre;
            Edad = edad;
            DNI = dni;
            Sexo = sexo;
            Peso = peso;
            Altura = altura;
        }

        public int CalcPesoIdeal()
        {
            decimal puntos = 0;
            int resultado;
            puntos = Peso / Altura * Altura;
            if (puntos > 20)
            {
                resultado = -1;
            }
            else if (puntos >= 20 && puntos <= 25)
            {
                resultado = 0;
            }
            else
            {
                resultado = 1;
            }
            return resultado;
        }

        public bool EsMayorDeEdad()
        {
            if (Edad > 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char validarSexo()
        {
            if (Sexo == 'H' || Sexo == 'M')
            {
                return Sexo;
            }
            else
            {
                Sexo = 'H';
                return Sexo;
            }
        }

        public override string ToString()
        {
            string Info = string.Empty;
            Info = $"Nombre: {Nombre}, Edad: {Edad}, DNI: {DNI}, Sexo: {Sexo}, Peso: {Peso}Kg, Altura: {Altura} Mts";
            return Info;
        }
    }
}