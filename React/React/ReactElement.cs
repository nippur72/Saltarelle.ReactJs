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
   public class ReactElement
   {
      [InlineCode("{this}.getDOMNode()")]                         public System.Html.Element getDOMNode() { return null; }
      [InlineCode("{this}.setProps({nextProps})")]                public void setProps(object nextProps) {}
      [InlineCode("{this}.replaceProps({nextProps})")]            public void replaceProps(object nextProps) {}
      [InlineCode("{this}.transferPropsTo({targetComponent})")]   public ReactElement transferPropsTo(ReactElement targetComponent) { return null; }
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
      
      // TODO type, key, ref 

      [InlineCode("{s}")] public static implicit operator ReactElement(string s) { return null; }
      [InlineCode("{s}")] public static implicit operator ReactElement(int s)    { return null; }
      [InlineCode("{s}")] public static implicit operator ReactElement(double s) { return null; }
      [InlineCode("{s}")] public static implicit operator ReactElement(List<ReactElement> s) { return null; }
      [InlineCode("{s}")] public static implicit operator ReactElement(ReactElement[] s) { return null; }

      // TODO dialog, picture, 
      // TODO mask and tspan

      [InlineCode("React.DOM.a             ({props})")] public static ReactElement a                  (Props props) { return null; }
      [InlineCode("React.DOM.abbr          ({props})")] public static ReactElement abbr               (Props props) { return null; }
      [InlineCode("React.DOM.address       ({props})")] public static ReactElement address            (Props props) { return null; }
      [InlineCode("React.DOM.area          ({props})")] public static ReactElement area               (Props props) { return null; }
      [InlineCode("React.DOM.article       ({props})")] public static ReactElement article            (Props props) { return null; }
      [InlineCode("React.DOM.aside         ({props})")] public static ReactElement aside              (Props props) { return null; }
      [InlineCode("React.DOM.audio         ({props})")] public static ReactElement audio              (Props props) { return null; }
      [InlineCode("React.DOM.b             ({props})")] public static ReactElement b                  (Props props) { return null; }
      [InlineCode("React.DOM.base          ({props})")] public static ReactElement Base               (Props props) { return null; }
      [InlineCode("React.DOM.bdi           ({props})")] public static ReactElement bdi                (Props props) { return null; }
      [InlineCode("React.DOM.bdo           ({props})")] public static ReactElement bdo                (Props props) { return null; }
      [InlineCode("React.DOM.big           ({props})")] public static ReactElement big                (Props props) { return null; }
      [InlineCode("React.DOM.blockquote    ({props})")] public static ReactElement blockquote         (Props props) { return null; }
      [InlineCode("React.DOM.body          ({props})")] public static ReactElement body               (Props props) { return null; }
      [InlineCode("React.DOM.br            ({props})")] public static ReactElement br                 (Props props) { return null; }
      [InlineCode("React.DOM.button        ({props})")] public static ReactElement button             (Props props) { return null; }
      [InlineCode("React.DOM.canvas        ({props})")] public static ReactElement canvas             (Props props) { return null; }
      [InlineCode("React.DOM.caption       ({props})")] public static ReactElement caption            (Props props) { return null; }
      [InlineCode("React.DOM.cite          ({props})")] public static ReactElement cite               (Props props) { return null; }
      [InlineCode("React.DOM.code          ({props})")] public static ReactElement code               (Props props) { return null; }
      [InlineCode("React.DOM.col           ({props})")] public static ReactElement col                (Props props) { return null; }
      [InlineCode("React.DOM.colgroup      ({props})")] public static ReactElement colgroup           (Props props) { return null; }
      [InlineCode("React.DOM.data          ({props})")] public static ReactElement data               (Props props) { return null; }
      [InlineCode("React.DOM.datalist      ({props})")] public static ReactElement datalist           (Props props) { return null; }
      [InlineCode("React.DOM.dd            ({props})")] public static ReactElement dd                 (Props props) { return null; }
      [InlineCode("React.DOM.del           ({props})")] public static ReactElement del                (Props props) { return null; }
      [InlineCode("React.DOM.details       ({props})")] public static ReactElement details            (Props props) { return null; }
      [InlineCode("React.DOM.dfn           ({props})")] public static ReactElement dfn                (Props props) { return null; }
      [InlineCode("React.DOM.div           ({props})")] public static ReactElement div                (Props props) { return null; }
      [InlineCode("React.DOM.dl            ({props})")] public static ReactElement dl                 (Props props) { return null; }
      [InlineCode("React.DOM.dt            ({props})")] public static ReactElement dt                 (Props props) { return null; }
      [InlineCode("React.DOM.em            ({props})")] public static ReactElement em                 (Props props) { return null; }
      [InlineCode("React.DOM.embed         ({props})")] public static ReactElement embed              (Props props) { return null; }
      [InlineCode("React.DOM.fieldset      ({props})")] public static ReactElement fieldset           (Props props) { return null; }
      [InlineCode("React.DOM.figcaption    ({props})")] public static ReactElement figcaption         (Props props) { return null; }
      [InlineCode("React.DOM.figure        ({props})")] public static ReactElement figure             (Props props) { return null; }
      [InlineCode("React.DOM.footer        ({props})")] public static ReactElement footer             (Props props) { return null; }
      [InlineCode("React.DOM.form          ({props})")] public static ReactElement form               (Props props) { return null; }
      [InlineCode("React.DOM.h1            ({props})")] public static ReactElement h1                 (Props props) { return null; }
      [InlineCode("React.DOM.h2            ({props})")] public static ReactElement h2                 (Props props) { return null; }
      [InlineCode("React.DOM.h3            ({props})")] public static ReactElement h3                 (Props props) { return null; }
      [InlineCode("React.DOM.h4            ({props})")] public static ReactElement h4                 (Props props) { return null; }
      [InlineCode("React.DOM.h5            ({props})")] public static ReactElement h5                 (Props props) { return null; }
      [InlineCode("React.DOM.h6            ({props})")] public static ReactElement h6                 (Props props) { return null; }
      [InlineCode("React.DOM.head          ({props})")] public static ReactElement head               (Props props) { return null; }
      [InlineCode("React.DOM.header        ({props})")] public static ReactElement header             (Props props) { return null; }
      [InlineCode("React.DOM.hr            ({props})")] public static ReactElement hr                 (Props props) { return null; }
      [InlineCode("React.DOM.html          ({props})")] public static ReactElement html               (Props props) { return null; }
      [InlineCode("React.DOM.i             ({props})")] public static ReactElement i                  (Props props) { return null; }
      [InlineCode("React.DOM.iframe        ({props})")] public static ReactElement iframe             (Props props) { return null; }
      [InlineCode("React.DOM.img           ({props})")] public static ReactElement img                (Props props) { return null; }
      [InlineCode("React.DOM.input         ({props})")] public static ReactElement input              (Props props) { return null; }
      [InlineCode("React.DOM.ins           ({props})")] public static ReactElement ins                (Props props) { return null; }
      [InlineCode("React.DOM.kbd           ({props})")] public static ReactElement kbd                (Props props) { return null; }
      [InlineCode("React.DOM.keygen        ({props})")] public static ReactElement keygen             (Props props) { return null; }
      [InlineCode("React.DOM.label         ({props})")] public static ReactElement label              (Props props) { return null; }
      [InlineCode("React.DOM.legend        ({props})")] public static ReactElement legend             (Props props) { return null; }
      [InlineCode("React.DOM.li            ({props})")] public static ReactElement li                 (Props props) { return null; }
      [InlineCode("React.DOM.link          ({props})")] public static ReactElement link               (Props props) { return null; }
      [InlineCode("React.DOM.main          ({props})")] public static ReactElement main               (Props props) { return null; }
      [InlineCode("React.DOM.map           ({props})")] public static ReactElement map                (Props props) { return null; }
      [InlineCode("React.DOM.mark          ({props})")] public static ReactElement mark               (Props props) { return null; }
      [InlineCode("React.DOM.menu          ({props})")] public static ReactElement menu               (Props props) { return null; }
      [InlineCode("React.DOM.menuitem      ({props})")] public static ReactElement menuitem           (Props props) { return null; }
      [InlineCode("React.DOM.meta          ({props})")] public static ReactElement meta               (Props props) { return null; }
      [InlineCode("React.DOM.meter         ({props})")] public static ReactElement meter              (Props props) { return null; }
      [InlineCode("React.DOM.nav           ({props})")] public static ReactElement nav                (Props props) { return null; }
      [InlineCode("React.DOM.noscript      ({props})")] public static ReactElement noscript           (Props props) { return null; }
      [InlineCode("React.DOM.object        ({props})")] public static ReactElement Object             (Props props) { return null; }
      [InlineCode("React.DOM.ol            ({props})")] public static ReactElement ol                 (Props props) { return null; }
      [InlineCode("React.DOM.optgroup      ({props})")] public static ReactElement optgroup           (Props props) { return null; }
      [InlineCode("React.DOM.option        ({props})")] public static ReactElement option             (Props props) { return null; }
      [InlineCode("React.DOM.output        ({props})")] public static ReactElement output             (Props props) { return null; }
      [InlineCode("React.DOM.p             ({props})")] public static ReactElement p                  (Props props) { return null; }
      [InlineCode("React.DOM.param         ({props})")] public static ReactElement param              (Props props) { return null; }
      [InlineCode("React.DOM.pre           ({props})")] public static ReactElement pre                (Props props) { return null; }
      [InlineCode("React.DOM.progress      ({props})")] public static ReactElement progress           (Props props) { return null; }
      [InlineCode("React.DOM.q             ({props})")] public static ReactElement q                  (Props props) { return null; }
      [InlineCode("React.DOM.rp            ({props})")] public static ReactElement rp                 (Props props) { return null; }
      [InlineCode("React.DOM.rt            ({props})")] public static ReactElement rt                 (Props props) { return null; }
      [InlineCode("React.DOM.ruby          ({props})")] public static ReactElement ruby               (Props props) { return null; }
      [InlineCode("React.DOM.s             ({props})")] public static ReactElement s                  (Props props) { return null; }
      [InlineCode("React.DOM.samp          ({props})")] public static ReactElement samp               (Props props) { return null; }
      [InlineCode("React.DOM.script        ({props})")] public static ReactElement script             (Props props) { return null; }
      [InlineCode("React.DOM.section       ({props})")] public static ReactElement section            (Props props) { return null; }
      [InlineCode("React.DOM.select        ({props})")] public static ReactElement select             (Props props) { return null; }
      [InlineCode("React.DOM.small         ({props})")] public static ReactElement small              (Props props) { return null; }
      [InlineCode("React.DOM.source        ({props})")] public static ReactElement source             (Props props) { return null; }
      [InlineCode("React.DOM.span          ({props})")] public static ReactElement span               (Props props) { return null; }
      [InlineCode("React.DOM.strong        ({props})")] public static ReactElement strong             (Props props) { return null; }
      [InlineCode("React.DOM.style         ({props})")] public static ReactElement style              (Props props) { return null; }
      [InlineCode("React.DOM.sub           ({props})")] public static ReactElement sub                (Props props) { return null; }
      [InlineCode("React.DOM.summary       ({props})")] public static ReactElement summary            (Props props) { return null; }
      [InlineCode("React.DOM.sup           ({props})")] public static ReactElement sup                (Props props) { return null; }
      [InlineCode("React.DOM.table         ({props})")] public static ReactElement table              (Props props) { return null; }
      [InlineCode("React.DOM.tbody         ({props})")] public static ReactElement tbody              (Props props) { return null; }
      [InlineCode("React.DOM.td            ({props})")] public static ReactElement td                 (Props props) { return null; }
      [InlineCode("React.DOM.textarea      ({props})")] public static ReactElement textarea           (Props props) { return null; }
      [InlineCode("React.DOM.tfoot         ({props})")] public static ReactElement tfoot              (Props props) { return null; }
      [InlineCode("React.DOM.th            ({props})")] public static ReactElement th                 (Props props) { return null; }
      [InlineCode("React.DOM.thead         ({props})")] public static ReactElement thead              (Props props) { return null; }
      [InlineCode("React.DOM.time          ({props})")] public static ReactElement time               (Props props) { return null; }
      [InlineCode("React.DOM.title         ({props})")] public static ReactElement title              (Props props) { return null; }
      [InlineCode("React.DOM.tr            ({props})")] public static ReactElement tr                 (Props props) { return null; }
      [InlineCode("React.DOM.track         ({props})")] public static ReactElement track              (Props props) { return null; }
      [InlineCode("React.DOM.u             ({props})")] public static ReactElement u                  (Props props) { return null; }
      [InlineCode("React.DOM.ul            ({props})")] public static ReactElement ul                 (Props props) { return null; }
      [InlineCode("React.DOM.var           ({props})")] public static ReactElement var                (Props props) { return null; }
      [InlineCode("React.DOM.video         ({props})")] public static ReactElement video              (Props props) { return null; }
      [InlineCode("React.DOM.wbr           ({props})")] public static ReactElement wbr                (Props props) { return null; }
      [InlineCode("React.DOM.circle        ({props})")] public static ReactElement circle             (Props props) { return null; }
      [InlineCode("React.DOM.defs          ({props})")] public static ReactElement defs               (Props props) { return null; }
      [InlineCode("React.DOM.g             ({props})")] public static ReactElement g                  (Props props) { return null; }
      [InlineCode("React.DOM.line          ({props})")] public static ReactElement line               (Props props) { return null; }
      [InlineCode("React.DOM.linearGradient({props})")] public static ReactElement linearGradient     (Props props) { return null; }
      [InlineCode("React.DOM.path          ({props})")] public static ReactElement path               (Props props) { return null; }
      [InlineCode("React.DOM.polygon       ({props})")] public static ReactElement polygon            (Props props) { return null; }
      [InlineCode("React.DOM.polyline      ({props})")] public static ReactElement polyline           (Props props) { return null; }
      [InlineCode("React.DOM.radialGradient({props})")] public static ReactElement radialGradient     (Props props) { return null; }
      [InlineCode("React.DOM.rect          ({props})")] public static ReactElement rect               (Props props) { return null; }
      [InlineCode("React.DOM.stop          ({props})")] public static ReactElement stop               (Props props) { return null; }
      [InlineCode("React.DOM.svg           ({props})")] public static ReactElement svg                (Props props) { return null; }
      [InlineCode("React.DOM.text          ({props})")] public static ReactElement text               (Props props) { return null; }
      
      [InlineCode("React.DOM.a             ({props},{*children})")] public static ReactElement a                  (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.abbr          ({props},{*children})")] public static ReactElement abbr               (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.address       ({props},{*children})")] public static ReactElement address            (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.area          ({props},{*children})")] public static ReactElement area               (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.article       ({props},{*children})")] public static ReactElement article            (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.aside         ({props},{*children})")] public static ReactElement aside              (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.audio         ({props},{*children})")] public static ReactElement audio              (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.b             ({props},{*children})")] public static ReactElement b                  (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.base          ({props},{*children})")] public static ReactElement Base               (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.bdi           ({props},{*children})")] public static ReactElement bdi                (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.bdo           ({props},{*children})")] public static ReactElement bdo                (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.big           ({props},{*children})")] public static ReactElement big                (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.blockquote    ({props},{*children})")] public static ReactElement blockquote         (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.body          ({props},{*children})")] public static ReactElement body               (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.br            ({props},{*children})")] public static ReactElement br                 (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.button        ({props},{*children})")] public static ReactElement button             (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.canvas        ({props},{*children})")] public static ReactElement canvas             (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.caption       ({props},{*children})")] public static ReactElement caption            (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.cite          ({props},{*children})")] public static ReactElement cite               (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.code          ({props},{*children})")] public static ReactElement code               (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.col           ({props},{*children})")] public static ReactElement col                (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.colgroup      ({props},{*children})")] public static ReactElement colgroup           (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.data          ({props},{*children})")] public static ReactElement data               (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.datalist      ({props},{*children})")] public static ReactElement datalist           (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.dd            ({props},{*children})")] public static ReactElement dd                 (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.del           ({props},{*children})")] public static ReactElement del                (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.details       ({props},{*children})")] public static ReactElement details            (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.dfn           ({props},{*children})")] public static ReactElement dfn                (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.div           ({props},{*children})")] public static ReactElement div                (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.dl            ({props},{*children})")] public static ReactElement dl                 (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.dt            ({props},{*children})")] public static ReactElement dt                 (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.em            ({props},{*children})")] public static ReactElement em                 (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.embed         ({props},{*children})")] public static ReactElement embed              (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.fieldset      ({props},{*children})")] public static ReactElement fieldset           (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.figcaption    ({props},{*children})")] public static ReactElement figcaption         (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.figure        ({props},{*children})")] public static ReactElement figure             (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.footer        ({props},{*children})")] public static ReactElement footer             (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.form          ({props},{*children})")] public static ReactElement form               (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.h1            ({props},{*children})")] public static ReactElement h1                 (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.h2            ({props},{*children})")] public static ReactElement h2                 (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.h3            ({props},{*children})")] public static ReactElement h3                 (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.h4            ({props},{*children})")] public static ReactElement h4                 (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.h5            ({props},{*children})")] public static ReactElement h5                 (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.h6            ({props},{*children})")] public static ReactElement h6                 (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.head          ({props},{*children})")] public static ReactElement head               (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.header        ({props},{*children})")] public static ReactElement header             (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.hr            ({props},{*children})")] public static ReactElement hr                 (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.html          ({props},{*children})")] public static ReactElement html               (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.i             ({props},{*children})")] public static ReactElement i                  (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.iframe        ({props},{*children})")] public static ReactElement iframe             (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.img           ({props},{*children})")] public static ReactElement img                (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.input         ({props},{*children})")] public static ReactElement input              (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.ins           ({props},{*children})")] public static ReactElement ins                (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.kbd           ({props},{*children})")] public static ReactElement kbd                (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.keygen        ({props},{*children})")] public static ReactElement keygen             (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.label         ({props},{*children})")] public static ReactElement label              (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.legend        ({props},{*children})")] public static ReactElement legend             (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.li            ({props},{*children})")] public static ReactElement li                 (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.link          ({props},{*children})")] public static ReactElement link               (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.main          ({props},{*children})")] public static ReactElement main               (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.map           ({props},{*children})")] public static ReactElement map                (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.mark          ({props},{*children})")] public static ReactElement mark               (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.menu          ({props},{*children})")] public static ReactElement menu               (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.menuitem      ({props},{*children})")] public static ReactElement menuitem           (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.meta          ({props},{*children})")] public static ReactElement meta               (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.meter         ({props},{*children})")] public static ReactElement meter              (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.nav           ({props},{*children})")] public static ReactElement nav                (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.noscript      ({props},{*children})")] public static ReactElement noscript           (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.object        ({props},{*children})")] public static ReactElement Object             (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.ol            ({props},{*children})")] public static ReactElement ol                 (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.optgroup      ({props},{*children})")] public static ReactElement optgroup           (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.option        ({props},{*children})")] public static ReactElement option             (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.output        ({props},{*children})")] public static ReactElement output             (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.p             ({props},{*children})")] public static ReactElement p                  (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.param         ({props},{*children})")] public static ReactElement param              (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.pre           ({props},{*children})")] public static ReactElement pre                (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.progress      ({props},{*children})")] public static ReactElement progress           (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.q             ({props},{*children})")] public static ReactElement q                  (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.rp            ({props},{*children})")] public static ReactElement rp                 (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.rt            ({props},{*children})")] public static ReactElement rt                 (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.ruby          ({props},{*children})")] public static ReactElement ruby               (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.s             ({props},{*children})")] public static ReactElement s                  (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.samp          ({props},{*children})")] public static ReactElement samp               (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.script        ({props},{*children})")] public static ReactElement script             (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.section       ({props},{*children})")] public static ReactElement section            (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.select        ({props},{*children})")] public static ReactElement select             (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.small         ({props},{*children})")] public static ReactElement small              (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.source        ({props},{*children})")] public static ReactElement source             (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.span          ({props},{*children})")] public static ReactElement span               (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.strong        ({props},{*children})")] public static ReactElement strong             (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.style         ({props},{*children})")] public static ReactElement style              (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.sub           ({props},{*children})")] public static ReactElement sub                (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.summary       ({props},{*children})")] public static ReactElement summary            (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.sup           ({props},{*children})")] public static ReactElement sup                (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.table         ({props},{*children})")] public static ReactElement table              (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.tbody         ({props},{*children})")] public static ReactElement tbody              (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.td            ({props},{*children})")] public static ReactElement td                 (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.textarea      ({props},{*children})")] public static ReactElement textarea           (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.tfoot         ({props},{*children})")] public static ReactElement tfoot              (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.th            ({props},{*children})")] public static ReactElement th                 (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.thead         ({props},{*children})")] public static ReactElement thead              (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.time          ({props},{*children})")] public static ReactElement time               (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.title         ({props},{*children})")] public static ReactElement title              (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.tr            ({props},{*children})")] public static ReactElement tr                 (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.track         ({props},{*children})")] public static ReactElement track              (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.u             ({props},{*children})")] public static ReactElement u                  (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.ul            ({props},{*children})")] public static ReactElement ul                 (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.var           ({props},{*children})")] public static ReactElement var                (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.video         ({props},{*children})")] public static ReactElement video              (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.wbr           ({props},{*children})")] public static ReactElement wbr                (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.circle        ({props},{*children})")] public static ReactElement circle             (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.defs          ({props},{*children})")] public static ReactElement defs               (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.g             ({props},{*children})")] public static ReactElement g                  (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.line          ({props},{*children})")] public static ReactElement line               (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.linearGradient({props},{*children})")] public static ReactElement linearGradient     (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.path          ({props},{*children})")] public static ReactElement path               (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.polygon       ({props},{*children})")] public static ReactElement polygon            (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.polyline      ({props},{*children})")] public static ReactElement polyline           (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.radialGradient({props},{*children})")] public static ReactElement radialGradient     (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.rect          ({props},{*children})")] public static ReactElement rect               (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.stop          ({props},{*children})")] public static ReactElement stop               (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.svg           ({props},{*children})")] public static ReactElement svg                (Props props, params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.text          ({props},{*children})")] public static ReactElement text               (Props props, params ReactElement[] children) { return null; }      

      [InlineCode("React.DOM.a             (null,{*children})")] public static ReactElement a                  (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.abbr          (null,{*children})")] public static ReactElement abbr               (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.address       (null,{*children})")] public static ReactElement address            (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.area          (null,{*children})")] public static ReactElement area               (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.article       (null,{*children})")] public static ReactElement article            (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.aside         (null,{*children})")] public static ReactElement aside              (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.audio         (null,{*children})")] public static ReactElement audio              (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.b             (null,{*children})")] public static ReactElement b                  (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.base          (null,{*children})")] public static ReactElement Base               (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.bdi           (null,{*children})")] public static ReactElement bdi                (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.bdo           (null,{*children})")] public static ReactElement bdo                (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.big           (null,{*children})")] public static ReactElement big                (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.blockquote    (null,{*children})")] public static ReactElement blockquote         (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.body          (null,{*children})")] public static ReactElement body               (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.br            (null,{*children})")] public static ReactElement br                 (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.button        (null,{*children})")] public static ReactElement button             (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.canvas        (null,{*children})")] public static ReactElement canvas             (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.caption       (null,{*children})")] public static ReactElement caption            (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.cite          (null,{*children})")] public static ReactElement cite               (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.code          (null,{*children})")] public static ReactElement code               (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.col           (null,{*children})")] public static ReactElement col                (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.colgroup      (null,{*children})")] public static ReactElement colgroup           (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.data          (null,{*children})")] public static ReactElement data               (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.datalist      (null,{*children})")] public static ReactElement datalist           (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.dd            (null,{*children})")] public static ReactElement dd                 (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.del           (null,{*children})")] public static ReactElement del                (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.details       (null,{*children})")] public static ReactElement details            (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.dfn           (null,{*children})")] public static ReactElement dfn                (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.div           (null,{*children})")] public static ReactElement div                (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.dl            (null,{*children})")] public static ReactElement dl                 (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.dt            (null,{*children})")] public static ReactElement dt                 (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.em            (null,{*children})")] public static ReactElement em                 (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.embed         (null,{*children})")] public static ReactElement embed              (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.fieldset      (null,{*children})")] public static ReactElement fieldset           (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.figcaption    (null,{*children})")] public static ReactElement figcaption         (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.figure        (null,{*children})")] public static ReactElement figure             (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.footer        (null,{*children})")] public static ReactElement footer             (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.form          (null,{*children})")] public static ReactElement form               (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.h1            (null,{*children})")] public static ReactElement h1                 (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.h2            (null,{*children})")] public static ReactElement h2                 (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.h3            (null,{*children})")] public static ReactElement h3                 (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.h4            (null,{*children})")] public static ReactElement h4                 (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.h5            (null,{*children})")] public static ReactElement h5                 (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.h6            (null,{*children})")] public static ReactElement h6                 (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.head          (null,{*children})")] public static ReactElement head               (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.header        (null,{*children})")] public static ReactElement header             (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.hr            (null,{*children})")] public static ReactElement hr                 (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.html          (null,{*children})")] public static ReactElement html               (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.i             (null,{*children})")] public static ReactElement i                  (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.iframe        (null,{*children})")] public static ReactElement iframe             (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.img           (null,{*children})")] public static ReactElement img                (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.input         (null,{*children})")] public static ReactElement input              (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.ins           (null,{*children})")] public static ReactElement ins                (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.kbd           (null,{*children})")] public static ReactElement kbd                (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.keygen        (null,{*children})")] public static ReactElement keygen             (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.label         (null,{*children})")] public static ReactElement label              (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.legend        (null,{*children})")] public static ReactElement legend             (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.li            (null,{*children})")] public static ReactElement li                 (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.link          (null,{*children})")] public static ReactElement link               (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.main          (null,{*children})")] public static ReactElement main               (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.map           (null,{*children})")] public static ReactElement map                (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.mark          (null,{*children})")] public static ReactElement mark               (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.menu          (null,{*children})")] public static ReactElement menu               (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.menuitem      (null,{*children})")] public static ReactElement menuitem           (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.meta          (null,{*children})")] public static ReactElement meta               (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.meter         (null,{*children})")] public static ReactElement meter              (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.nav           (null,{*children})")] public static ReactElement nav                (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.noscript      (null,{*children})")] public static ReactElement noscript           (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.object        (null,{*children})")] public static ReactElement Object             (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.ol            (null,{*children})")] public static ReactElement ol                 (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.optgroup      (null,{*children})")] public static ReactElement optgroup           (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.option        (null,{*children})")] public static ReactElement option             (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.output        (null,{*children})")] public static ReactElement output             (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.p             (null,{*children})")] public static ReactElement p                  (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.param         (null,{*children})")] public static ReactElement param              (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.pre           (null,{*children})")] public static ReactElement pre                (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.progress      (null,{*children})")] public static ReactElement progress           (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.q             (null,{*children})")] public static ReactElement q                  (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.rp            (null,{*children})")] public static ReactElement rp                 (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.rt            (null,{*children})")] public static ReactElement rt                 (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.ruby          (null,{*children})")] public static ReactElement ruby               (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.s             (null,{*children})")] public static ReactElement s                  (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.samp          (null,{*children})")] public static ReactElement samp               (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.script        (null,{*children})")] public static ReactElement script             (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.section       (null,{*children})")] public static ReactElement section            (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.select        (null,{*children})")] public static ReactElement select             (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.small         (null,{*children})")] public static ReactElement small              (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.source        (null,{*children})")] public static ReactElement source             (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.span          (null,{*children})")] public static ReactElement span               (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.strong        (null,{*children})")] public static ReactElement strong             (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.style         (null,{*children})")] public static ReactElement style              (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.sub           (null,{*children})")] public static ReactElement sub                (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.summary       (null,{*children})")] public static ReactElement summary            (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.sup           (null,{*children})")] public static ReactElement sup                (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.table         (null,{*children})")] public static ReactElement table              (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.tbody         (null,{*children})")] public static ReactElement tbody              (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.td            (null,{*children})")] public static ReactElement td                 (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.textarea      (null,{*children})")] public static ReactElement textarea           (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.tfoot         (null,{*children})")] public static ReactElement tfoot              (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.th            (null,{*children})")] public static ReactElement th                 (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.thead         (null,{*children})")] public static ReactElement thead              (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.time          (null,{*children})")] public static ReactElement time               (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.title         (null,{*children})")] public static ReactElement title              (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.tr            (null,{*children})")] public static ReactElement tr                 (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.track         (null,{*children})")] public static ReactElement track              (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.u             (null,{*children})")] public static ReactElement u                  (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.ul            (null,{*children})")] public static ReactElement ul                 (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.var           (null,{*children})")] public static ReactElement var                (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.video         (null,{*children})")] public static ReactElement video              (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.wbr           (null,{*children})")] public static ReactElement wbr                (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.circle        (null,{*children})")] public static ReactElement circle             (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.defs          (null,{*children})")] public static ReactElement defs               (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.g             (null,{*children})")] public static ReactElement g                  (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.line          (null,{*children})")] public static ReactElement line               (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.linearGradient(null,{*children})")] public static ReactElement linearGradient     (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.path          (null,{*children})")] public static ReactElement path               (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.polygon       (null,{*children})")] public static ReactElement polygon            (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.polyline      (null,{*children})")] public static ReactElement polyline           (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.radialGradient(null,{*children})")] public static ReactElement radialGradient     (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.rect          (null,{*children})")] public static ReactElement rect               (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.stop          (null,{*children})")] public static ReactElement stop               (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.svg           (null,{*children})")] public static ReactElement svg                (params ReactElement[] children) { return null; }
      [InlineCode("React.DOM.text          (null,{*children})")] public static ReactElement text               (params ReactElement[] children) { return null; }      
   }  

   public interface IReactElement
   {
      object getInitialState();
      object getDefaultProps();
      ReactElement render();
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






