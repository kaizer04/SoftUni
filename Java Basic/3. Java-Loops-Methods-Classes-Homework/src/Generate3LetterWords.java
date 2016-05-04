import java.lang.reflect.Array;
import java.util.Scanner;


public class Generate3LetterWords {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String letters = in.next();
		//System.out.print(letters);
		
		char[] arr = new char[letters.length()];
		for (int i = 0; i < letters.length(); i++) {
			char letter = letters.charAt(i);
			arr[i] = letter;
		}
		
		//System.out.print(arr[1]);
		
	
		for (int j = 0; j < arr.length; j++) {
	
			for (int k = 0; k < arr.length; k++) {
	
				for (int l = 0; l < arr.length; l++) {
					System.out.print("" + arr[j] + arr[k] + arr[l] + " ");
				}
			}
		}
	
	}

}
