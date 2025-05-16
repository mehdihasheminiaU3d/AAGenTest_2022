
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using Utilities.Inspector;
using UnityEngine.SceneManagement;

public class LoadSceneBehaviour : MonoBehaviour
{

    public AssetReference sceneToLoad; 

    public void LoadScene()
    {
        NextSceneLoader sceneLoader = new NextSceneLoader();
        sceneLoader.LoadNextScene(sceneToLoad);
    }
    
}

