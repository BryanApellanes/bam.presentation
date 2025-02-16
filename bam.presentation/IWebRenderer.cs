/*
    Copyright © Bryan Apellanes 2015
*/

namespace Bam.Presentation
{
    public interface IWebRenderer: ITemplateRenderer
    {
        string[] Extensions { get; set; }
        string ContentType { get; set; }
        Stream OutputStream { get; set; }
        void Render(object toRender);        
    }
}