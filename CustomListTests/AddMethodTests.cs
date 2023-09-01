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

       
        public class ToStringMethodTests

        {
            [TestMethod]  //#1
            public void ToStringMethodTests_CreateListOfStrings_ListCreated()
            {
                //Arrange


                CustomList<string> myList = new CustomList<string>();

                //Act

                myList.Add("1");
                myList.Add("2");
                myList.Add("3");
                myList.Add("4");
                myList.Add("5");


                //Assert

                Assert.AreEqual("12345", myList.ToString());

            }



            [TestMethod]  //#2
            public void ToStringMethodTests_CreateEmptyList_EmptyStringCreated()
            {
                //Arrange


                CustomList<string> myList = new CustomList<string>();

                //Act

                myList.Add("");



                //Assert

                Assert.AreEqual("", myList.ToString());

            }




            [TestMethod]  //#3
            public void ToStringMethodTests_CreateListOfInts_IntListCreated()
            {
                //Arrange

                
                CustomList<int> numbers = new CustomList<int>();

                //Act
                
                numbers.Add(1);
                numbers.Add(2);
                numbers.Add(3);
                numbers.Add(4);
                numbers.Add(5);
                numbers.Add(6);



                //Assert

                Assert.AreEqual("123456", numbers.ToString());

            }
        }
    }
}

