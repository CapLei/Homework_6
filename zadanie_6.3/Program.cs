
int[] array = {1,2,3,4,5};
int i = array.Length-1;


void ArrayShow(int [] array, int i){
    if(i<0) return;
    int result = array[i];
    Console.WriteLine($"{result}");

    ArrayShow(array,i-1);
}

ArrayShow(array,i);