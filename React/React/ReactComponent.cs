using System;

using System.Html;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Serialization;
using System.Diagnostics;

namespace ReactJs
{
   //[Imported, IgnoreNamespace]
   public class ReactComponent
   {
      [InlineCode("{this}.getDOMNode()")]                         public System.Html.Element getDOMNode() { return null; }
      [InlineCode("{this}.setProps({nextProps})")]                public void setProps(object nextProps) {}
      [InlineCode("{this}.replaceProps({nextProps})")]            public void replaceProps(object nextProps) {}
      [InlineCode("{this}.transferPropsTo({targetComponent})")]   public ReactComponent transferPropsTo(ReactComponent targetComponent) { return null; }
      [InlineCode("{this}.setState({nextState})")]                public void setState(object nextState) {}
      [InlineCode("{this}.setState({nextState},{callback})")]     public void setState(object nextState, Action callback) {}
      [InlineCode("{this}.replaceState({nextState})")]            public void replaceState(object nextState) {}
      [InlineCode("{this}.replaceState({nextState},{callback})")] public void replaceState(object nextState, Action callback) {}
      [InlineCode("{this}.forceUpdate()")]                        public void forceUpdate() {}
      [InlineCode("{this}.forceUpdate({callback})")]              public void forceUpdate(Action callback) {}
      [InlineCode("{this}.isMounted()")]                          public bool isMounted() { return false; }

      public Props Prop { [InlineCode("{}")] get { return new Props{}; } }
      public dynamic state { [InlineCode("{this}.state")] get { return null; } }   // state is immutable   
      public dynamic props { [InlineCode("{this}.props")] get { return null; } }   // props are immutable  
      public object State { [InlineCode("{this}.state")] get { return null; } }   // state is immutable   
      public object Props { [InlineCode("{this}.props")] get { return null; } }   // props are immutable  

