using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.UI;

public class control : MonoBehaviour
{
	public Text lev ;
	public string conn;
    public IDbConnection dbconn;
    // Start is called before the first frame update
    void Start()
    {
        
    } 
public void press_cont()
	{
		string section ="";
		string level="";
		 string instname=PlayerPrefs.GetString("instemail");
	 string stuname=PlayerPrefs.GetString("studentname");
	 conn= "URI=file:" +Application.dataPath+"/Plugins/grad.s3db";
        dbconn=(IDbConnection) new SqliteConnection(conn);
        dbconn.Open();
		IDbCommand dbcmd=dbconn.CreateCommand();
		string sqlQuery3 = "SELECT * from "+instname+ " WHERE name = '" + stuname + "'";
		dbcmd.CommandText=sqlQuery3;
			IDataReader reader=dbcmd.ExecuteReader();
		
		
		while(reader.Read())
		{
			 section = reader.GetString(3);
			 level = reader.GetString(4);
		}
		string upd=section+":"+level;
		lev.text=upd;
		
		
	}
	
	public void press_yes()
	{
		int lastscene=0;
	 string instname=PlayerPrefs.GetString("instemail");
	 string stuname=PlayerPrefs.GetString("studentname");
	 conn= "URI=file:" +Application.dataPath+"/Plugins/grad.s3db";
        dbconn=(IDbConnection) new SqliteConnection(conn);
        dbconn.Open();
		IDbCommand dbcmd=dbconn.CreateCommand();
		string sqlQuery3 = "SELECT * from "+instname+ " WHERE name = '" + stuname + "'";
		dbcmd.CommandText=sqlQuery3;
			IDataReader reader=dbcmd.ExecuteReader();
		
		
		while(reader.Read())
		{
			lastscene = reader.GetInt32(2);
		}
		AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(lastscene);
	}
	
	
    // Update is called once per frame
    void Update()
    {
        
    }
}
