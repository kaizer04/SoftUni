import java.util.Scanner;

public class DecimalToHexadecimal {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
        
        int number = in.nextInt();
        System.out.println(Integer.toHexString(number).toUpperCase());

	}

}
