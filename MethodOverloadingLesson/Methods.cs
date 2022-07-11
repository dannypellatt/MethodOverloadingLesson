using System;
namespace MethodOverloadingLesson
{
    public class Methods
    {


        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool z)
        {
            if (z != true)
            {
                return "ERROR: your bool was false";
            }
            else
            {
                if (x + y == 1)
                {
                    return ($"{x + y} dollar");
                }
                else
                {
                    return ($"{x + y} dollars");
                }
            }
        }

    }
}

