using TMPro;
using UnityEngine;

public class CoffeeCounter : MonoBehaviour
{
    public TMP_Text coffeeText;

    private int coffeeCount = 0;

    void Start()
    {
        UpdateText();
    }

    void UpdateText()
    {
        coffeeText.text = "Caffè: " + coffeeCount.ToString();
    }

    public void AddCoffee()
    {
        coffeeCount++;
        UpdateText();
    }

    public void RemoveCoffee()
    {
        if (coffeeCount > 0)
            coffeeCount--;

        UpdateText();
    }
}