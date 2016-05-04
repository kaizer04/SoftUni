import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;


public class ExtractAllUniqueWords {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String[] text = in.nextLine().toLowerCase().split("([().,!?:;'\"-]|\\s)+");
		Set<String> words = new TreeSet<>();
		for (String word : text) {
			words.add(word);
		}
		
		for (String word : words) {
			System.out.print(word + " ");
		}

	}

}
