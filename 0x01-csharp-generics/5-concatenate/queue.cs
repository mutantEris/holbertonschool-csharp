using System;

/// <summary> queue </summary>
public class Queue<T>
{
	/// <summary> queueueue </summary>
	public Type CheckType()
    {
		return typeof(T);
	}
	/// <summary> node </summary>
	public class Node{
		/// <summary> value </summary>
		public T value;
		/// <summary> next </summary>
		public Node next = null;
		/// <summary> node </summary>
		public Node(T value){
			this.value = value;
		}
	}
	Node head = null;
	Node tail = null;
	int count = 0;
	/// <summary> adds </summary>
	public void Enqueue(T value){
		Node g = new Node(value);
		if (this.head == null)
			this.head = g;
		else
			this.tail.next = g;
		this.tail = g;
		count++;
	}
	/// <summary> counting </summary>
	public int Count() => this.count;
    /// <summary> dequeueue </summary>
    public T Dequeue()
    {
        if (count != 0)
        {
            T value = head.value;
            head = head.next;
            count--;
            return value;
        }
        Console.WriteLine("Queue is empty");
        return default(T);
    }
    /// <summary> primt </summary>
    public T Peek()
    {
        if (count != 0)
            return head.value;
        Console.WriteLine("Queue is empty");
        return default(T);
    }
    /// <summary> cats </summary>
    public void Print()
    {
        if (count != 0)
        {
            Node instance = head;
            while (instance != null)
            {
                Console.WriteLine(instance.value);
                instance = instance.next;
            }
        }
        else
            Console.WriteLine("Queue is empty");
    }
    /// <summary> cats </summary>
    public string Concatenate()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }
        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate is for a queue of Strings or Chars only.");
            return null;
        }
        string x = "";
        Node instance = head;
        for (int g = 0; g < count; g++)
        {
            x += instance.value.ToString();
            if (typeof(T) == typeof(string) && instance.next != null)
                x += " ";
            instance = instance.next;
        }
        return x;
    }
}