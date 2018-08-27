using System;
using System.Collections.Generic;
using System.Text;

namespace MedianInStreamOfIntegers
{
    class MaxHeap: Heap
    {
        public MaxHeap() { }

        public MaxHeap(int capacity) {
            this.size = 0;
            this.capacity = capacity;
            HeapArray = new int[capacity];
        }

        //Sifting Down during Extract Minimum
        public void MaxHeapify(int index) {
            int largest = index;
            int left = base.LeftChild(index);
            int right = base.RightChild(index);

            if (left < this.size && HeapArray[left] > HeapArray[index]) {
                largest = left;
            }
            if (right < size && HeapArray[right] > HeapArray[largest]) {
                largest = right;
            }

            if (largest != index) {
                int temp = HeapArray[largest];
                HeapArray[largest] = HeapArray[index];
                HeapArray[index] = temp;
            }
        }
        protected override void Heapify(int index)
        {
            MaxHeapify(index);
        }

        //Sifting Up - During Insertion
        protected override void SiftUp(int size)
        {
            if (size != 0 && HeapArray[size] < HeapArray[Parent(size)])
            {
                int temp = HeapArray[Parent(size)];
                HeapArray[Parent(size)] = HeapArray[size];
                HeapArray[size] = temp;
                SiftUp(Parent(size));
            }
        }
    }
}
