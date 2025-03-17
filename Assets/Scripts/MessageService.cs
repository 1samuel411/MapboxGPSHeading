namespace Mapbox.Unity.Ar
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class MessageService : MonoBehaviour {

		/// <summary>
		/// This class handles communication with gamesparks for
		/// removing, loading, and writing new messages. New Message
		/// objects are instantiated here.
		/// </summary>
		private static MessageService _instance;
		public static MessageService Instance { get { return _instance; } } 

		public Transform mapRootTransform;

		public GameObject messagePrefabAR;

		void Awake(){
			_instance = this;
		}

		public void RemoveAllMessages(){
			
		}

		public void LoadAllMessages(){

			List<GameObject> messageObjectList = new List<GameObject> ();
			
			//pass list of objects to ARmessage provider so they can be placed
			ARMessageProvider.Instance.LoadARMessages (messageObjectList);
		}

		public void SaveMessage(double lat, double lon, string text){
			
		}
	}
}
