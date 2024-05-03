namespace VirtualMethodsInConstructor
{
    public class VirtualMethodsInConstructor
    {
        static void Main()
        {
            Parent parent = new Child(); //NullReferenceExcepetion
            //First the constructor of Parent is called
            //which calls the Test method of Child before the
            //constructor of Child so the list is not initialised

            //CONSTRUCTORS ARE CALLED IN A TOP-TO-BOTTOM ORDER BASED ON THE CLASS HIERARCHY.
            //MEMBER INITIALIZATION OCCURS BOTTOM TO TOP WITHIN EACH CLASS,
            //WHERE DERIVED CLASS MEMBERS ARE INITIALIZED BEFORE BASE CLASS MEMBERS.
        }
    }

    public class Parent
    {
        public Parent()  { Test(); }

        public virtual void Test() { }
    }

    public class Child : Parent
    {
        private ICollection<string> list;

        public Child()
        {
            list = new List<string>();
        }

        public override void Test()
        {
            Console.WriteLine(list.Count);
        }
    }
}
