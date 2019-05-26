 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.UI;

public class login : MonoBehaviour

{
    // Start is called before the first frame update
	
	public InputField em ;
    public InputField pa ;
    public Button log ;
	public string conn;
	public string e;
    public IDbConnection dbconn;
	const string k="instemail";
    void Start()
    {
		
    }
	
	public void press()
	{
		e=em.text;
		PlayerPrefs.SetString(k,e);
		String p=pa.text;
		e=e.Trim();
		
		conn= "URI=file:" +Application.dataPath+"/Plugins/grad.s3db";
        dbconn=(IDbConnection) new SqliteConnection(conn);
        dbconn.Open();
		
		
		IDbCommand dbcmd=dbconn.CreateCommand();

		string sqlQuery="SELECT * FROM login where email='"+e+"'";
		Debug.Log(sqlQuery);

		dbcmd.CommandText=sqlQuery;
		IDataReader reader=dbcmd.ExecuteReader();


while(reader.Read())
{

string Email=reader.GetString(0);
string pass=reader.GetString(1);

Debug.Log(Email+"\n");
Debug.Log(pass+"\n");

string cov2=pass.Trim();


	if(p.Equals(cov2))
	{
		Debug.Log("correct pass");
		//Destroy(0);

		AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(128);
	}
	else Debug.Log("incorrect pass");


}	 
Debug.Log("incorrect email");


	reader.Close();
reader=null;
dbcmd.Dispose();
dbcmd=null;
dbconn.Close();
dbconn=null;	
	}

   
}
