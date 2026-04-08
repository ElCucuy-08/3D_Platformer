using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Game : MonoBehaviour
{
    public void SceneLoad(int IndexScene)
    {
        SceneManager.LoadScene(IndexScene);
    }
}
