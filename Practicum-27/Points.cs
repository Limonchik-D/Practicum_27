using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_27
{
    class Points
    {
        private double x;
        private double y;

        /// <summary>
        ///  свойства для доступа к полям
        /// </summary>
        public double X
        {
            get { return x;  }
            set { x = value;  }
        }
        
        public double Y
        {
            get { return y;  }
            set { y = value;  }
        }

        public Points ()
        {
            x = 4.5;
            y = 3.5;
        }
        public Points(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"Х: {x} Y: {y}";
        }
    }
}
