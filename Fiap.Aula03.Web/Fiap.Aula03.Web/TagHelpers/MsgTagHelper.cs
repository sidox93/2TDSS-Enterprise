using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula03.Web.TagHelpers
{
    public class MsgTagHelper : TagHelper
    {
        public string Texto { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //valida se o texto não está vazio ou null
            if (!string.IsNullOrEmpty(Texto)) 
            {
                output.TagName = "div"; //nome da tag que será criada
                output.Attributes.SetAttribute("class", "alert alert-success"); //seta atributos da tag
                output.Content.SetContent(Texto); //seta o conteúdo da tag
            }
        }
    }
}
