using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mapcreation : MonoBehaviour
{

    public GameObject[] item;


    // Start is called before the first frame update
    void Start()
    {
        InitMap();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InitMap()
    {
        int num = 0;
        int ranNum = 0;
        for (float y = 4.75f; y >= -4.75f; y -= 0.5f)
            for (float x = -8.75f; x <= 8.75f; x += 0.5f)
            {

                if (y <= 0.75 && y >= -0.75 && x >= -0.75 && x <= 0.75)
                    CreateItem(item[num++], new Vector3(x, y, 0), Quaternion.identity);
                else
                {
                    ranNum = Random.Range(0, 16);
                    CreateItem(item[ranNum], new Vector3(x, y, 0), Quaternion.identity);
                }

            }
    }

    private void CreateItem(GameObject createCameObject, Vector3 createPosition, Quaternion createRotation)
    {
        GameObject itemGo = Instantiate(createCameObject, createPosition, createRotation);
        itemGo.transform.SetParent(gameObject.transform);

    }
}
