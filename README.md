# 功能

导出精灵头像、皮肤等游戏数据

# 用法

1. 下载安装 .NET Framework 运行时
2. 打开 AssetStudioGUI.exe，在左上角菜单栏选择 File -> Load folder，加载游戏本体（不是启动器）所在的文件夹
3. 菜单栏 Seer -> Config，设置要保存到的文件夹
4. 菜单栏 Seer -> ExHead、ExBody 或 ExConfig，导出所有头像、皮肤（只导出新增的图片） 或 文本资料（导出全部，覆盖原有文件。先删除游戏目录下的 ```Seer_Data\yoo\ConfigPackage``` 文件夹再打开游戏自动更新，不然导出的文本资料可能会不完整）

# 导出其他

1. 下载源码
2. 用 Visual Studio 打开项目，修改 AssetStudioGUI 子项目
3. AssetStudioForm 修改窗口 UI
4. 参考 AssetStudioForm.cs 中的 exHeadToolStripMenuItem_Click 函数，筛选、导出你想要的其他资源
