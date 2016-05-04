import java.util.Scanner;


public class CountSpecifiedWord {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		
		String[] arr = in.nextLine().split("([().,!?:;'\"-]|\\s)+");
		String specifiedWord = in.next();
		int countSpecifiedWord = 0;
		
		for (int i = 0; i < arr.length; i++) {
			if (specifiedWord.equalsIgnoreCase(arr[i])) {
				countSpecifiedWord++;
			}
		}
		
		System.out.println(countSpecifiedWord);
		
		

	}

}
