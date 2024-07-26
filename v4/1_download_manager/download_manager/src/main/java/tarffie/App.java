package tarffie;
import java.io.IOException;
import java.util.Scanner;
/**
 * Download Manager  
 *
 */
public class App 
{
    public static void main(String[] args)
    {
	Boolean shouldClose = false;
	Downloader downloader = new Downloader();
	System.out.print("\033[H\033[2J");
        System.out.flush(); 
	String saveDir = System.getProperty("user.home")+"/Downloads";
	// human-computer interface 
	while(!shouldClose) {
	    Scanner keyboard = new Scanner(System.in);
	    System.out.print("Please feed us the desired file url you wish to download\n");
	    String source = keyboard.nextLine();
	    System.out.print(source+"\n");
	    downloader.download(source, saveDir);
	    shouldClose = true;
	}
    }
}
