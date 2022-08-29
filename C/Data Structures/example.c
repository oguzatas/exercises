#include <stdio.h>

void printMatrix(int arr[5][5]);
void rotate(int a[5][5]);

void main()

{
    int m = 0, c, n, temp, array[5];
    ;
    ;
    int square_matrix[5][5] = {
        {10, 11, 12, 13, 14},
        {15, 16, 17, 18, 19},
        {20, 21, 22, 23, 24},
        {25, 26, 27, 28, 29},
        {30, 31, 32, 33, 34},
    };

    while (m != 1)
    {
        printf("\nPlease Choose an option");
        printf("\n1-Rotate the square matrix");
        printf("\n2-Search a vector in the defined square matrix");
        printf("\n3-Exit the program");
        scanf("%d", &c);

        if (c == 1)
        {
            printf("\nChoose an angle (degree) to continue");
            printf("\n1- 90");
            printf("\n2- 180");
            printf("\n3- 270\n");
            scanf("%d", &c);

            if (c == 1)
            {
                printf("\nbefore rotation\n");
                printMatrix(square_matrix);
                rotate(square_matrix);
                printf("\nAfter rotation\n");
                printMatrix(square_matrix);
            }
            else if (c == 2)
            {
                printf("\nbefore rotation\n");
                printMatrix(square_matrix);
                rotate(square_matrix);
                rotate(square_matrix);
                printf("\nAfter rotation\n");
                printMatrix(square_matrix);
            }
            else if (c == 3)
            {
                printf("\nbefore rotation\n");
                printMatrix(square_matrix);
                rotate(square_matrix);
                rotate(square_matrix);
                rotate(square_matrix);
                printf("\nAfter rotation\n");
                printMatrix(square_matrix);
            }
            else
            {
                printf("Please use a proper format");
            }
        }
        else if (c == 2)
        {
            // DISPLAYING THE ARRAY
            printMatrix(square_matrix);
            //--------------------

            //-----MENU-----------
            printf("\nSelect vector size");
            printf("\n2");
            printf("\n3");
            printf("\n4");
            printf("\n5");
            //--------------------
            scanf("%d", &c);
            if (c == 2)
            {
                printf("Type 2 values.");
                scanf("%d%d", &array[0], &array[1]);

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {

                        if (square_matrix[i][j] == array[0]) // 1- Finding the value1
                        {
                            if (square_matrix[i][j + 1] == array[1]) // 2- checking if the val2 comes after
                            {
                                printf("\nvector found\n");
                                printf("\nFirst element=>%d", array[0]);
                                temp = array[0];
                            }
                        }
                    }
                }
                if (temp != array[0])
                {
                    printf("vector not found");
                }
            }
            else if (c == 3)
            {
                printf("Type 3 values.");
                scanf("%d%d", &array[0], &array[1], &array[2]);

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {

                        if (square_matrix[i][j] == array[0]) // 1- Finding the value1
                        {
                            if (square_matrix[i][j + 1] == array[1]) // 2- checking if the val2 comes after
                            {
                                if (square_matrix[i][j + 2] == array[2]) // 3- checking if the val3 comes after
                                {
                                    if (square_matrix[i][j + 3] == array[3]) // 4-checking val4
                                        printf("\nvector found\n");
                                    printf("\nFirst element=>%d", array[0]);
                                    temp = array[0];
                                }
                            }
                        }
                    }
                }
                if (temp != array[0])
                {
                    printf("vector not found");
                }
            }
            else if (c == 4)
            {
                printf("Type 4 values.");
                printf("Type 3 values.");
                scanf("%d%d", &array[0], &array[1], &array[2], &array[3]);

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {

                        if (square_matrix[i][j] == array[0]) // 1- Finding the value1
                        {
                            if (square_matrix[i][j + 1] == array[1]) // 2- checking if the val2 comes after
                            {
                                if (square_matrix[i][j + 2] == array[2]) // 3- checking if the val3 comes after
                                {
                                    printf("\nvector found\n");
                                    printf("\nFirst element=>%d", array[0]);
                                    temp = array[0];
                                }
                            }
                        }
                    }
                }
                if (temp != array[0])
                {
                    printf("vector not found");
                }
            }
            else
            {
                printf("Format Error");
            }
        }
        else if (c == 3)
        {
            m = 1;
        }
        else
        {
            printf("please use a proper format");
        }
    }
}

void rotate(int a[5][5])
{

    // It will traverse the each cycle
    for (int i = 0; i < 5 / 2; i++)
    {
        for (int j = i; j < 4 - i; j++)
        {

            // It will swap elements of each cycle in clock-wise direction
            int temp = a[i][j];
            a[i][j] = a[4 - j][i];
            a[4 - j][i] = a[4 - i][4 - j];
            a[4 - i][4 - j] = a[j][4 - i];
            a[j][4 - i] = temp;
        }
    }
}
void printMatrix(int arr[5][5])
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
            printf("%d\t", arr[i][j]);
        printf("\n\n");
    }
}
