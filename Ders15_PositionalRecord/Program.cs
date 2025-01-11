namespace Ders15_PositionalRecord
{
    class Program
    {
        private static void Main(string[] args)
        {
            MyRecord m = new MyRecord("a","b");
            var (n,s) = m;
            
        }
    }
    record MyRecord(string name, string surname)
    {
        //
    }
}