using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {


  void Start()
  {
      Button btn = GetComponent<Button>();
      btn.onClick.AddListener(TaskOnClick);
  }

  void TaskOnClick() {
	    SceneManager.LoadLevel("Some Scene");
  }
}
