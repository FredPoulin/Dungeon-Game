using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour {

    private Image content;

    [SerializeField]
    private Text statValue;

    private float currentFill;

    [SerializeField]
    private float lerpSpeed;

    public float MaxValue { get; set; }

    public float CurrentValue
    {
        get
        {
            return currentValue;
        }

        set
        {
            if (value > MaxValue)
            {
                currentValue = MaxValue;
            }
            else if (value<0)
            {
                currentValue = 0;
            }
            else
            {
                currentValue = value;
            }

            currentFill = currentValue / MaxValue;
            statValue.text = currentValue + "/" + MaxValue;

        }
    }

    private float currentValue;

                                       // Use this for initialization
    void Start () {
        content = GetComponent<Image>();
        
	}
	
	// Update is called once per frame
	void Update () {

        if (currentFill!=content.fillAmount)
        {
            content.fillAmount = Mathf.Lerp(content.fillAmount, currentFill, Time.deltaTime * lerpSpeed);
        }
       

	}

    public void Initialize(float myCurrentValue, float maxValue)
    {
        MaxValue = maxValue;
        CurrentValue = myCurrentValue;
        Debug.Log(MaxValue);
        Debug.Log(CurrentValue);
    }
}
