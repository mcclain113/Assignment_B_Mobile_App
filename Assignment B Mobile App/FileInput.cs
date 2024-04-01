using System;
using System.IO;

namespace Assignment_B_Mobile_App;

public class FileInput
{
    private StreamReader _streamReader;
    private string fileName;

    public FileInput(string fileName)
    {
        this.fileName = fileName;
        try
        {
            _streamReader = new StreamReader(fileName);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("File Open Error: " + fileName + " " + e.Message);
        }
    }

    public void FileRead()
    {
        string line;
        try
        {
            while ((line = _streamReader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("File Read Error: " + fileName + " " + e.Message);
        }
    }

    public string FileReadLine()
    {
        try
        {
            string line = _streamReader.ReadLine();
            return line;
        }
        catch (Exception e)
        {
            Console.WriteLine("File Read Error: " + fileName + " " + e.Message);
            return null;
        }
    }

    public void FileClose()
    {
        if (_streamReader != null)
        {
            try
            {
                _streamReader.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}