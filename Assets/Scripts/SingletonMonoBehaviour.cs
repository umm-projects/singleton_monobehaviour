using UnityEngine;

/// <summary>
/// Singleton にコンポーネントにアクセスするための機能を提供する
/// </summary>
/// <typeparam name="T">コンポーネントの型</typeparam>
public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T> {

	/// <summary>
	/// 自身のインスタンスの実体
	/// </summary>
	private static T instance;

	/// <summary>
	/// 自身のインスタンス
	/// </summary>
	public static T Instance {
		get {
			if (instance == default(T)) {
				instance = Permanent.Add<T>();
			}
			return instance;
		}
		private set {
			instance = value;
		}
	}

	/// <summary>
	/// Unity lifecycle: Awake
	/// </summary>
	/// <remarks>Singleton 化のために、既にインスタンスが存在していたら自殺</remarks>
	public virtual void Awake() {
		if (FindObjectOfType<T>() != null && FindObjectOfType<T>().gameObject != this.gameObject) {
			Destroy(this);
		} else {
			Instance = (T)this;
		}
	}

}