using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class PlusOperatorOverloadTests
    {
        [TestMethod]  //#1
        public void OperatorOverload_List1LongerThanList2_FinalResultListFromToStringMethod()
        {
            //Arrange

            //Act
            CustomList<int> list1 = new CustomList<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);

            CustomList<int> list2 = new CustomList<int>();
            list2.Add(4);
            list2.Add(5);





            CustomList<int> finalResult = list1 + list2;
            //Assert
            Assert.AreEqual(12345, finalResult.ToString());
        }

        [TestMethod]  //#2
        public void OperatorOverload_List2LongerThanList1_FinalResultListFromToStringMethod()
        {
            //Arrange

            //Act
            CustomList<int> list1 = new CustomList<int>();
            list1.Add(1);
            list1.Add(2);


            CustomList<int> list2 = new CustomList<int>();
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);





            CustomList<int> finalResult = list1 + list2;
            //Assert
            Assert.AreEqual(12456, finalResult.ToString());
        }

        [TestMethod]  //#3
        public void OperatorOverload_Add2ListsWithOneListEmpty_FinalResultListFromToStringMethod()
        {
            //Arrange

            //Act
            CustomList<int> list1 = new CustomList<int>();
            
            CustomList<int> list2 = new CustomList<int>();
            list2.Add(4);
            list2.Add(5);





            CustomList<int> finalResult = list1 + list2;
            //Assert
            Assert.AreEqual(45, finalResult.ToString());
        }
    }
}
