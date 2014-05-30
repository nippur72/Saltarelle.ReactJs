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
      // looks for the element that will host the main react view
      var reactview = Document.GetElementById("reactview");      
      
      // render the component: here ButtonCounter is instantiated by a custom static 
      // constructor named "New" and defined in the ButtonCounter class
      React.renderComponent(ButtonCounter.New("Someone"), reactview);       

      // alternatively react components can be instantiated with the general 
      // static constructor, e.g.:
      // var but = React.createClass<ButtonCounter>();
      // React.renderComponent(but.New(new {name="Someone"}), reactview);       
   }    
}







