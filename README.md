# Scriptable-Tags
Quickly set up object tags without using the standard Unity tag system.

## How to install
This package can be installed through the Unity `Package Manager` with Unity version 2019.3 or greater.

Open up the package manager `Window/Package Manager` and click on `Add package from git URL...`.

![unity_package_manager_git_drop_down](Documentation~/images/unity_package_manager_git_drop_down.png)

Paste in this repository's url.

`https://github.com/Jason-Skillman/Scriptable-Tags.git`

![unity_package_manager_git_with_url](Documentation~/images/unity_package_manager_git_with_url.png)

Click `Add` and the package will be installed in your project.

---
**NOTE:** For Unity version 2019.2 or lower

If you are using Unity 2019.2 or lower than you will not be able to install the package with the above method. Here are a few other ways to install the package.
1. You can clone this git repository into your project's `Packages` folder.
1. Another alternative would be to download this package from GitHub as a zip file. Unzip and in the `Package Manager` click on `Add package from disk...` and select the package's root folder.

---

### Git submodule
Alternatively you can also install this package as a git submodule.

```console
$ git submodule add https://github.com/Jason-Skillman/Scriptable-Tags.git Packages/Scriptable-Tags
```

## How to use
1. Add the `Tag Component` to the object you want to tag.
1. To create a new Tag scritable object, right click in the project window and navigate to `Create/Scriptable Tags/Tag`.
1. Give the tag a name in the inspector.
1. Add the new tag to the tag component.
1. To check if an object has a tag you can use the `ContainsTag()` function.

```C#
public Tag tag;

...

if(gameObject.ContainsTag(tag)) { }
```
