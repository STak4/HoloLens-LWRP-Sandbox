using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    [SerializeField]
    GameObject[] vfxPrefab;

    [SerializeField]
    GameObject mainMenu, backMenu;

    GameObject nowObj;

    public void SpawnVFX(int vfxnum)
    {
        var nowPos = Camera.main.transform.position;

        nowObj = Instantiate(vfxPrefab[vfxnum], new Vector3(nowPos.x, nowPos.y, nowPos.z + 1.0f), Quaternion.identity, gameObject.transform);
        nowObj.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        mainMenu.SetActive(false);
        backMenu.SetActive(true);
    }

    public void BackMenu()
    {
        if(nowObj != null)
        {
            Destroy(nowObj);
        }

        backMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
