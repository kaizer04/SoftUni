import java.util.Scanner;

public class CountsOfBitsOne {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int counter = 0;
       
        for (int i = 0; i < 32; i++) {
        	
                if ((n&1)==1) {
                	
                        counter++;
                }
                n = n>>1;
        }
        
        System.out.println(counter);

	}

}
