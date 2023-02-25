# Blazicons.Bootstrap
Provides the Bootstrap icon library packaged as [Blazicons](https://github.com/kyleherzog/Blazicons), SVG icon components for Blazor.

Check out the [Demo Site](http://blazicons.com).

![Nuget](https://img.shields.io/nuget/v/Blazicons.Bootstrap)

[![Build Status](https://dev.azure.com/kyleherzog/Blazicons/_apis/build/status/Blazicons.Bootstrap?branchName=main)](https://dev.azure.com/kyleherzog/Blazicons/_build/latest?definitionId=17&branchName=main)

## Getting Started
To get started using the Bootstrap Blazicons, just install the Blazicons.Bootstrap NuGet package.

Next add the Blazicons reference to the `_Imports.razor` file in the Blazor project.

```csharp
@using Blazicons
```

Finally, add the Blazicon component to your Blazor pages/components.
```html
<Blazicon Svg="BootstrapIcon.Award"></Blazicon>
```

## Parameters & Styling
See the [Blazicons](https://github.com/kyleherzog/Blazicons) documentation for details on parameters and styling.

## Credits
Thanks to the creators of [Bootstrap Icons](https://github.com/twbs/icons)