using UnityEngine; 
using System.Collections; 

	
 public class rere : MonoBehaviour { 


		void Update () { 
		 
				if (Input.GetKeyDown (KeyCode.R)) { 
						Application.LoadLevel (Application.loadedLevel) ; 
			} } }
