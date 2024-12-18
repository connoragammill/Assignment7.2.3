namespace Assignment7._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Enter the first word:"); 
			string word1 = Console.ReadLine(); 
			Console.WriteLine("Enter the second word:"); 
			string word2 = Console.ReadLine(); 
			bool result = IsAnagram(word1, word2); 
			if (result) 
			{ 
				Console.WriteLine($"{word1} and {word2} are anagrams."); 
			} 
			else 
			{ 
				Console.WriteLine($"{word1} and {word2} are not anagrams."); 
			}
		}
		public static bool IsAnagram(string s, string t)
		{
			if (s.Length != t.Length)
			{
				return false;
			}

			char[] sSort = s.ToCharArray();
			char[] tSort = t.ToCharArray();
			Array.Sort(sSort);
			Array.Sort(tSort);
			return sSort.SequenceEqual(tSort);
		}
	}
}
