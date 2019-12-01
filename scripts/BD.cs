using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BD : MonoBehaviour
{
	public float scroll_speed = -0.1f;
	private MeshRenderer mesh_renderer;
	private float y;

	private void Awake()
	{
		mesh_renderer = GetComponent<MeshRenderer>();
	}
	void Start()
    {
        
    }
    void Update()
    {
		float x = Time.time * scroll_speed;
		Vector3 offset = new Vector3(x, 0, 0);
		mesh_renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
