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

      [InlineCode("{s}")] public static implicit operator ReactComponent(string s) { return null; }
      [InlineCode("{s}")] public static implicit operator ReactComponent(int s)    { return null; }
      [InlineCode("{s}")] public static implicit operator ReactComponent(double s) { return null; }
      [InlineCode("{s}")] public static implicit operator ReactComponent(List<ReactComponent> s) { return null; }
      [InlineCode("{s}")] public static implicit operator ReactComponent(ReactComponent[] s) { return null; }

      [InlineCode("React.DOM.a             ({props})")] public static ReactComponent a                  (Props props) { return null; }
      [InlineCode("React.DOM.abbr          ({props})")] public static ReactComponent abbr               (Props props) { return null; }
      [InlineCode("React.DOM.address       ({props})")] public static ReactComponent address            (Props props) { return null; }
      [InlineCode("React.DOM.area          ({props})")] public static ReactComponent area               (Props props) { return null; }
      [InlineCode("React.DOM.article       ({props})")] public static ReactComponent article            (Props props) { return null; }
      [InlineCode("React.DOM.aside         ({props})")] public static ReactComponent aside              (Props props) { return null; }
      [InlineCode("React.DOM.audio         ({props})")] public static ReactComponent audio              (Props props) { return null; }
      [InlineCode("React.DOM.b             ({props})")] public static ReactComponent b                  (Props props) { return null; }
      [InlineCode("React.DOM.base          ({props})")] public static ReactComponent Base               (Props props) { return null; }
      [InlineCode("React.DOM.bdi           ({props})")] public static ReactComponent bdi                (Props props) { return null; }
      [InlineCode("React.DOM.bdo           ({props})")] public static ReactComponent bdo                (Props props) { return null; }
      [InlineCode("React.DOM.big           ({props})")] public static ReactComponent big                (Props props) { return null; }
      [InlineCode("React.DOM.blockquote    ({props})")] public static ReactComponent blockquote         (Props props) { return null; }
      [InlineCode("React.DOM.body          ({props})")] public static ReactComponent body               (Props props) { return null; }
      [InlineCode("React.DOM.br            ({props})")] public static ReactComponent br                 (Props props) { return null; }
      [InlineCode("React.DOM.button        ({props})")] public static ReactComponent button             (Props props) { return null; }
      [InlineCode("React.DOM.canvas        ({props})")] public static ReactComponent canvas             (Props props) { return null; }
      [InlineCode("React.DOM.caption       ({props})")] public static ReactComponent caption            (Props props) { return null; }
      [InlineCode("React.DOM.cite          ({props})")] public static ReactComponent cite               (Props props) { return null; }
      [InlineCode("React.DOM.code          ({props})")] public static ReactComponent code               (Props props) { return null; }
      [InlineCode("React.DOM.col           ({props})")] public static ReactComponent col                (Props props) { return null; }
      [InlineCode("React.DOM.colgroup      ({props})")] public static ReactComponent colgroup           (Props props) { return null; }
      [InlineCode("React.DOM.data          ({props})")] public static ReactComponent data               (Props props) { return null; }
      [InlineCode("React.DOM.datalist      ({props})")] public static ReactComponent datalist           (Props props) { return null; }
      [InlineCode("React.DOM.dd            ({props})")] public static ReactComponent dd                 (Props props) { return null; }
      [InlineCode("React.DOM.del           ({props})")] public static ReactComponent del                (Props props) { return null; }
      [InlineCode("React.DOM.details       ({props})")] public static ReactComponent details            (Props props) { return null; }
      [InlineCode("React.DOM.dfn           ({props})")] public static ReactComponent dfn                (Props props) { return null; }
      [InlineCode("React.DOM.div           ({props})")] public static ReactComponent div                (Props props) { return null; }
      [InlineCode("React.DOM.dl            ({props})")] public static ReactComponent dl                 (Props props) { return null; }
      [InlineCode("React.DOM.dt            ({props})")] public static ReactComponent dt                 (Props props) { return null; }
      [InlineCode("React.DOM.em            ({props})")] public static ReactComponent em                 (Props props) { return null; }
      [InlineCode("React.DOM.embed         ({props})")] public static ReactComponent embed              (Props props) { return null; }
      [InlineCode("React.DOM.fieldset      ({props})")] public static ReactComponent fieldset           (Props props) { return null; }
      [InlineCode("React.DOM.figcaption    ({props})")] public static ReactComponent figcaption         (Props props) { return null; }
      [InlineCode("React.DOM.figure        ({props})")] public static ReactComponent figure             (Props props) { return null; }
      [InlineCode("React.DOM.footer        ({props})")] public static ReactComponent footer             (Props props) { return null; }
      [InlineCode("React.DOM.form          ({props})")] public static ReactComponent form               (Props props) { return null; }
      [InlineCode("React.DOM.h1            ({props})")] public static ReactComponent h1                 (Props props) { return null; }
      [InlineCode("React.DOM.h2            ({props})")] public static ReactComponent h2                 (Props props) { return null; }
      [InlineCode("React.DOM.h3            ({props})")] public static ReactComponent h3                 (Props props) { return null; }
      [InlineCode("React.DOM.h4            ({props})")] public static ReactComponent h4                 (Props props) { return null; }
      [InlineCode("React.DOM.h5            ({props})")] public static ReactComponent h5                 (Props props) { return null; }
      [InlineCode("React.DOM.h6            ({props})")] public static ReactComponent h6                 (Props props) { return null; }
      [InlineCode("React.DOM.head          ({props})")] public static ReactComponent head               (Props props) { return null; }
      [InlineCode("React.DOM.header        ({props})")] public static ReactComponent header             (Props props) { return null; }
      [InlineCode("React.DOM.hr            ({props})")] public static ReactComponent hr                 (Props props) { return null; }
      [InlineCode("React.DOM.html          ({props})")] public static ReactComponent html               (Props props) { return null; }
      [InlineCode("React.DOM.i             ({props})")] public static ReactComponent i                  (Props props) { return null; }
      [InlineCode("React.DOM.iframe        ({props})")] public static ReactComponent iframe             (Props props) { return null; }
      [InlineCode("React.DOM.img           ({props})")] public static ReactComponent img                (Props props) { return null; }
      [InlineCode("React.DOM.input         ({props})")] public static ReactComponent input              (Props props) { return null; }
      [InlineCode("React.DOM.ins           ({props})")] public static ReactComponent ins                (Props props) { return null; }
      [InlineCode("React.DOM.kbd           ({props})")] public static ReactComponent kbd                (Props props) { return null; }
      [InlineCode("React.DOM.keygen        ({props})")] public static ReactComponent keygen             (Props props) { return null; }
      [InlineCode("React.DOM.label         ({props})")] public static ReactComponent label              (Props props) { return null; }
      [InlineCode("React.DOM.legend        ({props})")] public static ReactComponent legend             (Props props) { return null; }
      [InlineCode("React.DOM.li            ({props})")] public static ReactComponent li                 (Props props) { return null; }
      [InlineCode("React.DOM.link          ({props})")] public static ReactComponent link               (Props props) { return null; }
      [InlineCode("React.DOM.main          ({props})")] public static ReactComponent main               (Props props) { return null; }
      [InlineCode("React.DOM.map           ({props})")] public static ReactComponent map                (Props props) { return null; }
      [InlineCode("React.DOM.mark          ({props})")] public static ReactComponent mark               (Props props) { return null; }
      [InlineCode("React.DOM.menu          ({props})")] public static ReactComponent menu               (Props props) { return null; }
      [InlineCode("React.DOM.menuitem      ({props})")] public static ReactComponent menuitem           (Props props) { return null; }
      [InlineCode("React.DOM.meta          ({props})")] public static ReactComponent meta               (Props props) { return null; }
      [InlineCode("React.DOM.meter         ({props})")] public static ReactComponent meter              (Props props) { return null; }
      [InlineCode("React.DOM.nav           ({props})")] public static ReactComponent nav                (Props props) { return null; }
      [InlineCode("React.DOM.noscript      ({props})")] public static ReactComponent noscript           (Props props) { return null; }
      [InlineCode("React.DOM.object        ({props})")] public static ReactComponent Object             (Props props) { return null; }
      [InlineCode("React.DOM.ol            ({props})")] public static ReactComponent ol                 (Props props) { return null; }
      [InlineCode("React.DOM.optgroup      ({props})")] public static ReactComponent optgroup           (Props props) { return null; }
      [InlineCode("React.DOM.option        ({props})")] public static ReactComponent option             (Props props) { return null; }
      [InlineCode("React.DOM.output        ({props})")] public static ReactComponent output             (Props props) { return null; }
      [InlineCode("React.DOM.p             ({props})")] public static ReactComponent p                  (Props props) { return null; }
      [InlineCode("React.DOM.param         ({props})")] public static ReactComponent param              (Props props) { return null; }
      [InlineCode("React.DOM.pre           ({props})")] public static ReactComponent pre                (Props props) { return null; }
      [InlineCode("React.DOM.progress      ({props})")] public static ReactComponent progress           (Props props) { return null; }
      [InlineCode("React.DOM.q             ({props})")] public static ReactComponent q                  (Props props) { return null; }
      [InlineCode("React.DOM.rp            ({props})")] public static ReactComponent rp                 (Props props) { return null; }
      [InlineCode("React.DOM.rt            ({props})")] public static ReactComponent rt                 (Props props) { return null; }
      [InlineCode("React.DOM.ruby          ({props})")] public static ReactComponent ruby               (Props props) { return null; }
      [InlineCode("React.DOM.s             ({props})")] public static ReactComponent s                  (Props props) { return null; }
      [InlineCode("React.DOM.samp          ({props})")] public static ReactComponent samp               (Props props) { return null; }
      [InlineCode("React.DOM.script        ({props})")] public static ReactComponent script             (Props props) { return null; }
      [InlineCode("React.DOM.section       ({props})")] public static ReactComponent section            (Props props) { return null; }
      [InlineCode("React.DOM.select        ({props})")] public static ReactComponent select             (Props props) { return null; }
      [InlineCode("React.DOM.small         ({props})")] public static ReactComponent small              (Props props) { return null; }
      [InlineCode("React.DOM.source        ({props})")] public static ReactComponent source             (Props props) { return null; }
      [InlineCode("React.DOM.span          ({props})")] public static ReactComponent span               (Props props) { return null; }
      [InlineCode("React.DOM.strong        ({props})")] public static ReactComponent strong             (Props props) { return null; }
      [InlineCode("React.DOM.style         ({props})")] public static ReactComponent style              (Props props) { return null; }
      [InlineCode("React.DOM.sub           ({props})")] public static ReactComponent sub                (Props props) { return null; }
      [InlineCode("React.DOM.summary       ({props})")] public static ReactComponent summary            (Props props) { return null; }
      [InlineCode("React.DOM.sup           ({props})")] public static ReactComponent sup                (Props props) { return null; }
      [InlineCode("React.DOM.table         ({props})")] public static ReactComponent table              (Props props) { return null; }
      [InlineCode("React.DOM.tbody         ({props})")] public static ReactComponent tbody              (Props props) { return null; }
      [InlineCode("React.DOM.td            ({props})")] public static ReactComponent td                 (Props props) { return null; }
      [InlineCode("React.DOM.textarea      ({props})")] public static ReactComponent textarea           (Props props) { return null; }
      [InlineCode("React.DOM.tfoot         ({props})")] public static ReactComponent tfoot              (Props props) { return null; }
      [InlineCode("React.DOM.th            ({props})")] public static ReactComponent th                 (Props props) { return null; }
      [InlineCode("React.DOM.thead         ({props})")] public static ReactComponent thead              (Props props) { return null; }
      [InlineCode("React.DOM.time          ({props})")] public static ReactComponent time               (Props props) { return null; }
      [InlineCode("React.DOM.title         ({props})")] public static ReactComponent title              (Props props) { return null; }
      [InlineCode("React.DOM.tr            ({props})")] public static ReactComponent tr                 (Props props) { return null; }
      [InlineCode("React.DOM.track         ({props})")] public static ReactComponent track              (Props props) { return null; }
      [InlineCode("React.DOM.u             ({props})")] public static ReactComponent u                  (Props props) { return null; }
      [InlineCode("React.DOM.ul            ({props})")] public static ReactComponent ul                 (Props props) { return null; }
      [InlineCode("React.DOM.var           ({props})")] public static ReactComponent var                (Props props) { return null; }
      [InlineCode("React.DOM.video         ({props})")] public static ReactComponent video              (Props props) { return null; }
      [InlineCode("React.DOM.wbr           ({props})")] public static ReactComponent wbr                (Props props) { return null; }
      [InlineCode("React.DOM.circle        ({props})")] public static ReactComponent circle             (Props props) { return null; }
      [InlineCode("React.DOM.defs          ({props})")] public static ReactComponent defs               (Props props) { return null; }
      [InlineCode("React.DOM.g             ({props})")] public static ReactComponent g                  (Props props) { return null; }
      [InlineCode("React.DOM.line          ({props})")] public static ReactComponent line               (Props props) { return null; }
      [InlineCode("React.DOM.linearGradient({props})")] public static ReactComponent linearGradient     (Props props) { return null; }
      [InlineCode("React.DOM.path          ({props})")] public static ReactComponent path               (Props props) { return null; }
      [InlineCode("React.DOM.polygon       ({props})")] public static ReactComponent polygon            (Props props) { return null; }
      [InlineCode("React.DOM.polyline      ({props})")] public static ReactComponent polyline           (Props props) { return null; }
      [InlineCode("React.DOM.radialGradient({props})")] public static ReactComponent radialGradient     (Props props) { return null; }
      [InlineCode("React.DOM.rect          ({props})")] public static ReactComponent rect               (Props props) { return null; }
      [InlineCode("React.DOM.stop          ({props})")] public static ReactComponent stop               (Props props) { return null; }
      [InlineCode("React.DOM.svg           ({props})")] public static ReactComponent svg                (Props props) { return null; }
      [InlineCode("React.DOM.text          ({props})")] public static ReactComponent text               (Props props) { return null; }
      
      [InlineCode("React.DOM.a             ({props},{*children})")] public static ReactComponent a                  (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.abbr          ({props},{*children})")] public static ReactComponent abbr               (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.address       ({props},{*children})")] public static ReactComponent address            (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.area          ({props},{*children})")] public static ReactComponent area               (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.article       ({props},{*children})")] public static ReactComponent article            (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.aside         ({props},{*children})")] public static ReactComponent aside              (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.audio         ({props},{*children})")] public static ReactComponent audio              (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.b             ({props},{*children})")] public static ReactComponent b                  (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.base          ({props},{*children})")] public static ReactComponent Base               (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.bdi           ({props},{*children})")] public static ReactComponent bdi                (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.bdo           ({props},{*children})")] public static ReactComponent bdo                (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.big           ({props},{*children})")] public static ReactComponent big                (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.blockquote    ({props},{*children})")] public static ReactComponent blockquote         (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.body          ({props},{*children})")] public static ReactComponent body               (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.br            ({props},{*children})")] public static ReactComponent br                 (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.button        ({props},{*children})")] public static ReactComponent button             (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.canvas        ({props},{*children})")] public static ReactComponent canvas             (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.caption       ({props},{*children})")] public static ReactComponent caption            (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.cite          ({props},{*children})")] public static ReactComponent cite               (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.code          ({props},{*children})")] public static ReactComponent code               (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.col           ({props},{*children})")] public static ReactComponent col                (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.colgroup      ({props},{*children})")] public static ReactComponent colgroup           (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.data          ({props},{*children})")] public static ReactComponent data               (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.datalist      ({props},{*children})")] public static ReactComponent datalist           (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.dd            ({props},{*children})")] public static ReactComponent dd                 (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.del           ({props},{*children})")] public static ReactComponent del                (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.details       ({props},{*children})")] public static ReactComponent details            (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.dfn           ({props},{*children})")] public static ReactComponent dfn                (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.div           ({props},{*children})")] public static ReactComponent div                (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.dl            ({props},{*children})")] public static ReactComponent dl                 (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.dt            ({props},{*children})")] public static ReactComponent dt                 (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.em            ({props},{*children})")] public static ReactComponent em                 (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.embed         ({props},{*children})")] public static ReactComponent embed              (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.fieldset      ({props},{*children})")] public static ReactComponent fieldset           (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.figcaption    ({props},{*children})")] public static ReactComponent figcaption         (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.figure        ({props},{*children})")] public static ReactComponent figure             (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.footer        ({props},{*children})")] public static ReactComponent footer             (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.form          ({props},{*children})")] public static ReactComponent form               (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.h1            ({props},{*children})")] public static ReactComponent h1                 (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.h2            ({props},{*children})")] public static ReactComponent h2                 (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.h3            ({props},{*children})")] public static ReactComponent h3                 (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.h4            ({props},{*children})")] public static ReactComponent h4                 (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.h5            ({props},{*children})")] public static ReactComponent h5                 (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.h6            ({props},{*children})")] public static ReactComponent h6                 (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.head          ({props},{*children})")] public static ReactComponent head               (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.header        ({props},{*children})")] public static ReactComponent header             (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.hr            ({props},{*children})")] public static ReactComponent hr                 (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.html          ({props},{*children})")] public static ReactComponent html               (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.i             ({props},{*children})")] public static ReactComponent i                  (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.iframe        ({props},{*children})")] public static ReactComponent iframe             (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.img           ({props},{*children})")] public static ReactComponent img                (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.input         ({props},{*children})")] public static ReactComponent input              (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.ins           ({props},{*children})")] public static ReactComponent ins                (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.kbd           ({props},{*children})")] public static ReactComponent kbd                (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.keygen        ({props},{*children})")] public static ReactComponent keygen             (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.label         ({props},{*children})")] public static ReactComponent label              (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.legend        ({props},{*children})")] public static ReactComponent legend             (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.li            ({props},{*children})")] public static ReactComponent li                 (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.link          ({props},{*children})")] public static ReactComponent link               (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.main          ({props},{*children})")] public static ReactComponent main               (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.map           ({props},{*children})")] public static ReactComponent map                (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.mark          ({props},{*children})")] public static ReactComponent mark               (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.menu          ({props},{*children})")] public static ReactComponent menu               (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.menuitem      ({props},{*children})")] public static ReactComponent menuitem           (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.meta          ({props},{*children})")] public static ReactComponent meta               (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.meter         ({props},{*children})")] public static ReactComponent meter              (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.nav           ({props},{*children})")] public static ReactComponent nav                (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.noscript      ({props},{*children})")] public static ReactComponent noscript           (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.object        ({props},{*children})")] public static ReactComponent Object             (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.ol            ({props},{*children})")] public static ReactComponent ol                 (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.optgroup      ({props},{*children})")] public static ReactComponent optgroup           (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.option        ({props},{*children})")] public static ReactComponent option             (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.output        ({props},{*children})")] public static ReactComponent output             (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.p             ({props},{*children})")] public static ReactComponent p                  (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.param         ({props},{*children})")] public static ReactComponent param              (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.pre           ({props},{*children})")] public static ReactComponent pre                (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.progress      ({props},{*children})")] public static ReactComponent progress           (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.q             ({props},{*children})")] public static ReactComponent q                  (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.rp            ({props},{*children})")] public static ReactComponent rp                 (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.rt            ({props},{*children})")] public static ReactComponent rt                 (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.ruby          ({props},{*children})")] public static ReactComponent ruby               (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.s             ({props},{*children})")] public static ReactComponent s                  (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.samp          ({props},{*children})")] public static ReactComponent samp               (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.script        ({props},{*children})")] public static ReactComponent script             (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.section       ({props},{*children})")] public static ReactComponent section            (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.select        ({props},{*children})")] public static ReactComponent select             (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.small         ({props},{*children})")] public static ReactComponent small              (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.source        ({props},{*children})")] public static ReactComponent source             (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.span          ({props},{*children})")] public static ReactComponent span               (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.strong        ({props},{*children})")] public static ReactComponent strong             (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.style         ({props},{*children})")] public static ReactComponent style              (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.sub           ({props},{*children})")] public static ReactComponent sub                (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.summary       ({props},{*children})")] public static ReactComponent summary            (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.sup           ({props},{*children})")] public static ReactComponent sup                (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.table         ({props},{*children})")] public static ReactComponent table              (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.tbody         ({props},{*children})")] public static ReactComponent tbody              (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.td            ({props},{*children})")] public static ReactComponent td                 (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.textarea      ({props},{*children})")] public static ReactComponent textarea           (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.tfoot         ({props},{*children})")] public static ReactComponent tfoot              (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.th            ({props},{*children})")] public static ReactComponent th                 (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.thead         ({props},{*children})")] public static ReactComponent thead              (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.time          ({props},{*children})")] public static ReactComponent time               (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.title         ({props},{*children})")] public static ReactComponent title              (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.tr            ({props},{*children})")] public static ReactComponent tr                 (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.track         ({props},{*children})")] public static ReactComponent track              (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.u             ({props},{*children})")] public static ReactComponent u                  (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.ul            ({props},{*children})")] public static ReactComponent ul                 (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.var           ({props},{*children})")] public static ReactComponent var                (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.video         ({props},{*children})")] public static ReactComponent video              (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.wbr           ({props},{*children})")] public static ReactComponent wbr                (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.circle        ({props},{*children})")] public static ReactComponent circle             (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.defs          ({props},{*children})")] public static ReactComponent defs               (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.g             ({props},{*children})")] public static ReactComponent g                  (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.line          ({props},{*children})")] public static ReactComponent line               (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.linearGradient({props},{*children})")] public static ReactComponent linearGradient     (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.path          ({props},{*children})")] public static ReactComponent path               (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.polygon       ({props},{*children})")] public static ReactComponent polygon            (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.polyline      ({props},{*children})")] public static ReactComponent polyline           (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.radialGradient({props},{*children})")] public static ReactComponent radialGradient     (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.rect          ({props},{*children})")] public static ReactComponent rect               (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.stop          ({props},{*children})")] public static ReactComponent stop               (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.svg           ({props},{*children})")] public static ReactComponent svg                (Props props, params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.text          ({props},{*children})")] public static ReactComponent text               (Props props, params ReactComponent[] children) { return null; }      

      [InlineCode("React.DOM.a             (null,{*children})")] public static ReactComponent a                  (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.abbr          (null,{*children})")] public static ReactComponent abbr               (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.address       (null,{*children})")] public static ReactComponent address            (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.area          (null,{*children})")] public static ReactComponent area               (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.article       (null,{*children})")] public static ReactComponent article            (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.aside         (null,{*children})")] public static ReactComponent aside              (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.audio         (null,{*children})")] public static ReactComponent audio              (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.b             (null,{*children})")] public static ReactComponent b                  (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.base          (null,{*children})")] public static ReactComponent Base               (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.bdi           (null,{*children})")] public static ReactComponent bdi                (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.bdo           (null,{*children})")] public static ReactComponent bdo                (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.big           (null,{*children})")] public static ReactComponent big                (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.blockquote    (null,{*children})")] public static ReactComponent blockquote         (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.body          (null,{*children})")] public static ReactComponent body               (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.br            (null,{*children})")] public static ReactComponent br                 (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.button        (null,{*children})")] public static ReactComponent button             (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.canvas        (null,{*children})")] public static ReactComponent canvas             (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.caption       (null,{*children})")] public static ReactComponent caption            (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.cite          (null,{*children})")] public static ReactComponent cite               (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.code          (null,{*children})")] public static ReactComponent code               (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.col           (null,{*children})")] public static ReactComponent col                (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.colgroup      (null,{*children})")] public static ReactComponent colgroup           (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.data          (null,{*children})")] public static ReactComponent data               (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.datalist      (null,{*children})")] public static ReactComponent datalist           (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.dd            (null,{*children})")] public static ReactComponent dd                 (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.del           (null,{*children})")] public static ReactComponent del                (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.details       (null,{*children})")] public static ReactComponent details            (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.dfn           (null,{*children})")] public static ReactComponent dfn                (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.div           (null,{*children})")] public static ReactComponent div                (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.dl            (null,{*children})")] public static ReactComponent dl                 (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.dt            (null,{*children})")] public static ReactComponent dt                 (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.em            (null,{*children})")] public static ReactComponent em                 (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.embed         (null,{*children})")] public static ReactComponent embed              (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.fieldset      (null,{*children})")] public static ReactComponent fieldset           (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.figcaption    (null,{*children})")] public static ReactComponent figcaption         (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.figure        (null,{*children})")] public static ReactComponent figure             (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.footer        (null,{*children})")] public static ReactComponent footer             (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.form          (null,{*children})")] public static ReactComponent form               (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.h1            (null,{*children})")] public static ReactComponent h1                 (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.h2            (null,{*children})")] public static ReactComponent h2                 (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.h3            (null,{*children})")] public static ReactComponent h3                 (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.h4            (null,{*children})")] public static ReactComponent h4                 (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.h5            (null,{*children})")] public static ReactComponent h5                 (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.h6            (null,{*children})")] public static ReactComponent h6                 (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.head          (null,{*children})")] public static ReactComponent head               (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.header        (null,{*children})")] public static ReactComponent header             (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.hr            (null,{*children})")] public static ReactComponent hr                 (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.html          (null,{*children})")] public static ReactComponent html               (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.i             (null,{*children})")] public static ReactComponent i                  (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.iframe        (null,{*children})")] public static ReactComponent iframe             (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.img           (null,{*children})")] public static ReactComponent img                (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.input         (null,{*children})")] public static ReactComponent input              (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.ins           (null,{*children})")] public static ReactComponent ins                (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.kbd           (null,{*children})")] public static ReactComponent kbd                (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.keygen        (null,{*children})")] public static ReactComponent keygen             (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.label         (null,{*children})")] public static ReactComponent label              (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.legend        (null,{*children})")] public static ReactComponent legend             (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.li            (null,{*children})")] public static ReactComponent li                 (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.link          (null,{*children})")] public static ReactComponent link               (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.main          (null,{*children})")] public static ReactComponent main               (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.map           (null,{*children})")] public static ReactComponent map                (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.mark          (null,{*children})")] public static ReactComponent mark               (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.menu          (null,{*children})")] public static ReactComponent menu               (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.menuitem      (null,{*children})")] public static ReactComponent menuitem           (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.meta          (null,{*children})")] public static ReactComponent meta               (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.meter         (null,{*children})")] public static ReactComponent meter              (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.nav           (null,{*children})")] public static ReactComponent nav                (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.noscript      (null,{*children})")] public static ReactComponent noscript           (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.object        (null,{*children})")] public static ReactComponent Object             (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.ol            (null,{*children})")] public static ReactComponent ol                 (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.optgroup      (null,{*children})")] public static ReactComponent optgroup           (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.option        (null,{*children})")] public static ReactComponent option             (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.output        (null,{*children})")] public static ReactComponent output             (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.p             (null,{*children})")] public static ReactComponent p                  (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.param         (null,{*children})")] public static ReactComponent param              (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.pre           (null,{*children})")] public static ReactComponent pre                (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.progress      (null,{*children})")] public static ReactComponent progress           (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.q             (null,{*children})")] public static ReactComponent q                  (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.rp            (null,{*children})")] public static ReactComponent rp                 (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.rt            (null,{*children})")] public static ReactComponent rt                 (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.ruby          (null,{*children})")] public static ReactComponent ruby               (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.s             (null,{*children})")] public static ReactComponent s                  (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.samp          (null,{*children})")] public static ReactComponent samp               (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.script        (null,{*children})")] public static ReactComponent script             (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.section       (null,{*children})")] public static ReactComponent section            (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.select        (null,{*children})")] public static ReactComponent select             (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.small         (null,{*children})")] public static ReactComponent small              (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.source        (null,{*children})")] public static ReactComponent source             (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.span          (null,{*children})")] public static ReactComponent span               (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.strong        (null,{*children})")] public static ReactComponent strong             (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.style         (null,{*children})")] public static ReactComponent style              (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.sub           (null,{*children})")] public static ReactComponent sub                (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.summary       (null,{*children})")] public static ReactComponent summary            (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.sup           (null,{*children})")] public static ReactComponent sup                (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.table         (null,{*children})")] public static ReactComponent table              (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.tbody         (null,{*children})")] public static ReactComponent tbody              (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.td            (null,{*children})")] public static ReactComponent td                 (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.textarea      (null,{*children})")] public static ReactComponent textarea           (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.tfoot         (null,{*children})")] public static ReactComponent tfoot              (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.th            (null,{*children})")] public static ReactComponent th                 (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.thead         (null,{*children})")] public static ReactComponent thead              (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.time          (null,{*children})")] public static ReactComponent time               (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.title         (null,{*children})")] public static ReactComponent title              (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.tr            (null,{*children})")] public static ReactComponent tr                 (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.track         (null,{*children})")] public static ReactComponent track              (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.u             (null,{*children})")] public static ReactComponent u                  (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.ul            (null,{*children})")] public static ReactComponent ul                 (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.var           (null,{*children})")] public static ReactComponent var                (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.video         (null,{*children})")] public static ReactComponent video              (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.wbr           (null,{*children})")] public static ReactComponent wbr                (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.circle        (null,{*children})")] public static ReactComponent circle             (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.defs          (null,{*children})")] public static ReactComponent defs               (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.g             (null,{*children})")] public static ReactComponent g                  (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.line          (null,{*children})")] public static ReactComponent line               (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.linearGradient(null,{*children})")] public static ReactComponent linearGradient     (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.path          (null,{*children})")] public static ReactComponent path               (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.polygon       (null,{*children})")] public static ReactComponent polygon            (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.polyline      (null,{*children})")] public static ReactComponent polyline           (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.radialGradient(null,{*children})")] public static ReactComponent radialGradient     (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.rect          (null,{*children})")] public static ReactComponent rect               (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.stop          (null,{*children})")] public static ReactComponent stop               (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.svg           (null,{*children})")] public static ReactComponent svg                (params ReactComponent[] children) { return null; }
      [InlineCode("React.DOM.text          (null,{*children})")] public static ReactComponent text               (params ReactComponent[] children) { return null; }      
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






