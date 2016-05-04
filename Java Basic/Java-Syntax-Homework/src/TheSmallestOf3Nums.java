import java.util.Scanner;
import java.text.DecimalFormat;

public class TheSmallestOf3Nums {

	public static void main(String[] args) {
		DecimalFormat format = new DecimalFormat();
        format.setDecimalSeparatorAlwaysShown(false);
           
            Scanner in = new Scanner(System.in);
            double a = in.nextDouble();
            double b = in.nextDouble();
            double c = in.nextDouble();
           
            if (a<b && a<c) {
                System.out.println(format.format(a));
            }
            else if (b<a && b<c) {
                System.out.println(format.format(b));
            }
            else {
                System.out.println(format.format(c));
            }

	}

}
