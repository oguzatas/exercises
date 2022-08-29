#include <stdio.h>

void printMatrix(int arr[5][5]);
void rotate(int a[5][5]);

void searchvector(int arr[5][5], int array[2]);

void main()

{
    int square_matrix[5][5] = {
        {10, 11, 12, 13, 14},
        {15, 16, 17, 18, 19},
        {20, 21, 22, 23, 24},
        {25, 26, 27, 28, 29},
        {30, 31, 32, 33, 34},
    };

    int m = 0, n, c;

    while (m != 1)
    {
        int array[5] = {-999, -999, -999, -999, -999};
        printf("\nPlease Choose an option");
        printf("\n1-Rotate the square matrix");
        printf("\n2-Search a vector in the defined square matrix");
        printf("\n3-Exit the program\n");
        scanf("%d", &c);

        if (c == 1)
        {
            //-------------------MENU---------------------
            printf("\nChoose an angle (degree) to continue");
            printf("\n1- 90");
            printf("\n2- 180");
            printf("\n3- 270\n");
            //-------------------MENU---------------------

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
                printf("Please use a proper format\n");
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
                printf("\nType 2 values.\n");
                scanf("%d%d", &array[0], &array[1]);
                searchvector(square_matrix, array);
            }
            else if (c == 3)
            {
                printf("\nType 3 values.\n");
                scanf("%d%d%d", &array[0], &array[1], &array[2]);
                searchvector(square_matrix, array);
            }
            else if (c == 4)
            {
                printf("\ntype 4 values.\n");
                scanf("%d%d%d%d", &array[0], &array[1], &array[2], &array[3]);
                searchvector(square_matrix, array);
            }
            else if (c == 5)
            {
                printf("\ntype 5 values.\n");
                scanf("%d%d%d%d%d", &array[0], &array[1], &array[2], &array[3], array[4]);
                searchvector(square_matrix, array);
            }
            else
            {
                printf("\nFormat Error\n");
            }
        }
        else if (c == 3)
        {
            m = 1;
        }
        else
        {
            printf("\nplease use a proper format\n");
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

void searchvector(int square_matrix[5][5], int array[5])
{
    int temp;
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {

            if (square_matrix[i][j] == array[0]) // 1- Finding the value1
            {

                if (square_matrix[i][j + 1] == array[1]) // 2- checking if the val2 comes after
                {
                    if (array[2] == -999)
                    {
                        printf("\nvector found\n");
                        printf("\nFirst element=>%d", array[0]);
                        temp = array[0];
                    }
                    else
                    {
                        if (square_matrix[i][j + 2] == array[2]) // 3- checking if the val3 comes after
                        {
                            if (array[3] == -999)
                            {
                                printf("\nvector found\n");
                                printf("\nFirst element=>%d\n", array[0]);
                                temp = array[0];
                            }
                            else
                            {
                                if (square_matrix[i][j + 3] == array[3]) // 4- checking the val4
                                {
                                    if (array[4] == -999)
                                    {
                                        printf("\nvector found\n");
                                        printf("\nFirst element=>%d\n", array[0]);
                                        temp = array[0];
                                    }
                                    else
                                    {
                                        if (square_matrix[i][j + 4] == array[4]) // 5- checking the val5
                                        {
                                            printf("\nvector found\n");
                                            printf("\nFirst element=>%d\n", array[0]);
                                            temp = array[0];
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
    if (temp != array[0])
    {
        printf("\nvector not found\n");
    }
}
