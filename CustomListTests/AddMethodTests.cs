using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class AddMethodTests
    {
        [TestMethod]
        public void AddMethod_ItemsAdddedToList_CountGoesUp()
        {
            //Arrange
                        
            int itemsAddedToList = 1;
            CustomList < string> myList = new CustomList<string>();

            //Act

            myList.count(itemsAddedToList);

            //Assert

            Assert.AreEqual(itemsAddedToList.count(1), items.count);
        }

        [TestMethod]
        public void AddMethod_AddTwoItems_SecondItemAtIndexOne()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("12");
            myList.Add("22");
            //Assert

            Assert.AreEqual("22", myList[1]);
        }
        [TestMethod]
        public void AddMethod_AddOneItem_FirstItemAtIndexZero()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("12");
            myList.Add("22");
            //Assert

            Assert.AreEqual("12", myList[0]);
        }
        [TestMethod]
        public void AddMethod_CapacityExceeded_CapacityIncreases() //????? Come Back to this
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("12");
            myList.Add("22");
            myList.Add("10");
            myList.Add("13");

            //Assert

            Assert.AreEqual("22", myList[1]);
        }
        [TestMethod]
        public void AddMethod_CapacityIncreases_ItemLeftInOriginalIndex()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("12");
            myList.Add("22");
            //Assert

            Assert.AreEqual("22", myList[1]);
        }
    }
}