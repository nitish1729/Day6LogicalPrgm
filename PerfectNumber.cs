
// 2. Perfect Number

int num;
int i = 1, 
int total = 0;

 Console.WriteLine("Enter a number");

  num = int.Parse(Console.ReadLine());

 for(i=1; i<num; i++)
   {
    if(num % i == 0)
     total += i;
   }
   if(total == num)
   {
    Console.Write("{0} is a perfect number", num);
   }
   else
   {
    Console.Write("{0} is not a perfect number", num);
	}