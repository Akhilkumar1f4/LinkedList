public class UseCase3LinkedList : LinkedList<int>
{
    public void CreateLinkedList()
    {
        AddFirst(56);
        AddLast(30);
        AddLast(70);
        Display();  // Output: 56 30 70
    }
}