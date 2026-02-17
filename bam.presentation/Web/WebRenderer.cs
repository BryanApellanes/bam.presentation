using Bam;

namespace bam.presentation.Web;

public class WebRenderer : IWebRenderer
{
    public string[] Extensions { get; set; } = null!;
    public string ContentType { get; set; } = null!;
    public Stream OutputStream { get; set; } = null!;
    void IWebRenderer.Render(object toRender)
    {
        throw new NotImplementedException();
    }

    string IRenderer.Render(object toRender)
    {
        throw new NotImplementedException();
    }

    public string Render(string templateName, object? toRender)
    {
        throw new NotImplementedException();
    }

    public void Render(object? toRender, Stream output)
    {
        throw new NotImplementedException();
    }

    public void Render(string templateName, object? toRender, Stream output)
    {
        throw new NotImplementedException();
    }
}