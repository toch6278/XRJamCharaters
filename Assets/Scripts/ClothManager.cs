using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothManager : MonoBehaviour
{
    public GameObject Hat;
    public GameObject [] objects;

    int index;

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        objects = GameObject.FindGameObjectsWithTag("aObj");
        for (int i = 0; i < objects.Length; i++) {
            objects[i].SetActive(false);
        }

    }

    void Update()
    {
        selectObj(index);
    }

    public void Next() {
        index++;
       
    }

    public void Previous()
    {
        index--;
    }

    void selectObj(int sindex) {

        for (int i = 0; i < objects.Length; i++)
        {
            objects[i].SetActive(false);
        }
        objects[sindex].SetActive(true);
    }
}
