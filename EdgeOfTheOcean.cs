int adjacentElementsProduct(int[] inputArray) {
    int result = 0;
    for(int i = 0; i < inputArray.Length - 1; i++)
    {
        if(inputArray[i] * inputArray[i+1] > result || i == 0)
            result = inputArray[i] * inputArray[i+1];       
    }
    return result;
}

int shapeArea(int n) {
  return (n*n)+((n-1)*(n-1));
}

int makeArrayConsecutive2(int[] statues) {
    List<int> statueList = new List<int>(statues);
    statueList.Sort();
    statueList.Reverse();
    int sizesNeeded = 0;
    for(int i = 0; i < statueList.Count()-1; i++)
    {
        int diff = statueList[i] - statueList[i+1];
        if(diff != 1)
        {
            sizesNeeded += diff - 1;
        }
    }
    return sizesNeeded;
}

bool almostIncreasingSequence(int[] sequence) {
    
    if(sequence.Length <= 2)
        return true;
        
    int falseCount = 0;
    bool run = true;
    int index = 0;
    List<int> sequenceList = new List<int>(sequence);
    while(run)
    {
        if(sequenceList[index] >= sequenceList[index+1])
        {
            falseCount++;
            sequenceList.RemoveAt(index);
        }
        else if(index+2 < sequenceList.Count() && sequenceList[index] >= sequenceList[index+2])
        {
            falseCount++;
            sequenceList.RemoveAt(index+2);
        }
        else index++;
        if(falseCount > 1 || index >= sequenceList.Count()-1)
        {
            run = false;
            break;
        }
    }
    if(falseCount > 1)
    {
        return false;
    }
    else return true;

}

int matrixElementsSum(int[][] matrix) {
    int total = 0;
    bool[] excludedColumn = new bool[matrix[0].Length];
    for(int y = 0; y < matrix.Length; y++)
    {
        for(int x = 0; x < matrix[y].Length; x++)
        {
            if(!excludedColumn[x] && matrix[y][x] > 0)
            {
                total += matrix[y][x];
            }
            else
            {
                excludedColumn[x] = true;
            }
        
        }
    }
        return total;
}
