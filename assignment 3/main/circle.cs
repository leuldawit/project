using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using shape;

namespace circle
{
    public class circle : shape.shape
    {
        private double _radius;

        public double radius
        {
            get
            {
                return _radius;

            }
            set
            {
                _radius = value;
            }
        }
        static double PI = 3.14;

     /*void shape.shape.cal_area()
        {
            Console.WriteLine( PI * (_radius * _radius));
        }

        void shape.shape.cal_perimeter()
        {
            Console.WriteLine(2 * PI * _radius);
        }
*/
       

        public override void cal_area()
        {

            Console.WriteLine(PI * (_radius * _radius));
        }


        public override void cal_perimeter()
        {
            Console.WriteLine(2 * PI * _radius);
        }
    }
}
