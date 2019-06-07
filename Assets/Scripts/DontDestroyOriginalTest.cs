using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOriginalTest : MonoBehaviour {
    private static DontDestroyOriginalTest instance;

    void Awake() {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(gameObject);
        }
        
        Debug.Log("[DontDestroyOriginalTest] Calling DontDestroyOnLoad");
        DontDestroyOnLoad(gameObject);
    }
}