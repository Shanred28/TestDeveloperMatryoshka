using System;
using UnityEngine;
using UnityEngine.UI;

using CookingPrototype.Controllers;

using TMPro;

namespace CookingPrototype.UI
{
	public sealed class StartWindow : MonoBehaviour
	{
		public Image    GoalBar     = null;
		public TMP_Text GoalText    = null;
		public Button   PlayButton    = null;
		
		bool _isInit = false;
		void Init() {
			if (_isInit) 
				return;
			
			PlayButton.onClick.AddListener(GameplayController.Instance.StartGame);
			_isInit = true;
		}
		
		public void Show () {
			Init();
			
			var gc = GameplayController.Instance;

			GoalText.text      = $"{gc.OrdersTarget}";
			GoalBar.fillAmount = 0;
			
			gameObject.SetActive(true);
		}
		
		public void Hide() {
			gameObject.SetActive(false);
		}
	}
}
