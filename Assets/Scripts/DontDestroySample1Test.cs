using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroySample1Test : MonoBehaviour {
    private static DontDestroySample1Test instance;

    void Awake() {
        if (instance == null) {
            instance = this;
            Debug.Log("[DontDestroySample1Test] Calling DontDestroyOnLoad");
            DontDestroyOnLoad(gameObject);
        } else if (instance != this) {
            Destroy(gameObject);
        }
    }
}