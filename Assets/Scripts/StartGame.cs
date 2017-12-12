using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour {


  void Start()
  {
      Button btn = GetComponent<Button>();
      btn.onClick.AddListener(TaskOnClick);
  }

  void TaskOnClick() {
	    SceneManager.LoadScene("trainScene");
  }
}
