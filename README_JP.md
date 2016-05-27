# Unity MathfExample

　「ダメージを与えられたり、回復薬を使った後のHPを調整したい。0未満であれば0にして、最大HPより大きければ最大HPにして、それら以外はそのままにする。」

　このような処理を行うために、次のようなメソッドを作ったことはありませんか？

```csharp
int Adjust(int value, int min, int max)
{
    if(value < min) {
        return min;
    } else if(value > max) {
        return max;
    } else {
        return value;
    }
}
```

　使い方はこんな感じでしょうかね？

```csharp
int damagedHp = currentHp - damage;
int adjustedHp = Adjust(value: damagedHp, min: 0, max: maxHp);
```

　この`Adjust`メソッドのようなメソッドを、自分で作ったことのある読者の方も多いのではないでしょうか？

　ところで`Mathf`というクラスを知っていますか？そして使っていますか？

　「あぁ、三角関数とか、円周率を近似した浮動小数点数が定義されているクラスでしょ？」と思ったりしていませんか？

　確かに`Mathf`には、三角関数や、円周率を近似した浮動小数点数も定義されています。ですが`Mathf`はそれらだけではありません！`Mathf`にはゲーム開発で三角関数よりも、ずっと便利でずっと使える場面が多い静的メソッドが多数定義されているのです。

　さて先ほどの`Adjust`メソッド、実は同じようなメソッドがもうすでに`Mathf`クラスに定義されています。`Clamp`メソッドです。次のように`Clamp`メソッドを使えばいいので、先ほどのような`Adjust`メソッドをわざわざ作る必要がありません。

```csharp
int damagedHp = currentHp - damage;
int adjustedHp = Mathf.Clamp(value: damagedHp, min: 0, max: maxHp);
```

　このリポジトリでは、`Mathf`のUnit Testを介して、`Mathf`の使い方を紹介します。

# 作者

室星亮太

* 投稿先:http://qiita.com/RyotaMurohoshi
* Twitter:https://twitter.com/RyotaMurohoshi

# ライセンス
MIT License です。
