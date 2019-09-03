using System.Collections;

using System.Collections.Generic;
using UnityEngine;

public class SpotLightS : MonoBehaviour
{
    float switchtimer;
    [SerializeField] GameObject spotlight;
   [SerializeField] List<GameObject> spots = new List<GameObject>();
    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            Instantiate(spotlight);

        }
        spots = new List<GameObject>();
        print(spots.Count);

        foreach (GameObject item in GameObject.FindGameObjectsWithTag("spots"))
        {
            if (item)
            {
                spots.Add(item);

            }
        }
        Switchspots();
    }

    // Update is called once per frame
    void Update()
    {
        if (switchtimer >= 4)
        {

            Switchspots();
        }

        if (switchtimer == 0)
        {
            
            foreach (GameObject item in spots)
            {
                item.GetComponent<Renderer>().material.color = new Color(item.GetComponent<Renderer>().material.color.r, item.GetComponent<Renderer>().material.color.g, item.GetComponent<Renderer>().material.color.b, 0);

            }
        }

        if (switchtimer > 0 && switchtimer <= 2)
        {
            foreach (GameObject item in spots)
            {
                FadeIn(item);
            }
        }

        if (switchtimer > 2)
        {
            foreach (GameObject item in spots)
            {
                FadeOut(item);
            }
        }
        switchtimer += 1 * Time.deltaTime;

    }
    void Switchspots()
    {
 
        switchtimer = 0;


        for (int i = 0; i < spots.Count; i++)
        {
            spots[i].transform.position = new Vector3(Random.Range(-9, 9), Random.Range(-4.5f, 4.5f),0);
            float val = Random.Range(1, 3);

            spots[i].transform.localScale = spots[i].transform.localScale = new Vector3(val,val, 1);


            if (Random.Range(1,3) == 1)
            {
                spots[i].GetComponent<Renderer>().material.color = new Color(0, 0, 1, 1);
            }
            else if (Random.Range(1, 3) == 2)
            {
                spots[i].GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
            }
            else
            {
                spots[i].GetComponent<Renderer>().material.color = new Color(1, 1, 0, 1);
            }

    


        }
    }
    void FadeIn(GameObject item)
    {
        item.GetComponent<Renderer>().material.color = new Color(item.GetComponent<Renderer>().material.color.r, item.GetComponent<Renderer>().material.color.g, item.GetComponent<Renderer>().material.color.b, item.GetComponent<Renderer>().material.color.a + 1f*Time.deltaTime);

    }
    void FadeOut(GameObject item)
    {
        item.GetComponent<Renderer>().material.color = new Color(item.GetComponent<Renderer>().material.color.r, item.GetComponent<Renderer>().material.color.g, item.GetComponent<Renderer>().material.color.b, item.GetComponent<Renderer>().material.color.a - 1f* Time.deltaTime);

    }


}
