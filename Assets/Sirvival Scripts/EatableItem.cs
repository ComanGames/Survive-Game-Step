using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatableItem : MonoBehaviour
{

    public float FoodCount = 1;

    public void OnTriggerEnter(Collider other)
    {
        Eater eater = other.GetComponent<Eater>();
        if (eater != null)
        {
            eater.AddFood(FoodCount);
            Destroy(this.gameObject);
        }

    }

}
