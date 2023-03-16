class calculator
{
	static void main(string{}args)
	{
		int a = 10;
		int b = 6;
		
		Console.Writelineriteline("hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
		Console.Writelineriteline("hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b));
		
		Consoleonsole.Writelineriteline("\nTekan sembarang Key untuk keluar");
		Console.Readkey();
	}
	static int Penambahan(int a, int b)
	{
		return a + b;
	}
	static int Pengurangan(int a, int b)
	{
		return a - b;
	}
}				