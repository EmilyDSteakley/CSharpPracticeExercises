using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_D_DesignLinkedList
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 707. Design Linked List

        // Design your implementation of the linked list. 
        // You can choose to use the singly linked list or the doubly linked list.
        // A node in a singly linked list should have two attributes: val and next.
        // val is the value of the current node, and next is a pointer/reference to the next node.
        // If you want to use the doubly linked list, you will need one more attribute prev to indicate the previous node in the linked list.
        // Assume all nodes in the linked list are 0-indexed.

        // Implement these functions in your linked list class:
        //  - get(index) : Get the value of the index-th node in the linked list.If the index is invalid, return -1.
        //  - addAtHead(val) : Add a node of value val before the first element of the linked list.After the insertion, the new node will be the first node of the linked list.
        //  - addAtTail(val) : Append a node of value val to the last element of the linked list.
        //  - addAtIndex(index, val) : Add a node of value val before the index-th node in the linked list.
        //                             If index equals to the length of linked list, the node will be appended to the end of linked list.
        //                             If index is greater than the length, the node will not be inserted.
        //  - deleteAtIndex(index) : Delete the index-th node in the linked list, if the index is valid.

        // Example:
        // Input: 
        // ["MyLinkedList","addAtHead","addAtTail","addAtIndex","get","deleteAtIndex","get"]
        // [[],[1],[3],[1,2],[1],[1],[1]]
        // Output:  
        // [null,null,null,null,2,null,3]
        // Explanation:
        // MyLinkedList linkedList = new MyLinkedList(); // Initialize empty LinkedList
        // linkedList.addAtHead(1);
        // linkedList.addAtTail(3);
        // linkedList.addAtIndex(1, 2);  // linked list becomes 1->2->3
        // linkedList.get(1);            // returns 2
        // linkedList.deleteAtIndex(1);  // now the linked list is 1->3
        // linkedList.get(1);            // returns 3

        // Constraints:
        // 0 <= index,val <= 1000
        // Please do not use the built-in LinkedList library.
        // At most 2000 calls will be made to get, addAtHead, addAtTail, addAtIndex and deleteAtIndex.

    }

    // ---------------------------------------- My Solution ----------------------------------------
    public class MyLinkedList
    {
        class Node
        {
            internal int Val { get; set; }
            internal Node Next { get; set; }

            internal Node(int val, Node next = null)
            {
                Val = val;
                Next = next;
            }
        }

        private Node head;
        private Node tail;
        private int count;

        // Initialize your data structure here.
        public MyLinkedList()
        {
            count = -1;
        }

        // Get the value of the index-th node in the linked list. If the index is invalid, return -1.
        public int Get(int index)
        {
            if (index > count)
                return -1;

            Node pointer = head;
            for (int i = 0; i < index; i++)
                pointer = pointer.Next;
            return pointer.Val;
        }

        // Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list.
        public void AddAtHead(int val)
        {
            Node node = new Node(val);

            if (count < 0)
                head = tail = node;
            else
            {
                node.Next = head;
                head = node;
            }
            count++;
        }

        // Append a node of value val to the last element of the linked list.
        public void AddAtTail(int val)
        {
            Node node = new Node(val);

            if (count < 0)
                head = tail = node;
            else
            {
                tail.Next = node;
                tail = node;
            }
            count++;
        }

        // Add a node of value val before the index-th node in the linked list. 
        // If index equals to the length of linked list, the node will be appended to the end of linked list. 
        // If index is greater than the length, the node will not be inserted.
        public void AddAtIndex(int index, int val)
        {
            if (index > count + 1)
                return;
            else if (index == 0)
                AddAtHead(val);
            else if (index == count + 1)
                AddAtTail(val);
            else
            {
                Node pointer = head;
                for (int i = 1; i < index; i++)
                    pointer = pointer.Next;
                pointer.Next = new Node(val, pointer.Next);
                count++;
            }
        }

        // Delete the index-th node in the linked list, if the index is valid.
        public void DeleteAtIndex(int index)
        {
            if (index < 0 || index > count)
                return;
            else if (index == count && count == 0)
            {
                head = tail = null;
                count = -1;
                return;
            }
            else if (index == 0)
            {
                head = head.Next;
                count--;
                return;
            }
            else
            {
                Node pointer = head;
                int pos = 0;
                for (int i = 1; i < index; i++)
                {
                    pointer = pointer.Next;
                    pos = i;
                }

                if (pos == count - 1)
                {
                    pointer.Next = null;
                    tail = pointer;
                }
                else
                    pointer.Next = pointer.Next.Next;
                count--;
            }
        }

        public void PrintLinkedList()
        {
            Node pointer = head;
            for (int i = 0; i <= count; i++)
            {
                Console.WriteLine($"Node {pointer.Val}");
                pointer = pointer.Next;
            }
        }
    }
    // 148 ms
    // Solved March 30, 2020



    // ---------------------------------------- 153 ms Solution on LeetCode ----------------------------------------
    public class ListNode153
    {
        public int value;
        public ListNode153 next;

        public ListNode153(int val)
        {
            value = val;
        }
    }

    public class MyLinkedList153
    {

        ListNode153 head;
        int size;

        /** Initialize your data structure here. */
        public MyLinkedList153()
        {
            size = 0;
            head = new ListNode153(0);
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (index < 0 || index >= size) return -1;

            ListNode153 curr = head;
            for (int i = 0; i <= index; i++)
            {
                curr = curr.next;
            }

            return curr.value;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            AddAtIndex(0, val);
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            AddAtIndex(size, val);
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {

            //Cannot add beyond the index
            if (index > size) return;

            //Node can be added at the head if negative
            if (index < 0) index = 0;

            size++;

            //Find the predecessor of the node to be added
            ListNode153 prev = head;
            for (int i = 0; i < index; i++)
            {
                prev = prev.next;
            }

            //New node
            ListNode153 nodeToAdd = new ListNode153(val);

            //insert the node
            nodeToAdd.next = prev.next;
            prev.next = nodeToAdd;
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index < 0 || index >= size) return;

            //reduce the count
            size--;

            //Find the predecessor for the node to be deleted
            ListNode153 prev = head;
            for (int i = 0; i < index; i++) prev = prev.next;

            // delete the node
            prev.next = prev.next.next;
        }
    }

} // CSharpPracticeExercises namespace
