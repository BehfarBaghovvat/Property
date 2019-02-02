namespace Property
{
    class Person
    {

        private uint age;
        private string fullname;
        private ulong salary;



        /// <summary>
        /// Property Age
        /// </summary>

        public uint Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value>=0 && value<=150)
                {
                    age = value;
                }
            }
        }

        public string FullName { get; set; }
        

        /// <summary>
        /// Property Salary
        /// </summary>

        public ulong Salary
        {
            get
            {
                return salary;
            }

            set
            {
                if (value>=0 && value<=50000000)
                {
                    salary = value;
                }
            }
        }

        /// <summary>
        /// Method Show Information.
        /// </summary>

        public void ShowInfo()
        {
            string message =
                $"My name is { FullName } and... { Age } years old and.... my salary { Salary }$ ";

            System.Console.WriteLine(message);

            System.Console.WriteLine();
        }

        /// <summary>
        /// Snippet Propfull for Weight
        /// </summary>

        private int weight;

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        /// <summary>
        /// Snippet propfull for Height
        /// </summary>


        private int height;

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }



    }
}
