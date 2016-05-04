import java.util.Scanner;


public class ExtractEmails { //Знам, че кодаът е ужасно именован, но почти работи, както е по условие.
//ТРЯБВА ДА СЕ ВКАРА СТРИНГЪТ  chars  при trim и ще заработи по-добре
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);

        String s = in.nextLine();
        String buildS = " " + s + " ";
        //String[] chars = { " ", ",", ".", "!", "?", "-" };
        String buildSub;
        for (int i = 0; i < buildS.length(); i++) {
            int indexAt = buildS.indexOf("@", i);
            if (indexAt != -1) {
                int leftSpace = buildS.lastIndexOf(" ", indexAt);
                //Console.WriteLine(leftSpace);
                int rightSpace = buildS.indexOf(" ", indexAt);
                buildSub = buildS.substring(leftSpace, rightSpace).trim();
                if (leftSpace < indexAt - 1 && indexAt + 3 < rightSpace 
                		&& buildSub.lastIndexOf(".", buildSub.length() - 3) != -1) {
                    System.out.println(buildSub);
                }
                i = rightSpace;
            }    
            
        }
	}
}
