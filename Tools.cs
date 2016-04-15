using UnityEngine;
using System.Collections;
using UnityEditor;
using UnityEngine.UI;
using System.IO;
public class Tools : MonoBehaviour {
    

    [MenuItem("CCGLP/Template/Platform3DTemplate")]
	public static void CreatePlatform3D()
    {
        GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
        go.transform.position = new Vector3(0, 3, 0);
        go.AddComponent<Rigidbody>();
        go.AddComponent<BoxCollider>();

        GameObject suelo = GameObject.CreatePrimitive(PrimitiveType.Plane);
        suelo.transform.localScale = new Vector3(10, 1, 10);



    }


    [MenuItem("CCGLP/Template/CanvasInGameTemplate")]
    public static void CreateBasicCanvas()
    {
        GameObject canvas = new GameObject("Canvas");
       
        canvas.AddComponent<Canvas>().renderMode = RenderMode.ScreenSpaceOverlay;
        canvas.AddComponent<CanvasScaler>().uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        canvas.GetComponent<CanvasScaler>().referenceResolution = new Vector2(1920, 1080);
        canvas.GetComponent<CanvasScaler>().screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        canvas.AddComponent<GraphicRaycaster>();
        canvas.layer = 5;

        GameObject lifeText = new GameObject("lifeText");
        lifeText.AddComponent<Text>().text = "Life: 100";
        lifeText.transform.SetParent(canvas.transform);
        lifeText.layer = 5;
        RectTransform rlt = lifeText.GetComponent<RectTransform>();
        rlt.sizeDelta = new Vector2(500, 200);
        rlt.anchorMin = new Vector2(0, 1);
        rlt.anchorMax = new Vector2(0, 1);
        rlt.pivot = new Vector2(0, 1);
        rlt.localPosition = new Vector2(0, 0);
        lifeText.GetComponent<Text>().fontSize = 120;
    }

    [MenuItem("CCGLP/Template/CanvasMenuTemplate")]
    public static void CreateStartMenu()
    {
        GameObject canvas = new GameObject("Canvas");

        canvas.AddComponent<Canvas>().renderMode = RenderMode.ScreenSpaceOverlay;
        canvas.AddComponent<CanvasScaler>().uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        canvas.GetComponent<CanvasScaler>().referenceResolution = new Vector2(1920, 1080);
        canvas.GetComponent<CanvasScaler>().screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        canvas.AddComponent<GraphicRaycaster>();
        canvas.layer = 5;
        GameObject lifeText = new GameObject("titleText");
        lifeText.AddComponent<Text>().text = "MY NAME";
        lifeText.transform.SetParent(canvas.transform);
        lifeText.layer = 5;
        RectTransform rlt = lifeText.GetComponent<RectTransform>();
        
        rlt.anchorMin = new Vector2(0, 1);
        rlt.anchorMax = new Vector2(1, 1);
        rlt.sizeDelta = new Vector2(0, 200);
        rlt.pivot = new Vector2(0.5f, 1);
        rlt.localPosition = new Vector2(0, 0);
        lifeText.GetComponent<Text>().fontSize = 120;
        lifeText.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;

        GameObject button = new GameObject("StartButton");

        Button bt = button.AddComponent<Button>();
        button.transform.SetParent(canvas.transform);
        Image imB=  button.AddComponent<Image>();

        bt.targetGraphic = imB;

        ColorBlock cb = bt.colors;
        cb.normalColor = new Color(0.325f,0.3568f,0.99f,0.7f);

        bt.colors = cb;

        RectTransform brt = button.GetComponent<RectTransform>();
        brt.localPosition = new Vector3(0, 0, 0);
        brt.sizeDelta = new Vector2(500, 200);

        GameObject textButton = Instantiate(lifeText);
        textButton.transform.SetParent(button.transform);
        textButton.name = "Text";
        Text textTB = textButton.GetComponent<Text>();
        textTB.text = "START";
        textTB.alignment = TextAnchor.MiddleCenter;
        textButton.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 200);
        textButton.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);



    }

    [MenuItem("CCGLP/Template/OrganizeProject")]
    public static void createOrganizedFolders()
    {
        Directory.CreateDirectory("./Assets/_Code");
        Directory.CreateDirectory("./Assets/_Scenes");
        Directory.CreateDirectory("./Assets/Models");
        Directory.CreateDirectory("./Assets/Sprites");
        Directory.CreateDirectory("./Assets/Textures");
        Directory.CreateDirectory("./Assets/Materials");
        Directory.CreateDirectory("./Assets/AnimatorControllers");
        Directory.CreateDirectory("./Assets/Animations");
        Directory.CreateDirectory("./Assets/Prefabs");
    }

}
