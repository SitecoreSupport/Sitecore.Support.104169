# Sitecore.Support.104169
Checkbox and radio lists cannot be rendered in columns.

## Main

This repository contains Sitecore Patch #104169, which allows render a checkbox list or radio list in columns.

## Deployment

To apply the patch on either CM or CD server perform the following steps:

1. Place the `Sitecore.Support.104169.dll` assembly into the `\bin` directory.
2. Place the `CheckboxListField.cshtml` file into the `\Views\Form\EditorTemplates` directory.
3. Place the `RadioListField.cshtm` file into the `\Views\Form\EditorTemplates` directory.

## Content 

Sitecore Patch includes the following files:

1. `\bin\Sitecore.Support.104169.dll`
2. `\Views\Form\EditorTemplates\CheckboxListField.cshtml`
3. `\Views\Form\EditorTemplates\RadioListField.cshtm`
 
## License

This patch is licensed under the [Sitecore Corporation A/S License for GitHub](https://github.com/sitecoresupport/Sitecore.Support.104169/blob/master/LICENSE).  

## Download

Downloads are available via [GitHub Releases](https://github.com/sitecoresupport/Sitecore.Support.104169/releases).  
