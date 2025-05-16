using UnityEngine;
using UnityEngine.AddressableAssets;
using Utilities.Inspector;
using UnityEngine.SceneManagement;

public class NextSceneLoader
{
    public void LoadNextScene(AssetReference sceneToLoad)
    {
        Addressables.LoadSceneAsync(sceneToLoad);
        // SceneManager.LoadScene(sceneToLoad);
    }
}