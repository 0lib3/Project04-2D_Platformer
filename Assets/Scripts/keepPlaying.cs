using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepPlaying : MonoBehaviour
{
    private static keepPlaying instance = null;

    public static keepPlaying Instance
    {
        get {return instance;}
    }

    void Awake()
    {
        if(instance != null && instance != this){
            Destroy(this.gameObject);
            return;
        }else{
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
