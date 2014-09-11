namespace RefactorIfStatements
{
    using System;

    class RefactorIfStatements
    {
        static void Main(string[] args)
        {
            // Refactor the following if statements: 

            // Example 1:
            Potato potato;
            //... lines of code
            if (potato != null)
            {
                if (potato.IsPeeled && !potato.IsRotten) 
                //second double negation is acceptable - it is better than potato.IsNotRotten
                {
                    Cook(potato); //if there are more nested if-s they should be extracted as method
                }
            }

            // Example 2:
            //numbers in If has to be ordered as they are presented on a number line(slide 23)
            bool isXinRange = MIN_X <= x && x <= MAX_X; 
            bool isYinRange = MIN_Y <= y && y <= MAX_Y;
            bool shouldVisitCell;// = some condition or method

            if (isXinRange && isYinRange && shouldVisitCell)
            {
               VisitCell();
            }
        }
    }
}
