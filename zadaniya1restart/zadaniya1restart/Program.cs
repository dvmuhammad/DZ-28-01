using System;
using System.Linq;

namespace zadaniya1
{
	class ArrayHelper
	{
		public static void Pop()
		{
			Random random = new Random();
			int[] a = Enumerable.Repeat(0, 15).Select(x => random.Next(0, 10)).ToArray();
			Console.WriteLine(string.Join(" ", a.Select(x => x.ToString()).ToArray()));

			System.Array.Resize(ref a, a.Length - 1);
			Console.WriteLine(string.Join(" ", a.Select(x => x.ToString()).ToArray()));
			Console.ReadKey(true);
		}

		public static void Push(ref int[] array, int value, int index)
		{


			int[] newArray = new int[array.Length + 1];
			newArray[index] = value;

			for (int i = 0; i < index; i++)
				newArray[i] = array[i];

			for (int i = index; i < array.Length; i++)
				newArray[i + 1] = array[i];

			array = newArray;
			Console.WriteLine(newArray);

		}
		public static void Shift()
		{
			int[] numbers = { 1, 3, 4, 9, 2, 4 };
			int numToRemove = 1;
			int numIndex = Array.IndexOf(numbers, numToRemove);
			numbers = numbers.Where((val, idx) => idx != numIndex).ToArray();
			Console.WriteLine(numbers);
		}
		public static void Unshift(ref int[] array, int value)
		{
			Push(ref array, value, 0);


		}

	}
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] myArray = { 1, 4, 6, 2 };
			ArrayHelper.Push(ref myArray, -5, 2);

			ArrayHelper.Unshift(ref myArray, -5);

			ArrayHelper araryHelper = new ArrayHelper();

			ArrayHelper.Pop();

			ArrayHelper.Shift();


			Console.ReadKey();

		}
	}
}