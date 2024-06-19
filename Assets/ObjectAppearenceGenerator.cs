using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAppearenceGenerator : MonoBehaviour
{
    public GameObject[] cubes;
    public int currentIndex = 0;

    void Start()
    {
        DeactivateAll();
    }

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentIndex++;
            if (currentIndex < cubes.Length)
            {
                DeactivateAll();
                ActibateByIndex(currentIndex);

            }
            else if (currentIndex > cubes.Length)
            {
                currentIndex = -1;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            DeactivateAll();
            ActibateByIndex(currentIndex);
            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = cubes.Length - 1;
            }


        }
    }

    void DeactivateAll()
    {
        for (int i = 0; i < cubes.Length; i++)
        {
            cubes[i].SetActive(false);
        }
    }
    void ActivateAll()
    {
        for (int i = 0; i < cubes.Length; i++)
        {
            cubes[i].SetActive(true);
        }
    }
    void ActibateByIndex(int index)
    {
        cubes[index].SetActive(true);
    }

}
