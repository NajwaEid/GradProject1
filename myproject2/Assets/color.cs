using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class color : MonoBehaviour
{
	public Image image;
     
     void Update()
     {
         image = GetComponent<Image>();
		 image.color = Color.white;
     
     }
}