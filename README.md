# 功能

导出精灵头像、皮肤等游戏数据

# 用法

## 导出资源

1. 下载安装 .NET Framework 运行时
2. 打开 AssetStudioGUI.exe，在左上角菜单栏选择 File -> Load folder，加载游戏本体（不是启动器）所在的文件夹 ```Seer_Data\yoo```
3. 菜单栏 Seer -> Config，设置要保存到的文件夹
4. 菜单栏 Seer -> ExHead、ExBody 或 ExConfig，导出所有头像、皮肤（只导出新增的图片） 或 文本资料（导出全部，覆盖原有文件。先删除游戏目录下的 ```Seer_Data\yoo\ConfigPackage``` 文件夹再打开游戏自动更新，不然导出的文本资料可能会不完整）

## 更新资源

1. 无需游戏本体，下载最新版本的资源文件（目前是删除所有旧资源后重新下载，所有资源占用磁盘空间 10GB 以上，不建议更新全部；适合单独更新 ConfigPackage）
2. 菜单栏 Seer -> Update，可以选择更新 全部 或 单独 的游戏资源分类（ConfigPackage：文本类资源，精灵ID、皮肤、技能等；DefaultPackage：图片、少量 config.json；PetAnimPackage：动画），完成后会自动打开资源所在文件夹
3. 下载的资源可以加载并导出，操作方式与导出游戏本体资源一样

# 导出其他

1. 下载源码
2. 用 Visual Studio 打开项目，修改 AssetStudioGUI 子项目
3. AssetStudioForm 修改窗口 UI
4. 参考 AssetStudioForm.cs 中的 exHeadToolStripMenuItem_Click 函数，筛选、导出你想要的其他资源
4. 快捷键 Ctrl + B 构建项目，好像会报错，不过能构建出 AssetStudioGUI 的程序就行
