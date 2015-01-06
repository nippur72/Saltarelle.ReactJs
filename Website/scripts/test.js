(function() {
	'use strict';
	var $asm = {};
	ss.initAssembly($asm, 'test');
	////////////////////////////////////////////////////////////////////////////////
	// ButtonCounter
	var $ButtonCounter = function() {
		ReactJs.ReactElement.call(this);
	};
	$ButtonCounter.__typeName = 'ButtonCounter';
	global.ButtonCounter = $ButtonCounter;
	////////////////////////////////////////////////////////////////////////////////
	// ButtonCounter.ButtonProp
	var $ButtonCounter$ButtonProp = function() {
		this.name = null;
	};
	$ButtonCounter$ButtonProp.__typeName = 'ButtonCounter$ButtonProp';
	global.ButtonCounter$ButtonProp = $ButtonCounter$ButtonProp;
	////////////////////////////////////////////////////////////////////////////////
	// ButtonCounter.ButtonState
	var $ButtonCounter$ButtonState = function(count) {
		this.click_count = 0;
		this.click_count = count;
	};
	$ButtonCounter$ButtonState.__typeName = 'ButtonCounter$ButtonState';
	global.ButtonCounter$ButtonState = $ButtonCounter$ButtonState;
	////////////////////////////////////////////////////////////////////////////////
	// Hello
	var $Hello = function() {
		ReactJs.ReactElement.call(this);
	};
	$Hello.__typeName = 'Hello';
	global.Hello = $Hello;
	////////////////////////////////////////////////////////////////////////////////
	// JasmineTests
	var $JasmineTests = function() {
		ss.shallowCopy({}, this);
	};
	$JasmineTests.__typeName = 'JasmineTests';
	global.JasmineTests = $JasmineTests;
	////////////////////////////////////////////////////////////////////////////////
	// TestDemo
	var $TestDemo = function() {
	};
	$TestDemo.__typeName = 'TestDemo';
	$TestDemo.Main = function() {
		// register components within React      
		//Hello._factory         =
		ReactJs.ReactHelper.CreateComponent($Hello).call(null);
		//ButtonCounter._factory =
		ReactJs.ReactHelper.CreateComponent($ButtonCounter).call(null);
		// render into main view      
		var reactview = document.getElementById('reactview');
		React.render(React.createElement($ButtonCounter._factory), reactview);
	};
	global.TestDemo = $TestDemo;
	ss.initClass($ButtonCounter, $asm, {
		getInitialState: function() {
			return new $ButtonCounter$ButtonState(0);
		},
		handleClick: function(ev) {
			var currstate = this.state;
			this.setState(new $ButtonCounter$ButtonState(currstate.click_count + 1));
			// in case of mutable state, it would have been much simpler:
			// click_count++; 
			// setState();
		},
		render: function() {
			var P = this.props;
			// we need to read props typedly
			var S = this.state;
			// and we read typed state too
			// component from Hello.cs
			// the 'hello' variable will hold the component factory function
			// instances of the hello component needs to be created with 'hello.New()'
			// create a list of <li> items 
			var lll = [];
			for (var t = 0; t < S.click_count; t++) {
				lll.push(React.DOM.li(null, ss.formatString('item {0} with name {1} clicked {2} times', t, P.name, S.click_count)));
			}
			// and wrap them in a <div> and <ul> 
			var $t1 = {};
			$t1.style = ss.mkdict(['font-size', '1em']);
			var $t3 = React.DOM.p(null, 'Featuring React v0.12.2');
			var $t2 = {};
			$t2.style = ss.mkdict(['font-size', '2em']);
			return React.DOM.div($t1, $t3, React.DOM.ul(null, lll, React.DOM.li(ReactJs.PropsExtensions.onClick($t2, ss.mkdel(this, this.handleClick)), 'click here'), React.DOM.li(null, 'this is a fixed item'), React.DOM.li(null, React.createElement($Hello._factory))));
		}
	}, ReactJs.ReactElement);
	ss.initClass($ButtonCounter$ButtonProp, $asm, {});
	ss.initClass($ButtonCounter$ButtonState, $asm, {});
	ss.initClass($Hello, $asm, {
		render: function() {
			return React.DOM.div(null, "this is an item made from a component named 'hello'");
		}
	}, ReactJs.ReactElement);
	ss.initClass($JasmineTests, $asm, {
		SpecRunner: function() {
		}
	}, Object);
	ss.initClass($TestDemo, $asm, {});
})();
