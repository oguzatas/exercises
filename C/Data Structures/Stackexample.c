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
int pop(StackNodePtr *topPtr);
int isEmpty(StackNodePtr topPtr);
void printStack(StackNodePtr currentPtr);
void instructions(void);

int main()
{
    StackNodePtr stackPtr = NULL;
    int value;

    return 0;
}

void instructions(void)
{
    puts("Enter choice:\n"
         "1 to push a value"
         "2 to pop a value"
         "3 to end program");
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

int pop(StackNodePtr *topPtr)
{
    StackNodePtr tempPtr = *topPtr;
    int popValue = (*topPtr)->data;
    *topPtr = (*topPtr)->nextPtr;
    free(tempPtr);
    return popValue;
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

int isEmpty(StackNodePtr topPtr)
{
    return topPtr == NULL; // returns 1 if its empty else 0
}
