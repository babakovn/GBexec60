int[,,] GetRandomArray()
{
    Random rnd = new Random();
    int[,,] cube = new int[2,2,2];
    for(int i = 0; i < 2; i++)
        for(int j = 0; j < 2; j++)
            for(int k = 0; k < 2; k++)
                cube[i,j,k] = rnd.Next(10,99);
    return cube;
}

void PrintCube(int[,,] cube)
{
    for(int i = 0; i < 2; i++)
    {   for(int j = 0; j < 2; j++)
        {
            for(int k = 0; k < 2; k++)
                Console.Write($"{cube[i,j,k]} ({i},{j},{k}) ");
            Console.WriteLine();
        }
    }
}

bool CheckRepeat(int[,,] cube)
{
    int check = 0;
    int count = 0;
    for(int i = 0; i < 2; i++)
        for(int j = 0; j < 2; j++)
            for(int k = 0; k < 2; k++)
            {
                check = cube[i,j,k];
                for(int i1 = 0; i1 < 2; i1++)
                    for(int j1 = 0; j1 < 2; j1++)
                        for(int k1 = 0; k1 < 2; k1++)
                            if(cube[i1,j1,k1] == check) count = count + 1;            
            }
    if(count > 8) return true;
    else return false;    
}

////

int[,,] cube = GetRandomArray();


while(CheckRepeat(cube)) cube = GetRandomArray(); 

PrintCube(cube);


