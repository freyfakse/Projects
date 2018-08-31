import java.awt.Color;
import java.awt.FlowLayout;
import javax.swing.JFrame;

public class Game extends JFrame
{
	int height = 700;
	int width = 1000;
	
	public Game()
	{
		FlowLayout F = new FlowLayout();
		JFrame frame = new JFrame();
		frame.setLayout(F);
		frame.setSize(width, height);
		frame.setVisible(true);
		frame.setDefaultCloseOperation(EXIT_ON_CLOSE);
		
		//System.out.println("test2");
		Player p1 = new Player();
		Player p2 = new Player();
		Ball ball = new Ball();
	}
	
	public void Gameloop()
	{
		
	}
	
	

}
