#include <stdio.h>
#include <stdlib.h>

#define IRIS_DATA_LEN 150

struct iris{
    float sepal_length;
    float sepal_width;
    float petal_length;
    float petal_width;
    char iris_class[17];
};

void read_data(struct iris * data){
    FILE *cfPtr;

    // fopen opens file; exits program if file cannot be opened
    if ((cfPtr = fopen("iris.txt", "r")) == NULL){
        puts("File could not be opened");
    }
    else{
        for(int i = 0; i < IRIS_DATA_LEN; i++) {
            fscanf(cfPtr, "%f%f%f%f%s", &data[i].sepal_length, &data[i].sepal_width,
               &data[i].petal_length, &data[i].petal_width, data[i].iris_class);
        }

        fclose(cfPtr); // fclose closes the file
    }
}

void selection_sort_data(struct iris * data) {
     int i, j, min_idx;
     for (i = 0; i < IRIS_DATA_LEN-1; i++) {
        min_idx = i;

        for (j = i+1; j < IRIS_DATA_LEN; j++)
            if (data[j].sepal_length < data[min_idx].sepal_length)
                min_idx = j;

        struct iris temp = data[min_idx];
        data[min_idx] = data[i];
        data[i] = temp;
    }
}

void print_iris_data(struct iris * data) {
    printf("%12s %12s %12s %12s %16s\n", "sepal_length", "sepal_width",
           "petal_length", "petal_width", "iris_class");
           printf("%12s %12s %12s %12s %16s\n", "----------", "----------",
           "----------", "----------", "----------");
    for(int i = 0; i < IRIS_DATA_LEN; i++) {
        printf("%12.2f %12.2f %12.2f %12.2f %16s\n", data[i].sepal_length, data[i].sepal_width,
           data[i].petal_length, data[i].petal_width, data[i].iris_class);
    }
}

void binary_search_data(struct iris *data, float sepal_length) {
    int l = 0;
    int r = IRIS_DATA_LEN - 1;
    int m;
    int found = 0;

    while (l <= r) {
        m = l + (r - l) / 2;

        if (data[m].sepal_length == sepal_length){
            found = 1;
            break;
        }

        if (data[m].sepal_length < sepal_length)
            l = m + 1;
        else
            r = m - 1;
    }

    if(found) {
        printf("\n Data found:\n");
        int i = m;

        printf("%12.2f %12.2f %12.2f %12.2f %16s\n", data[i].sepal_length, data[i].sepal_width,
           data[i].petal_length, data[i].petal_width, data[i].iris_class);

        for(i = m - 1; ; i--) {
            if(i >= 0 && data[i].sepal_length != sepal_length)
                break;
            printf("%12.2f %12.2f %12.2f %12.2f %16s\n", data[i].sepal_length, data[i].sepal_width,
                data[i].petal_length, data[i].petal_width, data[i].iris_class);
        }

        for(i = m + 1; ; i++) {
            if(i <= IRIS_DATA_LEN - 1 && data[i].sepal_length != sepal_length)
                break;
            printf("%12.2f %12.2f %12.2f %12.2f %16s\n", data[i].sepal_length, data[i].sepal_width,
                data[i].petal_length, data[i].petal_width, data[i].iris_class);
        }
    } else{
        printf("\nData could not found.");
    }
}

int main()
{
    struct iris data[IRIS_DATA_LEN];

    read_data(data);
    print_iris_data(data);

    selection_sort_data(data);
    printf("\nAfter Sort:\n");
    print_iris_data(data);

    binary_search_data(data, 6.9);

    return 0;
}
