import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.time.temporal.ChronoUnit;
import java.util.FormatterClosedException;
import java.util.Scanner;

public class DaysBetweenTwoDates {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in); 
		String beginDate = in.nextLine();
        String endDate = in.nextLine();
		
		try {
			LocalDate firstDate = LocalDate.parse(beginDate, DateTimeFormatter.ofPattern("dd-MM-yyyy"));
			LocalDate secondDate = LocalDate.parse(endDate, DateTimeFormatter.ofPattern("d-MM-uuuu"));
            long days = ChronoUnit.DAYS.between(firstDate, secondDate);
			System.out.println(days);
        }
	    catch (FormatterClosedException e) {
        	System.out.println("Invalid date format");
        }

	}

}
