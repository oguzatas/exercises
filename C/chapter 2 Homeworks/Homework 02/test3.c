#include <stdio.h>
#include <stdlib.h>

struct stackNode
{
    int data;
    struct stackNode *nextPtr;
};

typedef struct stackNode StackNode;
typedef StackNode *StackNodePtr; // a pointer to point StackNode type variables

void push(StackNodePtr *topPtr, int info);
void printStack(StackNodePtr currentPtr);

void main()
{
    StackNodePtr stackPtr = NULL;
    push(&stackPtr, 1);
    push(&stackPtr, 2);
    push(&stackPtr, 3);
    push(&stackPtr, 4);
    printStack(stackPtr);
}

void push(StackNodePtr *topPtr, int info)
{
    StackNodePtr newPtr = malloc(sizeof(StackNode));

    if (newPtr != NULL)
    {
        newPtr->data = info;
        newPtr->nextPtr = *topPtr;
        *topPtr = newPtr;
    }
    else
    {
        printf("No memory available to perform this operation.\n");
    }
}

void printStack(StackNodePtr currentPtr)
{
    if (currentPtr == NULL)
    {
        puts("The stack is empty.\n");
    }
    else
    {
        puts("The stack is:");

        while (currentPtr != NULL)
        {
            printf("%d--> ", currentPtr->data);
            currentPtr = currentPtr->nextPtr;
        }

        puts("NULL\n");
    }
}