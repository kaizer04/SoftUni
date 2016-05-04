
public class FullHouse {
	
	public static void printCardNumber(int number) {
        if (number <= 10 && number > 1) {
        	System.out.print(number);
        }
        else {
            switch(number){
            	case 11: 
            		System.out.print("J");
            		break;
	            case 12: 
	            	System.out.print("Q");
	            	break;
	            case 13: 
	            	System.out.print("K");
	            	break;
	            case 1: 
	            	System.out.print("A");
	            	break;
            }
        }
	}
	
	public static void printSuit(int suitNumber) {
        char clubs = '♣';
        char diamonds = '♦';
        char hearts = '♥';
	    char spades = '♠';
	    switch(suitNumber) {
		    case 1: 
		    	System.out.print(clubs + " ");
		    	break;
		    case 2: 
		    	System.out.print(diamonds + " ");
		    	break;
		    case 3: 
		    	System.out.print(hearts + " ");
		    	break;
		    case 4: 
		    	System.out.print(spades + " ");
		    	break;
	    }
	}
	
	public static void main(String[] args) {
		int counter = 0;
		
		for(int firstCard = 1; firstCard <= 13 ; firstCard++) {
			for(int secondCard = 1; secondCard <= 13 ; secondCard++){
				if(secondCard == firstCard) { 
					continue;
				}
             	for(int firstSuit = 1 ; firstSuit <= 4 ; firstSuit++) {
             		for(int secondSuit = firstSuit + 1; secondSuit <= 4; secondSuit++) {
             			for(int thirdSuit = secondSuit + 1; thirdSuit <= 4 ; thirdSuit++) {
             				for(int forthSuit = 1; forthSuit <= 4; forthSuit++) {
             					for(int fifthSuit = forthSuit + 1; fifthSuit <= 4; fifthSuit++) {
                                	printCardNumber(firstCard);
                                   	printSuit(firstSuit);
                                    printCardNumber(firstCard);
                                    printSuit(secondSuit);
                                    printCardNumber(firstCard);
                                    printSuit(thirdSuit);
                                    printCardNumber(secondCard);
                                    printSuit(forthSuit);
                                    printCardNumber(secondCard);
                                    printSuit(fifthSuit);
                                    System.out.println();
                                    counter++;
             					}
             				}
             			}
             		}
             	}
			}
		}
		
		System.out.println(counter + " full houses");
	}
}


