using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions.Extensions
{
	public static class Extensions
	{
		/// <summary>
		/// Capitalize the text
		/// </summary>
		/// <param text: ="text"></param>
		/// <returns></returns>
		public static string Capitalize(this string text)
		{
			char firstLetter = Char.ToUpper(text[0]);
			StringBuilder stringBuilder = new StringBuilder(text);
			stringBuilder[0] = firstLetter;
			return stringBuilder.ToString();
		}
		/// <summary>
		/// Reverce the text
		/// </summary>
		/// <param text: ="text"></param>
		/// <returns></returns>
		public static string Reverse(this string text)
		{
			char[] reversible = text.ToCharArray();
			string reversedText = "";
			for (int i = reversible.Length - 1; i >= 0; i--)
			{
				reversedText += reversible[i];
			}
			return reversedText;
		}
		/// <summary>
		/// Gets letter from your index
		/// </summary>
		/// <param text: ="text"></param>
		/// <param index: ="index"></param>
		/// <returns></returns>
		public static string GetLetter(this string text, int index)
        {
			char[] letters = text.ToCharArray();
			string letter = "";
			return letter += letters[index];
		}
		/// <summary>
		/// Adds element into your array
		/// </summary>
		/// <param array: ="stringArr"></param>
		/// <param index: ="index"></param>
		/// <param element: ="text"></param>
		/// <returns></returns>
		public static string[] Add(this string[] stringArr, int index, string text)
        {
			string[] added = new string[stringArr.Length + 1];
            for (int i = 0; i < added.Length; i++)
            {
                if (i == added.Length - 1)
                {
					added[i] = text;
					break;
                }
				added[i] = stringArr[i];
			}
			string temp = added[index];
			added[index] = added[added.Length - 1];
			added[added.Length - 1] = temp;
			return added;
		}
		/// <summary>
		/// Adds element into your array
		/// </summary>
		/// <param array: ="charArr"></param>
		/// <param index: ="index"></param>
		/// <param element: ="character"></param>
		/// <returns></returns>
		public static char[] Add(this char[] charArr, int index, char character)
		{
			char[] added = new char[charArr.Length + 1];
			for (int i = 0; i < added.Length; i++)
			{
				if (i == added.Length - 1)
				{
					added[i] = character;
					break;
				}
				added[i] = charArr[i];
			}
			char temp = added[index];
			added[index] = added[added.Length - 1];
			added[added.Length - 1] = temp;
			return added;
		}
		/// <summary>
		/// Adds element into your array
		/// </summary>
		/// <param array: ="intArr"></param>
		/// <param index: ="index"></param>
		/// <param element: ="number"></param>
		/// <returns></returns>
		public static int[] Add(this int[] intArr, int index, int number)
		{
			int[] added = new int[intArr.Length + 1];
			for (int i = 0; i < added.Length; i++)
			{
				if (i == added.Length - 1)
				{
					added[i] = number;
					break;
				}
				added[i] = intArr[i];
			}
			int temp = added[index];
			added[index] = added[added.Length - 1];
			added[added.Length - 1] = temp;
			return added;
		}
	}
}
