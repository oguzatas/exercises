#include <stdio.h>
#include <string.h>

struct person
{
    char name[30];
    int age;
    char city[20];
    float salary;
} p1;

void main() {
    strcpy(p1.name, "John");
}