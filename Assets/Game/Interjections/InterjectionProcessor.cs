using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterjectionProcessor : MonoBehaviour
{
    public int startingValue;
    public Dictionary<GameObject, float> multipliers = new Dictionary<GameObject, float>();
    public Dictionary<GameObject, int> adders = new Dictionary<GameObject, int>();
    public Dictionary<GameObject, int> setters = new Dictionary<GameObject, int>();
    public void ReceiveMultiplier(GameObject interjector, float multiplierAmount)
    {
        if (!multipliers.ContainsKey(interjector))
        {
            multipliers.Add(interjector, multiplierAmount);
        }
    }

    public void ReceiveAdder(GameObject interjector, int addedAmount)
    {
        if (!adders.ContainsKey(interjector))
        {
            adders.Add(interjector, addedAmount);
        }
    }

    public void ReceiveSetter(GameObject interjector, int setterAmount)
    {
        if (!setters.ContainsKey(interjector))
        {
            setters.Add(interjector, setterAmount);
        }
    }

    public int CalculateFinalValue()
    {
        int calculatedValue = startingValue;

        if (setters.Count > 0)
        {
            int lowestValue = 9001;
            foreach (KeyValuePair<GameObject, int> eachSetter in setters)
            {
                if (eachSetter.Value < lowestValue)
                {
                    lowestValue = eachSetter.Value;
                }
            }
            calculatedValue = lowestValue;
        }
        else
        {
            float totalMultipliers = 0.0f;
            foreach (KeyValuePair<GameObject, float> eachMultiplier in multipliers)
            {
                totalMultipliers += eachMultiplier.Value;
            }
            int totalAdders = 0;
            foreach (KeyValuePair<GameObject, int> eachAdder in adders)
            {
                totalAdders += eachAdder.Value;
            }

            calculatedValue = Mathf.FloorToInt((startingValue + totalAdders) * (1.0f + totalMultipliers));
        }

        //Fill this out

        return calculatedValue;
    }
}
