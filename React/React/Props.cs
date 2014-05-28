using System;

using System.Html;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Serialization;
using System.Diagnostics;

namespace ReactJs
{
   public sealed class Props
   {
      [InlineCode("{}")] public Props() {}

      public object accept;               //
      public object accessKey;            //
      public object action;               //
      public object allowFullScreen;      //  MUST_USE_ATTRIBUTE | HAS_BOOLEAN_VALUE,
      public object allowTransparency;    //  MUST_USE_ATTRIBUTE,
      public object alt;                  //  null,
      public object async;                //  HAS_BOOLEAN_VALUE,
      public object autoComplete;         //  null,

                                          // autoFocus is polyfilled/normalized by AutoFocusMixin
                                          // autoFocus    //  HAS_BOOLEAN_VALUE,

      public object autoPlay;             //  HAS_BOOLEAN_VALUE,
      public object cellPadding;          //  null,
      public object cellSpacing;          //  null,
      public object charSet;              //  MUST_USE_ATTRIBUTE,
      [ScriptName("checked")]
      public object Checked;              //  MUST_USE_PROPERTY | HAS_BOOLEAN_VALUE,
      public object className;            //  MUST_USE_PROPERTY,
      public object cols;                 //  MUST_USE_ATTRIBUTE | HAS_POSITIVE_NUMERIC_VALUE,
      public object colSpan;              //  null,
      public object content;              //  null,
      public object contentEditable;      //  null,
      public object contextMenu;          //  MUST_USE_ATTRIBUTE,
      public object controls;             //  MUST_USE_PROPERTY | HAS_BOOLEAN_VALUE,
      public object crossOrigin;          //  null,
      public object data;                 //  null, // For `<object />` acts as `src`.
      public object dateTime;             //  MUST_USE_ATTRIBUTE,
      public object defer;                //  HAS_BOOLEAN_VALUE,
      public object dir;                  //  null,
      public object disabled;             //  MUST_USE_ATTRIBUTE | HAS_BOOLEAN_VALUE,
      public object download;             //  null,
      public object draggable;            //  null,
      public object encType;              //  null,
      public object form;                 //  MUST_USE_ATTRIBUTE,
      public object formNoValidate;       //  HAS_BOOLEAN_VALUE,
      public object frameBorder;          //  MUST_USE_ATTRIBUTE,
      public object height;               //  MUST_USE_ATTRIBUTE,
      public object hidden;               //  MUST_USE_ATTRIBUTE | HAS_BOOLEAN_VALUE,
      public object href;                 //  null,
      public object hrefLang;             //  null,
      public object htmlFor;              //  null,
      public object httpEquiv;            //  null,
      public object icon;                 //  null,
      public object id;                   //  MUST_USE_PROPERTY,
      public object label;                //  null,
      public object lang;                 //  null,
      public object list;                 //  null,
      public object loop;                 //  MUST_USE_PROPERTY | HAS_BOOLEAN_VALUE,
      public object max;                  //  null,
      public object maxLength;            //  MUST_USE_ATTRIBUTE,
      public object mediaGroup;           //  null,
      public object method;               //  null,
      public object min;                  //  null,
      public object multiple;             //  MUST_USE_PROPERTY | HAS_BOOLEAN_VALUE,
      public object muted;                //  MUST_USE_PROPERTY | HAS_BOOLEAN_VALUE,
      public object name;                 //  null,
      public object noValidate;           //  HAS_BOOLEAN_VALUE,
      public object pattern;              //  null,
      public object placeholder;          //  null,
      public object poster;               //  null,
      public object preload;              //  null,
      public object radioGroup;           //  null,
      public object readOnly;             //  MUST_USE_PROPERTY | HAS_BOOLEAN_VALUE,
      public object rel;                  //  null,
      public object required;             //  HAS_BOOLEAN_VALUE,
      public object role;                 //  MUST_USE_ATTRIBUTE,
      public object rows;                 //  MUST_USE_ATTRIBUTE | HAS_POSITIVE_NUMERIC_VALUE,
      public object rowSpan;              //  null,
      public object sandbox;              //  null,
      public object scope;                //  null,
      public object scrollLeft;           //  MUST_USE_PROPERTY,
      public object scrollTop;            //  MUST_USE_PROPERTY,
      public object seamless;             //  MUST_USE_ATTRIBUTE | HAS_BOOLEAN_VALUE,
      public object selected;             //  MUST_USE_PROPERTY | HAS_BOOLEAN_VALUE,
      public object size;                 //  MUST_USE_ATTRIBUTE | HAS_POSITIVE_NUMERIC_VALUE,
      public object span;                 //  HAS_POSITIVE_NUMERIC_VALUE,
      public object spellCheck;           //  null,
      public object src;                  //  null,
      public object srcDoc;               //  MUST_USE_PROPERTY,
      public object srcSet;               //  null,
      public object step;                 //  null,
      public JsDictionary style;                //  null,
      public object tabIndex;             //  null,
      public object target;               //  null,
      public object title;                //  null,
      public object type;                 //  null,
      public object value;                //  MUST_USE_PROPERTY | HAS_SIDE_EFFECTS,
      public object width;                //  MUST_USE_ATTRIBUTE,
      public object wmode;                //  MUST_USE_ATTRIBUTE,
                                       
      // Non-standard Properties       

      public object autoCapitalize;       //  null, // Supported in Mobile Safari for keyboard hints
      public object autoCorrect;          //  null, // Supported in Mobile Safari for keyboard hints
      public object property;             //  null, // Supports OG in meta tags

      // SVG Properties
      
      public object cx;                   //  MUST_USE_ATTRIBUTE,
      public object cy;                   //  MUST_USE_ATTRIBUTE,
      public object d;                    //  MUST_USE_ATTRIBUTE,
      public object fill;                 //  MUST_USE_ATTRIBUTE,
      public object fx;                   //  MUST_USE_ATTRIBUTE,
      public object fy;                   //  MUST_USE_ATTRIBUTE,
      public object gradientTransform;    //  MUST_USE_ATTRIBUTE,
      public object gradientUnits;        //  MUST_USE_ATTRIBUTE,
      public object offset;               //  MUST_USE_ATTRIBUTE,
      public object points;               //  MUST_USE_ATTRIBUTE,
      public object r;                    //  MUST_USE_ATTRIBUTE,
      public object rx;                   //  MUST_USE_ATTRIBUTE,
      public object ry;                   //  MUST_USE_ATTRIBUTE,
      public object spreadMethod;         //  MUST_USE_ATTRIBUTE,
      public object stopColor;            //  MUST_USE_ATTRIBUTE,
      public object stopOpacity;          //  MUST_USE_ATTRIBUTE,
      public object stroke;               //  MUST_USE_ATTRIBUTE,
      public object strokeLinecap;        //  MUST_USE_ATTRIBUTE,
      public object strokeWidth;          //  MUST_USE_ATTRIBUTE,
      public object textAnchor;           //  MUST_USE_ATTRIBUTE,
      public object transform;            //  MUST_USE_ATTRIBUTE,
      public object version;              //  MUST_USE_ATTRIBUTE,
      public object viewBox;              //  MUST_USE_ATTRIBUTE,
      public object x1;                   //  MUST_USE_ATTRIBUTE,
      public object x2;                   //  MUST_USE_ATTRIBUTE,
      public object x;                    //  MUST_USE_ATTRIBUTE,
      public object y1;                   //  MUST_USE_ATTRIBUTE,
      public object y2;                   //  MUST_USE_ATTRIBUTE,
      public object y;                    //  MUST_USE_ATTRIBUTE                 
   }
}






