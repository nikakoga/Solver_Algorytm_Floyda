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
                Console.WriteLine("Kolumna {0} wiersz {1}", col, row);
                do
                {
                    FloydArray[row, col] = SaveIntFromUser();
                } while (FloydArray[row, col] < 0);
            }
            
        }

    }

    return FloydArray;
}
int[,] FoydAlgorithm (int [,]InputArray)//,int iteration)
    {

    int[,] ResultArray = InputArray;
    //if (iteration<InputArray.GetLength(0))
    //{
    //    return ResultArray;
    //}
    for (int i = 0; i < InputArray.GetLength(0); i++)
    {
        for (int j = 0; j < InputArray.GetLength(1); j++)
        {
            
        }
        
    }

    return ResultArray;


    
}


int [,] FloydArray = Create_Array();
PrintArray(FloydArray);





