import java.util.Scanner;


public class SymmetricNumbersInRange {
	
	
	
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
        int start = in.nextInt();
        int end = in.nextInt();
        String numberToString = new String();
        
        for (int number = start; number <= end; number++) {
        	numberToString = "" + number;
    		char startChar = numberToString.charAt(0);
			char endChar = numberToString.charAt(numberToString.length() - 1);
			if (startChar == endChar) {
				System.out.print(numberToString + " ");
			}
		 
		}
	}

}
