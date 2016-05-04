import java.util.Arrays;
import java.util.Scanner;


public class Task2 {

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

		//fillArray(arr, n);
		for (int i = 0; i < arr.length; i++) {
			arr[i] = in.nextInt();
		}
		//Arrays.sort(arr);

		//printArray(arr);
		boolean isOutput = false;
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr.length; j++) {
				for (int k = 0; k < arr.length; k++) {
					if (arr[i] <= arr[j] 
							&& arr[i] * arr[i] + arr[j] * arr[j] == arr[k] * arr[k]) {
						System.out.println(arr[i] + "*" + arr[i] + " + " + arr[j] + "*" + arr[j]
											+ " = " + arr[k] + "*" + arr[k]);
						isOutput = true;
					}
				}
			}
		}
		
		if (!isOutput) {
			System.out.println("No");
		}

	}


}
