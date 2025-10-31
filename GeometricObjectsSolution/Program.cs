using System.Collections;

namespace GeometricObjectsSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Circle? kreis1 = null;
            Circle? kreis2 = null;

            try
            {
                kreis1 = new Circle();
                kreis1.InvalidMeasure += Kreis1_InvalidMeasure;
                kreis1.Radius = -100;
                kreis2 = new Circle(-89);
                kreis2.Radius = -9;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Im Catch-Block: {ex.Message}");
                Console.WriteLine($"Log-Daten: {ex.Data["Time"]}");
            }
            Console.ReadLine();


            
        }

        private static void Kreis1_InvalidMeasure(object sender, InvalidMeasureEventArgs e)
        {
            Console.WriteLine($"Ereignishandler: {e.Error.Message}");
        }
    }
}
