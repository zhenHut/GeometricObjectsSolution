namespace GeometricObjectsSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Airplane flg = new Airplane();
            flg.Start();
            Helicopter helicopter = new Helicopter();
            helicopter.Start();
        }
    }
}
