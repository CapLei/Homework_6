

int Akkerman(int m,int n){
    if(m == 0) return n+1;
    else if(n == 0) return Akkerman(m-1, 1);
    else return Akkerman(m-1, Akkerman(m, n-1));
}


Console.WriteLine("Enter number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number n: ");
int n = Convert.ToInt32(Console.ReadLine());
int akkerman = Akkerman(m,n);
Console.WriteLine($"Функция Аккермана равна {akkerman}");