import java.util.Scanner;
import java.util.Arrays;

public class SortArrayOfStrings {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int n = scanner.nextInt();
		String[] array = new String[n];
		
		for (int i = 0; i < array.length; i++) {
			array[i] = scanner.next();
		}
		
		Arrays.sort(array);
		
		for (int i = 0; i < array.length; i++) {
			System.out.println(array[i]);
		}

	}

}
