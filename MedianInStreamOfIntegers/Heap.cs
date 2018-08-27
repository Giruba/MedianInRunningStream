using System;
using System.Collections.Generic;
using System.Text;

namespace MedianInStreamOfIntegers
{
    abstract class Heap
    {
        protected int[] HeapArray;

        protected int size;

        protected int capacity;

        public int Size() { return size; }

        public int Capacity() { return capacity; }

        public int GetTop() { return HeapArray[0]; }

        public int LeftChild(int index) {
            return (2 * index) + 1;
        }

        public int RightChild(int index) {
            return (2 * index) + 2;
        }

        public int Parent(int index) {
            return (index - 1) / 2;
        }

        protected abstract void SiftUp(int size);

        protected abstract void Heapify(int index);

        public int ExtractTopElement() {
            int topElement = -1;
            if (size == 0)
            {
                Console.WriteLine("Heap is Empty! Cannot remove anything!");
                return topElement;
            }
            else
            {
                topElement = HeapArray[0];
                HeapArray[0] = HeapArray[size - 1];
                size--;
                Heapify(0);
            }
            return topElement;
        }

        public void Insert(int data) {
            if (size == capacity)
            {
                Console.WriteLine("Heap is already full! Cannot insert now!");
            }
            else {
                size++;
                HeapArray[size-1] = data;
                SiftUp(size-1);
            }
        }
    }
}
