
void NumberLine(int m, int n){
    if(m == n)  return;
    Console.WriteLine($"{m} ","");
    NumberLine(m+1 , n);
}




Console.WriteLine("Enter your number");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your number");
int n = Convert.ToInt32(Console.ReadLine());
NumberLine(m,n);
