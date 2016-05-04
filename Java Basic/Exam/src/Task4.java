import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;


public class Task4 {
	
	public static void printArray(String[] arr) {
		for (int i = 0; i < arr.length; i++) {
			System.out.println(arr[i]);
		}
	}
	
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		
		String[] input = in.nextLine().split(" ");
		int[] arr = new int[input.length];
		
		for (int i = 0; i < arr.length; i++) {
			arr[i] = Integer.parseInt(input[i]);
		}
		//printArray(arr);
		
		String[] strArr = new String[arr.length - 1];
		
		for (int i = 0; i < strArr.length; i++) {
			strArr[i] = arr[i] + " " + arr[i + 1];
		}
		
		//printArray(strArr);
		
		Map<String, Integer> cardsMap = new LinkedHashMap<String, Integer>();
		for (String card : strArr) {
			Integer count = cardsMap.get(card);
			if (count == null) {
				count = 0;
			}
			cardsMap.put(card, count + 1);
		}
		for (Map.Entry<String, Integer> entry : cardsMap.entrySet()) {
			double precentage = (double) entry.getValue() * 100 / strArr.length;
			System.out.printf("%s -> %.2f%%\n", entry.getKey(), precentage);
		}
		
		
	}
}
