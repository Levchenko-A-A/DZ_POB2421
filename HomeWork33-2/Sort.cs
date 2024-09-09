using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork33_2
{
    public class Sort
    {
        public void BubbleSort(int[] arr) //сортировка пузырьком
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
        public void BubbleSortReverse(int[] arr) //обратная сортировка пузырьком
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        public void SelectionSort(int[] arr) //сотрировка выбором
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
        public void SelectionSortReverse(int[] arr) //обратная сотрировка выбором
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[minIndex])
                        minIndex = j;
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }
        public void InsertionSort(int[] arr) //сортировка вставками
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
        public void InsertionSortReverse(int[] arr) //обратная сортировка вставками
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] < key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
        public void Merge(int[] arr, int left, int middle, int right) //сортировка слиянием
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;
            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];
            for (int i = 0; i < n1; i++) leftArr[i] = arr[left + i];
            for (int j = 0; j < n2; j++) rightArr[j] = arr[middle + 1 + j];
            int k = left;
            int p = 0, q = 0;
            while (p < n1 && q < n2)
            {
                if (leftArr[p] <= rightArr[q])
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
        public void MergeSort(int[] arr, int left, int right) //сортировка слиянием
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(arr, left, middle);
                MergeSort(arr, middle + 1, right);
                Merge(arr, left, middle, right);
            }
        }
        private void MergeRevers(int[] arr, int left, int middle, int right) //сортировка слиянием
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;
            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];
            for (int i = 0; i < n1; i++) leftArr[i] = arr[left + i];
            for (int j = 0; j < n2; j++) rightArr[j] = arr[middle + 1 + j];
            int k = left;
            int p = 0, q = 0;
            while (p < n1 && q < n2)
            {
                if (leftArr[p] >= rightArr[q])
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
        public void MergeSortRevers(int[] arr, int left, int right) //сортировка слиянием
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSortRevers(arr, left, middle);
                MergeSortRevers(arr, middle + 1, right);
                MergeRevers(arr, left, middle, right);
            }
        }
        public int Partition(int[] arr, int low, int high) //быстрая сортировка
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

        public void QuickSort(int[] arr, int low, int high) //быстрая сортировка
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);
                QuickSort(arr, low, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, high);
            }

        }
        public int PartitionRevers(int[] arr, int low, int high) //быстрая сортировка
        {
            int pivot = arr[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j] > pivot)
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

        public void QuickSortReverse(int[] arr, int low, int high) //быстрая сортировка
        {
            if (low < high)
            {
                int pivotIndex = PartitionRevers(arr, low, high);
                QuickSortReverse(arr, low, pivotIndex - 1);
                QuickSortReverse(arr, pivotIndex + 1, high);
            }

        }
        public int[] EvenOddNumber(int[] arr)
        {
            return arr.Where(e => e % 2 == 0 ).Concat(arr.Where(e => e % 2 != 0)).ToArray();
        }
        public void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " "); 
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
