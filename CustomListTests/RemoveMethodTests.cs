using CustomList;


namespace CustomListTests
{
    [TestClass]
    public class RemoveMethodTests
    {
        [TestMethod]  //#1
        public void RemoveMethod_ItemsRemovedFromList_CountDecreases()
        {
            //Arrange

            string itemsRemovedFromList = "1";
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("1");
            myList.Add("2");
            myList.Remove(itemsRemovedFromList);

            //Assert

            Assert.AreEqual(1, myList.Count);

        }

        [TestMethod]  //#2
        public void RemoveMethod_ItemRemoved_MethodReturnsTrue()
        {
            //Arrange

            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("1");
            myList.Add("22");
            myList.Add("10");
            myList.Add("13");
            bool wasItemRemoved = myList.Remove("1");

            //Assert

            Assert.AreEqual(true, wasItemRemoved);

        }

        [TestMethod]  //#3
        public void RemoveMethod_ItemRemovedNotInList_CountDoesNotDecrease()
        {
            //Arrange


            CustomList<string> myList = new CustomList<string>();

            //Act

            myList.Add("12");
            myList.Add("22");
            myList.Add("10");
            myList.Add("13");
            myList.Remove("99");
            //Assert

            Assert.AreEqual(4, myList.Count);
        }





        [TestMethod]  //#4
        public void RemoveMethod_ItemRemoved_ItemsShiftBackInIndex()
        {
            //Arrange


            CustomList<string> myList = new CustomList<string>();

            //Act

            myList.Add("1");
            myList.Add("2");
            myList.Add("3");
            myList.Add("4");
            myList.Add("5");
            myList.Remove("4");

            //Assert

            Assert.AreEqual("5", myList[3]);

        }


        [TestMethod]  //#5
        public void RemoveMethod_RemoveOneInstanceOnlyOfRepeatedItem_OnlyFirstInstanceRemoved()
        {
            //Arrange


            CustomList<string> myList = new CustomList<string>();

            //Act

            myList.Add("4");
            myList.Add("2");
            myList.Add("3");
            myList.Add("4");
            myList.Add("5");
            myList.Remove("4");

            //Assert

            Assert.AreEqual("4", myList[2]);

        }

    }
}
