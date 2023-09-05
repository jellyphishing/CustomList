using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class PlusOperatorOverloadTests
    {
        [TestMethod]  //#1
        public void PlusOperatorOverload_()
        {
            CustomList<int> list1 = new CustomList<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);

            CustomList<int> list2 = new CustomList<int>();
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);


            CustomList<int> finalResult = list1 + list2;
            //[1,2,3,4,5,6]
        }
    }
    
}
