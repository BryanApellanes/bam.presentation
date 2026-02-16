# bam.presentation

Web rendering abstraction layer for the Bam framework (early-stage, not yet implemented).

## Overview

The `bam.presentation` project is a .NET 10 class library that defines interfaces and a stub implementation for web content rendering. It establishes the `IWebRenderer` interface (extending `ITemplateRenderer` from `bam.base`) to provide a contract for rendering objects into output streams with configurable content types and file extensions.

The project contains two copies of the `IWebRenderer` interface -- one in the `Bam.Presentation` namespace at the project root and one in `bam.presentation.Web` under the `Web` folder -- along with a single `WebRenderer` implementation class. The `WebRenderer` class implements all interface methods but every method body throws `NotImplementedException`, making this project a structural placeholder awaiting real rendering logic.

This project is designed to be a thin abstraction over template engines or HTML rendering pipelines, decoupling presentation concerns from the rest of the Bam framework.

## Key Classes

| Class | Description |
|-------|-------------|
| `IWebRenderer` (Bam.Presentation) | Interface extending `ITemplateRenderer`. Defines `Extensions`, `ContentType`, `OutputStream`, and `Render(object)`. |
| `IWebRenderer` (bam.presentation.Web) | Duplicate interface in a different namespace. Same contract as above. |
| `WebRenderer` | Stub implementation of `IWebRenderer`. All five render methods throw `NotImplementedException`. Properties `Extensions`, `ContentType`, and `OutputStream` are auto-implemented. |

## Dependencies

### Project References
- `bam.base` -- provides `ITemplateRenderer`, `IRenderer`, and related base interfaces

### Package References
None.

## Usage Examples

Since all rendering methods throw `NotImplementedException`, the project cannot be used for actual rendering yet. However, the intended API surface is:

```csharp
using bam.presentation.Web;

IWebRenderer renderer = new WebRenderer
{
    Extensions = new[] { ".html", ".htm" },
    ContentType = "text/html",
    OutputStream = responseStream
};

// When implemented, these would produce rendered output:
// renderer.Render(myModel);
// string html = renderer.Render("templateName", myModel);
// renderer.Render("templateName", myModel, outputStream);
```

## Known Gaps / Not Yet Implemented

- **`WebRenderer` is entirely a stub.** All five methods (`IWebRenderer.Render(object)`, `IRenderer.Render(object)`, `Render(string, object?)`, `Render(object?, Stream)`, `Render(string, object?, Stream)`) throw `NotImplementedException`.
- **Duplicate `IWebRenderer` interface.** The interface is defined twice in different namespaces (`Bam.Presentation` and `bam.presentation.Web`). This duplication should likely be resolved.
- **No template engine integration.** No rendering engine (Razor, Handlebars, etc.) is wired up.
