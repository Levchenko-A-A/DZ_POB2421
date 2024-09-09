void BubbleSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
}

void SelectionSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minIndex = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minIndex])
                minIndex = j;
        }
        int temp = arr[minIndex];
        arr[minIndex] = arr[i];
        arr[i] = temp;
    }
}

void InsertionSort(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        int key = arr[i];
        int j = i - 1;
        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j--;
        }
        arr[j + 1] = key;
    }
}

void Merge(int[] arr, int left, int middle, int right)
{
    int n1 = middle - left + 1;
    int n2 = right - middle;
    int[] leftArr = new int[n1];
    int[] rightArr = new int[n2];
    for (int i = 0; i < n1; i++)
    {
        leftArr[i] = arr[left + 1];
    }
    for (int j = 0; j < n2; j++)
    {
        leftArr[j] = arr[middle + 1 + j];
    }
    int k = left;
    int p = 0, q = 0;
    while (p < n1 && q < n2)
    {
        if (leftArr[p] == rightArr[q])
        {
            arr[k] = leftArr[p];
            p++;
        }
        else
        {
            arr[k] = rightArr[q];
            q++;
        }
        k++;
    }
    while (p < n1)
    {
        arr[k] = leftArr[p];
        p++;
        k++;
    }
    while (q < n2)
    {
        arr[k] = rightArr[q];
        q++;
        k++;
    }
}

void MergeSort(int[] arr, int left, int right)
{
    if (left < right)
    {
        int middle = (left + right) / 2;
        MergeSort(arr, left, middle);
        MergeSort(arr, middle + 1, right);
        Merge(arr, left, middle, right);
    }
}

int Partition(int[] arr, int low, int high)
{
    int pivot = arr[high];
    int i = low - 1;
    for (int j = low; j < high; j++)
    {
        if (arr[j] < pivot)
        {
            i++;
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
    int temp2 = arr[i + 1];
    arr[i + 1] = arr[high];
    arr[high] = temp2;
    return i + 1;
}

void QuickSort(int[] arr, int low, int high)
{
    if (low < high)
    {
        int pivotIndex = Partition(arr, low, high);
        QuickSort(arr, low, pivotIndex - 1);
        QuickSort(arr, pivotIndex + 1, high);
    }

}


int[] mas = new int[100000];
Random rand = new Random();
for (int i = 0; i < mas.Length; i++) mas[i] = rand.Next(1, 100);
//BubbleSort(mas);
//SelectionSort(mas);
//InsertionSort(mas);
//MergeSort(mas, 0, mas.Length-1);
QuickSort(mas, 0, mas.Length - 1);
for (int i = 0; i < mas.Length; i++) Console.Write(mas[i] + " ");
