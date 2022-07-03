using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle
{
    class rectangle : shape.shape
    {
        private double _length;
        private double _width;

        public double length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }
        public double width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        public override void cal_area()
        {
           Console.WriteLine( _width * _length);
        }

        public override void cal_perimeter()
        {
            Console.WriteLine( 2 * (_length + _width));
        }
    }
}
