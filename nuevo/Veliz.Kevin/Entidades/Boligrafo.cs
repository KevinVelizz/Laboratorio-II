using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo
    {
        public const int cantidadTintaMaxima = 100;
        int tinta;
        ConsoleColor color;


        public Boligrafo(int tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public int GetTinta() 
        {
            return tinta;
        }

        void SetTinta(int tinta)
        {
            int tintaResultante = this.tinta + tinta;

            if(tintaResultante >= 0 && tintaResultante <= cantidadTintaMaxima)
            {
                this.tinta = tintaResultante;
            }
            else if(tintaResultante >= cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }
            else
            {
                this.tinta = 0;
            }
        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        public string Pintar(int gasto, out string dibujo)
        {
            string aux = "";

            if(tinta == 0)
            {
                dibujo = "Sin tinta";
            }
            else
            {
                while(tinta > 0 && gasto > 0)
                {
                    SetTinta(-1);
                    gasto--;
                    aux += "*";
                }
                Console.ForegroundColor = this.color;
                dibujo = aux;
            }    
            return dibujo;
        }
    }
}
