using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

int SaveIntFromUser()
{
    string from_user = Console.ReadLine();
    int number;
    bool succes = Int32.TryParse(from_user, out number);
    if (succes && number > 0)
    {
        return number;
    }
    else
    {
        Console.WriteLine("Podaj liczbe naturalna wieksza niz 0");
        return -1;
    }
}

void PrintArray(int[,]Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write(Array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] Create_Array ()
{
    Console.WriteLine("Podaj rozmiar macierzy (macierz bedzie automatycznie kwadratem o zadanej ilosci rzedow i tej samej kolumn)");

    int size;
    do
    {
        size = SaveIntFromUser();
    } while (size <= 0);

    int[,] FloydArray = new int[size, size];

    Console.WriteLine("Podaj wartosci dla poszczegolnych pol w przypadku nieskonczonosci zalecane jest podac liczbe wieksza od najwiekszej liczbowej wartosci w macierzy\n");

    for (int row = 0; row < FloydArray.GetLength(0); row++)
    {
        for (int col = 0; col < FloydArray.GetLength(1); col++)
        {   
            if(col!=row)
            {
                Console.WriteLine("Kolumna {0} wiersz {1}", col+1, row+1);
                do
                {
                    FloydArray[row, col] = SaveIntFromUser();
                } while (FloydArray[row, col] < 0);
            }
            
        }

    }

    return FloydArray;
}
int[,] FloydAlgorithm (int [,]InputArray,int iteration, int IterationNum)//,int iteration)
    {

    //int[,] ResultArray = InputArray;
    //if (iteration<InputArray.GetLength(0))
    //{
    //    return ResultArray;
    //}

    if(iteration < (IterationNum-1)) 
    {
       
        return FloydAlgorithm(InputArray, iteration+1,IterationNum);
        Console.WriteLine($"\n Iteracja: {iteration}");
        PrintArray(InputArray);

    }
    else 
    {
        int row_it = iteration;
        int col_it = iteration;

        for (int row = 0; row < InputArray.GetLength(0); row++)
        {
            for (int col = 0; col < InputArray.GetLength(1); col++)
            {
                if (col != col_it && row != row_it)
                {
                    if (InputArray[row, col] > (InputArray[row_it, col] + InputArray[row, col_it]))
                    {
                        InputArray[row, col] = InputArray[row_it, col] + InputArray[row, col_it];
                    }
                }
            }
        }
        Console.WriteLine($"\n Iteracja: {iteration}");
        PrintArray(InputArray);
        Console.WriteLine("\n");
        return InputArray;
    } 
}


//int [,] FloydArray = Create_Array();
int[,] FloydArray = { {0,3,300,1,300 },{ 3,0,300,4,1},{2,300,0,7,300},{300,300,5,0,4 },{300,1,2,300,0} };
Console.WriteLine("Macierz stworzona\n");
PrintArray(FloydArray);
Console.WriteLine("\nMacierz po algorytmie\n");
var Result = FloydAlgorithm(FloydArray,0,FloydArray.GetLength(0)-1);
PrintArray(Result);





