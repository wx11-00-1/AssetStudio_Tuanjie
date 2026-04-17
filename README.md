# 功能

导出精灵头像、皮肤等游戏数据

# 用法

## 导出资源

1. 下载安装 .NET Framework 运行时
2. 打开 AssetStudioGUI.exe，在左上角菜单栏选择 File -> Load folder，加载游戏本体（不是启动器）所在的文件夹 ```Seer_Data\yoo```（加载过程中似乎会把文件夹整个放入内存，请确保电脑的剩余内存大于要加载的文件夹大小）
3. 菜单栏 Seer -> Config，设置要保存到的文件夹
4. 菜单栏 Seer -> ExHead、ExBody 或 ExConfig，导出所有头像、皮肤（只导出新增的图片） 或 文本资料（导出全部，覆盖原有文件。先删除游戏目录下的 ```Seer_Data\yoo\ConfigPackage``` 文件夹再打开游戏自动更新，不然导出的文本资料可能会不完整）

## 更新资源

1. 无需游戏本体，下载最新版本的资源文件（目前是删除所有旧资源后重新下载，所有资源总共占用磁盘空间 10GB 以上）

2. 菜单栏 Seer -> Update -> Custom List，可以单独更新部分游戏资源，可以在菜单栏 Seer -> Config -> Update list 配置项指定（ConfigPackage：文本类资源，精灵ID、皮肤、技能等；DefaultPackage：图片、少量 config.json；PetAnimPackage：动画），完成后会自动打开资源所在文件夹

   ```
   配置格式为 json，示例：
   -----
   [
       {
           "name": "ConfigPackage",
           "list": [
               ".*"
           ]
       },
       {
           "name": "DefaultPackage",
           "list": [
               "defaultpackage_assets_art_ui_assets_pet_head_\\d+\\.bundle",
               "defaultpackage_assets_art_ui_assets_pet_body_\\d+\\.bundle"
           ]
       },
       {
           "name": "FollowPackage",
           "list": []
       },
       {
           "name": "PetAnimPackage",
           "list": []
       },
       {
           "name": "StartupPackage",
           "list": []
       }
   ]
   -----
   解析：
   1、节点属性：name 包名；list 正则表达式列表
   2.1、ConfigPackage 包下载全部
   2.2、DefaultPackage 下载精灵头像和皮肤
   2.3、其他的 list 为空列表，不下载资源
   3、正则表达式来源，以精灵头像为例
   3.1、先加载游戏本体的 Seer_Data\yoo\DefaultPackage\CacheBundleFiles，从解析出的 Asset List 中找到精灵头像，右键 Show original file 找到资源所在文件的文件夹名，例如 0482bb5d420d2309565a47f8fb620b9a
   3.2、菜单栏 Update -> Custom List 更新一次，更新完会弹出文件夹，里面的 DefaultPackage.json 是 DefaultPackage 包里面的所有资源清单，在这个 json 文件里搜索 
   0482bb5d420d2309565a47f8fb620b9a，找到对应的 BundleName 是 defaultpackage_assets_art_ui_assets_pet_head_19.bundle，所以可以用示例中的正则表达式来匹配这个资源名称
   ```

   

3. 下载的资源可以加载并导出，操作方式与导出游戏本体资源一样

3. 进阶用法：更新开始时会获取所有文件列表，并以 json 格式保存到 seer_download 文件夹，如果仅需要导出一小部分资源，可以参考 json 文件精确找到所需资源对应的文件，无需加载整个文件夹

# 导出其他

1. 下载源码
2. 用 Visual Studio 打开项目，修改 AssetStudioGUI 子项目
3. AssetStudioForm 修改窗口 UI
4. 参考 AssetStudioForm.cs 中的 exHeadToolStripMenuItem_Click 函数，筛选、导出你想要的其他资源
4. 快捷键 Ctrl + B 构建项目，好像会报错，不过能构建出 AssetStudioGUI 的程序就行
