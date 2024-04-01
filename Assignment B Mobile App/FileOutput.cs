using System;
using System.IO;
using System.Net.Configuration;

namespace Assignment_B_Mobile_App;

public class FileOutput
{
    private StreamWriter _streamWriter;
    private string fileName;

    public FileOutput(string fileName)
    {
        this.fileName = fileName;
        try
        {
            _streamWriter = new StreamWriter(fileName);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("File Open Error: " + fileName + " " + e.Message);
        }
    }

    public void FileWrite(string line)
    {
        try
        {
            Console.WriteLine(line);
        }
        catch (Exception e)
        {
            Console.WriteLine("File Write Error: " + fileName + " " + e.Message);
            throw;
        }
    }

    public void FileClose()
    {
        if (_streamWriter != null)
        {
            try
            {
                _streamWriter.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }
    }
}