using System;
using System.Collections.Generic;
using System.Text;

namespace MedianInStreamOfIntegers
{
    class MaxMinHeapHolder
    {
        public int Median = 0;
        public MaxHeap MaxHeap{get; set;}

        public MinHeap MinHeap{get; set;}

        public MaxMinHeapHolder(int capacity) {
            MaxHeap = new MaxHeap(capacity);
            MinHeap = new MinHeap(capacity);
        }

        public int GetRunningMedian(int number) {

            int difference = MinHeap.Size() - MaxHeap.Size();

            switch (difference) {
                case 0:
                    if (number < Median)
                    {
                        MinHeap.Insert(number);
                        Median = MinHeap.GetTop();
                    }
                    else {
                        MaxHeap.Insert(number);
                        Median = MaxHeap.GetTop();
                    }
                    break;

                case 1:
                    if (number < Median)
                    {
                        MaxHeap.Insert(MinHeap.ExtractTopElement());
                        MinHeap.Insert(number);
                    }
                    else {
                        MinHeap.Insert(MaxHeap.ExtractTopElement());
                        MaxHeap.Insert(number);
                    }
                    Median = (MinHeap.GetTop() + MaxHeap.GetTop()) / 2;
                    break;

                case -1:
                    if (number < Median)
                    {
                        MinHeap.Insert(MaxHeap.ExtractTopElement());
                    }
                    else {
                        MinHeap.Insert(MaxHeap.ExtractTopElement());
                        MaxHeap.Insert(number);
                    }
                    Median = (MinHeap.GetTop() + MaxHeap.GetTop()) / 2;
                    break;
            }
            return Median;
        }
    }
}
