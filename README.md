# Kogane Trim Audio Clip Silence

AudioClip の無音区間を削除できるエディタ拡張

## 準備

本パッケージを使用するためには Python のインストールと  
以下の Python パッケージのインストールが必要です

```sh
pip install librosa
pip install soundfile
```

## 使用例

```cs
using Kogane;
using UnityEditor;

public static class Example
{
    [MenuItem( "Tools/Hoge" )]
    private static void Hoge()
    {
        TrimAudioClipSilence.Trim
        (
            sourcePath: "Assets/source.ogg",
            destinationPath: "Assets/destination.ogg",
            topDb: 30
        );

        AssetDatabase.Refresh();
    }
}
```

### Before

![ScreenShot00004](https://user-images.githubusercontent.com/6134875/210160877-99cbe5b2-3efe-4f5a-8deb-ac222db122d9.png)

### After

![ScreenShot00005](https://user-images.githubusercontent.com/6134875/210160879-5bde1507-0bc3-4eb7-8a08-de310bf5f9fd.png)
