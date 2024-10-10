namespace NEW_DSA_PRACTICE;
class Node
{
    public int element;
    public Node next;

    public Node(int element, Node next)
    {
        this.element = element;
        this.next = next;
    }
}
class LinkedList
{
    Node head = null;
    Node tail = null;
    public int size = 0;
    public bool isEmpty()
    {
        return size == 0;
    }

    public int length()
    {
        return size;
    }
    public void AddLast(int ele)
    {
        Node newest = new Node(ele, null);

        if (isEmpty())
        {
            head = newest;
        }
        else
        {
            tail.next = newest;
        }
        tail = newest;
        size = size + 1;
    }

    public void DisplayElement()
    {
        Node p = head;
        while (p != null)
        {
            Console.Write(p.element + " ");
            p = p.next;
        }
    }

    public void AddFirst(int ele)
    {
        Node newestt = new Node(ele, null);
        if (isEmpty())
        {
            head = newestt;
            tail = newestt;
        }
        else
        {
            newestt.next = head;
            head = newestt;
        }
        size = size + 1;
    }

    public void AddAny(int ele, int position)
    {
        if (position < 0 || position >= size)
        {
            Console.WriteLine("Invalid size--");
            return;
        }
        Node newest1 = new Node(ele, null);
        int i = 1;
        Node p = head;
        while (i < position - 1)
        {
            p = p.next;
            i++;

        }
        newest1.next = p.next;
        p.next = newest1;
        size++;

    }
    public void DeleteFirstEle()
    {
        if (isEmpty())
        {
            Console.WriteLine("List is empty");
        }
        head = head.next;
        size = size - 1;
        if (isEmpty())
        {
            tail = null;
        }
    }

    public void DeleteLastEle()
    {
        if (isEmpty())
        {
            Console.WriteLine("list is empty");
            return;
        }
        if (size == 1)
        {
            head = null;
            tail = null;
        }
        int i = 1;
        Node p = head;
        while (i < size - 1)
        {
            p = p.next;
            i++;
        }
        tail = p;
        p = p.next;
        tail.next = null;
        int e = p.element;
        Console.WriteLine("element was delted " + e);
        size--;

    }

    public void DeleteAny(int pos)
    {
        if (isEmpty())
        {
            Console.WriteLine("List was empty");
            return;
        }
        int i = 1;
        Node p = head;
        while (i < pos - 1)
        {
            p = p.next;
            i++;
        }
        Node prev = p;
        p = p.next;
        prev.next = p.next;

        // we can also do like this insted of, p.next = p.next.next 

        size--;

    }

    public int Search(int key)
    {
        Node p = head;
        int index = 0;
        while (p != null)
        {
            if (p.element == key)
            {
                return index;
            }
            p = p.next;
            index++;
        }
        return -1;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int num1 = 1;
        Object obj = num1;
        Console.WriteLine(num1.GetType());
        Console.WriteLine(obj.GetType());
        LinkedList l = new LinkedList();
        l.AddLast(1);
        l.AddLast(2);
        l.AddLast(3);
        l.AddLast(4);
        l.DisplayElement();
        // Console.WriteLine();
        // l.AddFirst(-89);
        // l.DisplayElement();
        // Console.WriteLine();
        // l.DeleteFirstEle();
        // l.DisplayElement();
        // Console.WriteLine();

        // l.AddAny(100, 2);
        // l.DisplayElement();
        // Console.WriteLine();

        // Console.WriteLine("size " + l.length());
        // l.DeleteLastEle();
        // l.DisplayElement();
        // Console.WriteLine("size " + l.length());
        // l.DeleteAny(2);
        // Console.WriteLine();
        // l.DisplayElement();
        // var res =l.Search(898);
        // Console.WriteLine(res);



    }
}
