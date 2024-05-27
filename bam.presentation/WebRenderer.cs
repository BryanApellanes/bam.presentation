namespace Bam.Presentation;

public class WebRenderer : IWebRenderer
{
    public string[] Extensions { get; set; }
    public string ContentType { get; set; }
    public Stream OutputStream { get; set; }
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