using System;

public class DoublyLinkedList<T>
{
    private Node<T> head;
    private Node<T> tail;

    public void AddToEnd(T value)
    {
        Node<T> newNode = new Node<T>(value);
        if (head == null)
        {
            head = tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            newNode.Previous = tail;
            tail = newNode;
        }
    }


    public void Remove(T data)
    {
        Node<T> current = head;
        while (current != null)
        {
            if (current.Data.Equals(data))
            {
                if (current.Previous != null)
                    current.Previous.Next = current.Next;
                else
                    head = current.Next;

                if (current.Next != null)
                    current.Next.Previous = current.Previous;
                else
                    tail = current.Previous;
                break;
            }
            current = current.Next;
        }
    }

    public Node<T> Find(T data)
    {
        Node<T> current = head;
        while (current != null)
        {
            if (current.Data.Equals(data)) return current;
            current = current.Next;
        }
        return null;
    }

    public void PrintList()
    {
        Node<T> current = head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }

    // Завдання 1: Вставити 66 після кожного від’ємного числа
    public void Insert66AfterNegatives()
    {
        Node<T> current = head;
        while (current != null)
        {
            if (current.Data is int val && val < 0)
            {
                Node<T> newNode = new Node<T>((T)Convert.ChangeType(66, typeof(T)));
                newNode.Next = current.Next;
                newNode.Previous = current;
                if (current.Next != null)
                    current.Next.Previous = newNode;
                else
                    tail = newNode;

                current.Next = newNode;
                current = newNode.Next;
            }
            else
            {
                current = current.Next;
            }
        }
    }

    // Завдання 2: Вставити перший від’ємний перед кожним числом == 20
    public void InsertFirstNegativeBefore20()
    {
        Node<T> firstNegative = null;
        Node<T> current = head;

        while (current != null && firstNegative == null)
        {
            if (current.Data is double val && val < 0)
                firstNegative = new Node<T>(current.Data);
            current = current.Next;
        }

        if (firstNegative == null) return;

        current = head;
        while (current != null)
        {
            if (current.Data is double val && val == 20)
            {
                Node<T> newNode = new Node<T>(firstNegative.Data);
                newNode.Next = current;
                newNode.Previous = current.Previous;
                if (current.Previous != null)
                    current.Previous.Next = newNode;
                else
                    head = newNode;

                current.Previous = newNode;
                current = current.Next;
            }
            else
            {
                current = current.Next;
            }
        }
    }
}
