
namespace RestaurantCheckout
{
    class Function
    {
        
        public static double Add( double countofstarters, double countofmains)
        {
            double total = 0;
            if (countofstarters >= 0 && countofmains >= 0)
            {
                total = (countofstarters * 4.40) + (countofmains * 7.00);
            }
            else if (countofstarters >= 0 && countofmains < 0)
            {
                total = (countofstarters * 4.40) ;
            }
            else if (countofstarters < 0 && countofmains >= 0)
            {
                total =  (countofmains * 7.00);
            }
            else if (countofstarters < 0 && countofmains < 0)
            {
                total = 0;
            }
            return total;
        }

        public static double Update(double countofstarters, double countofmains)
        {
            double total = 0;
            if (countofstarters >= 0 && countofmains >= 0)
            {
                total = (countofstarters * 4.40) + (countofmains * 7.00);
            }
            else if (countofstarters >= 0 && countofmains < 0)
            {
                total = (countofstarters * 4.40);
            }
            else if (countofstarters < 0 && countofmains >= 0)
            {
                total = (countofmains * 7.00);
            }
            else if (countofstarters < 0 && countofmains < 0)
            {
                total = 0;
            }
            return total;
        }


    }
}
