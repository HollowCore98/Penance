using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class SaveManager 
{
    //ruta hacia la carpeta donde voy a guardar los archivos de guardado
    private static readonly string saveFolder = Application.dataPath + "/Saves/";
    private const string saveExtension = "txt";

    public static GameManager GameManager
    {
        get => default;
        set
        {
        }
    }

    public static void Init()
    {
        //lo primero comprubeo si el directorio donde voy a guardar mis datos existe o no
        if (!Directory.Exists(saveFolder))
            Directory.CreateDirectory(saveFolder);//creo la ruta para guardas mis archivos
    }

    public static void Save(string saveString)
    {
        //Esto lo hago para saber el número de archivo que voy a guardar
        int saveNumber = 1;
        while (File.Exists(saveFolder + "save" + saveNumber + "." + saveExtension))
            saveNumber++;
        //
        //Guardamos los datos
        File.WriteAllText(saveFolder + "save" + saveNumber + "." + saveExtension, saveString);
    }

    public static string Load()
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(saveFolder);

        //cogemos los archivos del directorio y accedemos al último
        FileInfo[] saveFiles = directoryInfo.GetFiles("*." + saveExtension);
        FileInfo mostRecentFile = null;
        foreach(FileInfo fileinfo in saveFiles)
        {
            if (mostRecentFile == null)
                mostRecentFile = fileinfo;
            else
            {
                if (fileinfo.LastWriteTime > mostRecentFile.LastWriteTime)
                    mostRecentFile = fileinfo;
            }
        }
        if (mostRecentFile != null)
        {
            //cargar datos
            string saveString = File.ReadAllText(mostRecentFile.FullName);
            return saveString;
        }
        else return null;//no hay datos para cargar;

    }
   

}
