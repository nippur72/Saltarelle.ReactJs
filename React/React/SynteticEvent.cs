using System;

using System.Html;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Serialization;
using System.Diagnostics;

namespace ReactJs
{
  [Imported] public class DOMDataTransfer {}
  [Imported] public class DOMEventTarget {}
  [Imported] public class DOMEvent {}
  [Imported] public class DOMTouchList {}
  [Imported] public class DOMAbstractView {}
    
  [Imported] public class SyntheticEvent
  {
      public bool bubbles;
      public bool cancelable;
      public DOMEventTarget currentTarget;
      public bool defaultPrevented;
      public int  eventPhase;
      public bool isTrusted;
      public DOMEvent nativeEvent;
      public void preventDefault() {}
      public void stopPropagation() {}
      public DOMEventTarget target;
      public JsDate timeStam;
      public String type;
  }

  [Imported] public class ClipboardEvent : SyntheticEvent
  {
      public DOMDataTransfer clipboardData;
  }

  [Imported] public class KeyboardEvent : SyntheticEvent
  {
      public bool altKey;
      public bool ctrlKey;
      public int charCode;
      public String key;
      public int keyCode;
      public String locale;
      public int location;
      public bool metaKey;
      public bool repeat;
      public bool shiftKey;
      public int which;
  }

   [Imported] public class FocusEvent : SyntheticEvent
   {
      public DOMEventTarget relatedTarget;
   }

   [Imported] public class FormEvent : SyntheticEvent
   {      
   }

   [Imported] public class MouseEvent : SyntheticEvent
   {
      public bool altKey                   ;
      public int button                    ;
      public int buttons                   ;
      public double clientX                ;
      public double clientY                ;
      public bool ctrlKey                  ;
      public bool metaKey                  ;
      public double pageX                  ;
      public double pageY                  ;
      public DOMEventTarget relatedTarget  ;
      public double screenX                ;
      public double screenY                ;
      public bool shiftKey                 ;
   }

   [Imported] public class TouchEvent : SyntheticEvent
   {
      public bool altKey;
      public DOMTouchList changedTouches;
      public bool ctrlKey;
      public bool metaKey;
      public bool shiftKey;
      public DOMTouchList targetTouches;
      public DOMTouchList touches;
   }

   [Imported] public class UIEvent : SyntheticEvent
   {
      public int detail;
      public DOMAbstractView view;
   }

   [Imported] public class WheelEvent : SyntheticEvent
   {
      public double deltaX;
      public double deltaMode;
      public double deltaY;
      public double deltaZ;
   }
}






