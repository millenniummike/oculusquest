using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    private AssetBundleCreateRequest bundleRequest;
    private UnityWebRequest request;

    public string url;
    public string scene;

    private void Start()
    {
        request = UnityWebRequestAssetBundle.GetAssetBundle(url);
        request.Send();
    }

    private void Update()
    {
        if (request.isDone)
        {
            AssetBundle bundle = DownloadHandlerAssetBundle.GetContent(request);
            Debug.Log("GOT HERE!");
            SceneManager.LoadScene(scene);
        }
    }
}