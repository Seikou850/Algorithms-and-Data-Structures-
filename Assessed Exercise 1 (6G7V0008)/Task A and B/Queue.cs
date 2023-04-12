using System;

namespace Task_A_and_B
{
    class Queue
    {
        private string[] store;
        private int head = 0;
        private readonly int maxsize = 11;
        private int tail = 0;
        private int size;

        public Queue(int size)
        {
            maxsize = size; // Number of names input on the main method 
            store = new string[maxsize]; // storing maximum 
        }

        public void Enqueue(string value)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full");
                return;
            }
            else
            {
                size++;
                store[tail++] = value; // Here we are storing the value on the tail.

                if (tail == store.Length)
                {
                    tail = 0;
                }

            } }

        // Function to remove an item from queue.
        // It changes front and size
        public string Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty");
                return "-1";
            }
            else
            {
                size--;
                 //new string call headItem
                string headItem = store[head++]; //This is storing the head item which means the first item of the list. 
                if (head == store.Length)
                {
                    head = 0;
                }
                return headItem; //ends the execution of a function, and returns control to the calling function.
            }

        }
        public int reverseK(int k)
        {
            int i = head;
            k = k + head;
            
            while (k > i)
            {
                string storeValues = store[k];
                store[k] = store[i];
                store[i] = storeValues;

                i++;
                k--;
            }

            return 0;
        }

        public void display()
        {
            string result = "";
            
            for (int i = head; i <= store.Length - 1 ; i++)
            {
                result += store[i] + ",";
            }
            
            result = result.TrimEnd(',', ' ');
            Console.Write(result);
        }
        
        public string Peek() //method returns the head of the queue. 
        {
            return store[head]; 
        }

        public int actualSize()
        {
            return size;
        }

        public bool IsEmpty() //Is going to check if the array is empty and if is empty console will output TRUE if not false
        {
            return size == 0;
        }

        public bool IsFull() //Is going to check if the array is FULL and if is FULL console will output TRUE if not false
        {
            return head == maxsize;
        }
    }
}
