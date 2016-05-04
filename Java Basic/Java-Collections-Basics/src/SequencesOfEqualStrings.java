import java.util.Scanner;


public class SequencesOfEqualStrings {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		
		String[] arr = in.nextLine().split(" ");
		
		/*for (int i = 0; i < arr.length; i++) {
			arr[i] = in.next();
		}*/
		
		System.out.print(arr[0] + " ");
		
		for (int i = 1; i < arr.length; i++) {
			if (!arr[i - 1].equals(arr[i])) {
				System.out.println();
			}
			System.out.print(arr[i] + " ");
		}
		
	}

}
