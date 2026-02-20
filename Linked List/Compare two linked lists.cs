    // Complete the CompareLists function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static bool CompareLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2) {

        SinglyLinkedListNode a = head1;
        SinglyLinkedListNode b = head2;
        
        while(a !=null && b != null){
            
            if(a.data != b.data){
                return false;
            }
            a = a.next;
            b = b.next;
        }
        
        if(a != null && b == null){ return false;}
        if(a == null && b != null){ return false;}
        
        return true;
        
    }