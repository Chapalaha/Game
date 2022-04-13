using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowNotify : MonoBehaviour
{
    public GameObject showObject;
    public float showAtDistance = 0f;
    public Transform fromTheObject;

    void OnMouseOver()
    {
        if (fromTheObject) {
            Vector3 offset = fromTheObject.position - transform.position;
            float sqrlen = offset.sqrMagnitude;
            if (sqrlen < showAtDistance * showAtDistance)
                showObject.SetActive(true);
            if (Input.GetKey(KeyCode.E))
                SceneManager.LoadScene("Street");
        }
        
    }

    void OnMouseExit()
    {
        showObject.SetActive(false);
    }

    void Update()
    {
        if (fromTheObject)
        {
            Vector3 offset = fromTheObject.position - transform.position;
            float sqrlen = offset.sqrMagnitude;
            if (sqrlen > showAtDistance * showAtDistance)
                showObject.SetActive(false);
        }
    }
}
