# Dagor Shader Language Support

[![Visual Studio Marketplace Version](https://img.shields.io/visual-studio-marketplace/v/gaijin.GaijinDagorShaderLanguageSupportVS?color=44cc11)](https://marketplace.visualstudio.com/items?itemName=gaijin.GaijinDagorShaderLanguageSupportVS)
[![build](https://github.com/GaijinEntertainment/Dagor-Shader-Language-Support-for-Visual-Studio/actions/workflows/build.yml/badge.svg)](https://github.com/GaijinEntertainment/Dagor-Shader-Language-Support-for-Visual-Studio/actions/workflows/build.yml)

Dagor Shader Language Support for Visual Studio.

## Features

### Syntax highlight

The extension colorizes types, variables, functions, constructors, keywords, modifiers, semantics, attributes, preprocessor directives, operators, literals, and comments.

![syntax highlight, dark theme](DagorShaderLanguageSupport/Resources/Screenshots/syntax-highlight-dark.png)

![syntax highlight, light theme](DagorShaderLanguageSupport/Resources/Screenshots/syntax-highlight-light.png)

### Diagnostics

The extension can show compile time errors or warnings when you open or save a file.

![diagnostics](DagorShaderLanguageSupport/Resources/Screenshots/diagnostics.gif)

### Code completion

The extension provides types, variables, functions, constructors, keywords, modifiers, semantics, attributes, shaders, block statements, preprocessor directives, code snippets, DSHL macros, and HLSL defines using IntelliSense, according to the context. It can also give you a quick summary about the item when available.

![code completion](DagorShaderLanguageSupport/Resources/Screenshots/completion.gif)

### Signature help

The extension can display a signature helper for DSHL functions, and macros.

![signature help](DagorShaderLanguageSupport/Resources/Screenshots/signature-help.gif)

### Document highlights

The extension can highlight all the occurrences of the selected DSHL variable, function, shader, block statement, macro or HLSL define in the file.

![highlights](DagorShaderLanguageSupport/Resources/Screenshots/highlights.gif)

### Hover

The extension can provide useful information if you hover over DSHL variables, functions, shaders, block statements, macros or HLSL defines.

![hover](DagorShaderLanguageSupport/Resources/Screenshots/hover.gif)

### Document symbols

The extension can provide outline information and breadcrumbs about DSHL variables, shaders, block statements, macros and HLSL defines.

![symbols](DagorShaderLanguageSupport/Resources/Screenshots/symbols.gif)

### Formatting

The extension can format the whole document, or the selected region.

![format](DagorShaderLanguageSupport/Resources/Screenshots/format.gif)

### Go to / Peek definitions

You can find (go to / peek) the definition of a DSHL variable, function, shader, block statement, macro, HLSL define, or to the included file.

![definitions](DagorShaderLanguageSupport/Resources/Screenshots/definition.gif)

### Go to declarations

You can find the declaration of a DSHL variable, function, shader, block statement, macro, HLSL define, or to the included file.

![declarations](DagorShaderLanguageSupport/Resources/Screenshots/declaration.gif)

### Go to implementations

You can find the implementation of DSHL function, shader, block statement, macro, HLSL define, or to the included file.

![implementations](DagorShaderLanguageSupport/Resources/Screenshots/implementation.gif)

### Comment toggling

![comment toggling](DagorShaderLanguageSupport/Resources/Screenshots/comment-toggle.gif)

### Bracket matching

![bracket matching](DagorShaderLanguageSupport/Resources/Screenshots/bracket-match.gif)

### Auto closing pairs

![auto closing pairs](DagorShaderLanguageSupport/Resources/Screenshots/auto-close.gif)

### Indentation

![indentation](DagorShaderLanguageSupport/Resources/Screenshots/indentation.gif)

### File icons

![file icons](DagorShaderLanguageSupport/Resources/Screenshots/icons.png)

## Issues

If you have any problems or feature request for the extension, feel free to create an issue.

## Release Notes

For more information, see the [changelog](CHANGELOG.md).

### 1.5.0

-   Diagnostics
-   Code formatting
-   Includes work with go to declaration/definition/implementation
-   Other smaller improvements

### 1.3.0

-   Code completion (for DSHL variables, shaders, and block statements)
-   Document highlights (for DSHL variables, functions, shaders, and block statements)
-   Hover (for DSHL variables, functions, shaders, and block statements)
-   Document symbols (for DSHL variables, shaders, and block statements)
-   Signature help (for DSHL functions)
-   Go to definition (for DSHL variables, functions, shaders, and block statements)
-   Go to declaration (for DSHL variables, functions, shaders, and block statements)
-   Go to implementation (for DSHL functions, shaders, and block statements)
-   Adding folding ranges based on blocks
-   Several improvements, bugfixes and optimizations

### 1.2.0

- Code completion (for HLSL defines, include statements, DSHL macro parameters)
- Document highlights (for HLSL defines, DSHL macro parameters)
- Hover (for HLSL defines)
- Document symbols (for HLSL defines)
- Go to definition (for HLSL defines, DSHL macro parameters)
- Go to declaration (for HLSL defines, DSHL macro parameters)
- Go to implementation (for HLSL defines)
- Several bugfixes and optimizations

### 1.1.0

- Code completion (for built-in items, and DSHL macros)
- Signature help (for DSHL macros)
- Document highlights (for DSHL macros)
- Hover (for DSHL macros)
- Document symbols (for DSHL macros)
- Go to definition (for DSHL macros)
- Go to declaration (for DSHL macros)
- Go to implementation (for DSHL macros)
- Several bugfixes and optimizations

### 1.0.0

- Syntax highlight
- Comment toggling
- Bracket matching
- Auto closing pairs
- Indentation
- File icons
