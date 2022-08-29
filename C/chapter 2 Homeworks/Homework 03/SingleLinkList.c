#include <stdlib.h>
#include <stdio.h>

struct node
{
    int data;
    struct node *link;
};
void main()
{
    struct node *head = malloc(sizeof(struct node));
    head->data = 28;
    head->link = NULL;

    struct node *ptr = head;
    ptr = addend2(ptr, 90);
    ptr = addend2(ptr, 80);
    ptr = addend2(ptr, 70);

    /* adding to beginning */

    // here head is basicly passing by value
    head = addbegin(head, 25);

    // here head is basicly passing by reference
    addbegin2(&head, 38);

    head = dellast(head);
}

/*--------------------------------------- ADDEND FUNCTIONS---------------------------- */

/*If we use addend everytime it will increase runtime because it contains a traversing algorythm
      instead of it we declare a pointer that points last node so we dont need to find last member of
      linked list everytime*/

void addend(struct node *head, int data) // inserting a node to end
{
    struct node *ptr, *temp;
    ptr = head;
    temp = (struct node *)malloc(sizeof(struct node));

    temp->data = data;
    temp->link = NULL;

    while (ptr->link != NULL)
    {
        ptr = ptr->link;
    }
    ptr->link = temp;
    /* This function contains a traversing algorythm which increases the time complexity
       It can be written optimal like addend2 function. */
}

/* Since addend2 function doesn't contain any traversing algorythm it will be working faster*/
struct node *addend2(struct node *ptr, int data)
{
    struct node *temp = malloc(sizeof(struct node));
    temp->data = data;
    temp->link = NULL;

    ptr->link = temp;
    return temp;
}

/*--------------------------------------- ADDBEGIN FUNCTIONS---------------------------- */
struct node *addbegin(struct node *head, int data) // a function that adds a new node to beginning of the list
{
    struct node *temp;

    temp = (struct node *)malloc(sizeof(struct node));

    temp->data = data;
    temp->link = head;

    head = temp;
    return head;
}
// addbegin is working with pass by value whilst 2 working with pass by reference
void addbegin2(struct node **head, int data)
{
    struct node *temp = malloc(sizeof(struct node));

    temp->data = data;
    temp->link = NULL;

    temp->link = *head;
    *head = temp;
}

/*--------------------------------------- ADDCUSTOM FUNCTION---------------------------- */

void addcustom(struct node *head, int data, int pos)
{
    struct node *ptr = head;
    struct node *ptr2 = malloc(sizeof(struct node));
    ptr2->data = data;
    ptr2->link = NULL;

    pos--; // you can skip this if you write while(pos != 2)
    while (pos != 1)
    {
        ptr = ptr->link;
        pos--;
    }
    ptr2->link = ptr->link;
    ptr->link = ptr2;
}

/*--------------------------------------- DELETEFUNCTIONS---------------------------- */

struct node *delfirst(struct node *head)
{
    if (head == NULL)
    {
        printf("List is already empty");
    }
    else
    {
        struct node *temp = head;
        head = head->link;
        free(temp);
        temp = NULL;
    }
    return head;
}

/*dellast uses 2 pointer whilst dellast2 using only one*/
struct node *dellast(struct node *head)
{

    if (head == NULL)
    {
        printf("List is already empty;");
    }
    else if (head->link == NULL)
    {
        free(head);
        head = NULL;
    }
    else
    {
        struct node *ptr, *ptr2;

        while (ptr->link != NULL)
        {
            ptr2 = ptr;
            ptr = ptr->link;
        }
        ptr2->link = NULL;
        free(ptr);
        ptr = NULL;
    }
    return head;
}
struct node *dellast2(struct node *head)
{
    if (head == NULL)
    {
        printf("List is already empty;");
    }
    else if (head->link == NULL)
    {
        free(head);
        head = NULL;
    }
    else
    {
        struct node *temp = head;
        while (temp->link->link != NULL)
        {
            temp = temp->link;
        }
        free(temp->link);
        temp->link = NULL;
    }
    return head;
}

void delcustom(struct node **head, int pos)
{
    struct node *cur = *head;
    struct node *pre = *head;

    if (head == NULL)
    {
        printf("List is already empty;");
    }
    else if (pos == 1)
    {
        *head = cur->link;
        free(cur);
        cur = NULL;
    }
    else
    {
        while (pos != 1)
        {
            pre = cur;
            cur = cur->link;
            pos--;
        }
        pre->link = cur->link;
        free(cur);
        cur = NULL;
    }
}

void delentire(struct node **head) //function to delete entire linked list
{
    struct node *temp= NULL;
    temp = head;

    while(temp->link==NULL)
    {
        temp=temp->link;
        free(head);
        head=temp;
    }

}

struct node *reverseall(struct node *head) // function to reverse entire linked list (hard)
{
    struct node *temp = NULL;
    struct node *temp2 = NULL;

    while(head==NULL)
    {
        temp = head->link;
        head->link = temp2;
        temp2 = head;
        head = temp;
    }
    head = temp2;
    return head;
}
