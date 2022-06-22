int a; 
int b;  
int result = 0; 


	
Console.WriteLine("Enter a number");

 a = int.Parse(Console.ReadLine());
	
while(a!=0)
	{
		    b = a % 10;
			result = result*10 + b;
			a = a/10;
	}

          Console.WriteLine(result);