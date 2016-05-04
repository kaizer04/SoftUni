import java.util.Scanner;


public class Task1 {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String input = "";
		//int hours = 0;
		//int minutes = 0;
		int sumHours = 0;
		int sumMinutes = 0;
		while (true) {
			input = in.next();
			//while (input[i].equals);
			if (input.equals("End")) {
				break;
			}
			String[] stringArr = input.split(":");
			int[] intArr = new int[stringArr.length];
			for (int i = 0; i < stringArr.length; i++) {
				intArr[i] = Integer.parseInt(stringArr[i]);
			}
			
			sumHours = sumHours + intArr[0];
			sumMinutes = sumMinutes + intArr[1];
		}
		
		if (sumMinutes > 59) {
			sumHours = sumHours + sumMinutes / 60;
			sumMinutes = sumMinutes % 60;
		}
		
		System.out.printf("%d:%02d", sumHours, sumMinutes);
	}

}
