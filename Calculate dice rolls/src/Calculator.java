import java.util.ArrayList;
import java.util.Scanner;

public class Calculator {
	
	String scannerInput = new String();
	int int_quantity = 0; //# of dice(s)
	int int_quality = 0; //# of sides to a dice
	
	public Calculator()
	{
		
		
		while(!scannerInput.equals("exit"))
		{
			setup();
			if(!scannerInput.equals("exit"))
			{
				System.out.println("Laveste verdi: " +minValue(int_quantity));
				System.out.println("Største verdi: " +maxValue(int_quantity,int_quality));
				System.out.println("Mest sannsynlige verdi: " +mostLikelyValue(int_quantity,int_quality));
			}
			
		}
	}
	
	public int mostLikelyValue(int quantity,int quality)
	{
		ArrayList dices = new ArrayList();
		
		for(int i=0;i<quantity;i++)
		{
			dices[i] = 1;
		}
		
		for(int x=1; x<=quantity; x++)
		{
			for(int n=1; n<=quality; n++)
			{
				//System.out.println(n);
				
			}
		}
		
		
		
		int sum = 0;
		
		return sum;
	}
	
	public int maxValue(int quantity,int quality) {int sum = quantity*quality; return sum;}
	
	public int minValue(int quantity) {int sum = 1*quantity; /* lowest quality is always 1 */ return sum;}
	
	//asks for input and initializes int_quantity & int_quality
	public void setup()
	{
		Scanner scanner = new Scanner(System.in);
		String[] divided_input;
		
		System.out.println("Oppgi terninger (D&D format, xdn) 'exit' avslutter:");
		scannerInput = scanner.nextLine();
		//scanner.close(); No, don't close. Stops System.in input stream
		
		//if(scannerInput != "exit")
		try
		{
			divided_input = scannerInput.split("d");
			
			int_quantity = Integer.parseInt(divided_input[0]);
			int_quality = Integer.parseInt(divided_input[1]);
		}
		catch(NumberFormatException e){System.out.println("Feil format");}
		finally{}// Always runs. Cleans/closes potentially opened resources
	}
	
	
}
