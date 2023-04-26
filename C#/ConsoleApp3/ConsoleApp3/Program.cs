using System;
namespace HeapSort
{
    public class Question4
    {
        static void heapSort(int[] arr, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                heapify(arr, i, 0);
            }
        }
        static void heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && arr[left] > arr[largest])
                largest = left;
            if (right < n && arr[right] > arr[largest])
                largest = right;
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                heapify(arr, n, largest);
            }
        }
        public static void Main()
        {
            int[] arr = { 50, 33, 78, -23, 90 };
            int n = 5, i;
            Console.WriteLine("Heap Sort");
            Console.Write("Initial array(hst) is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            heapSort(arr, 5);
            Console.Write(" Sorted Array(hst) is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");

            }
        }

    }
}
