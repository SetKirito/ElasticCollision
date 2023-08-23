using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticCollision
{
    class CollisionObject
    {
        public double Mass { get; set; }// масса шара
        public double Radius { get; set; }// радиус шара
        public double X { get; set; }// координата по оси х
        public double Velocity { get; set; }// скорость
        public double StartVelocity { get; set; }// начальная скорость
        public double RestitutionCoefficient { get; set; } // Коэффициент упругости (по умолчанию 1.0)

    }
}
