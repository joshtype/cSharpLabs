namespace MiscPractice
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            // inheritance:
            Dog d1 = new Dog(25.5, "white");
            Cat c1 = new Cat(5.1, "brown");

            // early binding (at compile time):
            Console.WriteLine(d1.speak());
            Console.WriteLine(c1.speak());

            // using parent constructor:
            Mammal m1 = new Dog(10.2, "tan");
            Mammal m2 = new Cat(2.3, "black");

            // polymorphism:
            m1 = new Cat();
            m2 = new Dog(4.3, "rainbow");

            // add objs to array:
            Mammal[] mArr = new Mammal[6];
            mArr[0] = m1;
            mArr[1] = m2;
            mArr[2] = c1;
            mArr[3] = d1;
            mArr[4] = new Dog();
            mArr[5] = new Cat();

            // late binding (at runtime):
            for(int i = 0; i < mArr.Length; i++)
            {
                // depending on context, method binds at runtime
                Console.WriteLine(mArr[i].ToString() + " and goes " + mArr[i].speak());
            }

            // list of 100 alternating mammal objs
            List<Mammal> mList = new List<Mammal>();
            for(int i = 0; i < 100; i++)
            {
                if(i%2 == 0)
                {
                    mList.Add(new Dog()); // could randomize paramaters also
                }
                else
                {
                    mList.Add(new Cat());
                }
            }
            foreach(Mammal m in mList)
            {
                Console.WriteLine(m.ToString());
            }
        }
    }
}
