import java.util.Scanner;
import java.util.regex.Pattern;


public class Task3 {
	
	public static void printArray(int[] arr) {
		for (int i = 0; i < arr.length; i++) {
			System.out.print(arr[i] + " ");
		}
	}
	
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		
		String input = in.nextLine();
		String input2 = input.replace('x', ' ');
		//System.out.println(input2);
		String[] stringArr = input2.split("([().,!?\\]\\[:;'\"-]|\\s)+");
		//for (int i = 0; i < stringArr.length; i++) {
			//System.out.print(stringArr[i] + " ");
		//}
		
		int[] intArr = new int[stringArr.length - 1];
		for (int i = 0; i < stringArr.length - 1; i++) {
			intArr[i] = Integer.parseInt(stringArr[i + 1]);
		}
		//System.out.println();
		//printArray(intArr);
		
		int[] arrSum = new int[intArr.length / 2];
		
		for (int i = 0, j = 0; i < intArr.length; i = i + 2, j++) {
			arrSum[j] = intArr[i] * intArr[i + 1];
		}
		//printArray(arrSum);
		//int sumSquare = 0;
		int maxSumSquare = 0;
		for (int i = 0; i < arrSum.length - 2; i++) {
			if (arrSum[i] + arrSum[i + 1] + arrSum[i + 2] > maxSumSquare) {
				maxSumSquare = arrSum[i] + arrSum[i + 1] + arrSum[i + 2];;
			}
		}
		
		System.out.println(maxSumSquare);
	}
	
	
}
