using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace TestUnity
{
    public class Divide
    {
        public Divide()
        {
        }

        public int DivideNumber(int number1, int number2)
        {
            int result;
            try
            {
                result = number1 / number2;
            }
            catch (DivideByZeroException)
            {
                result = 88888;
            }
            return result;


        }

        public  void Quick_Sort(int[] arr, int left, int right)
            {
                if (left < right)
                {
                    int pivot = Partition(arr, left, right);

                    if (pivot > 1)
                    {
                        Quick_Sort(arr, left, pivot - 1);
                    }
                    if (pivot + 1 < right)
                    {
                        Quick_Sort(arr, pivot + 1, right);
                    }
                }

            }

        public void Bubble(int[] arr)
        {

            for (int j = 0; j < arr.Length - 1; j++)
            {


                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }

            }
        }




        public  int Partition(int[] arr, int left, int right)
            {
                int pivot = arr[left];
                while (true)
                {

                    while (arr[left] < pivot)
                    {
                        left++;
                    }

                    while (arr[right] > pivot)
                    {
                        right--;
                    }

                    if (left < right)
                    {
                        if (arr[left] == arr[right]) return right;

                        int temp = arr[left];
                        arr[left] = arr[right];
                        arr[right] = temp;


                    }
                    else
                    {
                        return right;
                    }
                }
            }
           
            }
        }












