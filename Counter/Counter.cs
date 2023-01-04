namespace CounterProject
{
    public class Counter
    {
        private int count;
        private static Counter? instance = null;

        // mark as not beforefieldinit 
        static Counter()
        {

        }

        // lock away the default constructor
        private Counter()
        {

        }

        // got this method to get instance as a singleton
        // from https://www.c-sharpcorner.com/UploadFile/8911c4/singleton-design-pattern-in-C-Sharp/
        /*private static Counter count
        {
            get
            {
                if (instance == null)
                {
                    instance = new Counter();
                }
                return instance;
            }
        }*/


        // traditional way
        public static Counter getInstance ()
        {
            if (instance == null)
            {
                instance = new Counter ();
            }
            instance.count = 0; // habit of c/c++
            return instance;
        }


        public void Increment()
        {
            count++;
        }

        public void Decrement()
        {
            count--;
        }

        public int getCount()
        {
            return count;
        }

    }
}
