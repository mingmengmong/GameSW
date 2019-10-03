using UnityEngine;

namespace Script {
	public class GameStartUI : MonoBehaviour {
		public GameObject bulletCreate;
		public GameObject lifeUI;

		public void Update() {
			if (Time.timeScale == 0) {
				bulletCreate.SetActive(false);
				lifeUI.SetActive(false);
				this.transform.GetChild(0).gameObject.SetActive(true);
			}
		}
		
		public void onGameStartClick() {
			bulletCreate.SetActive(true);
			lifeUI.SetActive(true);
			this.transform.GetChild(0).gameObject.SetActive(false);
			Time.timeScale = 1;
		}

		public void onGameReStartClick() {
			bulletCreate.SetActive(true);
			lifeUI.SetActive(true);
			this.transform.GetChild(0).gameObject.SetActive(false);
		}
	}
}