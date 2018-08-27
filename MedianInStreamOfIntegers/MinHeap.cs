using System;
using System.Collections.Generic;
using System.Text;

namespace MedianInStreamOfIntegers
{
    class MinHeap:Heap
    {     
        public MinHeap() { }

        public MinHeap(int capacity)
        {
            this.size = 0;
            this.capacity = capacity;
            HeapArray = new int[capacity];
        }        

        public void MinHeapify(int index) {
            int left = base.LeftChild(index);
            int smallest = 0;
            int right = base.RightChild(index);

            if (this.size > left && this.HeapArray[index] > this.HeapArray[left]) {
                smallest = left;
            }
            else if (this.size > right && this.HeapArray[smallest] > this.HeapArray[right])
            {
                smallest = right;
            }
            if (smallest != index) {
                int temp = HeapArray[smallest];
                HeapArray[smallest] = HeapArray[index];
                HeapArray[index] = temp;
                MinHeapify(smallest);
            }
        }

        protected override void Heapify(int index) {
            MinHeapify(index);
        }

        //Sifting Up
        protected override void SiftUp(int size)
        {
            if (size != 0 && HeapArray[size] > HeapArray[Parent(size)]) {
                int temp = HeapArray[Parent(size)];
                HeapArray[Parent(size)] = HeapArray[size];
                HeapArray[size] = temp;
                SiftUp(Parent(size));
            }
        }
    }
}
