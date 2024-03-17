using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_star_8tasbulmacasi
{
    public class MinHeap<T> where T : IComparable<T>
    {
        private List<T> heap;

        public int Count => heap.Count;

        public MinHeap()
        {
            heap = new List<T>();
        }

        public void Insert(T item)
        {
            heap.Add(item);
            HeapifyUp();
        }

        public T RemoveMin()
        {
            if (Count == 0)
                throw new InvalidOperationException("Heap is empty");

            T min = heap[0];
            int lastIndex = Count - 1;

            heap[0] = heap[lastIndex];
            heap.RemoveAt(lastIndex);

            HeapifyDown();

            return min;
        }

        private void HeapifyUp()
        {
            int currentIndex = Count - 1;

            while (currentIndex > 0)
            {
                int parentIndex = (currentIndex - 1) / 2;
                if (heap[currentIndex].CompareTo(heap[parentIndex]) >= 0)
                    break;

                Swap(currentIndex, parentIndex);
                currentIndex = parentIndex;
            }
        }

        private void HeapifyDown()
        {
            int currentIndex = 0;

            while (true)
            {
                int leftChildIndex = 2 * currentIndex + 1;
                int rightChildIndex = 2 * currentIndex + 2;

                int smallerChildIndex = currentIndex;

                if (leftChildIndex < Count && heap[leftChildIndex].CompareTo(heap[smallerChildIndex]) < 0)
                    smallerChildIndex = leftChildIndex;

                if (rightChildIndex < Count && heap[rightChildIndex].CompareTo(heap[smallerChildIndex]) < 0)
                    smallerChildIndex = rightChildIndex;

                if (currentIndex == smallerChildIndex)
                    break;

                Swap(currentIndex, smallerChildIndex);
                currentIndex = smallerChildIndex;
            }
        }

        private void Swap(int index1, int index2)
        {
            T temp = heap[index1];
            heap[index1] = heap[index2];
            heap[index2] = temp;
        }
    }
    }
