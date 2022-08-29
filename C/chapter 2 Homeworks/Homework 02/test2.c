#include <stdio.h>
#include <stdlib.h>

struct node
{
    int data;
    struct node *nextPtr;
};

typedef struct node Node;
typedef Node *NodePtr;

int isEmpty(NodePtr head);

void enqueue(NodePtr *head, NodePtr *tail, int val);

void printQueue(NodePtr curPtr);

void main()
{
    int val;
    scanf("%d", &val);
    Node **collatz2 = malloc(sizeof(struct node *) * val); // queue type

    int temp = val;

    for (int i = 0; i < val; i++)
    {
        NodePtr headPtr = NULL;
        NodePtr tailPtr = NULL;
        temp = val - i;

        while (temp > 1)
        {
            if (temp % 2 == 0)
            {
                enqueue(&headPtr, &tailPtr, temp);
                temp = temp / 2;
            }

            else if (temp % 2 == 1)
            {
                enqueue(&headPtr, &tailPtr, temp);

                temp = 3 * temp + 1;
            }

            else
            {
                printf("Format error");
            }
        }
        collatz2[i] = headPtr;

        for (size_t i = 0; i < val; i++)
        {
            printQueue(collatz2[i]);
        }
    }
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
        printf("Queue is Empty\n");
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