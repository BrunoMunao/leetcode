using _876;

ListNode MiddleNode(ListNode head)
{
	ListNode slow = head;
	ListNode fast = head;

	while (fast != null && fast.next != null)
	{
		slow = slow.next;
		fast = fast.next.next;
	}
	return slow;
}

void PrintList(ListNode head)
{
	ListNode current = head;
	while (current != null)
	{
		Console.WriteLine(current.val);
		current = current.next;
	}
}

ListNode head = new ListNode(1);
head.next = new ListNode(2);
head.next.next = new ListNode(3);
head.next.next.next = new ListNode(4);
head.next.next.next.next = new ListNode(5);
head.next.next.next.next.next = new ListNode(6);

var list = MiddleNode(head);


PrintList(list);

