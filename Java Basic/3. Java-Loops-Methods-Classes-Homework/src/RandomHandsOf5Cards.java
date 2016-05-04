import java.util.Random;
import java.util.Scanner;


public class RandomHandsOf5Cards {

	public static String printCardNumber(int number) {
        String result = "";
		if (number <= 10 && number > 1) {
        	result = result + number;
        }
        else {
            switch(number){
            	case 11: 
            		result = "J";
            		break;
	            case 12: 
	            	result = "Q";
	            	break;
	            case 13: 
	            	result = "K";
	            	break;
	            case 1: 
	            	result = "A";
	            	break;
            }
        }
		return result;
	}
	
	public static char printSuit(int suitNumber) {
        char clubs = '♣';
        char diamonds = '♦';
        char hearts = '♥';
	    char spades = '♠';
	    char result = 0;
	    switch(suitNumber) {
		    case 1: 
		    	result = clubs;
		    	break;
		    case 2: 
		    	result = diamonds;
		    	break;
		    case 3: 
		    	result = hearts;
		    	break;
		    case 4: 
		    	result = spades;
		    	break;
	    }
		return result;
	}
	
	
	
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int n = in.nextInt();

		Random random = new Random();
        
        int randomNum = 0;
        int randomSuite = 0;
        for (int j = 0; j < n; j++) {  
            for (int i = 0; i < 5; i++) {
                randomNum = random.nextInt((13 - 1) + 1) + 1;
                System.out.print(printCardNumber(randomNum));
                randomSuite = random.nextInt((4 - 1) + 1) + 1;
                System.out.print(printSuit(randomSuite) + " ");         
            }
            System.out.println();
        }
        
	}
	
}
