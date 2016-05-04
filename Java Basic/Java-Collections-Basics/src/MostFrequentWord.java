import java.awt.List;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;


public class MostFrequentWord {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String[] text = in.nextLine().toLowerCase().split("([().,!?:;'\"-]|\\s)+");
		
		Arrays.sort(text);
		
		int count = 1;
		int tempCount = 1;
		String mostFrequent = "";
		ArrayList<String> mostFrequentBuilder = new ArrayList<>();
		for (int i = 0; i < text.length - 1; i++) {
		    if (text[i].equalsIgnoreCase(text[i + 1])) {
		        tempCount++;
		        if (tempCount >= count) {
		        	if (tempCount > count) {
		        		mostFrequentBuilder.clear();
		        	}
		            count = tempCount;
		            mostFrequent = text[i];
		            mostFrequentBuilder.add(mostFrequent);
		        }
		    }
		    else {
		        tempCount = 1;
		    }
		}
		
		for (int i = 0; i < mostFrequentBuilder.size(); i++) {
        	System.out.println(mostFrequentBuilder.get(i) + " -> " + count + " times");
        }

	}

}
