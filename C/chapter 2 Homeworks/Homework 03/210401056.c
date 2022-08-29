#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <string.h>

#define IRIS_DATA_LEN 150

struct iris
{

    float sepal_length;
    float sepal_width;
    float petal_length;
    float petal_width;
    char iris_class[20];
};

struct euclid
{
    float distance;
    char class[20];
};

void readData(struct iris *data);
void printData(struct iris *data);
float calcDist(struct iris data1, struct iris data2);
void euclidistance(struct iris *data, struct iris input, struct euclid *save);
void selection_sort_data(struct euclid *data);
void pickNN(struct euclid *data, int K);

void main()
{
    struct iris data[IRIS_DATA_LEN], input;
    struct euclid euclid[IRIS_DATA_LEN];
    readData(data);

    int menu, K;

    printf("Select an option\n");

    while (menu != 3)
    {
        scanf("%d", &menu);
        if (menu == 1)
        {
            printData(data);
        }

        else if (menu == 2)
        {
            printf("Enter sepal length\n");
            scanf("%f", &input.sepal_length);

            printf("Enter sepal width\n");
            scanf("%f", &input.sepal_width);

            printf("Enter petal length\n");
            scanf("%f", &input.petal_length);

            printf("Enter petal width\n");
            scanf("%f", &input.petal_width);

            printf("Enter a K value\n");
            scanf("%d", &K);

            euclidistance(data, input, euclid);
            selection_sort_data(euclid);

            /* for (size_t i = 0; i < K; i++) //test code to see the classes of first K iris
             {
                 printf("%s\n", euclid[i].class);
             }
             */
            pickNN(euclid, K);
        }
        else if (menu == 3)
        {
            break;
        }
        else
        {
            printf("Invalid Option\n");
        }
    }
}

void readData(struct iris *data)
{
    FILE *fptr;
    if ((fptr = fopen("iris.txt", "r")) == NULL)
    {
        puts("iris txt missing.");
    }
    else
    {
        for (int i = 0; i < IRIS_DATA_LEN; i++)
        {
            fscanf(fptr, "%f%f%f%f%s", &data[i].sepal_length, &data[i].sepal_width,
                   &data[i].petal_length, &data[i].petal_width, data[i].iris_class);
        }

        fclose(fptr);
    }
}

void printData(struct iris *data)
{
    printf("%12s %12s %12s %12s %16s\n", "sepal_length", "sepal_width",
           "petal_length", "petal_width", "iris_class");
    printf("%12s %12s %12s %12s %16s\n", "----------", "----------",
           "----------", "----------", "----------");
    for (int i = 0; i < IRIS_DATA_LEN; i++)
    {
        printf("%12.2f %12.2f %12.2f %12.2f %16s\n", data[i].sepal_length, data[i].sepal_width,
               data[i].petal_length, data[i].petal_width, data[i].iris_class);
    }
}

float calcDist(struct iris data1, struct iris data2)
{
    return sqrt(
        pow(data1.sepal_length - data2.sepal_length, 2) + pow(data1.sepal_width - data2.sepal_width, 2) + pow(data1.petal_length - data2.petal_length, 2) + pow(data1.petal_width - data2.petal_width, 2));
}

void euclidistance(struct iris *data, struct iris input, struct euclid *save)
{
    for (size_t i = 0; i < IRIS_DATA_LEN; i++)
    {
        save[i].distance = calcDist(data[i], input);

        strcpy(save[i].class, data[i].iris_class);
    }
}

void selection_sort_data(struct euclid *data)
{
    int i, j, min_idx;
    for (i = 0; i < IRIS_DATA_LEN - 1; i++)
    {
        min_idx = i;

        for (j = i + 1; j < IRIS_DATA_LEN; j++)
            if (data[j].distance < data[min_idx].distance)
                min_idx = j;

        struct euclid temp = data[min_idx];
        data[min_idx] = data[i];
        data[i] = temp;
    }
}

void pickNN(struct euclid *data, int K)
{
    int s = 0, c = 0, v = 0;

    for (size_t i = 0; i < K; i++)
    {
        if (strcmp(data[i].class, "Iris-setosa") == 0)
        {
            s++;
        }
        if (strcmp(data[i].class, "Iris-versicolor") == 0)
        {
            c++;
        }
        if (strcmp(data[i].class, "Iris-virginica") == 0)
        {
            v++;
        }
    }

    /*
    printf("%d\n", s);  //test code, checks if the counting algorhytm works properly
    printf("%d\n", c);
    printf("%d\n", v);
    */
    if (s > c && s > v)
    {
        printf("Iris-setosa\n");
    }
    else if (c > s && c > v)
    {
        printf("Iris-versicolor\n");
    }
    else if (v > s && v > c)
    {
        printf("Iris-virginica\n");
    }
}
