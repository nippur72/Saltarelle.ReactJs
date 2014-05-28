using System;

using System.Html;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Serialization;
using System.Diagnostics;

namespace ReactJs
{
   public static class PropsExtensions
   {
      // define an easy cast-to operator
      [InlineCode("{prop}")] public static T CastAs<T>(this Props prop) { return default(T); }  
      
      //Clipboard Events    
      public static Props onCopy                 (this Props props, Action<ClipboardEvent> callback) { props.CastAs<dynamic>().onCopy            = callback; return props; }
      public static Props onCut                  (this Props props, Action<ClipboardEvent> callback) { props.CastAs<dynamic>().onCut             = callback; return props; }
      public static Props onPaste                (this Props props, Action<ClipboardEvent> callback) { props.CastAs<dynamic>().onPaste           = callback; return props; }
 
      // Keyboard Events    
      public static Props onKeyDown              (this Props props, Action<KeyboardEvent> callback) { props.CastAs<dynamic>().onKeyDown          = callback; return props; }
      public static Props onKeyPress             (this Props props, Action<KeyboardEvent> callback) { props.CastAs<dynamic>().onKeyPress         = callback; return props; }
      public static Props onKeyUp                (this Props props, Action<KeyboardEvent> callback) { props.CastAs<dynamic>().onKeyUp            = callback; return props; }
 
      // Focus Events       
      public static Props onFocus                (this Props props, Action<FocusEvent> callback) { props.CastAs<dynamic>().onFocus               = callback; return props; }
      public static Props onBlur                 (this Props props, Action<FocusEvent> callback) { props.CastAs<dynamic>().onBlur                = callback; return props; }
 
      // Form Events        
      public static Props onChange               (this Props props, Action<FormEvent> callback) { props.CastAs<dynamic>().onChange               = callback; return props; }
      public static Props onInput                (this Props props, Action<FormEvent> callback) { props.CastAs<dynamic>().onInput                = callback; return props; }
      public static Props onSubmit               (this Props props, Action<FormEvent> callback) { props.CastAs<dynamic>().onSubmit               = callback; return props; }
 
      // Mouse Events       
      public static Props onClick                (this Props props, Action<MouseEvent> callback) { props.CastAs<dynamic>().onClick               = callback; return props; }
      public static Props onDoubleClick          (this Props props, Action<MouseEvent> callback) { props.CastAs<dynamic>().onDoubleClick         = callback; return props; }
      public static Props onDrag                 (this Props props, Action<MouseEvent> callback) { props.CastAs<dynamic>().onDrag                = callback; return props; }
      public static Props onDragEnd              (this Props props, Action<MouseEvent> callback) { props.CastAs<dynamic>().onDragEnd             = callback; return props; }
      public static Props onDragEnter            (this Props props, Action<MouseEvent> callback) { props.CastAs<dynamic>().onDragEnter           = callback; return props; }
      public static Props onDragExit             (this Props props, Action<MouseEvent> callback) { props.CastAs<dynamic>().onDragExit            = callback; return props; }
      public static Props onDragLeave            (this Props props, Action<MouseEvent> callback) { props.CastAs<dynamic>().onDragLeave           = callback; return props; }
      public static Props onDragOver             (this Props props, Action<MouseEvent> callback) { props.CastAs<dynamic>().onDragOver            = callback; return props; }
      public static Props onDragStart            (this Props props, Action<MouseEvent> callback) { props.CastAs<dynamic>().onDragStart           = callback; return props; }
      public static Props onDrop                 (this Props props, Action<MouseEvent> callback) { props.CastAs<dynamic>().onDrop                = callback; return props; }
      public static Props onMouseDown            (this Props props, Action<MouseEvent> callback) { props.CastAs<dynamic>().onMouseDown           = callback; return props; }
      public static Props onMouseEnter           (this Props props, Action<MouseEvent> callback) { props.CastAs<dynamic>().onMouseEnter          = callback; return props; }
      public static Props onMouseLeave           (this Props props, Action<MouseEvent> callback) { props.CastAs<dynamic>().onMouseLeave          = callback; return props; }
      public static Props onMouseMove            (this Props props, Action<MouseEvent> callback) { props.CastAs<dynamic>().onMouseMove           = callback; return props; }
      public static Props onMouseOut             (this Props props, Action<MouseEvent> callback) { props.CastAs<dynamic>().onMouseOut            = callback; return props; }
      public static Props onMouseOver            (this Props props, Action<MouseEvent> callback) { props.CastAs<dynamic>().onMouseOver           = callback; return props; }
      public static Props onMouseUp              (this Props props, Action<MouseEvent> callback) { props.CastAs<dynamic>().onMouseUp             = callback; return props; }
 
      // Touch events        
      public static Props onTouchCancel          (this Props props, Action<TouchEvent> callback) { props.CastAs<dynamic>().onTouchCancel         = callback; return props; }
      public static Props onTouchEnd             (this Props props, Action<TouchEvent> callback) { props.CastAs<dynamic>().onTouchEnd            = callback; return props; }
      public static Props onTouchMove            (this Props props, Action<TouchEvent> callback) { props.CastAs<dynamic>().onTouchMove           = callback; return props; }
      public static Props onTouchStart           (this Props props, Action<TouchEvent> callback) { props.CastAs<dynamic>().onTouchStart          = callback; return props; }      
 
      // UI Events          
      public static Props onScroll               (this Props props, Action<UIEvent> callback) { props.CastAs<dynamic>().onScroll                 = callback; return props; }
 
      // Wheel Events       
      public static Props onWheel                (this Props props, Action<WheelEvent> callback) { props.CastAs<dynamic>().onWheel               = callback; return props; }
 }                                                                                                                                      
}






