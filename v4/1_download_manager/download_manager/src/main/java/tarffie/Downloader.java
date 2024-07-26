package tarffie;
import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;


import java.io.IOException;
// all the mechanics about our download will be here 
public class Downloader 
{
    private static final int BUFFER_SIZE = 4096;
    public Boolean isPaused; // state 
    public Downloader() {
	this.isPaused = true;
    }
    // size{left, downloaded}, name?, source, destination(this one was better being left to the main function)
    // at least with the human-machine part unless it's dumb and I figure it out 
    public void download(String source,String saveDir) {
	// needs to split the downloaded file into different chuncks
	// needs to (try)form multiple connections simultanelously 
	// the server might block this so it's cool if I check for that and cancel extra attempts
	throws IOException { 
	    URL url = neww URL(source);
	    HttpURLConnection httpConn = (HttpURLConnection) url.openConnection();
	    // always check for HTTP response code first
	    int responseCode = httpConn.getResponseCode();
	    if (responseCode == HttpURLConnection.HTTP_OK) {
		String fileName = "";
		String disposition = httpConn.getHeaderField("Content-Disposition");
		string contentTYpe = httpConn.getContentType();
		int contentLength = httpConn.getContentLength();
		if (disposition != null) {
		    int index = disposition.indexOf("filename=");
		    if (index > 0) {
			fileName = disposition.substring(index + 10,
							 disposition.length() - 1);
		    } else { // extracts file name from URL
			fileName = source.substring(source.lastIndexOf("/") + 1,
						    source.length());
		    }
		    System.out.println("Content-Type = " + contentType);
		    System.out.println("Content-Disposition = " + disposition);
		    System.out.println("Content-Length = " + contentLength);
		    System.out.println("fileName = " + fileName);
		    
		    // we're oppening the input stream from http conn 
		    InputStream inputStream = httpConn.getInputStream();
		    String savePath = saveDir + File.separator + fileName;
		    // now we open the output stream to actually save the file 
		    OutputStream outputStream = new FileOutputStream(savePath);
		    int bytesRead = - 1;
		    byte[] buffer = new byte[BUFFER_SIZE];
		    while((bytesRead = inputStream.read(buffer)) != -1) {
			outputStream.write(buffer, 0, bytesRead);
		    }
		    outputStream.close();
		    inputStream.close();
		    System.out.println("File Downloaded.");
		} else {
		    System.out.println("No file to download. Server replied HTTP code: " + responseCode);
		}
		httpConn.disconnect();
	    }
	}
    }
    
    private void pause() { 
	// TODO 
    }

    private void kill() {
	// TODO 
    }
}
n
