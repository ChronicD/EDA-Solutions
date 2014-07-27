public class Die
{
List<String> sides;

public Die (List<String> labels)
{
if (labels.Count < 1)
{
throw new ArgumentException ("What! you want to radomly select nothing?");
}

else {
sides = labels;
}
}	

public int Sides ()
{
return sides.Count;
}

public string Roll ()
{
Random random = new Random();
int roll = random.Next(sides.Count);
return sides[roll];
}
}