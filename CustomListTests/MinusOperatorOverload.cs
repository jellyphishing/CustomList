
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class MinusOperatorOverloadTests
    {
        [TestMethod] //Test 1
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
            list2.Remove(4);

            CustomList<int> finalResult = list1 + list2;
            //Assert
            Assert.AreEqual("1235", finalResult.ToString());
        }
        [TestMethod] //#2
        public void OperatorOverload_List2LongerThanList1_FinalResultListFromToString()
        {
            //Arrange
            //Act
            CustomList<int> list1 = new CustomList<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Remove(1);

            CustomList<int> list2 = new CustomList<int>();
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);

            CustomList<int> finalResult = list1 + list2;
            //Assert
            Assert.AreEqual("2456", finalResult.ToString());

         }
        [TestMethod] //#3
        public void OperatorOverload_List2Empty_NothingRemovedFromList2FromToString()
        {
            CustomList<int> list1 = new CustomList<int>();
            list1.Add(3);
            list1.Add(6);
            list1.Add(9);

            CustomList<int> list2 = new CustomList<int>();
            

            CustomList<int> finalResult = list1 + list2;
            //Assert
            Assert.AreEqual("369", finalResult.ToString());
        }
        [TestMethod] //#4
        public void OperatorOverload_RemoveOneInstanceOnlyFromList2_List2OnlyRemovesFirstInstance()
        {
            CustomList<int> list1 = new CustomList<int>();
            
            CustomList<int> list2 = new CustomList<int>();
            list2.Add(3);
            list2.Add(3);
            list2.Add(3);
            list2.Remove(1);
            list2.Remove(2);
            list2.Remove(3);


            CustomList<int> finalResult = list1 + list2;
            //Assert
            Assert.AreEqual("33", finalResult.ToString());
        }
    }
}
