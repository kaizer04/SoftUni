import java.util.Scanner;

public class TriangleArea {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
        int aX = in.nextInt();
        int aY = in.nextInt();
       
        int bX = in.nextInt();
        int bY = in.nextInt();
       
        int cX = in.nextInt();
        int cY = in.nextInt();
       
        int result = (aX*(bY-cY)+ bX*(cY-aY)+cX*(aY-bY))/2;
       
        System.out.println(Math.abs(result));

	}

}
