/*
    Copyright © Bryan Apellanes 2015
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bam.Net.Presentation
{
    public interface IWebRenderer: ITemplateRenderer
    {
        string[] Extensions { get; set; }
        string ContentType { get; set; }
        Stream OutputStream { get; set; }
        void Render(object toRender);        
    }
}