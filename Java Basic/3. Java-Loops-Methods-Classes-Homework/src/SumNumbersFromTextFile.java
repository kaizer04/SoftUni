import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

public class SumNumbersFromTextFile {

	public static void main(String[] args) {
		BufferedReader bufferReader = null;
        int result = 0;
        
        try {
    		String currentLine;

    		bufferReader = new BufferedReader(new FileReader("Input.txt"));

            while ((currentLine = bufferReader.readLine()) != null) {
                    result += Integer.parseInt(currentLine);
            }
            System.out.println(result);

        } 
        catch (IOException e) {
        	System.out.println("Error!");
        } 
        finally {
            try {
                if (bufferReader != null){
                	bufferReader.close();
                }
            } 
            catch (IOException ex) {
                ex.printStackTrace();
            }
        }

	}

}
