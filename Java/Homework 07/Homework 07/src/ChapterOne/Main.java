package ChapterOne;

public class Main {
    public static void main(String args[])
    {
        LinkedList test = new LinkedList();
        LinkedList test2 = new LinkedList();
        LinkedList test3 = new LinkedList();


        test.insertFirst(1);
        test.insertLast(2);
        test.insertLast(3);
        test.insertLast(4);
        test.insertLast(5);

        test2.isEmpty(); // empty linked list

        test3.insertFirst(10);
        test3.insertFirst(10);
        test3.insertFirst(20);
        test3.insertFirst(20);
        test3.insertFirst(30);
        test3.insertFirst(30);
        test3.insertFirst(30);
        test3.insertFirst(30);



        //test.reverseList();
        //test2.reverseList();
        //test3.reverseList();

        LinkedList.removeContinuousNodes(test3.getHead(),30);









    }
}

