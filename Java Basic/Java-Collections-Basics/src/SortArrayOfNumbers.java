import java.util.Arrays;
import java.util.Scanner;


public class SortArrayOfNumbers {

	public static void fillArray(int[] arr, int n) {
		Scanner in = new Scanner(System.in);
		for (int i = 0; i < arr.length; i++) {
			arr[i] = in.nextInt();
		}
		
		//return arr;
	}
	
	public static void printArray(int[] arr) {
		for (int i = 0; i < arr.length; i++) {
			System.out.print(arr[i] + " ");
		}
	}
	
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int n = in.nextInt();
		
		int[] arr = new int[n];

		fillArray(arr, n);
		
		Arrays.sort(arr);

		printArray(arr);
		

	}

}
