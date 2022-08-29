#include <stdlib.h>
#include <stdio.h>

/*Doubly Linked lists contains one more self referencial variable that
points previous node*/
struct node
{
    int data;
    struct node *next;
    struct node *prev;
};

void main()
{
}

struct node *addToEmpty(struct node *head, int data)
{
    struct node *temp = malloc(sizeof(struct node));
    temp->prev = NULL;
    temp->data = NULL;
    temp->next = NULL;
    head = temp;
    return head;
}

struct node *addToBeg(struct node *head, int data)
{
    struct node *temp = malloc(sizeof(struct node));
    temp->prev = NULL;
    temp->data = data;
    temp->next = NULL;
    temp->next = head;
    head->prev = temp;
    head = temp;
    return head;
}
// Traversal Solution
struct node *addToEnd(struct node *head, int data)
{
    struct node *tp;
    struct node *temp = malloc(sizeof(struct node));
    temp->prev = NULL;
    temp->data = data;
    temp->next = NULL;
    tp = head;
    while (tp->next != NULL)
    {
        tp = tp->next;
    }
    tp->next = temp;
    temp->prev = tp;
    return head;
}

struct node *addCustomLoc(struct node *head, int position, int data)
{
    struct node *newP = NULL;
    struct node *temp = head;
    struct node *temp2 = NULL;
    newP = addToEmpty(newP, data);
    int pos = position;
    while (pos > 2)
    {
        temp = temp->next;
        pos--;
    }
    temp2 = temp->next;
    temp->next = newP;
    temp2->prev = newP;
    newP->next = temp2;
    newP->prev = temp;
    return head;
}