using UnityEngine;
using JetBrains.Annotations;

namespace CookingPrototype.Kitchen {
	[RequireComponent(typeof(FoodPlace))]
	public sealed class FoodTrasher : MonoBehaviour {

		FoodPlace _place = null;

		void Start() {
			_place = GetComponent<FoodPlace>();
		}
		
		[UsedImplicitly]
		public void TryTrashFood() {
			Food food = _place.CurFood;
			if (food?.CurStatus != Food.FoodStatus.Overcooked) {
				return;
			}
			
			_place.FreePlace();
		}
	}
}
