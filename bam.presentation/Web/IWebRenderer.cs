/*
    Copyright © Bryan Apellanes 2015
*/

using Bam;

namespace bam.presentation.Web
{
    public interface IWebRenderer: ITemplateRenderer
    {
        string[] Extensions { get; set; }
        string ContentType { get; set; }
        Stream OutputStream { get; set; }
        new void Render(object toRender);
    }
}