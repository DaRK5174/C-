using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
public class TrapsTriger : MonoBehaviour
{
    public string sceneName;
    private void OnTriggerEnter(Collider collider)
    {
        print("�������, �� ������ ����");
        EditorSceneManager.LoadScene(sceneName);
    }
}
