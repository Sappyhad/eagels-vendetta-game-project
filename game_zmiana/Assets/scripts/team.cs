using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class team : MonoBehaviour
{
    public static team instance;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }


}
