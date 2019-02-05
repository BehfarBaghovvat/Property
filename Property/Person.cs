namespace Property
{
	/// <summary>
	/// 
	/// </summary>
	class Person
	{
		public Person(long salary) : base()
		{
			Salary = salary;
		}

		#region Age Property
		/// <summary>
		/// 
		/// </summary>
		private int age;

		/// <summary>
		/// 
		/// </summary>
		public int Age
		{
			get
			{
				return age;
			}
			set
			{
				if (value >= 0 && value <= 100)
				{
					age = value;
				}
			}
		}
		#endregion /Age Property

		#region Salary Property
		/// <summary>
		/// Googooli
		/// </summary>
		private long salary;

		/// <summary>
		/// Magooli
		/// </summary>
		public long Salary
		{
			get
			{
				return salary;
			}
			private set
			{
				if (value >= 0 && value <= 50000000)
				{
					salary = value;
				}
			}
		}
		#endregion /Salary Property

		#region FullName Property
		/// <summary>
		/// 
		/// </summary>
		public string FullName { get; set; }
		#endregion /FullName Property

		#region Weight Property
		private int Weight { get; set; }
		#endregion /Weight Property

		#region Height Property
		public int Height { get; set; }
		#endregion /Height Property

		/// <summary>
		/// Show Information Method
		/// </summary>
		public void ShowInformation()
		{
			string message =
				$"My name is { FullName } and { Age } years old and I get { Salary }$";

			System.Console.WriteLine(message);
		}
	}
}
