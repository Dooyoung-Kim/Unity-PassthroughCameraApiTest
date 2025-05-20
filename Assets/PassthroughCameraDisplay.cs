using UnityEngine;
using PassthroughCameraSamples;

public class PassthroughCameraDisplay : MonoBehaviour
{
    public WebCamTextureManager webcamManager;
    public Renderer quadRenderer;
    public string textureName;

    private Texture2D picture;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(webcamManager.WebCamTexture != null)
        {
            if(OVRInput.GetDown(OVRInput.Button.One))
            {
                TakePicture();
            }
        }
        
    }

    public void TakePicture()
    {
        int width = webcamManager.WebCamTexture.width;
        int height = webcamManager.WebCamTexture.height;

        if(picture == null)
        {
            picture = new Texture2D(width, height);
        }

        Color32[] pixels = new Color32[width * height];
        webcamManager.WebCamTexture.GetPixels32(pixels);

        picture.SetPixels32(pixels);
        picture.Apply();

        quadRenderer.material.SetTexture(textureName, picture);

    }
}
