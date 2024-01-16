namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Calling the method
            InferredInterpolationTernary();


            
        }


        //creating a new method to keep Main clean
        static void InferredInterpolationTernary()
        {

            
            
            //int answer =4
            //_______________________________________________________________________________________________
            var answer = 4;


            //string response;
            //if (answer < 9)
            //response = answer + " is less than nine";
            //else
            //response = answer + " is greater than or equal to nine";
   


            //ternary operator
            //string response, < 9, $ and {} allows interpolation, true and false statements, colon to seperate 

            //____________________________________________________________________________________________________________
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than nine";

            //writes the response to the console
            //___________________________________________________________________________________________________________
            Console.WriteLine(response);

        }
    }
}
