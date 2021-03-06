﻿using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Markup;

[assembly: XmlnsPrefix("http://yjk.name/winfx/xaml/wpf", "yui")]
[assembly: XmlnsDefinition("http://yjk.name/winfx/xaml/wpf", "YUI.WPF.YControls")]
[assembly: XmlnsDefinition("http://yjk.name/winfx/xaml/wpf", "YUI.WPF.YConverters")]
[assembly: XmlnsDefinition("http://yjk.name/winfx/xaml/wpf", "YUI.WPF.YProperties")]
[assembly: XmlnsDefinition("http://yjk.name/winfx/xaml/wpf", "YUI.WPF.YThemes")]
[assembly: XmlnsDefinition("http://yjk.name/winfx/xaml/wpf", "YUI.WPF.YStyles")]
[assembly: XmlnsDefinition("http://yjk.name/winfx/xaml/wpf", "YUI.WPF.YUtil")]

// 有关程序集的一般信息由以下
// 控制。更改这些特性值可修改
// 与程序集关联的信息。
[assembly: AssemblyTitle("YUI.WPF")]
[assembly: AssemblyDescription("WPF样式工具类")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("YUI.WPF")]
[assembly: AssemblyCopyright("Copyright ©YJK 2020")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// 将 ComVisible 设置为 false 会使此程序集中的类型
//对 COM 组件不可见。如果需要从 COM 访问此程序集中的类型
//请将此类型的 ComVisible 特性设置为 true。
[assembly: ComVisible(false)]

// 如果此项目向 COM 公开，则下列 GUID 用于类型库的 ID
[assembly: Guid("85316835-3f20-460e-a20d-918566b5cd43")]

[assembly: ThemeInfo(
    ResourceDictionaryLocation.None, //主题特定资源词典所处位置
    //(在页面或应用程序资源词典中 
    // 未找到某个资源的情况下使用)
    ResourceDictionaryLocation.SourceAssembly //常规资源词典所处位置
    //(在页面、应用程序或任何主题特定资源词典中 
    // 未找到某个资源的情况下使用)
)]

// 程序集的版本信息由下列四个值组成: 
//
//      主版本
//      次版本
//      生成号
//      修订号
//
// 可以指定所有值，也可以使用以下所示的 "*" 预置版本号和修订号
//通过使用 "*"，如下所示:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.3.11")]
[assembly: AssemblyFileVersion("1.3.11")]
