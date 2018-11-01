using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;

public class Manager : MonoBehaviour
{
    public GameObject prefab;


    const string filePath = "/Resource/File/";
    string connectionPath;
    List<Personajes> personajes = new List<Personajes>();

    void Start()
    {
        string connectionPath = "URI=file:" + Application.dataPath + filePath + "Orcos.sqlite";
        IDbConnection connection = new SqliteConnection(connectionPath);
        connection.Open();

        IDbCommand command = connection.CreateCommand();
        string liteQuery = "SELECT * FROM Personajes";
        command.CommandText = liteQuery;
        IDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            reader.GetString(0);
            Debug.Log(reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3) + " " + reader.GetString(4) + " " + reader.GetString(5));
            personajes.Add(new Personajes(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5)));
        }
        command.Dispose();
        connection.Close();

    }

    // Update is called once per frame
    void Update () {
		
	}
}
