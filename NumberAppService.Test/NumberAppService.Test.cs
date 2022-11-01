using NumberApp;

namespace NumberAppServiceTest
{
    public class NumberAppServiceTest 

    {
     
        private readonly  INumberAppService _service;
        public  NumberAppServiceTest()
        {
            _service = new NumberAppService();
           
        }
        /// <summary>
        /// create a mock database for you tests to start running 
        /// </summary>
        [Fact]
        public void Test_AnyFiveNumbersAdded_WhenCallingTotalNumbersSum()
        {

            Assert.Equal(0, _service.GetTotalNumbers());

            _service.AddNumberToList(1);
   
            //  _service.AddNumberToList(2);
           // Assert.Single(1, list.Count);

            Assert.Equal (1, _service.GetTotalNumbers());

            _service.AddNumberToList(1); 
            _service.AddNumberToList(1); 
            _service.AddNumberToList(1); 
            _service.AddNumberToList(1);

            Assert.Equal(5, _service.GetTotalNumbers());
        }


        [Fact]

        public void Test_AverageOfFiveNumbers_ReturnAverageOfSum()
        {
            _service.AddNumberToList(1);
            _service.AddNumberToList(222);
            _service.AddNumberToList(3254);
            _service.AddNumberToList(148);
            _service.AddNumberToList(16589);
            Assert.Equal(20214, _service.GetTotalNumbers());

            var average = _service.GetAverage();

            Assert.Equal(4042.8m, average);

        }

        [Fact]

        public void Test_ForTheHighestNumber_ReturnTheHighestNumber()
        {
            _service.AddNumberToList(1);
            _service.AddNumberToList(222);
            _service.AddNumberToList(3254);
            _service.AddNumberToList(148);
            _service.AddNumberToList(16589);
            Assert.Equal(20214, _service.GetTotalNumbers());

            var highestNumber = _service.GetHighestNumber();

            Assert.Equal(16589, highestNumber);
        }
        [Fact]
        
        public void Test_NumberDividedByZero_ReturnZero()
        {
            var average = (_service.GetAverage());

            Assert.Equal(0, average);
        }
       
    }
}