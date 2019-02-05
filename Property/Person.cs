namespace Property
{

    /// <summary>
    /// Person Class
    /// </summary>
    class Person
    {
        #region Age

        /// <summary>
        ///  age field
        /// </summary>
        /// 
        private uint age;

        /// <summary>
        /// Age Property
        /// </summary>
        /// 

        public uint Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value >= 0 && value <= 150)
                {
                    age = value;
                }
            }
        }

        #endregion /Age

        #region FullName

        /// <summary>
        /// FullName Property
        /// </summary>

        public string FullName { get; set; }

        #endregion /FullName

        #region Salary

        /// <summary>
        /// salary field
        /// </summary>

        private ulong salary;

        /// <summary>
        /// Salary Property
        /// </summary>

        public ulong Salary
        {
            get
            {
                return salary;
            }

            set
            {
                if (value >= 0 && value <= 50000000)
                {
                    salary = value;
                }
            }
        }

        #endregion /Salary

        #region Weight
        /// <summary>
        /// weight field
        /// </summary>

        private int weight;

        /// <summary>
        /// Weight Property
        /// </summary>

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

        #endregion /Weight

        #region Height

        /// <summary>
        /// height field
        /// </summary>

        private int height;

        /// <summary>
        /// Height property
        /// </summary>

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
    
        #endregion Height

        #region Show InforMation

        /// <summary>
        /// Show Information Method
        /// </summary>

        public void ShowInformation()
        {
            string message =
                $"My name is { FullName } and... { Age } years old and.... my salary { Salary }$ ";

            System.Console.WriteLine(message);

            System.Console.WriteLine();
        }

        #endregion /Show InforMation
    }
}
