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
                   
      [InlineCode("{$ReactJs.ReactHelper}.CreateComponent({T}).call(null)")] 
      public static ReactComponent createComponent<T>() { return null; }
      
      /*               public extern static ReactElement createElement(string type);
                     public extern static ReactElement createElement(string type, object props);
      [ExpandParams] public extern static ReactElement createElement(string type, object props, params object[] children);
                     
                     public extern static ReactElement createElement(ReactComponent type);
                     public extern static ReactElement createElement(ReactComponent type, object props);
      [ExpandParams] public extern static ReactElement createElement(ReactComponent type, object props, params object[] children);  */

                     [InlineCode("React.createElement({T}._factory)")]                public extern static ReactElement createElement<T>();
                     [InlineCode("React.createElement({T}._factory,props)")]          public extern static ReactElement createElement<T>(object props);
      [ExpandParams] [InlineCode("React.createElement({T}._factory,props,children)")] public extern static ReactElement createElement<T>(object props, params object[] children);

      [InlineCode("React.render({component},{container})")]
      public static ReactElement render(ReactElement component, System.Html.Element container) { return null; }
      
      [InlineCode("React.render({component},{container},{callback})")]
      public static ReactElement render(ReactElement component, System.Html.Element container, Action callback) { return null; }

      public static bool unmountComponentAtNode(System.Html.Element container) { return false; }      

      public static extern string renderToString(ReactElement component);
      public static extern string renderToStaticMarkup(ReactElement component);
      public static extern bool isValidElement(object ob);     

      // TODO PropTypes      
   }

   [Imported, IgnoreNamespace]
   public class Children
   {
      public static object map(object children, Action fn) { return null; }
      public static object map(object children, Action<object> fn){ return null; }
      public static object map(object children, Action fn, object context) { return null; }
      public static object map(object children, Action<object> fn, object context) { return null; }
      
      public static void forEach(object children, Action fn) {  }
      public static void forEach(object children, Action<object> fn){  }
      public static void forEach(object children, Action fn, object context) {  }
      public static void forEach(object children, Action<object> fn, object context) {  }

      public extern int count { [InlineCode("{this}.count")] get; } 
      
      public static object only(object children) { return null; }
   }

   [Imported, IgnoreNamespace]
   public class DOM
   {
      [InlineCode("React.DOM.{@tagname}()")]        public object Element(string tagname) { return null; }
      [InlineCode("React.DOM.{@tagname}({props})")] public object Element(string tagname, object props) { return null; }
      
      [ExpandParams] [InlineCode("React.DOM.{@tagname}({props},{children})")] 
      public object Element(string tagname, object props, params object[] children) { return null; }      
   }     
}






