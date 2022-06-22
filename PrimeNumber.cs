int num; int count = 0;
		Console.WriteLine("Number");
		num = int.Parse(Console.ReadLine());
		
    for ( int i = 1; i <=num; i++)
	{
	   if (num % i == 0)
	  {
	count++;
	  }
	}
		if(count == 2)
		{
		Console.WriteLine("prime Number");
	}	
	
		else 
		{
		Console.WriteLine("Not a prime Number");
		}