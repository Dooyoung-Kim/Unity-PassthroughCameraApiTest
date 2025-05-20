using UnityEngine;
using PassthroughCameraSamples;

public class PassthroughCameraDisplay : MonoBehaviour
{
    public WebCamTextureManager webcamManager;
    public Renderer quadRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(webcamManager.WebCamTexture != null)
        {
            quadRenderer.material.mainTexture = webcamManager.WebCamTexture;
        }
        
    }
}
