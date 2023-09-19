using CustomList;

namespace CustomListTests
{
    [TestClass]
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



        [TestMethod]  //#3
        public void ToStringMethodTests_CreateEmptyList_EmptyStringCreated()
        {
            //Arrange


            CustomList<string> myList = new CustomList<string>();

            //Act




            //Assert

            Assert.AreEqual("", myList.ToString());

        }




        [TestMethod]  //#2
        public void ToStringMethodTests_CreateListOfInts_IntListCreated()
        {
            //Arrange
            string expected = "123456";
            string actual;
            CustomList<int> numbers = new CustomList<int>();

            

            //Act

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);

            actual = numbers.ToString();

            //Assert

            Assert.AreEqual(expected, actual);

        }
    }

}

