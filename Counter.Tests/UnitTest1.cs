using CounterProject;

namespace Counter.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void DoesCounterIncrement()
        {
            var counter = CounterProject.Counter.getInstance();
            counter.Increment();
            
            Assert.Equal(1, counter.getCount());
        }

        [Fact]
        public void DoesCounterDecrement()
        {
            var counter = CounterProject.Counter.getInstance();
            counter.Decrement();

            Assert.Equal(-1, counter.getCount());
        }
    }
}