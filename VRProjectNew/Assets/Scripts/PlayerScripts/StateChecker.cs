using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StateChecker : MonoBehaviour
{
    public Vector3 playerStartPosition;
    public GenRow generator;

    void Update()
    {
        EnforceBounds();
    }

    void EnforceBounds()
    {
        if (gameObject.transform.GetChild(0).transform.position.x < -7.5f || gameObject.transform.GetChild(0).transform.position.x > 5f || gameObject.transform.GetChild(0).transform.position.z < -5.5f || gameObject.transform.GetChild(0).transform.position.z > 4.5f)
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
      
    }
}
