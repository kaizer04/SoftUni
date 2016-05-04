import java.util.Scanner;


public class LongestIncreasingSequence {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		
		String[] input = in.nextLine().split(" ");
		int[] arr = new int[input.length];
		
		for (int i = 0; i < arr.length; i++) {
			arr[i] = Integer.parseInt(input[i]);
		}
		
		int countElement = 1;
		int longest = 0;
		String longestSequence = "" + arr[0] + " ";
		String tempSequence = "" + arr[0] + " ";
		System.out.print(arr[0] + " ");
		for (int i = 1; i < arr.length; i++) {
		
			if (arr[i - 1] >= (arr[i])) {
				System.out.println();
				//countElement++;
				if (countElement > longest) {
					//
					longest = countElement;
					longestSequence = tempSequence;
					
				}
				countElement = 0;
				tempSequence = "";
			}
			System.out.print(arr[i] + " ");
			tempSequence = tempSequence + arr[i] + " ";
			countElement++;
		}
		System.out.println();
		System.out.println("Longest: " + (longestSequence.length() >= tempSequence.length() ? 
							longestSequence : tempSequence)
							);
	}

}
