# What?

* 任意の MonoBehaviour に Singleton にアクセス出来るフィールドを提供します

# Why?

* シーンを跨いでアクセスしたりするコンポーネントが少なからず存在していたので実装しました

# Install

```shell
$ npm install github:umm-projects/singleton_monobehaviour.git
```

# Usage

```csharp
public class Hoge : SingletonMonoBehaviour<Hoge> {

    public string Fuga() {
        return "Fuga!!!";
    }

}

public class Fuga {

    public void Piyo() {
        Debug.Log(Hoge.Instance.Fuga());
    }

}
```

# License

Copyright (c) 2017 Tetsuya Mori

Released under the MIT license, see [LICENSE.txt](LICENSE.txt)

