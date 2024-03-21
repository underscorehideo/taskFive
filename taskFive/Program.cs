namespace taskFive
{
    class fiFth
    {

        void takinggrade()
        {
            //taking the grade
            Console.WriteLine("What is your grade for Math?: ");
            int math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your grade for Physics: ");
            int phy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your grade for Chemistry: ");
            int chem = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your grade for Computer Science: ");
            int compsci = Convert.ToInt32(Console.ReadLine());

            int average = ((math + phy + chem + compsci) / 4);
            Console.WriteLine("Your Average is " + average);

            //if and else to know the grade
            string result;
            if (average >= 80)
            {
                result = "A";
            }
            else if (average >= 70 || average < 80)
            {
                result = "B";
            }
            else if (average >= 60 || average < 70)
            {
                result = "C";
            }
            else if (average >= 50 || average < 60)
            {
                result = "D";
            }
            else
            {
                result = "F";
            }
            //switch case to know how they did
            switch (result)
            {
                case "A":
                    Console.WriteLine("Excellent! Your grade is A");
                    break;

                case "B":
                    Console.WriteLine("Good! Your grade is B");
                    break;

                case "C":
                    Console.WriteLine("Satisfactory. Your grade is C");
                    break;

                case "D":
                    Console.WriteLine("Pass. Your grade is D");
                    break;

                case "F":
                    Console.WriteLine("Fail. Your grade is F");
                    break;

                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }



        }
        static void Main(string[] args)
        {
            try
            {
                fiFth display = new fiFth();
                display.takinggrade();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception has been handled ");
            }
        }

    }
}