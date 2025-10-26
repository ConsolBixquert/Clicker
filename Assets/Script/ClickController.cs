using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class ClickController : MonoBehaviour
{
    int counter;
    public GameObject cat_01, cat_02, cat_03;

    [SerializeField]
    TextMeshProUGUI counting;
    [SerializeField]
    TextMeshProUGUI randMessage;
    [SerializeField]
    Animator birdie;
    [SerializeField]
    Animator path;
  

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        counting.text = $"{counter}";
    }

    public void Click()
    {
        Debug.Log("Click.");
        counter++;

        //Debug.Log($"{counter}");
        if (counter % 5 == 0)
        {
            RandomMessage();
        }

        if (counter % 20 == 0)
        {
            StartCoroutine(Blink());
        }

        if (counter % 30 == 0)
        {
            path.SetTrigger("Walk");
        }

        if (counter % 50 == 0)
        {
            birdie.SetTrigger("Run");
        }
    }

    void RandomMessage()
    {
        int rMessage = Random.Range(0, 5);

        if (rMessage == 0)
        {
            randMessage.text = "Good luck!";
        }

        else if (rMessage == 1)
        {
            randMessage.text = "Nice!";
        }

        else if (rMessage == 2)
        {
            randMessage.text = "Keep going!";
        }

        else if (rMessage == 3)
        {
            randMessage.text = "You can do this!";
        }

        else if (rMessage == 4)
        {
            randMessage.text = "This is fun!";
        }
    }

        IEnumerator Blink()
        {
            int random = Random.Range(0, 3);

            if (random == 0)
            {
                cat_01.SetActive(false);
                yield return new WaitForSeconds(1f);
                cat_01.SetActive(true);
            }

            if (random == 1)
            {
                cat_02.SetActive(false);
                yield return new WaitForSeconds(1f);
                cat_02.SetActive(true);
            }

            if (random == 2)
            {
                cat_03.SetActive(false);
                yield return new WaitForSeconds(1f);
                cat_03.SetActive(true);
            }
        }
}
