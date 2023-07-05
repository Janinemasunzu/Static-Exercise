namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
          var celsius =  TempConverter.FahrenheitToCelsius(86);

           var fahrenheit = TempConverter.CelsiusToFahrenheit(30);

            Console.WriteLine($"celsius {celsius}");
            Console.WriteLine();
            Console.WriteLine($"fahrenheit {fahrenheit}");
            
        }
    }
}
