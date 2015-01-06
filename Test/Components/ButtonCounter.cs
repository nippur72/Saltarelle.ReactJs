using System;

using System.Html;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Serialization;
using System.Diagnostics;

using ReactJs;

public class ButtonCounter : ReactElement
{
   // props can be either 'dynamic' or statically typed with their own type
   public class ButtonProp
   {
      public string name;
   }

   // state can be either 'dynamic' or statically typed with its own type
   // there is a third option where state variables are defined as field members of the class
   // in such case, state is no longer 'immutable' and doesn't need to be passed in setState()
   public class ButtonState
   {
      // the state variable that does the counting
      public int click_count;

      // for convenience, we can provide a constructor for the state
      public ButtonState(int count)
      {
         click_count = count;
      }
   }      

   // since we opted for typed state, we build it with its constructor
   // the other way was to: return new { count=0 };
   public object getInitialState()
   {
      return new ButtonState(count: 0);
   }

   // this is the event that responds to click 
   public void handleClick(ReactJs.MouseEvent ev)
   {
      ButtonState currstate = this.State.As<ButtonState>();         
      
      setState(new ButtonState(count: currstate.click_count+1));              

      // in case of mutable state, it would have been much simpler:
      // click_count++; 
      // setState();
   }
   
   // this is the main render method where we build the DOM for the component
   public object render()
   {         
      var P = this.Props.As<ButtonProp>();   // we need to read props typedly
      var S = this.State.As<ButtonState>();  // and we read typed state too
      
      // component from Hello.cs
      // the 'hello' variable will hold the component factory function
      // instances of the hello component needs to be created with 'hello.New()'
              
      // create a list of <li> items 
      List<ReactElement> lll = new List<ReactElement>();
      for(int t=0;t<S.click_count;t++) lll.Add
      ( 
         li(string.Format("item {0} with name {1} clicked {2} times",t,P.name,S.click_count) )
      );         
      
      // and wrap them in a <div> and <ul> 
      return div(new Props{ style = new JsDictionary("font-size", "1em") }, 
               p("Featuring React v0.12.2"),
               ul(     
                  lll, 
                  li(new Props{ style = new JsDictionary("font-size", "2em")}.onClick(handleClick), "click here"),
                  li("this is a fixed item"),
                  li(React.createElement<Hello>())              
               )
            );                          
   }
}








