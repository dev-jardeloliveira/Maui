namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
                DateTime date = DateTime.Now;

                if(date.TimeOfDay.Hours > 0 &&  date.TimeOfDay.Hours < 12)
                {
                    Console.WriteLine("Good morning!");

                }else if(date.TimeOfDay.Hours >= 12 && date.TimeOfDay.Hours < 18)
                {
                    Console.WriteLine("Good afternon!");
                }
                else 
                {
                    Console.WriteLine("Good evening!");
                }
           
        }

        [TestMethod]
        public void TestMethod2()
        {
            

        }

    }
}