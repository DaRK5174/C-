using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
public class winGame : MonoBehaviour
{
    public string sceneName;
    private void OnTriggerEnter(Collider collider)
    {
        EditorSceneManager.LoadScene(sceneName);
      
    }
}
