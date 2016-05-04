import java.util.Scanner;


public class AngleUnitConverter {

	public static void convertDegToRad(String degree) {
		double degreeDouble = Double.parseDouble(degree);
		System.out.format("%.6f rad", Math.toRadians(degreeDouble));
		System.out.println();
	}
	
	public static void convertRadToDeg(String rad) {
		double radDouble = Double.parseDouble(rad);
		System.out.format("%.6f deg", (Math.toDegrees(radDouble)));
		System.out.println();
	}
	
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		
		int n = in.nextInt();
		
		String[] arr = new String[2 * n];
		
		for (int i = 0; i < arr.length; i++) {
			arr[i] = in.next();
		}
		
		/*for (int i = 0; i < arr.length; i++) {
			System.out.println(arr[i]);
		}*/
		
		for (int i = 0; i < arr.length; i = i + 2) {
			if (arr[i + 1].equalsIgnoreCase("deg")) {
				convertDegToRad(arr[i]);
			}
			else {
				convertRadToDeg(arr[i]);
			}
		}

	}

}
