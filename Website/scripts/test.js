(function() {
	'use strict';
	var $asm = {};
	ss.initAssembly($asm, 'test');
	////////////////////////////////////////////////////////////////////////////////
	// ButtonCounter
	var $ButtonCounter = function() {
		ReactJs.ReactComponent.call(this);
	};
	$ButtonCounter.__typeName = 'ButtonCounter';
	$ButtonCounter.New = function(name) {
		if (ss.isNullOrUndefined($ButtonCounter.$_factory)) {
			$ButtonCounter.$_factory = ReactJs.ReactHelper.CreateClass($ButtonCounter).call(null);
		}
		var $t2 = $ButtonCounter.$_factory;
		var $t1 = new $ButtonCounter$ButtonProp();
		$t1.name = name;
		return $t2($t1);
	};
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
		ReactJs.ReactComponent.call(this);
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
		// looks for the element that will host the main react view
		var reactview = document.getElementById('reactview');
		// render the component: here ButtonCounter is instantiated by a custom static 
		// constructor named "New" and defined in the ButtonCounter class
		React.renderComponent($ButtonCounter.New('Someone'), reactview);
		// alternatively react components can be instantiated with the general 
		// static constructor, e.g.:
		// var but = React.createClass<ButtonCounter>();
		// React.renderComponent(but.New(new {name="Someone"}), reactview);       
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
			var hello = ReactJs.ReactHelper.CreateClass($Hello).call(null);
			// create a list of <li> items 
			var lll = [];
			for (var t = 0; t < S.click_count; t++) {
				ss.add(lll, React.DOM.li(null, [ss.formatString('item {0} with name {1} clicked {2} times', t, P.name, S.click_count)]));
			}
			// and wrap them in a <div> and <ul> 
			var $t1 = {};
			$t1.style = ss.mkdict(['font-size', '1em']);
			return React.DOM.div($t1, [React.DOM.ul({}, [lll, React.DOM.li(ReactJs.PropsExtensions.onClick({}, ss.mkdel(this, this.handleClick)), ['click here']), React.DOM.li({}, ['this is a fixed item']), React.DOM.li({}, [hello()])])]);
		}
	}, ReactJs.ReactComponent);
	ss.initClass($ButtonCounter$ButtonProp, $asm, {});
	ss.initClass($ButtonCounter$ButtonState, $asm, {});
	ss.initClass($Hello, $asm, {
		render: function() {
			return React.DOM.div(null, ["this is an item made from a component named 'hello'"]);
		}
	}, ReactJs.ReactComponent);
	ss.initClass($JasmineTests, $asm, {
		SpecRunner: function() {
		}
	}, Object);
	ss.initClass($TestDemo, $asm, {});
	$ButtonCounter.$_factory = null;
})();
