using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AutoFade : MonoBehaviour
{
	public static AutoFade m_Instance = null;
	public Texture2D fadeOutTexture;
	public float fadeSpeed = 0.8f;

	private int drawDepth = -1000;
	public float alpha = 1.0f;
	private int fadeDir = -1;

	protected virtual void OnEnable()
	{
		SceneManager.sceneLoaded += OnLevelLoad;

	}



	protected virtual void OnDisable()
	{
		SceneManager.sceneLoaded -= OnLevelLoad;

	}
	private static AutoFade Instance
	{
		get
		{
			if (m_Instance == null)
			{
				m_Instance = (new GameObject("AutoFade")).AddComponent<AutoFade>();
			}
			return m_Instance;
		}
	}

	void Awake(){
		DontDestroyOnLoad(this);
		m_Instance = this;
	}

	void OnGUI(){
		alpha += fadeDir * fadeSpeed * Time.deltaTime;
		alpha = Mathf.Clamp01 (alpha);

		GUI.color = new Color (GUI.color.r, GUI.color.g, GUI.color.b, alpha);
		GUI.depth = drawDepth;
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), fadeOutTexture);

	}

	public float BeginFade(int direction){
		fadeDir = direction;
		return (fadeSpeed);
	}

	

	protected virtual void OnLevelLoad(Scene scene, LoadSceneMode mode){
		BeginFade (-1);

	}



}