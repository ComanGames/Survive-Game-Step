using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class FinishLine:MonoBehaviour
    {
        public GameObject FinsishText;
        public Text FinishText;

        private void OnTriggerEnter(Collider other)
        {
            CarNumber car = other.transform.parent.parent.GetComponent<CarNumber>();
            if (car != null)
            {
                Time.fixedDeltaTime = 500;
                string text = "";
                if (car.Number == 0)
                {
                    text = "You Win";
                }
                else
                {
                    text = "You Lose";
                }
                FinsishText.SetActive(true);
                FinishText.text = text;
            }
        }


    }
}