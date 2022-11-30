using System;

public static class Globals
{
	internal static void Main()
	{
		Console.Write("Afisati in ordine inversa cifrele lui N");
		Console.Write("\n");

		int n;
		Console.Write("N = ");
		n = Convert.ToInt32(Console.ReadLine());

		int ogl = 0;
		while (n != 0)
		{
			ogl = 10 * ogl + n % 10;
			n /= 10;
		}
		Console.Write("Oglinditul lui N = ");
		Console.Write(ogl);
		Console.Write("\n");
	}
}