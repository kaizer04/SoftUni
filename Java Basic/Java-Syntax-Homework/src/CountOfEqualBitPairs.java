import java.util.Scanner;

public class CountOfEqualBitPairs {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        int counter = 0;
        for (int i = 0; i < 32; i++) {
                if (((n>>1) & 1)==(n & 1)) {
                        counter++;
                }
                n>>=1;
                if(n==0) i=32;
        }
        
        System.out.println(counter);
	}

}
