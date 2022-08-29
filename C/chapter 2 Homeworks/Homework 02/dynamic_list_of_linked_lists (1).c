#include <stdio.h>
#include <stdlib.h>

struct node
{
    int data;
    struct node *next;
};

void addLast(struct node **head, int val)
{
    // create a new node
    struct node *newNode = malloc(sizeof(struct node));
    newNode->data = val;
    newNode->next = NULL;

    // if head is NULL, it is an empty list
    if (*head == NULL)
        *head = newNode;
    // Otherwise, find the last node and add the newNode
    else
    {
        struct node *lastNode = *head;

        // last node's next address will be NULL.
        while (lastNode->next != NULL)
        {
            lastNode = lastNode->next;
        }

        // add the newNode at the end of the linked list
        lastNode->next = newNode;
    }
}

void printList(struct node *head)
{
    struct node *temp = head;

    // iterate the entire linked list and print the data
    while (temp != NULL)
    {
        printf("%d->", temp->data);
        temp = temp->next;
    }
    printf("NULL\n");
}

int main()
{
    printf("\nExample of list of linked lists with fixed size memory: ");

    struct node *head = NULL;
    addLast(&head, 10);
    addLast(&head, 20);
    addLast(&head, 30);

    struct node *head2 = NULL;
    addLast(&head2, 40);
    addLast(&head2, 20);
    addLast(&head2, 70);

    struct node *arr[2];
    arr[0] = head;
    arr[1] = head2;

    printList(arr[0]);
    printList(arr[1]);

    printf("\nExample of list of linked lists with dynamic memory: ");
    int x;
    printf("\nEnter x (number of linked lists to be produced): ");
    scanf("%d", &x);

    // constructs x linked lists with random length and random numbers, and store them in another list (arr_dynamic)
    struct node **arr_dynamic = malloc(sizeof(struct node *) * x);
    for (int i = 0; i < x; i++)
    {
        struct node *head = NULL;
        for (int j = 0; j < rand() % 5; j++)
        {                                // random linked list size
            addLast(&head, rand() % 10); // put random values inside the linked list
        }
        arr_dynamic[i] = head;
    }

    for (int i = 0; i < x; i++)
    {
        printf("arr_dynamic[%d]: ", i);
        printList(arr_dynamic[i]);
    }

    return 0;
}
