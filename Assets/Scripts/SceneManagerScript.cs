using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public void load_scene(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }
}
