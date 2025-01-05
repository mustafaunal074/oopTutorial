namespace Ders10_Record
{
    class Program
    {
        private static void Main(string[] args)
        {
            #region Part1
            
            // MyClass myClass = new MyClass()
            // {
            //     MyProperty = 5 ,
            //     A = 5
            // };
            // myClass.MyProperty = 3;

            #endregion

            #region Part2
            
            MyClass m1 = new MyClass()
            {
                MyProperty = 5
            };
            MyClass m2 = new MyClass()
            {
                MyProperty = 5
            };

            System.Console.WriteLine(m1.Equals(m2));


            MyRecord m3 = new MyRecord()
            {
                MyProperty = 5
            };
            MyRecord m4 = new MyRecord()
            {
                MyProperty = 5
            };

            System.Console.WriteLine(m3.Equals(m4));

            #endregion

            // MyClass my1 = new MyClass()
            // {
            //     MyProperty = 5,
            //     MyProperty2 = 10
            // };
            // my1.MyProperty2 = 15;
            // MyClass my2 = new MyClass()
            // {
            //     MyProperty = m1.MyProperty,
            //     MyProperty2 = 15
            // };
            // MyClass my2 = my1.With(15);

            MyRecord my1 = new MyRecord()
            {
                MyProperty = 5,
                MyProperty2 = 10
            };

            MyRecord my2 = my1 with { MyProperty2 = 15};
        }
    }

    record MyRecord
    {
        public int MyProperty { get; init; }
        public int MyProperty2 { get; init; }
        
    }
    class MyClass
    {
        public int MyProperty { get; init; }
        public int MyProperty2 { get; init; }
        public MyClass With(int prop2)
        {
            return new MyClass()
            {
                MyProperty = this.MyProperty,
                MyProperty2 = prop2
            };
        }
    }

    #region MyClass
    
    // class MyClass
    // {
    //     // reaodonly olan nesne set bloğu kalkmış nesnedir.
    //     // bu nesneye ilk değeri bir bu şekilde verilir
    //     // public int MyProperty { get;  } = 3;
    //     public int MyProperty { get; init; } = 3;

    //     readonly int a;
    //     public int A 
    //     {
    //         get
    //         {
    //             return a;
    //         }
    //         init
    //         {
    //             a = value;
    //         }
    //     }
    // }

    #endregion
}