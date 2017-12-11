using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour {


  void Start()
  {
      Button btn = GetComponent<Button>();
      btn.onClick.AddListener(TaskOnClick);
  }

  void TaskOnClick() {
	    Application.LoadLevel("Some Scene");
  }
}
