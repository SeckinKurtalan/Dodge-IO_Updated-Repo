using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelShower : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(showTheLevelStaus());
    }

    IEnumerator showTheLevelStaus()
    {
        gameObject.GetComponent<Animator>().Play("LevelIndicator");
        yield return new WaitForSecondsRealtime(3f);
        gameObject.GetComponent<Animator>().Play("LevelGoUp");
        yield return new WaitForSecondsRealtime(0.75f);
        gameObject.SetActive(false);
    }
}
