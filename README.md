# 功能

导出精灵头像、皮肤

# 用法

1. 下载安装 .NET Framework 运行时
2. 打开 AssetStudioGUI.exe，在左上角菜单栏选择 File -> Load folder，加载游戏本体（不是启动器）所在的文件夹
3. 菜单栏 Seer -> Config，设置要保存到的文件夹
4. 菜单栏 Seer -> ExHead 或 ExBody，导出所有头像、皮肤

# 导出其他

1. 下载源码
2. 用 Visual Studio 打开项目，修改 AssetStudioGUI 子项目
3. AssetStudioForm 修改窗口 UI
4. 参考 AssetStudioForm.cs 中的 exHeadToolStripMenuItem_Click 函数，筛选、导出你想要的其他资源
