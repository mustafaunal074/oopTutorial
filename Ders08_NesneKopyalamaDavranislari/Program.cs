namespace Ders08_NesneKopyalamaDavranislari
{
    class Program
    {
        private static void Main(string[] args)
        {
            #region DeepCopy
            // int a = 5;
            // int b = a;
            #endregion
            #region ShallowCopy
            // MyClass m1 = new MyClass();
            // MyClass m2 = m1;
            // MyClass m3 = m2;
            // MyClass m4 = new MyClass();
            #endregion

            #region Nesne Üzerinde DeepCopy yapma
            MyClass m1 = new MyClass();
            MyClass m2 = m1; // shallow copy
            MyClass m3 = m1.Clone(); // deep copy
            #endregion
        
        }
    }

    class MyClass
    {
        public MyClass Clone()
        {
            return (MyClass)this.MemberwiseClone();
        }
    }
}