using System;
using System.Linq;
using System.Windows.Markup;

namespace AreaandPerimeter
{
    public class Logic
{
        public double perimeterofsquare(double length)
        {
            if (length < 0)
            {
                return -1;
            }

            return 4 * length ;
        }

        public double areaofsquare(double length)
        {
            if(length < 0)
            {
                return -1;
            }
            var values = 2 * length;
            return values;
        }
        
        public double perimeterofrectangle(double length,double bredth)
        {
            var values = 2 * (length + bredth);
            return values;
        }

        public double areaofrectangle(double length, double bredth)
        {
            var values = length * bredth;
            return values;
        }

        public double perimeteroftriangle(double length, double bredth,double height)
        {
            if (length < 0 )
            {
                return -1;
            }
            var values = length + bredth + height;
            return values;
        }

        public double areaoftriangle(double length, double bredth)
        {
            if (length < 0 || bredth < 0)
            {
                return -1;
            }
            var values = (length + bredth) / 2;
            return values;
        }


    }









}