import java.util.Scanner;


public class Pairs {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);

		
		//String inString = in.nextLine();
        String[] inStringNow = in.nextLine().split(" ");
        
        

        int[] array = new int[inStringNow.length];

        for (int i = 0; i < inStringNow.length; i++)
		{
            array[i] = Integer.parseInt(inStringNow[i]);
		}
        boolean flag = false;

        int maxDiff = 0;

        int value = 0;

        for (int i = 0; i < array.length; i+=2)
        {
            value = array[0] + array[1];
            if (array[i] + array[i + 1] == value)
            {
                flag = true;
                
            }
            else 
            {
                flag = false;
            }

        }
        
        if (flag)
        {
            System.out.println("Yes, value=" + value);
        }
        else
        {
            for (int i = 0; i < array.length - 3; i+=2)
            {
                int tempValue1 = array[i] + array[i + 1];
                int tempValue2 = array[i + 2] + array[i + 3];
                int tempMaxDiff = Math.abs(tempValue1 - tempValue2);
                if (tempMaxDiff >= maxDiff)
                {
                    maxDiff = tempMaxDiff;
                }
            }
            System.out.println("No, maxdiff="+ maxDiff); 
        }

	}

}
