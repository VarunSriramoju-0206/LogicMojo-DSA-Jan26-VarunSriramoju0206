

    /*
     * Complete the 'reverse' function below.
     *
     * The function is expected to return an INTEGER_SINGLY_LINKED_LIST.
     * The function accepts INTEGER_SINGLY_LINKED_LIST llist as parameter.
     */

    /*
     * For your reference:
     *
     * SinglyLinkedListNode
     * {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
     static SinglyLinkedListNode reverse(SinglyLinkedListNode llist)
     {
        SinglyLinkedListNode curr = llist;
        SinglyLinkedListNode prev = null;
        
        while(curr != null){
            
            SinglyLinkedListNode nextNode = curr.next;
            curr.next = prev;
            prev = curr;
            curr = nextNode;
            
        }
        return prev;
     }

