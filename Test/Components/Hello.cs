using System;

using System.Html;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Serialization;
using System.Diagnostics;

using ReactJs;

// example of a very simple component: it does nothing, it's just a <div> with some text

public class Hello : ReactElement
{
   public object render()
   {
      return div("this is an item made from a component named 'hello'");
   }
}  
   







