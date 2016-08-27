using System;

public class Class1
{
	public Class1()
	{
        var mysteryMessage = new byte[] { 89, 0, 97, 0, 121, 0, 33, 0 };
        var messageContents = UnicodeEncoding.Unicode.GetString(mysteryMessage);
    }
}
