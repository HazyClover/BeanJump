using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDeleteAudio : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
