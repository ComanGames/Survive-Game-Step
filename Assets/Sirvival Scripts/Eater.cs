using UnityEngine;

public class Eater : MonoBehaviour
{
    public float StartFood = 80f;
    public float MaxFood = 100f;
    public float HungerSpeed = 0.1f;
    public HPBar BarHP;
    private float _totalFood = 0;
    public void Start()
    {
        _totalFood = StartFood;
    }

    public void Update()
    {
        _totalFood -= HungerSpeed * Time.deltaTime;
        BarHP.UpdateValue(_totalFood/MaxFood);

    }

    public void AddFood(float foodCount)
    {
        _totalFood += foodCount;
    }
}
