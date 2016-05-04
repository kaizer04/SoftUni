import java.util.Scanner;


public class LargestSequenceOfEqualStrings {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		
		String[] arr = in.nextLine().split(" ");
		
		/*for (int i = 0; i < arr.length; i++) {
			arr[i] = in.next();
		}*/
		String element = arr[0];
		int tempCount = 1;
		int count = 1;
		String tempElement = arr[0];
		
		for (int i = 0; i < arr.length - 1; i++) {
			if (arr[i].equals(arr[i + 1])) {
				tempCount++;
				if (tempCount > count) {
		            count = tempCount;
		            element = tempElement;
		        }
			}
			else {
		        tempCount = 1;
		        tempElement = arr[i + 1];
		    }
		}
		
		for (int i = 0; i < count; i++) {
			System.out.print(element + " ");
		}
	}

}
