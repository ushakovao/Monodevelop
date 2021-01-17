using System;
namespace Delegates
{
    public class TriDeTable
    {

        private delegate void DelegateTri(int[] array);


        private void TriUp (int[] array)
        {
            Array.Sort(array);

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }

        private void TriDown(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }



        public void Demo(int[] array)
        {
            DelegateTri tri = TriUp;
            tri += TriDown;
            tri(array);
         
        }

        public TriDeTable()
        {
        }
    }
}
