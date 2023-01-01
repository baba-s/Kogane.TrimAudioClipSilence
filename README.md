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