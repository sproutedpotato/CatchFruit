using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    [SerializeField]
    GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }
}
