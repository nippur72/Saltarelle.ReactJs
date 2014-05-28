using System;

using System.Html;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Serialization;
using System.Reflection;
using System.Diagnostics;

namespace ReactJs
{         
   public static class TypeExtensionMethods
   {
      public static List<string> GetInstanceMethodNames(this Type type)
      {
         List<string> result = new List<string>();
         foreach(string key in type.Prototype.Keys)
         {
            if(key!="constructor") result.Add(key);
         }   
         return result;
      }          
   }

   public static class ObjectExtensionMethods
   {
      [InlineCode("{ob}")]
      public static T As<T>(this object ob) { return default(T); }      
   }
}

