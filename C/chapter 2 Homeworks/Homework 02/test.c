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
void enqueue(NodePtr *head, NodePtr *tail, int val);
int isEmpty(NodePtr head);

int main()
{
    int menu = -999;
    unsigned int val;
    unsigned int *vptr;
    vptr = &val;

    Node **collatz = malloc(sizeof(struct node *) * val);  // stack type
    Node **collatz2 = malloc(sizeof(struct node *) * val); // queue type

    printMenu();

    while (menu != 4)
    {
        scanf("%d", &menu);

        if (menu == 1)
        {
            printf("Enter a natural number to create Collatz Sequences\n");
            scanf("%d", &val);

            unsigned int temp = *vptr;

            for (int i = 0; i < val; i++)
            {
                Node *head = NULL;
                temp = val - i;
                while (temp > 1)
                {

                    if (temp % 2 == 0)
                    {

                        push(&head, temp);
                        temp = temp / 2;
                    }

                    else if (temp % 2 == 1)
                    {
                        push(&head, temp);
                        temp = 3 * temp + 1;
                    }

                    else
                    {
                        printf("Format error");
                    }
                }
                collatz[i] = head;
            }
        }

        else if (menu == 2)
        {
            for (size_t i = 0; i < *vptr; i++)
            {
                printf("%d. Sequence=>", i + 1);
                print(collatz[i]);
                printf("\n");
            }
        }
        else if (menu == 3)
        {
            printf("%d", *vptr);
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

void push(struct node **head, int val)
{
    struct node *newNode = malloc(sizeof(struct node));
    newNode->data = val;
    newNode->nextPtr = NULL;

    if (*head == NULL)
    {

        *head = newNode;
    }
    else
    {

        struct node *lastNode = *head;

        while (lastNode->nextPtr != NULL)
        {

            lastNode = lastNode->nextPtr;
        }

        lastNode->nextPtr = newNode;
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


