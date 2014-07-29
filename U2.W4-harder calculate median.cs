public float Median(ArrayList array)
{
    	int [] filter = (int[]) array.ToArray( typeof( int ) );
	Array.Sort(filter);
	int c = filter.Length;
	if (c % 2 == 0)
	{
		int temp = (filter[(c / 2)-1] + filter[c / 2]) ;
	       return (float) temp/(float)2;
	}
	else
	{
	       int temp = filter[c / 2];
	       return (float) temp;
	}
}