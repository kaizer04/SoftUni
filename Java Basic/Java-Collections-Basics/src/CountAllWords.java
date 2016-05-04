import java.util.Scanner;


public class CountAllWords {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		
		String[] arr = in.nextLine().split("([().,!?:;'\"-]|\\s)+");
		
		System.out.println(arr.length);
	}

}
