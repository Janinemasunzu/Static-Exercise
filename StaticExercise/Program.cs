namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
          var celsius =  TempConverter.FahrenheitToCelsius(32);

           var fahrenheit = TempConverter.CelsiusToFahrenheit(0);

            Console.WriteLine($"celsius {celsius}");
            Console.WriteLine();
            Console.WriteLine($"fahrenheit {fahrenheit}");
            
        }
    }
}
