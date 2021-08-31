using System;

namespace _21._08._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] StringArr = {"One", "Two", "Three"};
            int[] IntArr = { 1, 2, 3, 4 };
            double[] DoubleArr = { 10.5, 11.5, 12.5, 13.5 };
            decimal[] DecimalArr = { 12m, 11m, 10m, 9m };
            float[] FloatArr = new float[0];
            Console.WriteLine($"было удалено: {ArrayHelper.Pop(ref StrindArr)}");
            Console.WriteLine($"обновленная длина массива: {ArrayHelper.Push(ref IntArr, -5)}");
            Console.WriteLine($"было удалено: {ArrayHelper.Shift(ref DoubleArr)}");
            Console.WriteLine($"обновленная длина массива: {ArrayHelper.UnShift(ref DecimalArr, 5m)}");
            Console.WriteLine($"было удалено: {ArrayHelper.Pop(ref FloatArr)}");

        }
        static class ArrayHelper
        {
            public static string Pop(ref string[] array)
            {
                if (array.Length == 0) return null;
                string[] NewArray = new string[array.Length - 1];
                for (int i = 0; i < array.Length - 1; i++)
                    NewArray[i] = array[i];
                string delete = array[array.Length - 1];
                array = NewArray;
                return delete;

            }
            public static int Pop(ref int[] array)
            {
                if (array.Length == 0) return 0;
                int[] NewArray = new int[array.Length - 1];
                for (int i = 0; i < array.Length - 1; i++)
                    NewArray[i] = array[i];
                int delete = array[array.Length - 1];
                array = NewArray;
                return delete;
            }
            public static double Pop(ref double[] array)
            {
                if (array.Length == 0) return 0;
                double[] NewArray = new double[array.Length - 1];
                for (int i = 0; i < array.Length - 1; i++)
                    NewArray[i] = array[i];
                double delete = array[array.Length - 1];
                array = NewArray;
                return delete;
            }
            public static decimal Pop(ref decimal[] array)
            {
                if (array.Length == 0) return 0;
                decimal[] NewArray = new decimal[array.Length - 1];
                for (int i = 0; i < array.Length - 1; i++)
                    NewArray[i] = array[i];
                decimal delete = array[array.Length - 1];
                array = NewArray;
                return delete;
            }
            public static float Pop(ref float[] array)
            {
                if (array.Length == 0) return 0;
                float[] NewArray = new float[array.Length - 1];
                for (int i = 0; i < array.Length - 1; i++)
                    NewArray[i] = array[i];
                float delete = array[array.Length - 1];
                array = NewArray;
                return delete;
            }
            public static int Push(ref string[] array, string value)
            {
                if (array.Length == 0) return 0;
                string[] NewArray = new string[array.Length + 1];
                NewArray[array.Length] = value;
                for (int i = 0; i < array.Length; i++)
                    NewArray[i] = array[i];
                array = NewArray;
                return array.Length;
            }
            public static int Push(ref int[] array, int value)
            {
                if (array.Length == 0) return 0;
                int[] NewArray = new int[array.Length + 1];
                NewArray[array.Length] = value;
                for (int i = 0; i < array.Length; i++)
                    NewArray[i] = array[i];
                array = NewArray;
                return array.Length;
            }
            public static int Push(ref double[] array, double value)
            {
                if (array.Length == 0) return 0;
                double[] NewArray = new double[array.Length + 1];
                NewArray[array.Length] = value;
                for (int i = 0; i < array.Length; i++)
                    NewArray[i] = array[i];
                array = NewArray;
                return array.Length;
            }
            public static int Push(ref decimal[] array, decimal value)
            {
                if (array.Length == 0) return 0;
                decimal[] NewArray = new decimal[array.Length + 1];
                NewArray[array.Length] = value;
                for (int i = 0; i < array.Length; i++)
                    NewArray[i] = array[i];
                array = NewArray;
                return array.Length;
            }
            public static int Push(ref float[] array, float value)
            {
                if (array.Length == 0) return 0;
                float[] NewArray = new float[array.Length + 1];
                NewArray[array.Length] = value;
                for (int i = 0; i < array.Length; i++)
                    NewArray[i] = array[i];
                array = NewArray;
                return array.Length;
            }
            public static string Shift(ref string[] array)
            {
                if (array.Length == 0) return null;
                string[] NewArray = new string[array.Length - 1];
                int j = 0; int i = 1;
                for (; i < array.Length; i++, j++)
                    NewArray[j] = array[i];
                string delete = array[0];
                array = NewArray;
                return delete;
            }
            public static int Shift(ref int[] array)
            {
                if (array.Length == 0) return 0;
                int[] NewArray = new int[array.Length - 1];
                int j = 0; int i = 1;
                for (; i < array.Length; i++, j++)
                    NewArray[j] = array[i];
                int delete = array[0];
                array = NewArray;
                return delete;
            }
            public static double Shift(ref double[] array)
            {
                if (array.Length == 0) return 0;
                double[] NewArray = new double[array.Length - 1];
                int j = 0; int i = 1;
                for (; i < array.Length; i++, j++)
                    NewArray[j] = array[i];
                double delete = array[0];
                array = NewArray;
                return delete;
            }
            public static decimal Shift(ref decimal[] array)
            {
                if (array.Length == 0) return 0;
                decimal[] NewArray = new decimal[array.Length - 1];
                int j = 0; int i = 1;
                for (; i < array.Length; i++, j++)
                    NewArray[j] = array[i];
                decimal delete = array[0];
                array = NewArray;
                return delete;
            }
            public static float Shift(ref float[] array)
            {
                if (array.Length == 0) return 0;
                float[] NewArray = new float[array.Length - 1];
                int j = 0; int i = 1;
                for (; i < array.Length; i++, j++)
                    NewArray[j] = array[i];
                float delete = array[0];
                array = NewArray;
                return delete;
            }
            public static int UnShift(ref string[] array, string value)
            {
                if (array.Length == 0) return 0;
                string[] NewArray = new string[array.Length + 1];
                NewArray[0] = value;
                for (int i = 0; i < array.Length; i++)
                    NewArray[i + 1] = array[i];
                array = NewArray;
                return array.Length;
            }
            public static int UnShift(ref int[] array, int value)
            {
                if (array.Length == 0) return 0;
                int[] NewArray = new int[array.Length + 1];
                NewArray[0] = value;
                for (int i = 0; i < array.Length; i++)
                    NewArray[i + 1] = array[i];
                array = NewArray;
                return array.Length;
            }
            public static int UnShift(ref double[] array, double value)
            {
                if (array.Length == 0) return 0;
                double[] NewArray = new double[array.Length + 1];
                NewArray[0] = value;
                for (int i = 0; i < array.Length; i++)
                    NewArray[i + 1] = array[i];
                array = NewArray;
                return array.Length;
            }
            public static int UnShift(ref decimal[] array, decimal value)
            { 
                if (array.Length == 0) return 0;
                decimal[] NewArray = new decimal[array.Length + 1];
                NewArray[0] = value;
                for (int i = 0; i < array.Length; i++)
                    NewArray[i + 1] = array[i];
                array = NewArray;
                return array.Length;
            }
            public static int UnShift(ref float[] array, float value)
            {
                if (array.Length == 0) return 0;
                float[] NewArray = new float[array.Length + 1];
                NewArray[0] = value;
                for (int i = 0; i < array.Length; i++)
                    NewArray[i + 1] = array[i];
                array = NewArray;
                return array.Length;
            }  
        }
    }
}
