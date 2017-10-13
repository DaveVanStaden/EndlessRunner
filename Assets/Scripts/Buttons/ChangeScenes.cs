using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScenes : MonoBehaviour {

	public void changeMenuScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