      [InlineCode("React.DOM.a             ({props})")] public static ReactComponent a                  (object props) { return null; }
      [InlineCode("React.DOM.abbr          ({props})")] public static ReactComponent abbr               (object props) { return null; }
      [InlineCode("React.DOM.address       ({props})")] public static ReactComponent address            (object props) { return null; }
      [InlineCode("React.DOM.area          ({props})")] public static ReactComponent area               (object props) { return null; }
      [InlineCode("React.DOM.article       ({props})")] public static ReactComponent article            (object props) { return null; }
      [InlineCode("React.DOM.aside         ({props})")] public static ReactComponent aside              (object props) { return null; }
      [InlineCode("React.DOM.audio         ({props})")] public static ReactComponent audio              (object props) { return null; }
      [InlineCode("React.DOM.b             ({props})")] public static ReactComponent b                  (object props) { return null; }
      [InlineCode("React.DOM.base          ({props})")] public static ReactComponent Base               (object props) { return null; }
      [InlineCode("React.DOM.bdi           ({props})")] public static ReactComponent bdi                (object props) { return null; }
      [InlineCode("React.DOM.bdo           ({props})")] public static ReactComponent bdo                (object props) { return null; }
      [InlineCode("React.DOM.big           ({props})")] public static ReactComponent big                (object props) { return null; }
      [InlineCode("React.DOM.blockquote    ({props})")] public static ReactComponent blockquote         (object props) { return null; }
      [InlineCode("React.DOM.body          ({props})")] public static ReactComponent body               (object props) { return null; }
      [InlineCode("React.DOM.br            ({props})")] public static ReactComponent br                 (object props) { return null; }
      [InlineCode("React.DOM.button        ({props})")] public static ReactComponent button             (object props) { return null; }
      [InlineCode("React.DOM.canvas        ({props})")] public static ReactComponent canvas             (object props) { return null; }
      [InlineCode("React.DOM.caption       ({props})")] public static ReactComponent caption            (object props) { return null; }
      [InlineCode("React.DOM.cite          ({props})")] public static ReactComponent cite               (object props) { return null; }
      [InlineCode("React.DOM.code          ({props})")] public static ReactComponent code               (object props) { return null; }
      [InlineCode("React.DOM.col           ({props})")] public static ReactComponent col                (object props) { return null; }
      [InlineCode("React.DOM.colgroup      ({props})")] public static ReactComponent colgroup           (object props) { return null; }
      [InlineCode("React.DOM.data          ({props})")] public static ReactComponent data               (object props) { return null; }
      [InlineCode("React.DOM.datalist      ({props})")] public static ReactComponent datalist           (object props) { return null; }
      [InlineCode("React.DOM.dd            ({props})")] public static ReactComponent dd                 (object props) { return null; }
      [InlineCode("React.DOM.del           ({props})")] public static ReactComponent del                (object props) { return null; }
      [InlineCode("React.DOM.details       ({props})")] public static ReactComponent details            (object props) { return null; }
      [InlineCode("React.DOM.dfn           ({props})")] public static ReactComponent dfn                (object props) { return null; }
      [InlineCode("React.DOM.div           ({props})")] public static ReactComponent div                (object props) { return null; }
      [InlineCode("React.DOM.dl            ({props})")] public static ReactComponent dl                 (object props) { return null; }
      [InlineCode("React.DOM.dt            ({props})")] public static ReactComponent dt                 (object props) { return null; }
      [InlineCode("React.DOM.em            ({props})")] public static ReactComponent em                 (object props) { return null; }
      [InlineCode("React.DOM.embed         ({props})")] public static ReactComponent embed              (object props) { return null; }
      [InlineCode("React.DOM.fieldset      ({props})")] public static ReactComponent fieldset           (object props) { return null; }
      [InlineCode("React.DOM.figcaption    ({props})")] public static ReactComponent figcaption         (object props) { return null; }
      [InlineCode("React.DOM.figure        ({props})")] public static ReactComponent figure             (object props) { return null; }
      [InlineCode("React.DOM.footer        ({props})")] public static ReactComponent footer             (object props) { return null; }
      [InlineCode("React.DOM.form          ({props})")] public static ReactComponent form               (object props) { return null; }
      [InlineCode("React.DOM.h1            ({props})")] public static ReactComponent h1                 (object props) { return null; }
      [InlineCode("React.DOM.h2            ({props})")] public static ReactComponent h2                 (object props) { return null; }
      [InlineCode("React.DOM.h3            ({props})")] public static ReactComponent h3                 (object props) { return null; }
      [InlineCode("React.DOM.h4            ({props})")] public static ReactComponent h4                 (object props) { return null; }
      [InlineCode("React.DOM.h5            ({props})")] public static ReactComponent h5                 (object props) { return null; }
      [InlineCode("React.DOM.h6            ({props})")] public static ReactComponent h6                 (object props) { return null; }
      [InlineCode("React.DOM.head          ({props})")] public static ReactComponent head               (object props) { return null; }
      [InlineCode("React.DOM.header        ({props})")] public static ReactComponent header             (object props) { return null; }
      [InlineCode("React.DOM.hr            ({props})")] public static ReactComponent hr                 (object props) { return null; }
      [InlineCode("React.DOM.html          ({props})")] public static ReactComponent html               (object props) { return null; }
      [InlineCode("React.DOM.i             ({props})")] public static ReactComponent i                  (object props) { return null; }
      [InlineCode("React.DOM.iframe        ({props})")] public static ReactComponent iframe             (object props) { return null; }
      [InlineCode("React.DOM.img           ({props})")] public static ReactComponent img                (object props) { return null; }
      [InlineCode("React.DOM.input         ({props})")] public static ReactComponent input              (object props) { return null; }
      [InlineCode("React.DOM.ins           ({props})")] public static ReactComponent ins                (object props) { return null; }
      [InlineCode("React.DOM.kbd           ({props})")] public static ReactComponent kbd                (object props) { return null; }
      [InlineCode("React.DOM.keygen        ({props})")] public static ReactComponent keygen             (object props) { return null; }
      [InlineCode("React.DOM.label         ({props})")] public static ReactComponent label              (object props) { return null; }
      [InlineCode("React.DOM.legend        ({props})")] public static ReactComponent legend             (object props) { return null; }
      [InlineCode("React.DOM.li            ({props})")] public static ReactComponent li                 (object props) { return null; }
      [InlineCode("React.DOM.link          ({props})")] public static ReactComponent link               (object props) { return null; }
      [InlineCode("React.DOM.main          ({props})")] public static ReactComponent main               (object props) { return null; }
      [InlineCode("React.DOM.map           ({props})")] public static ReactComponent map                (object props) { return null; }
      [InlineCode("React.DOM.mark          ({props})")] public static ReactComponent mark               (object props) { return null; }
      [InlineCode("React.DOM.menu          ({props})")] public static ReactComponent menu               (object props) { return null; }
      [InlineCode("React.DOM.menuitem      ({props})")] public static ReactComponent menuitem           (object props) { return null; }
      [InlineCode("React.DOM.meta          ({props})")] public static ReactComponent meta               (object props) { return null; }
      [InlineCode("React.DOM.meter         ({props})")] public static ReactComponent meter              (object props) { return null; }
      [InlineCode("React.DOM.nav           ({props})")] public static ReactComponent nav                (object props) { return null; }
      [InlineCode("React.DOM.noscript      ({props})")] public static ReactComponent noscript           (object props) { return null; }
      [InlineCode("React.DOM.object        ({props})")] public static ReactComponent Object             (object props) { return null; }
      [InlineCode("React.DOM.ol            ({props})")] public static ReactComponent ol                 (object props) { return null; }
      [InlineCode("React.DOM.optgroup      ({props})")] public static ReactComponent optgroup           (object props) { return null; }
      [InlineCode("React.DOM.option        ({props})")] public static ReactComponent option             (object props) { return null; }
      [InlineCode("React.DOM.output        ({props})")] public static ReactComponent output             (object props) { return null; }
      [InlineCode("React.DOM.p             ({props})")] public static ReactComponent p                  (object props) { return null; }
      [InlineCode("React.DOM.param         ({props})")] public static ReactComponent param              (object props) { return null; }
      [InlineCode("React.DOM.pre           ({props})")] public static ReactComponent pre                (object props) { return null; }
      [InlineCode("React.DOM.progress      ({props})")] public static ReactComponent progress           (object props) { return null; }
      [InlineCode("React.DOM.q             ({props})")] public static ReactComponent q                  (object props) { return null; }
      [InlineCode("React.DOM.rp            ({props})")] public static ReactComponent rp                 (object props) { return null; }
      [InlineCode("React.DOM.rt            ({props})")] public static ReactComponent rt                 (object props) { return null; }
      [InlineCode("React.DOM.ruby          ({props})")] public static ReactComponent ruby               (object props) { return null; }
      [InlineCode("React.DOM.s             ({props})")] public static ReactComponent s                  (object props) { return null; }
      [InlineCode("React.DOM.samp          ({props})")] public static ReactComponent samp               (object props) { return null; }
      [InlineCode("React.DOM.script        ({props})")] public static ReactComponent script             (object props) { return null; }
      [InlineCode("React.DOM.section       ({props})")] public static ReactComponent section            (object props) { return null; }
      [InlineCode("React.DOM.select        ({props})")] public static ReactComponent select             (object props) { return null; }
      [InlineCode("React.DOM.small         ({props})")] public static ReactComponent small              (object props) { return null; }
      [InlineCode("React.DOM.source        ({props})")] public static ReactComponent source             (object props) { return null; }
      [InlineCode("React.DOM.span          ({props})")] public static ReactComponent span               (object props) { return null; }
      [InlineCode("React.DOM.strong        ({props})")] public static ReactComponent strong             (object props) { return null; }
      [InlineCode("React.DOM.style         ({props})")] public static ReactComponent style              (object props) { return null; }
      [InlineCode("React.DOM.sub           ({props})")] public static ReactComponent sub                (object props) { return null; }
      [InlineCode("React.DOM.summary       ({props})")] public static ReactComponent summary            (object props) { return null; }
      [InlineCode("React.DOM.sup           ({props})")] public static ReactComponent sup                (object props) { return null; }
      [InlineCode("React.DOM.table         ({props})")] public static ReactComponent table              (object props) { return null; }
      [InlineCode("React.DOM.tbody         ({props})")] public static ReactComponent tbody              (object props) { return null; }
      [InlineCode("React.DOM.td            ({props})")] public static ReactComponent td                 (object props) { return null; }
      [InlineCode("React.DOM.textarea      ({props})")] public static ReactComponent textarea           (object props) { return null; }
      [InlineCode("React.DOM.tfoot         ({props})")] public static ReactComponent tfoot              (object props) { return null; }
      [InlineCode("React.DOM.th            ({props})")] public static ReactComponent th                 (object props) { return null; }
      [InlineCode("React.DOM.thead         ({props})")] public static ReactComponent thead              (object props) { return null; }
      [InlineCode("React.DOM.time          ({props})")] public static ReactComponent time               (object props) { return null; }
      [InlineCode("React.DOM.title         ({props})")] public static ReactComponent title              (object props) { return null; }
      [InlineCode("React.DOM.tr            ({props})")] public static ReactComponent tr                 (object props) { return null; }
      [InlineCode("React.DOM.track         ({props})")] public static ReactComponent track              (object props) { return null; }
      [InlineCode("React.DOM.u             ({props})")] public static ReactComponent u                  (object props) { return null; }
      [InlineCode("React.DOM.ul            ({props})")] public static ReactComponent ul                 (object props) { return null; }
      [InlineCode("React.DOM.var           ({props})")] public static ReactComponent var                (object props) { return null; }
      [InlineCode("React.DOM.video         ({props})")] public static ReactComponent video              (object props) { return null; }
      [InlineCode("React.DOM.wbr           ({props})")] public static ReactComponent wbr                (object props) { return null; }
      [InlineCode("React.DOM.circle        ({props})")] public static ReactComponent circle             (object props) { return null; }
      [InlineCode("React.DOM.defs          ({props})")] public static ReactComponent defs               (object props) { return null; }
      [InlineCode("React.DOM.g             ({props})")] public static ReactComponent g                  (object props) { return null; }
      [InlineCode("React.DOM.line          ({props})")] public static ReactComponent line               (object props) { return null; }
      [InlineCode("React.DOM.linearGradient({props})")] public static ReactComponent linearGradient     (object props) { return null; }
      [InlineCode("React.DOM.path          ({props})")] public static ReactComponent path               (object props) { return null; }
      [InlineCode("React.DOM.polygon       ({props})")] public static ReactComponent polygon            (object props) { return null; }
      [InlineCode("React.DOM.polyline      ({props})")] public static ReactComponent polyline           (object props) { return null; }
      [InlineCode("React.DOM.radialGradient({props})")] public static ReactComponent radialGradient     (object props) { return null; }
      [InlineCode("React.DOM.rect          ({props})")] public static ReactComponent rect               (object props) { return null; }
      [InlineCode("React.DOM.stop          ({props})")] public static ReactComponent stop               (object props) { return null; }
      [InlineCode("React.DOM.svg           ({props})")] public static ReactComponent svg                (object props) { return null; }
      [InlineCode("React.DOM.text          ({props})")] public static ReactComponent text               (object props) { return null; }
      
