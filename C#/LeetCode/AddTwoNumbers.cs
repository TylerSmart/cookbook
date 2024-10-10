namespace LeetCode.AddTwoNumbers
{
    public static class Solution
    {
        public static ListNode Solve(ListNode l1, ListNode l2)
        {
            int carry = 0;

            ListNode root = new();
            ListNode current = root;

            ListNode? currentL1 = l1;
            ListNode? currentL2 = l2;

            do
            {
                int sum = (currentL1?.val ?? 0) + (currentL2?.val ?? 0) + carry;

                // if larger than a single digit, move excess to carry
                int leftover = sum % 10;
                carry = (sum - leftover) / 10;

                current.val = leftover;

                currentL1 = currentL1?.next;
                currentL2 = currentL2?.next;

                if (currentL1 != null || currentL2 != null || carry != 0)
                {
                    current.next = new();
                    current = current.next;
                }

            } while (currentL1 != null || currentL2 != null || carry != 0);

            return root;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public static ListNode FromArray(int[] array)
        {
            if (array.Length < 1) return new ListNode();

            ListNode root = new ListNode(array[0]);
            ListNode current = root;
            for (int i = 1; i < array.Length; i++)
            {
                current.next = new ListNode(array[i]);
                current = current.next;
            }

            return root;
        }

        public int[] ToArray()
        {
            List<int> list = new List<int>();

            ListNode current = this;
            do
            {
                list.Add(current.val);
                current = current.next;
            } while (current != null);

            return list.ToArray();
        }
    }
}
