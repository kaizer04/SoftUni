import java.util.Scanner;


public class CountSubstringOccurrences {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String text = in.nextLine();
        String subStr = in.next();
        int count = 0;
        for (int i = 0; i < text.length(); i++) {
            int find = text.toLowerCase().indexOf(subStr.toLowerCase(), i);
            if (find != -1) {
                count++;
                i = find;
            }
        }
        
        System.out.println(count);
	}
}
