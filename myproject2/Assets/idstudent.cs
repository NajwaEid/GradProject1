 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.UI;

public class idstudent : MonoBehaviour
{
	string idins;
	public InputField id ;
	public Button log ;
	string getid;
	public string conn;
    public IDbConnection dbconn;
	const string sname="studentname";
	
	
	
    // Start is called before the first frame update
    void Start()
    {
		idins=PlayerPrefs.GetString("instemail");
        
    }
	
	public void press()
	{
		
		//string idins="najwa";
		getid=id.text;
		
		
		conn= "URI=file:" +Application.dataPath+"/Plugins/grad.s3db";
        dbconn=(IDbConnection) new SqliteConnection(conn);
        dbconn.Open();
		IDbCommand dbcmd=dbconn.CreateCommand();
		
		int myInt;
		bool isNumerical=int.TryParse(getid, out myInt);
		
		if(isNumerical)
		{
			
			Debug.Log("get id "+getid);
			
			string sqlQuery = "SELECT name FROM "+idins+" WHERE id = '" + getid + "'";
			
			dbcmd.CommandText=sqlQuery;
		 string count = Convert.ToString(dbcmd.ExecuteScalar());
		
		 PlayerPrefs.SetString(sname,count);
		 
		 getid=count;
		 Debug.Log("from DB "+getid);
	
	    }
	
	    else
		{
		getid=getid.Trim();
		PlayerPrefs.SetString(sname,getid);
		}
		
		
		string sqlQuery2="SELECT * FROM "+ idins +" where name='"+getid+"'";
		
	
		dbcmd.CommandText=sqlQuery2;
		IDataReader reader=dbcmd.ExecuteReader();
		
		while(reader.Read())
		{

			int id2=reader.GetInt32(0);
			string pass=reader.GetString(1);

			Debug.Log("from data base:  "+id2+"\n");
			Debug.Log("from data base:  "+pass+"\n");

		Debug.Log("correct id");

			AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(9);
		


		}

		Debug.Log("incorrect id");
		
		
	}

 
}
