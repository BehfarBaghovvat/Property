namespace Property
{
	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person(100000)
			{
				Age = 39,
				FullName = "James T Cerk",
			};

			person.ShowInformation();

			System.Console.WriteLine("Press [ENTER] To Exit... ");
			System.Console.ReadLine();
		}
	}
}
