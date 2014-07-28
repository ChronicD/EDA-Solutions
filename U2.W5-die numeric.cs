public class Die
{
	int sides;
	
	public Die (int number)
	{
		if (number < 2)
		{
			throw new ArgumentException ("Thoust die bend the laws of my fantastical world!");
		}
	
		else 
		{
			sides = number;
		}
	}	
	
	public int Sides ()
	{
		return sides;
	}
	
	public int Roll ()
	{
		Random rnd = new Random();
		int Roll = rnd.Next(1, sides);
		return Roll;
	}
}