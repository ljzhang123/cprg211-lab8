using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLL
{
	public class LinkedList
	{
		public Node Head { get; private set; }
		public int Count { get; private set; }

		public LinkedList()
		{
			Head = null;
			Count = 0;
		}

		public void AddFirst(string value)
		{
			Node newNode = new Node(value);
			newNode.Next = Head;
			Head = newNode;
			Count++;
		}

		public void AddLast(string value)
		{
			Node newNode = new Node(value);

			// Make new node if list is empty
			if (Head == null)
			{
				Head = newNode;
			}
			else
			{
				Node current = Head;
				while (current.Next != null)
				{
					current = current.Next;
				}
				current.Next = newNode;
			}
			Count++;
		}

		public void RemoveFirst()
		{
			if (Head == null)
			{
				return; // List is empty, nothing to remove
			}
			Head = Head.Next;
			Count--;
		}

		public void RemoveLast()
		{
			if (Head == null)
			{
				return;
			}
			if (Head.Next == null)
			{
				Head = null;
			}
			else
			{
				Node current = Head;
				// Traverse until second last node
				while (current.Next.Next != null)
				{
					current = current.Next;
				}
				current.Next = null;
			}
			Count--;
		}

		public string GetValue(int index)
		{
			if (index < 0 || index >= Count)
			{
				throw new ArgumentOutOfRangeException(nameof(index), "out of range");
			}

			Node current = Head;
			int currentIndex = 0;
			while (current != null)
			{
				if (currentIndex == index)
				{
					return current.Value;
				}
				current = current.Next;
				currentIndex++;
			}

			throw new Exception("index not found");
		}
	}
}
