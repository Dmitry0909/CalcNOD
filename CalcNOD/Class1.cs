namespace Calculator
{
    public class CalcNOD
    {

        public string NOD(int x, int y)


        {

            /*  while (x <= 0 || y <= 0)
              {
                 if ((x <= 0 && y < 0) || (x<0 && y<=0) || (x < 1 && y < 1))
                  return 999;
                 else
                  return x;
              } */
            if (x == 0 || y == 0)
            {
                return null;
            }


            while (x != y)
            {
                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }

            return Convert.ToString(x);
        }
    }
}