package partTwo;

import java.util.Arrays;

public class searchAlgorythms {

    public static void main(String[] args)
    {
        int[] arr1 = {10, 32, 34, 5, 1};
        int[] arr2 = {5, 4, 3, 2, 1};


        System.out.println("********************");
        System.out.println(Arrays.toString(arr1));
        bubbleSort(arr1);
        System.out.println(Arrays.toString(arr1));
        System.out.println("********************");
        System.out.println(binarySearch(arr1,32));
        System.out.println("********************");
        selectionSort(arr2);
        System.out.println(Arrays.toString(arr2));
        System.out.println("********************");
        System.out.println(linearSearch(arr2,3));

    }

    public static int linearSearch(int[] arr, int target) {
        for (int i = 0; i < arr.length; i++) {
            if (arr[i] == target) {
                return i;
            }
        }
        return -1;
    }


    public static void selectionSort(int[] arr) {
        for (int i = 0; i < arr.length - 1; i++) {
            int minIndex = i;
            for (int j = i + 1; j < arr.length; j++) {
                if (arr[j] < arr[minIndex]) {
                    minIndex = j;
                }
            }
            if (minIndex != i) {
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }
    }


    public static void bubbleSort(int[] arr) {
        boolean swapped;
        int n = arr.length;

        do {
            swapped = false;
            for (int i = 0; i < n - 1; i++) {
                if (arr[i] > arr[i + 1]) {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                    swapped = true;
                }
            }
            n--;
        } while (swapped);
    }



    public static int binarySearch(int[] arr, int target) {
        int left = 0;
        int right = arr.length - 1;

        while (left <= right) {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target) {
                // found target, now search for first occurrence
                while (mid > 0 && arr[mid - 1] == target) {
                    mid--;
                }
                return mid;
            } else if (arr[mid] < target) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }

        // target not found
        return -1;
    }

}
