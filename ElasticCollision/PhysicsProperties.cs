using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticCollision
{
    class PhysicsProperties
    {
        public double WallRestitution { get; set; } // Коэффициент упругости стен
        public double SurfaceRestitution { get; set; } // Коэффициент упругости поверхности
        public double FrictionCoefficient { get; set; } // Коэффициент трения
    }
}
