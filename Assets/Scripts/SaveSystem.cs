using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem
{
    private static string SAVE_FOLDER = Application.dataPath + "/Saves/";
    public static void Init()
    {
        //Test if directory exists
        if (!Directory.Exists(SAVE_FOLDER))
        {
            //Creates the directory
            Directory.CreateDirectory(SAVE_FOLDER);
        }
    }

    public static void Save(string saveString)
    {
        //int saveNum = 1;
        //while (File.Exists("save" + saveNum + ".txt"))
        //{
        //    saveNum++;
        //}
        File.WriteAllText(SAVE_FOLDER + "save.txt", saveString);

    }
    public static string Load()
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(SAVE_FOLDER);
        FileInfo[] savefiles = directoryInfo.GetFiles("*.txt");
        
        if (File.Exists(Application.dataPath + "save.txt"))
        {
            string saveString = File.ReadAllText(SAVE_FOLDER + "save.txt");
            return saveString;

        }
        else return null;

    }
}