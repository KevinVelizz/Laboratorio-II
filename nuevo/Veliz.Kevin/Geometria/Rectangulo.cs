using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        float area;
        float perimetro;
        Punto vertice1;
        Punto vertice2;
        Punto vertice3;
        Punto vertice4;

        bool calculadoArea;
        bool calculadoPerimetro;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(vertice3.getX(), vertice1.getY());
            this.vertice4 = new Punto(vertice1.getX(), vertice3.getY());
        }

        void CalcularArea()
        {
            float baseRectangulo = Math.Abs(vertice1.getX()  - vertice2.getX());
            float alturaRectangulo = Math.Abs(vertice1.getY() - vertice4.getY());

            this.area = baseRectangulo * alturaRectangulo;

            this.calculadoArea = true;
        }

        void CalcularPerimetro()
        {
            float baseRectangulo = Math.Abs(vertice1.getX() - vertice2.getX());
            float alturaRectangulo = Math.Abs(vertice1.getY() - vertice4.getY());

            this.perimetro = (baseRectangulo + alturaRectangulo) / 2;

            this.calculadoPerimetro = true;
        }

        public float GetArea()
        {
            if(!calculadoArea)
            {
                CalcularArea();
            }
            return area;
        }

        public float GetPerimetro()
        {
            if (!calculadoPerimetro)
            {
                CalcularPerimetro();
            }
            return perimetro;
        }
    }
}
