using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	Dictionary<string, Component> DicComponent = new Dictionary<string, Component>();

	//public T CallComponent<T>() where T : Component
	//{
	//	string objectName = string.Empty;
	//	string typeName = typeof(T).ToString();
	//	T tempComponent = default(T);

	//	if (Target == null)
	//	{
	//		objectName = this.gameObject.name;

	//		if (DicComponent.ContainsKey(typeName))
	//		{
	//			tempComponent = DicComponent[typeName] as T;
	//		}
	//		else
	//		{
	//			tempComponent = this.GetComponent<T>();

	//			if (tempComponent == null)
	//			{
	//				Debug.LogError("ObjectName : " + objectName
	//					+ ", Missing Component : " + typeName);
	//				tempComponent = this.gameObject.AddComponent<T>();
	//			}
	//			else
	//			{
	//				DicComponent.Add(typeName, tempComponent);
	//			}
	//		}
	//	}
	//	else
	//	{
	//		objectName = Target.SelfObject.name;
	//		tempComponent = TargetComponent.SelfComponent<T>();
	//	}

	//	return tempComponent;

	//}
}
