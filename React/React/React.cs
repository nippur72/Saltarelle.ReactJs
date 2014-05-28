using System;

using System.Html;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Serialization;
using System.Diagnostics;

namespace ReactJs
{
   [Imported, IgnoreNamespace]
   public class React
   {
      public static Children Children;
      public static DOM DOM;

      public static void initializeTouchEvents(bool shouldUseTouch) {}                      
                   
      [InlineCode("{$ReactJs.ReactHelper}.CreateClass({T}).call(null)")] 
      public static ReactClass createClass<T>() { return null; }

      [InlineCode("React.renderComponent({component},{container})")]
      public static ReactComponent renderComponent(ReactComponent component, System.Html.Element container) { return null; }
      
      [InlineCode("React.renderComponent({component},{container},{callback})")]
      public static ReactComponent renderComponent(ReactComponent component, System.Html.Element container, Action callback) { return null; }

      public static bool unmountComponentAtNode(System.Html.Element container) { return false; }

      public static string renderComponentToString(ReactComponent component) { return null; }
      public static string renderComponentToStaticMarkup(ReactComponent component) { return null; }
   }

   [Imported, IgnoreNamespace]
   public class Children
   {
      static object map(object children, Action fn) { return null; }
      static object map(object children, Action<object> fn){ return null; }
      static object map(object children, Action fn, object context) { return null; }
      static object map(object children, Action<object> fn, object context) { return null; }
      
      static void forEach(object children, Action fn) {  }
      static void forEach(object children, Action<object> fn){  }
      static void forEach(object children, Action fn, object context) {  }
      static void forEach(object children, Action<object> fn, object context) {  }
      
      static object only(object children) { return null; }
   }

   [Imported, IgnoreNamespace]
   public class DOM
   {
      [InlineCode("React.DOM.{@tagname}()")]                   public object Element(string tagname) { return null; }
      [InlineCode("React.DOM.{@tagname}({props})")]            public object Element(string tagname, object props) { return null; }
      
      [ExpandParams] [InlineCode("React.DOM.{@tagname}({props},{children})")] 
      public object Element(string tagname, object props, params object[] children) { return null; }      
   }     
}






