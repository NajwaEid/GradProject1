 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class switchScene : MonoBehaviour
{

string currentlevel="currentlevel";


  public void ChangeToLevel1()
    {
		string lev="ﻝﻭﻷﺍ ﻯﻮﺘﺴﻤﻟﺍ";
		PlayerPrefs.SetString(currentlevel,lev);
		 SceneManager.LoadScene("level1");

     }
	 
	 public void ChangeToGameMenu()
    {
		
		        SceneManager.LoadScene("gameMenu");

     }
	 
	  public void ChangeToHomeUnite()
    {
		
		        SceneManager.LoadScene("HomeMenu");

     }
	 
 
	 	

 public void ChangeToFoodUnite()
    {
		
		        SceneManager.LoadScene("FoodMenu");

     }		
	 
	 
public void ChangeToSelectFromVegList()
    {
		
		        SceneManager.LoadScene("VegatableMenu");

     }		/* 
	 
	 
	 
	 
	 public void ChangeToSelectFromVegList()
    {
		
		        SceneManager.LoadScene("FoodMenu");

     }		 */
	 
	 
	 
	 
	
	 //1
    public void SelectCarrots()
    {
		
		        SceneManager.LoadScene("Carrots");

     }		
	 
	 //2
	 
	  public void Selectbotato()
    {
		
		        SceneManager.LoadScene("botato");

     }	



	//3 
	 
	 
	 
	  public void Selectcucumber()
    {
		
		        SceneManager.LoadScene("cucumber");

     }	



   //4	 
	 
	 
	  public void Selectpepper()
    {
		
		        SceneManager.LoadScene("pepper");

     }		
	 
	 
	 
	 
	 //5
	  public void Selecttomato()
    {
		
		        SceneManager.LoadScene("tomato");

     }		
	 
	 
	 //6
	 
	  public void Selectvegan()
    {
		
		        SceneManager.LoadScene("vegan");

     }		
	 
	 
	 
	 //7
	 
	 
	   public void Selectlettuce()
    {
		
		        SceneManager.LoadScene("lettuce");

     }		
	 
	 
	 //8
	 
	 
	 
	 
	 //1
	 
	 
	   public void SelectApple()
    {
		
		        SceneManager.LoadScene("apple");

     }		
	 
	 
	 
	 //2
	   public void Selectpomegranate()
    {
		
		        SceneManager.LoadScene("pomegranate");

     }		
	 
	 
	   public void SelectfruitMenu()
    {
		
		        SceneManager.LoadScene("fruitMenu");

     }		
	 
	 
	 
	 
	 
	 
	 
	 //3
	 
	   public void Selectbanana()
    {
		
		        SceneManager.LoadScene("banana");

     }		
	 
	 
	 
	 
	 
	 
	 
	 //4
	   public void SelectFigs()
    {
		
		        SceneManager.LoadScene("figs");

     }		
	 
	 
	 
	 
	 
	 
	 //5
	 

	 
	   public void Selectwatermelon()
    {
		
		        SceneManager.LoadScene("watermelon");

     }		
	 
	 
	 
	 //6
	 
	   public void SelectGrapes()
    {
		
		        SceneManager.LoadScene("grapes");

     }		
	 
	 
	 
	 
	 
	 
	 //7
	   public void SelectOrange()
    {
		
		        SceneManager.LoadScene("orange");

     }		
	 
	 
	 
	 
	 
	 
	 
	 //8
	   public void SelectStrawberry()
    {
		
		        SceneManager.LoadScene("strawberry");

     }		
	 
	 
	 
	 
	 
	 
	 
	 
	 
	 
	 public void Select_fruitMenu()
    {
		
		        SceneManager.LoadScene("fruitMenu");

     }		
	 
	 
	  
	 
	 
	 
	 
	  public void Select_milk_cheeseScene()
    {
		
		        SceneManager.LoadScene("milk_cheese");

     }		
	 
	 	 
		 
		 
	  public void Select_beanse_Scene()
    {
		
		        SceneManager.LoadScene("beans");

     }		
	 
	 
	 
	 
	 
	 
	   public void Select_coldDrinks_Scene()
    {
		
		        SceneManager.LoadScene("coldDrinks");

     }	
	 
	 
	 
	  public void Select_HotDrinks_Scene()
    {
		
		        SceneManager.LoadScene("Hot");

     }	
	 
	 
	 
	  
	  public void Select_Meat_Scene()
    {
		
		        SceneManager.LoadScene("Meat");

     }	
 	 
 	 
	 
	 
	 
	 	  
	  public void Select_sweets_Scene()
    {
		
		        SceneManager.LoadScene("sweets");

     }	
	 
	 
 	 
	 	  public void Select_milk()
    {
		
		        SceneManager.LoadScene("milk");

				
     }	
	 
	 
	 
	 	  public void Select_egg()
    {
		
		        SceneManager.LoadScene("egg");

     }	
	 
	 
	 
	 
	 
	 	  public void Select_labana()
    {
		
		        SceneManager.LoadScene("labna");

     }	
	 
	 
	 //////////////////////////////////////
	 
	  	  public void Select_fish()
    {
		
		        SceneManager.LoadScene("fish");

     }
	 
	 
	 
	 
	 
	  	  public void Select_chicken()
    {
		
		        SceneManager.LoadScene("chicken");

     }
	 
	 
	 
	 
	 
	 
	 
	  	  public void Select_Liver_meat()
    {
		
		        SceneManager.LoadScene("Liver meat");

     }
	 
	 
	 
	 
	 
	 
	 
	  	  public void Select_Shawarma()
    {
		
		        SceneManager.LoadScene("Shawarma");

     }
	 
	 
	 
	 
	  	  public void Select_Veal()
    {
		
		        SceneManager.LoadScene("Veal");

     }
	 
	 
	 
	 //////////////////////
	 
	 
	  	  public void Select_coffe()
    {
		
		        SceneManager.LoadScene("coffe");

     }
	 
	 
	  	  public void Select_tea()
    {
		
		        SceneManager.LoadScene("tea");

     }
	 
	 
	  	  public void Select_kabathino()
    {
		
		        SceneManager.LoadScene("kabathino");

     }
	 
	  	  public void Select_kakao()
    {
		
		        SceneManager.LoadScene("kakao");

     }
	 
	 
	  	  public void Select_naskafe()
    {
		
		        SceneManager.LoadScene("naskafe");

     }
	 
	  	  public void Select_zhoorat()
    {
		
		        SceneManager.LoadScene("zhoorat");

     }
	 
	 
	 
	 
	 
	 
	 //////////////////////
	 
	 
	 
	   public void Select_cola()
    {
		
		        SceneManager.LoadScene("cola");

     }
	 
	 
	 
	   public void Select_water()
    {
		
		        SceneManager.LoadScene("water");

     }
	 
	 
	 	   public void Select_water2()
    {
		
		        SceneManager.LoadScene("water2");

     }
	 
	 
	 
	 
	   public void Select_fruitJuice()
    {
		
		        SceneManager.LoadScene("fruitJuice");

     }
	 
	 
	 
	 
	 
	 
	   public void Select_iccream2()
    {
		
		        SceneManager.LoadScene("iccream2");

     }
	 
	   public void Select_iccream()
    {
		
		        SceneManager.LoadScene("iccream");

     }
	 
	 
	 
	 
	   public void Select_kokteel()
    {
		
		        SceneManager.LoadScene("kokteel");

     }
	 
	 
	 
	 	 
	   public void Select_kokteel2()
    {
		
		        SceneManager.LoadScene("kokteel2");

     }
	 
	 ////////////
	 
	 
	 
	   public void Select_bazela()
    {
		
		        SceneManager.LoadScene("bazela");

     }
	 
	 
	 
	 
	   public void Select_fasolia()
    {
		
		        SceneManager.LoadScene("fasolia");

     }
	 
	 
	 
	 
	   public void Select_Full()
    {
		
		        SceneManager.LoadScene("Full");

     }
	 
	 
	 
	 
	   public void Select_Homos()
    {
		
		        SceneManager.LoadScene("Homos");

     }
	 
	 
	 
	 
	   public void Select_lentils()
    {
		
		        SceneManager.LoadScene("lentils");

     }
	 
	 
	 
	 /////////////
	 
	 
	   
     
	   public void Select_baqlawa()
    {
		
		        SceneManager.LoadScene("baqlawa");

     }
	 
	 
	   public void Select_baskweet()
    {
		
		        SceneManager.LoadScene("baskweet");

     }
	 
	   public void Select_cake()
    {
		
		        SceneManager.LoadScene("cake");

     }
	 
	 
	   public void Select_Knafa()
    {
		
		        SceneManager.LoadScene("Knafa");

     }
	 
	 
	   public void Select_shooklate()
    {
		
		        SceneManager.LoadScene("shooklate");

     }
	 
	 
	 
	 
	 
	 
	 
	 
	 
	 
	 
	 
	 
	 
	 
	 
	 	  public void Select_cheese()
    {
		
		        SceneManager.LoadScene("cheese");

     }	
	 
	 
	 public void Select_MilkRaib()
    {
		
		        SceneManager.LoadScene("MilkRaib");

     }	
	 
	 
	 public void Select_cola2()
    {
		
		        SceneManager.LoadScene("cola2");

     }	
	 
	 	 
	 public void Select_fruitJuice2()
    {
		
		        SceneManager.LoadScene("fruitJuice2");

     }	
	 
	 
	 public void Select_loadBar()
    {
		
		        SceneManager.LoadScene("loadingBarNOR");

     }	
	 
	 
	 
	 
	  public void Select_level2()
    {
		
		        SceneManager.LoadScene("level2");

     }	
	 
	  
	  public void Select_bodyUnite()
    {
		
		        SceneManager.LoadScene("body");

     }	
	 
	  
	  public void Select_login()
    {
		
		        SceneManager.LoadScene("loginScene");

     }
	 
	 
	 
	 
	  public void Select_fruitQuiz()
    {
		
		        SceneManager.LoadScene("quiz");

     }
	 
	 
	 
	 
	 
	 
	 public void Change_bathroom()


    {
		
		        SceneManager.LoadScene("bathroom");

     }
	 
	 
	  public void Change_bedroom()


    {
		
		        SceneManager.LoadScene("bedroom");

     }
	 
	  
	  public void Change_garden()


    {
		
		        SceneManager.LoadScene("garden");

     }
	 
	   public void Change_guestRoom()


    {
		
		        SceneManager.LoadScene("guestRoom");

     }
	 
	 
	 public void Change_kitchen_menu()


    {
		
		        SceneManager.LoadScene("kitchen_menu");

				
     }
	 
	 
	  public void ChangeLivingRoom()


    {
		
		        SceneManager.LoadScene("living room");

				
     }
	 
	 
	 
	 
	 
	 
	 
	 public void Change_bodyUnite()


    {
		
		        SceneManager.LoadScene("body");

     }
	 
	 
	 /////////////////////////////
	 
	 
	  public void arm()


    {
		
		        SceneManager.LoadScene("arm");

     }
	 
	  public void ear()


    {
		
		        SceneManager.LoadScene("ear");

     }
	 
	 
	  public void eye()


    {
		
		        SceneManager.LoadScene("eye");

     }
	 
	 
	  public void face()


    {
		
		        SceneManager.LoadScene("face");

     }
	 
	  public void fingers()


    {
		
		        SceneManager.LoadScene("fingers");

     }
	 
	  public void  foot()


    {
		
		        SceneManager.LoadScene("foot");

     }
	 
	  public void hand()


    {
		
		        SceneManager.LoadScene("hand");

     }
	 
	  public void head()


    {
		
		        SceneManager.LoadScene("head");

     }
	 
	  public void shoulder()


    {
		
		        SceneManager.LoadScene("shoulder");

     }
	 
	  public void mouth()


    {
		
		        SceneManager.LoadScene("mouth");

     }
	 
	  public void Change_neck()


    {
		
		        SceneManager.LoadScene("neck");

     }
	 
	  public void nose()


    {
		
		        SceneManager.LoadScene("nose");

     }
	 
	 
	 
	  public void studentLogin()   {
		
		   SceneManager.LoadScene("studentLogin");

     }
	  
	  
	   public void  level2()   {
		string lev="ﻲﻧﺎﺜﻟﺍ ﻯﻮﺘﺴﻤﻟﺍ";
		PlayerPrefs.SetString(currentlevel,lev);
		   SceneManager.LoadScene("level2");

     }
	 
	 
	  public void level3()   {
		
		string lev="ﺚﻟﺎﺜﻟﺍ ﻯﻮﺘﺴﻤﻟﺍ";
		PlayerPrefs.SetString(currentlevel,lev);
		   SceneManager.LoadScene("level3");

     }
	 
	 
	 
	 
	   public void 	 SaftyFood()   {
		
		   SceneManager.LoadScene("SaftyFood");

     }
	 
	 
	   public void  SaftyHome ()   {
		
		   SceneManager.LoadScene("SaftyHome");
		   
		   

     }
	 
	 
	 
	


	   public void  police ()   {
		
		   SceneManager.LoadScene("police");
		   
		   

     }




	   public void  SuummerClothes()   {
		
		   SceneManager.LoadScene("summerClothes");
		   
		   

     }




	   public void  winterClothes ()   {
		
		   SceneManager.LoadScene("winterClothes");
		   
		   

     }

	 
	 
	   public void  doctorClothes ()   {
		
		   SceneManager.LoadScene("doctorClothes");
		   
		   

     }
	 
	 
	   public void   bathroom ()   {
		
		
		   string lev="ﻲﻧﺎﺜﻟﺍ ﻯﻮﺘﺴﻤﻟﺍ";
		PlayerPrefs.SetString(currentlevel,lev);
	
	 
		   string bigsec="ﻡﺎﻤﺤﻟﺍ";
	string bigsection="bigsection";
	PlayerPrefs.SetString(bigsection,bigsec);
	PlayerPrefs.DeleteKey("smallsection");
	 int currentSceneIndex=139;
	 string scenenum="scenenumber";
		PlayerPrefs.SetInt(scenenum,currentSceneIndex);
		
		
		
		
		
		   SceneManager.LoadScene("bathroom1");
		   
		   

     }
	 
	 
	   public void  bedroom()   {
		   
		   string lev="ﻲﻧﺎﺜﻟﺍ ﻯﻮﺘﺴﻤﻟﺍ";
		PlayerPrefs.SetString(currentlevel,lev);
	
		   string bigsec="ﻡﻮﻨﻟﺍ ﺔﻓﺮﻏ";
	string bigsection="bigsection";
	PlayerPrefs.SetString(bigsection,bigsec);
	PlayerPrefs.DeleteKey("smallsection");
	 int currentSceneIndex=136;
	 string scenenum="scenenumber";
		PlayerPrefs.SetInt(scenenum,currentSceneIndex);
		   SceneManager.LoadScene("bedroom1");
		   
		   

     }
	 
	 
	   public void  kitchen ()   {
		   
		   
	
	
		   string lev="ﻲﻧﺎﺜﻟﺍ ﻯﻮﺘﺴﻤﻟﺍ";
		PlayerPrefs.SetString(currentlevel,lev);
	
	 string bigsec="ﺦﺒﻄﻤﻟﺍ";
	string bigsection="bigsection";
	PlayerPrefs.SetString(bigsection,bigsec);
	PlayerPrefs.DeleteKey("smallsection");
	 int currentSceneIndex=137;
	 string scenenum="scenenumber";
		PlayerPrefs.SetInt(scenenum,currentSceneIndex);
		
		   SceneManager.LoadScene("kitchen");
		   
		   

     }
	 

	 
	   public void  livingRoom ()   {
		   
		   
		      string lev="ﻲﻧﺎﺜﻟﺍ ﻯﻮﺘﺴﻤﻟﺍ";
		PlayerPrefs.SetString(currentlevel,lev);
	
	    string bigsec="ﺱﻮﻠﺠﻟﺍ ﺔﻓﺮﻏ";
	string bigsection="bigsection";
	PlayerPrefs.SetString(bigsection,bigsec);
	PlayerPrefs.DeleteKey("smallsection");
	 int currentSceneIndex=138;
	 string scenenum="scenenumber";
		PlayerPrefs.SetInt(scenenum,currentSceneIndex);
		   
		   
		   
		 
		
		   SceneManager.LoadScene("livingRoom");
		   
		        }
				
	////////////////////////////////////////			
				 
	   public void  fruitQuiz ()   {
		
		   SceneManager.LoadScene("fruitQuiz");
		   
		        }
				
				
				
				  public void  kitchenQuiz()   {
		
		   SceneManager.LoadScene("kitchenQuiz");
		   
		        }
				
				
				
				
				  public void  MeatQuiz()   {
		
		   SceneManager.LoadScene("FVQuiz");
		   
		        }
				
				
				
				  public void  MilkQuiz()   {
		
		   SceneManager.LoadScene("MilkQuiz");
		   
		        }
				
				
				
			
	  public void sweetQuiz()   {
		
		   SceneManager.LoadScene("sweetQuiz");
		   
		        }
					

  public void vegetableQuiz()   {
		
		   SceneManager.LoadScene("vegetableQuiz");
		   
		   
		        }
										
				
				
				
	

  public void beansQuiz()   {
		
		   SceneManager.LoadScene("beansQuiz");
		   
		   
		        }
				
				
				
			

  public void bodyQuiz()   {
		
		   SceneManager.LoadScene("bodyQuiz");
		   
		   
		        }
				
				

			

  public void homwQuiz()   {
		
		   SceneManager.LoadScene("homwQuiz");
		   
		   
		        }
				
				 public void FVQuiz()   {
		
		   SceneManager.LoadScene("FVQuiz");
		   
		   
		        }
				
				
				

				
				//////////////////////////////////////////////////////////////////
	 public void beans2()   {
		
		   SceneManager.LoadScene("beans2");
		   
		   
		        }
				
				
				
	 public void fasolia2()   {
		
		   SceneManager.LoadScene("fasolia2");
		   
		   
		        }
				
				
				
					
	 public void Full2()   {
		
		   SceneManager.LoadScene("Full2");
		   
		   
		        }
				
				
				
				 public void Homos2()   {
		
		   SceneManager.LoadScene("Homos2");
		   
		   
		        }
				
				
				
					 public void lentils2()   {
		
		   SceneManager.LoadScene("lentils2");
		   
		   
		        }
				
				
				 public void summmer()   {
		
		   SceneManager.LoadScene("summerCloths");
		   
		   
		        }
				
	
	
}
    