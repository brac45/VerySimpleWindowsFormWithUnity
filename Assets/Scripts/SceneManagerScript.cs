using UnityEngine;
using Assets.Forms;
using System.Collections;

public class SceneManagerScript : MonoBehaviour {
    private Form1 form;

	// Use this for initialization
	void Start () {
        ShowWindowsForm();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Show empty windows form
    void ShowWindowsForm () {
        form = new Form1();
        form.Show();
    }
}
