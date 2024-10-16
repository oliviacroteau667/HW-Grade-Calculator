/*
Olivia Croteau
IGME201
Due: 11/13 (extended for Columbus break)
*/

namespace grade_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables
            string studentName = "Olivia Croteau";
            int[] grades = [100, 92, 87, 200, -20, 52, 82, 75, 67, 88];
            string gradeStr = "This grade is a";
            int average = 0;
            int divisor = grades.Count();

            Console.WriteLine("Welcome " + studentName);
            Console.WriteLine("Here are your grades: ");

            foreach (int grade in grades)
            {
                Console.WriteLine(grade);

                average += grade;

                if (grade <= 100 && grade >= 90)
                {
                    Console.WriteLine(gradeStr + "n A!");

                    if (grade == 100)
                    { Console.WriteLine("WOW! A perfect score!"); }
                }
                else if (grade < 90 && grade >= 80)
                {
                    Console.WriteLine(gradeStr + " B.");
                }
                else if (grade < 80 && grade >= 70)
                {
                    Console.WriteLine(gradeStr + " C.");
                }
                else if (grade < 70 && grade >= 65)
                {
                    Console.WriteLine(gradeStr + " D.");
                }
                else if (grade < 65 && grade >= 0)
                {
                    Console.WriteLine(gradeStr + "n F.");
                }
                else
                {
                    Console.WriteLine("This is out of the range of 0-100. How did you even get this grade?");
                }
            }

            average = average / divisor;
            Console.WriteLine("Your final calculated average is: " + average + ".");
            Console.WriteLine("We have displayed all grades for" + studentName);
        }
    }
}
