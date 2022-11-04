using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour
{
	public void OpenInstagram()
	{
#if !UNITY_EDITOR
		openWindow("https://www.instagram.com/among_edu/");
#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);

}