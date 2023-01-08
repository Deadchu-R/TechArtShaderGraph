using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SetZValues : MonoBehaviour
{
    [SerializeField] float ZAD_Scale = 1f;
    [SerializeField] float ZAD_Offset = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shader.SetGlobalFloat("ZAD_Scale", ZAD_Scale);
        Shader.SetGlobalFloat("ZAD_Offset", ZAD_Offset);
        
    }
}
