using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine.UI;

public class barcontroller : MonoBehaviour
{
    public float min;
    //float max;
    float current;
	// Use this for initialization
	void Start ()
	{
	  current = min  = gameObject.GetComponent<Image>().fillAmount;
	}


    IEnumerator ControlPB()
    {
        if (!Mathf.Approximately(min, current))
        {
            if (current > min)
            {
                current -= 0.01f;
                gameObject.GetComponent<Image>().fillAmount = current;
                yield return new WaitForSeconds(1f);
            }
        }
    }

    // Update is called once per frame
	void Update ()
	{
	    gameObject.GetComponent<Image>().fillAmount -= 0.01f;
        //StartCoroutine(ControlPB());
	}
}