      [ExpandParams] [InlineCode("React.DOM.a             ({props},{children})")] public static ReactComponent a                  (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.abbr          ({props},{children})")] public static ReactComponent abbr               (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.address       ({props},{children})")] public static ReactComponent address            (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.area          ({props},{children})")] public static ReactComponent area               (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.article       ({props},{children})")] public static ReactComponent article            (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.aside         ({props},{children})")] public static ReactComponent aside              (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.audio         ({props},{children})")] public static ReactComponent audio              (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.b             ({props},{children})")] public static ReactComponent b                  (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.base          ({props},{children})")] public static ReactComponent Base               (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.bdi           ({props},{children})")] public static ReactComponent bdi                (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.bdo           ({props},{children})")] public static ReactComponent bdo                (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.big           ({props},{children})")] public static ReactComponent big                (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.blockquote    ({props},{children})")] public static ReactComponent blockquote         (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.body          ({props},{children})")] public static ReactComponent body               (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.br            ({props},{children})")] public static ReactComponent br                 (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.button        ({props},{children})")] public static ReactComponent button             (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.canvas        ({props},{children})")] public static ReactComponent canvas             (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.caption       ({props},{children})")] public static ReactComponent caption            (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.cite          ({props},{children})")] public static ReactComponent cite               (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.code          ({props},{children})")] public static ReactComponent code               (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.col           ({props},{children})")] public static ReactComponent col                (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.colgroup      ({props},{children})")] public static ReactComponent colgroup           (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.data          ({props},{children})")] public static ReactComponent data               (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.datalist      ({props},{children})")] public static ReactComponent datalist           (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.dd            ({props},{children})")] public static ReactComponent dd                 (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.del           ({props},{children})")] public static ReactComponent del                (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.details       ({props},{children})")] public static ReactComponent details            (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.dfn           ({props},{children})")] public static ReactComponent dfn                (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.div           ({props},{children})")] public static ReactComponent div                (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.dl            ({props},{children})")] public static ReactComponent dl                 (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.dt            ({props},{children})")] public static ReactComponent dt                 (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.em            ({props},{children})")] public static ReactComponent em                 (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.embed         ({props},{children})")] public static ReactComponent embed              (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.fieldset      ({props},{children})")] public static ReactComponent fieldset           (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.figcaption    ({props},{children})")] public static ReactComponent figcaption         (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.figure        ({props},{children})")] public static ReactComponent figure             (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.footer        ({props},{children})")] public static ReactComponent footer             (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.form          ({props},{children})")] public static ReactComponent form               (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.h1            ({props},{children})")] public static ReactComponent h1                 (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.h2            ({props},{children})")] public static ReactComponent h2                 (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.h3            ({props},{children})")] public static ReactComponent h3                 (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.h4            ({props},{children})")] public static ReactComponent h4                 (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.h5            ({props},{children})")] public static ReactComponent h5                 (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.h6            ({props},{children})")] public static ReactComponent h6                 (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.head          ({props},{children})")] public static ReactComponent head               (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.header        ({props},{children})")] public static ReactComponent header             (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.hr            ({props},{children})")] public static ReactComponent hr                 (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.html          ({props},{children})")] public static ReactComponent html               (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.i             ({props},{children})")] public static ReactComponent i                  (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.iframe        ({props},{children})")] public static ReactComponent iframe             (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.img           ({props},{children})")] public static ReactComponent img                (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.input         ({props},{children})")] public static ReactComponent input              (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.ins           ({props},{children})")] public static ReactComponent ins                (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.kbd           ({props},{children})")] public static ReactComponent kbd                (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.keygen        ({props},{children})")] public static ReactComponent keygen             (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.label         ({props},{children})")] public static ReactComponent label              (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.legend        ({props},{children})")] public static ReactComponent legend             (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.li            ({props},{children})")] public static ReactComponent li                 (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.link          ({props},{children})")] public static ReactComponent link               (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.main          ({props},{children})")] public static ReactComponent main               (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.map           ({props},{children})")] public static ReactComponent map                (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.mark          ({props},{children})")] public static ReactComponent mark               (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.menu          ({props},{children})")] public static ReactComponent menu               (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.menuitem      ({props},{children})")] public static ReactComponent menuitem           (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.meta          ({props},{children})")] public static ReactComponent meta               (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.meter         ({props},{children})")] public static ReactComponent meter              (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.nav           ({props},{children})")] public static ReactComponent nav                (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.noscript      ({props},{children})")] public static ReactComponent noscript           (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.object        ({props},{children})")] public static ReactComponent Object             (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.ol            ({props},{children})")] public static ReactComponent ol                 (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.optgroup      ({props},{children})")] public static ReactComponent optgroup           (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.option        ({props},{children})")] public static ReactComponent option             (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.output        ({props},{children})")] public static ReactComponent output             (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.p             ({props},{children})")] public static ReactComponent p                  (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.param         ({props},{children})")] public static ReactComponent param              (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.pre           ({props},{children})")] public static ReactComponent pre                (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.progress      ({props},{children})")] public static ReactComponent progress           (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.q             ({props},{children})")] public static ReactComponent q                  (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.rp            ({props},{children})")] public static ReactComponent rp                 (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.rt            ({props},{children})")] public static ReactComponent rt                 (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.ruby          ({props},{children})")] public static ReactComponent ruby               (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.s             ({props},{children})")] public static ReactComponent s                  (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.samp          ({props},{children})")] public static ReactComponent samp               (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.script        ({props},{children})")] public static ReactComponent script             (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.section       ({props},{children})")] public static ReactComponent section            (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.select        ({props},{children})")] public static ReactComponent select             (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.small         ({props},{children})")] public static ReactComponent small              (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.source        ({props},{children})")] public static ReactComponent source             (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.span          ({props},{children})")] public static ReactComponent span               (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.strong        ({props},{children})")] public static ReactComponent strong             (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.style         ({props},{children})")] public static ReactComponent style              (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.sub           ({props},{children})")] public static ReactComponent sub                (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.summary       ({props},{children})")] public static ReactComponent summary            (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.sup           ({props},{children})")] public static ReactComponent sup                (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.table         ({props},{children})")] public static ReactComponent table              (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.tbody         ({props},{children})")] public static ReactComponent tbody              (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.td            ({props},{children})")] public static ReactComponent td                 (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.textarea      ({props},{children})")] public static ReactComponent textarea           (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.tfoot         ({props},{children})")] public static ReactComponent tfoot              (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.th            ({props},{children})")] public static ReactComponent th                 (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.thead         ({props},{children})")] public static ReactComponent thead              (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.time          ({props},{children})")] public static ReactComponent time               (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.title         ({props},{children})")] public static ReactComponent title              (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.tr            ({props},{children})")] public static ReactComponent tr                 (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.track         ({props},{children})")] public static ReactComponent track              (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.u             ({props},{children})")] public static ReactComponent u                  (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.ul            ({props},{children})")] public static ReactComponent ul                 (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.var           ({props},{children})")] public static ReactComponent var                (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.video         ({props},{children})")] public static ReactComponent video              (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.wbr           ({props},{children})")] public static ReactComponent wbr                (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.circle        ({props},{children})")] public static ReactComponent circle             (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.defs          ({props},{children})")] public static ReactComponent defs               (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.g             ({props},{children})")] public static ReactComponent g                  (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.line          ({props},{children})")] public static ReactComponent line               (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.linearGradient({props},{children})")] public static ReactComponent linearGradient     (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.path          ({props},{children})")] public static ReactComponent path               (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.polygon       ({props},{children})")] public static ReactComponent polygon            (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.polyline      ({props},{children})")] public static ReactComponent polyline           (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.radialGradient({props},{children})")] public static ReactComponent radialGradient     (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.rect          ({props},{children})")] public static ReactComponent rect               (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.stop          ({props},{children})")] public static ReactComponent stop               (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.svg           ({props},{children})")] public static ReactComponent svg                (object props, params object[] children) { return null; }
      [ExpandParams] [InlineCode("React.DOM.text          ({props},{children})")] public static ReactComponent text               (object props, params object[] children) { return null; }      
   }  

   public interface IReactComponent
   {
      object getInitialState();
      object getDefaultProps();
      ReactComponent render();
      //object propTypes;
      //object[] mixins;
      //object statics;
      //string displayName;
      void componentWillMount();
      void componentDidMount();
      void componentWillReceiveProps(object nextProps);
      bool shouldComponentUpdate(object nextProps, object nextState);
      void componentWillUpdate(object nextProps, object nextState);
      void componentDidUpdate(object prevProps, object prevState);
      void componentWillUnmount();
   }      
}






