using System;

using System.Html;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Serialization;
using System.Diagnostics;

namespace ReactJs
{
   public class ReactHelper
   {     
      public static ReactClass CreateClass<T>()
      {         
         Type type = typeof(T);
        
         string body = "var $ob = {}; var $type="+type.FullName+";";

         var methods = type.GetInstanceMethodNames(); 

         string getInitialState = "getInitialState";
                          
         if(!methods.Contains(getInitialState))
         {
            // if user did not specify a getInitialState, provide an empty one
            body += string.Format("$ob.{0}=(function() {{ $type.apply(this); return {{ }}; }});",getInitialState);   
         }
         else
         {
            body += string.Format("$ob.{0}=(function() {{ $type.apply(this); return $type.prototype.{0}(); }});",getInitialState);
         }

         methods.Remove(getInitialState);

         foreach(var method in methods)
         {
            body += string.Format("$ob.{0}=$type.prototype.{0};",method);
         }

         body += "return $ob;";
         
         // TODO statics

         // TODO field and properties
          
         Function F = new Function("",body);
         var defob = F.Call(null);

         return createClass(defob);
      }

      [InlineCode("React.createClass({definition})")]
      public static ReactClass createClass(object definition) { return null; }
   }
}






