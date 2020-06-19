using System;

namespace passwordValidator
{
    class Program
    {
		public static bool isValid(String password)
		{
			// for checking if password length 8-14
			if (!((password.Length >= 8)
				&& (password.Length <= 15)))
			{
				return false;
			}

			// Check to check space 
			if (password.Contains(" "))
			{
				return false;
			}
			if (true)
			{
				int count = 0;

				// Check for digits from 0 to 9 
				for (int i = 0; i <= 9; i++)
				{

					// Convert int to string 
					String str1 = i.ToString();

					if (password.Contains(str1))
					{
						count = 1;
					}
				}
				if (count == 0)
				{
					return false;
				}
			}

			// Checking for special characters 
			// refactor later as array
			if (!(password.Contains("@") || password.Contains("#")
				|| password.Contains("!") || password.Contains("~")
				|| password.Contains("$") || password.Contains("%")
				|| password.Contains("^") || password.Contains("&")
				|| password.Contains("*") || password.Contains("(")
				|| password.Contains(")") || password.Contains("-")
				|| password.Contains("+") || password.Contains("/")
				|| password.Contains(":") || password.Contains(".")
				|| password.Contains(", ") || password.Contains("<")
				|| password.Contains(">") || password.Contains("?")
				|| password.Contains("|")))
			{
				return false;
			}
			if (true)
			{
				int count = 0;
				// Checking for capital letters 
				for (int i = 65; i <= 90; i++)
				{
					// Checking for type casting 
					char c = (char)i;
					String str1 = c.ToString();
					if (password.Contains(str1))
					{
						count = 1;
					}
				}
				if (count == 0)
				{
					return false;
				}
			}
			if (true)
			{
				int count = 0;
				// Checking for small letters 
				for (int i = 90; i <= 122; i++)
				{
					// Checking type casting 
					char c = (char)i;
					String str1 = c.ToString();

					if (password.Contains(str1))
					{
						count = 1;
					}
				}
				if (count == 0)
				{
					return false;
				}
			}
			return true;
		}
		// Run the code  in the terminal
		public static void Main(String[] args)
		{

			String password1 = "GeeksForGeeks";

			if (isValid(password1))
			{
				Console.WriteLine(password1 + " Is Valid Password");
			}
			else
			{
				Console.WriteLine(password1 + " Is Invalid Password!!!");
			}

			String password2 = "Geek$ForGeeks7";
			if (isValid(password2))
			{
				Console.WriteLine(password2 + " Is Valid Password");
			}
			else
			{
				Console.WriteLine(password2 + " Is Invalid Password!!!");
			}
		}
	}
}
