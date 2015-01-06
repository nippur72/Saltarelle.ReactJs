using System;

using System.Html;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Serialization;
using System.Diagnostics;

using ReactJs;

public class TestDemo
{
   public static void Main()
   {                    
      // register components within React      
      /*Hello._factory         =*/ React.createComponent<Hello>();      
      /*ButtonCounter._factory =*/ React.createComponent<ButtonCounter>();              

      // render into main view      
      var reactview = Document.GetElementById("reactview");      
      React.render(React.createElement<ButtonCounter>(), reactview);       
   }    
}







