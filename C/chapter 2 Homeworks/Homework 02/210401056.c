#include <stdio.h>
#include <stdlib.h>

struct node
{
    int data;
    struct node *nextPtr;
};

typedef struct node Node;
typedef Node *NodePtr;

void printMenu();
void push(struct node **head, int val);
void print(struct node *head);
int isEmpty(NodePtr head);
void enqueue(NodePtr *head, NodePtr *tail, int val);
void printQueue(NodePtr curPtr);

int findLength(NodePtr curPtr);

int main()
{
    int menu = -999;
    unsigned int val;
    unsigned int *vptr;
    vptr = &val;

    printf("Enter a natural number to create Collatz Sequences\n");
    scanf("%d", &val);

    Node **collatz = malloc(sizeof(struct node *) * val);  // stack type
    Node **collatz2 = malloc(sizeof(struct node *) * val); // queue type

    unsigned int temp = *vptr;

    printMenu();

    while (menu != 4)
    {
        scanf("%d", &menu);

        if (menu == 0)
        {

            for (int i = 0; i < val; i++)
            {
                NodePtr headPtr = NULL;
                NodePtr tailPtr = NULL;
                Node *head = NULL;
                temp = val - i;
                while (temp > 1)
                {

                    if (temp % 2 == 0)
                    {
                        enqueue(&headPtr, &tailPtr, temp);
                        push(&head, temp);
                        temp = temp / 2;
                    }

                    else if (temp % 2 == 1)
                    {
                        enqueue(&headPtr, &tailPtr, temp);
                        push(&head, temp);
                        temp = 3 * temp + 1;
                    }

                    else
                    {
                        printf("Format error\n");
                    }
                }

                collatz[i] = head;
                collatz2[i] = headPtr;
            }
            printf("Sequences Created Succesfully\n");
        }

        else if (menu == 1)
        {
            for (int i = 0; i < *vptr; i++)
            {
                printf("%d. Sequence=>", i + 1);
                print(collatz[i]);
                printf("\n");
            }
        }
        else if (menu == 2)
        {
            for (int i = 0; i < *vptr; i++)
            {
                printf("%d. Sequence=>", i + 1);
                printQueue(collatz2[i]);
                printf("\n");
            }
        }
        else if (menu == 3)
        {
            for (size_t i = 0; i < *vptr; i++)
            {
                printf("%d. Sequence=>", i + 1);
                printf("%d", findLength(collatz2[i]));
                printf("\n");
            }
        }
    }

    return 0;
}

void printMenu()
{
    printf("0-Generate a new Collatz Sequence of %d \n");
    puts("1-Print the Collatz Sequences in straight order\n"
         "2-Print the Collatz Sequences in reversed order\n"
         "3-Print Length\n"
         "4-Exit\n");
}

void push(Node **head, int val)
{
    NodePtr newPtr = malloc(sizeof(Node));

    if (newPtr != NULL)
    {

        newPtr->data = val;
        newPtr->nextPtr = *head;
        *head = newPtr;
    }
    else
    {
        printf("No memory available to perform this operation.\n");
    }
}
void print(struct node *head)
{
    struct node *temp = head;

    while (temp != NULL)
    {
        printf("%d ", temp->data);
        temp = temp->nextPtr;
    }
    printf("NULL\n");
}

void enqueue(NodePtr *head, NodePtr *tail, int val)
{
    Node *newNode = malloc(sizeof(Node));
    if (newNode != NULL)
    {
        newNode->data = val;
        newNode->nextPtr = NULL;

        if (isEmpty(*head))
        {
            *head = newNode;
        }
        else
        {
            (*tail)->nextPtr = newNode;
        }
        *tail = newNode;
    }
    else
    {
        printf("memory not available");
    }
}

void printQueue(NodePtr curPtr)
{
    if (curPtr == NULL)
    {
        printf("NULL\n");
    }
    else
    {

        while (curPtr != NULL)
        {
            printf("%d ", curPtr->data);
            curPtr = curPtr->nextPtr;
        }
        puts("NULL");
    }
}

int isEmpty(NodePtr head)
{
    return head == NULL;
}

int findLength(NodePtr curPtr)
{
    int j = 0;
    while (curPtr != NULL)
    {
        curPtr = curPtr->nextPtr;
        j++;
    }

    return j;
}