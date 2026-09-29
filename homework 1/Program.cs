namespace homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Compressor Compressor = new Compressor();
            Compressor.CompressArray();


            
            NumberCounter counter = new NumberCounter();
            counter.CountOccurrences();


            MatrixColumnSwapper swapper = new MatrixColumnSwapper();
            swapper.SwapColumns();
        }
    }
}
