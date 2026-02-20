    // Complete the mergeLists function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static SinglyLinkedListNode mergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2) {
    
        SinglyLinkedListNode a = head1;
        SinglyLinkedListNode b = head2;
        
        if(a == null){
            return head2;
        }
        if(b == null){
            return head1;
        }
        
        SinglyLinkedListNode dummy = new SinglyLinkedListNode(0);
        SinglyLinkedListNode temp = dummy;
        
        while(a != null && b != null){
            
            if(a.data <= b.data)
            {
                temp.next = new SinglyLinkedListNode(a.data);
                a = a.next;
            }
            else{
                temp.next = new SinglyLinkedListNode(b.data);
                b = b.next;
            }
            temp = temp.next;
        }
        
        if(a != null){
            temp.next = a;
        }
        
        if(b != null){
            temp.next = b;
        }
        
        return dummy.next;
        
        

    }