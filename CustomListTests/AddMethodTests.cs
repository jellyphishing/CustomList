using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class AddMethodTests
    {
        [TestMethod]  //#1
        public void AddMethod_ItemsAdddedToList_CountGoesUp()
        {
            //Arrange

            string itemsAddedToList = "1";
            CustomList<string> myList = new CustomList<string>();

            //Act

            myList.Add(itemsAddedToList);

            //Assert

            Assert.AreEqual(1, myList.Count);

        }

        [TestMethod]  //#2
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
        [TestMethod] //#3
        public void AddMethod_AddOneItem_FirstItemAtIndexZero()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("12");

            //Assert

            Assert.AreEqual("12", myList[0]);
        }
        [TestMethod] //#4
        public void AddMethod_CapacityExceeded_CapacityIncreases() //????? Come Back to this
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("12");
            myList.Add("22");
            myList.Add("10");
            myList.Add("13");
            myList.Add("76");
            //Assert

            Assert.AreEqual(8, myList.Capacity);
        }
        [TestMethod] //#5
        public void AddMethod_CapacityIncreases_ItemLeftInOriginalIndex()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("12");
            myList.Add("22");
            myList.Add("10");
            myList.Add("13");
            myList.Add("76");
            //Assert

            Assert.AreEqual("12", myList[0]);
        }



    }
           
}

