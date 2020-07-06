## 一个xml样例
```xml
<configuration>
    <MySettings Id="12" Age="N011">
        <Option>10</Option>
    </MySettings>
</configuration>
```

- 根结点可以随意，如上述是`configuration`，也可以改为`settings`
- 由于.net core的配置系统以Path, Key, Value来区分，因此不会再区分属性和值的区别
```json
{
    "Path": "MySettings:Age",
    "Key": "Age",
    "Value": "N011"
},
{
    "Path": "MySettings:Option",
    "Key": "Option",
    "Value": "10"
}
```
- Name是一个特殊的属性，如对于下面的xml，Name会被当成一个节点来处理
```xml
<configuration>
    <Person Name="Wagner" Age="20">
        <Height>160</Height>
    </Person>
</configuration>
```
获取Height的Path就自动变为:`Person:Wagner:Height`
